using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using WindowsFormsApp1.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.Controller;
using static WindowsFormsApp1.USB_Exchange;
using ToolTip = System.Windows.Forms.ToolTip;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TelemetryState TelState = new TelemetryState();
        enum TelemetryState
        {
            Stop = 0,
            Run = 1,
            Pause = 2,
            Record = 3,
            PauseRecord = 4,
            DownLoad = 5,
        }
        enum TelemetryStatus
        {
            OnlineTelemetry = 0,
            OffLineTelemetry = 1,
            IDLE = 2,
        }
        enum AppStateType
        {
            STOP = 5,
            IDLE = 0,
            DOWNLOAD_RUN = 1,
            UPLOAD_RUN = 2,
            INIT = 3,
            FINISH = 4,
            CLOSE = 8,
            CONNECTED = 6,
            CANSEL = 7
        }
        List<EEPROMRecord> PROMRecords;
        SystemInfo InfoForm;
        MainForm[] Charts;
       // private PassworForm passwordForm;
        AutoResetEvent USBDataNoProcess = new AutoResetEvent(true);
        private PdmController PDM;
        private TelemetryStatus TelStatus;
        private CanHACKERLoadForm ComLoadForm;
        private System.Windows.Forms.DataVisualization.Charting.Series ChartData;
        private System.Windows.Forms.DataVisualization.Charting.Series ChartData1;
        static Semaphore USBIsEnd;
        private delegate void SafeCallDelegate(Telemetry data);
        private delegate void SafeCallDelegate1(uint data);
        private delegate void SafeCallDelegate2(Int32 status_ok);
        private delegate void SafeCallDelegate3(bool status_ok);
        private delegate void SafeCallDelegate4(TelemetryState status_ok);
        private delegate void SafeCallDelegate5();
        string USB_VID = "1155";
        string USB_PID = "22352";
        string app_version = "2.0.0";
        private int TimeStump = 0;
        AppSettings Settings;
        AppStateType State = AppStateType.INIT;
        bool FormCloseStatus = false;
        bool ErrorStringIsRead = false;
        DataLog LogData;
        public DataStorageViewModel VMstorage;
        Stopwatch stopwatch = new Stopwatch();
        private Binding oEEPROMSizeBind;
        private static string LuaCheckParam = " --no-max-line-length -t --globals io os init main CanTable setDINConfig EXT_CAN_ID CanInput  setOutConfig sendCandRequest setCanFilter CanSend getDelay setAINCalTable GetCanToTable CanOut getRPM getOut setCanFilte DInput getCurrent GetEEPROMReg SetEEPROMReg AddReccord ConfigStorage ConfigCan waitDIN CanRequest Yield CheckAnswer setCanFilte GetRequest";
        public Form1()
        {
            Charts = new MainForm[8];
           
            for (int i = 0; i < Charts.Length; i++)
            {
                Charts[i] = new MainForm();
            }
            
            VMstorage = new DataStorageViewModel();
            LogData = new DataLog(20, 20, 20, 6);
            InitializeComponent();
            LoopTimeLabel.Text = "Время" + Environment.NewLine + " цикла";
            Settings = new AppSettings();
            vSetTelemetryState(TelemetryState.Stop);
            btnTelemetryStop.Enabled = false;
            btnTelemetryRun.Enabled = true;
            btnTelemetryRecord.Enabled = false;
            btnTelemetryPause.Enabled = false;
            PDM = new PdmController(200, Int32.Parse(USB_VID), Int32.Parse(USB_PID), this.onConnect, this.onDisconect, new RedrawHandler(RedrawCallback), USBIsEnd);
            lua5_4.Checked = true;  
            vDataGrindInit();
            vRecordDataGrindInit();
            tabControl1.SelectTab(tabPage2);
            vSetTabPageButtn(1);
            btnLoad.Select();
            vSetState(AppStateType.INIT);
            tabControl1_SelectedIndexChanged(null, null);
            vInitInterface();
            vSetTelemetryStatus(TelemetryStatus.IDLE);

            app_version_lebel.Text = app_version;
            vDataBindingConnect();
        }
        void vDataBindingConnect()
        {
            Binding bind = new Binding("Text", VMstorage, "sEEPROMSize", false, DataSourceUpdateMode.OnPropertyChanged);
            tbEEPROMSize.DataBindings.Add(bind);
        }
        private void onConnect()
        {
            btnConnect.BackColor = Color.LightGreen;
            vGetDevice();
        }
        private void onDisconect()
        {
            btnConnect.BackColor = SystemColors.Control;
            PDM.setDisconected();
            vSetState(AppStateType.STOP);
            vSetTelemetryState(TelemetryState.Stop);
            if (TelStatus == TelemetryStatus.OnlineTelemetry) vSetTelemetryStatus(TelemetryStatus.IDLE);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCloseStatus = true;
            vSetState(AppStateType.CLOSE);
        }

        public void RedrawCallback(Telemetry data)
        {
            if (FormCloseStatus)
            {
                return;
            }
            if (System_Par.InvokeRequired)
            {
                var d = new SafeCallDelegate(RedrawCallback);
                System_Par.Invoke(d, new object[] { data });
            }
            else
            {
                bool record_enable = (TelState == TelemetryState.Record);
                string logbuffer = null;
                TimeStump += int.Parse(LoopTime.Text);
                logbuffer += record_enable ? TimeStump.ToString() + ";" : "";

                for (int i = 0; i < PDM.pdm.DOUT_Count; i++)
                {
                    LogData.dout[i].AddPoint(data.dout[i].current, TimeStump, true);
                    logbuffer += record_enable ? data.dout[i].current.ToString() + ";" : "";
                    if (LogData.dout[i].GrapData != 0)
                    {
                        vSetGrapData(data.dout[i].current, LogData.dout[i].GrapData);
                    }
                    if (data.dout[i].error == 2)
                    {
                        DiscreteOut[1, i].Style.BackColor = Color.Red;
                        DiscreteOut[1, i].Style.ForeColor = Color.White;
                    }
                    else
                    if (data.dout[i].error == 3)
                    {
                        DiscreteOut[1, i].Style.BackColor = Color.Yellow;
                        DiscreteOut[1, i].Style.ForeColor = Color.Black;
                    }
                    else
                    if ((data.dout[i].state == 1) || (data.dout[i].state == 2))
                    {
                        DiscreteOut[1, i].Style.BackColor = Color.Green;
                        DiscreteOut[1, i].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        DiscreteOut[1, i].Style.BackColor = Color.White;
                        DiscreteOut[1, i].Style.ForeColor = Color.Black;
                    }
                    DiscreteOut[1, i].Value = Math.Round(data.dout[i].current, 2);
                    DiscreteOut[2, i].Value = Math.Round(data.dout[i].max, 2);
                    DiscreteOut[3, i].Value = Math.Round(LogData.dout[i].MaxValue, 2);
                    DiscreteOut[4, i].Value = Math.Round(LogData.dout[i].MinValue, 2);
                    DiscreteOut[5, i].Value = Math.Round(LogData.dout[i].TripValue, 2);
                }

                float[] sys_data = { data.battery, data.temperature[0], data.angle[0], data.angle[1], (float)(data.velocity[0][1]<<8 | data.velocity[0][0])/*/(float)6.8*/
                        , (data.velocity[1][1]<<8 | data.velocity[1][0]) };
                for (int i = 0; i < sys_data.Length; i++)
                {
                    if (LogData.system[i].GrapData != 0)
                    {
                        vSetGrapData(sys_data[i], LogData.system[i].GrapData);
                    }
                    logbuffer += record_enable ? sys_data[i].ToString() + ";" : "";
                    LogData.system[i].AddPoint(sys_data[i], TimeStump, true);
                    System_Par[1, i].Value = Math.Round(sys_data[i], 2);
                    System_Par[2, i].Value = Math.Round(LogData.system[i].MaxValue, 2);
                    System_Par[3, i].Value = Math.Round(LogData.system[i].MinValue, 2);
                    System_Par[4, i].Value = Math.Round(LogData.system[i].TripValue, 2);
                }
                SystemDataSource.ResetBindings(false);
                logbuffer += "0;0;";

                for (int i = 0; i < PDM.pdm.ainN; i++)
                {
                    if (LogData.ain[i].GrapData != 0)
                    {
                        vSetGrapData(data.voltage[i], LogData.ain[i].GrapData);
                    }
                    logbuffer += record_enable ? data.voltage[i].ToString() + ";" : "";
                    AnalogInput[1, i].Value = Math.Round(data.voltage[i], 2);
                    LogData.ain[i].AddPoint(data.voltage[i], TimeStump, true);
                    AnalogInput[2, i].Value = Math.Round(LogData.ain[i].MaxValue, 2);
                    AnalogInput[3, i].Value = Math.Round(LogData.ain[i].MinValue, 2);
                    AnalogInput[4, i].Value = Math.Round(LogData.ain[i].TripValue, 2);
                }
                for (int i = 0; i < PDM.pdm.dinN; i++)
                {
                    logbuffer += record_enable ? data.din[i].ToString() + ";" : "";
                    LogData.din[i].AddPoint(data.din[i], TimeStump, false);
                    if (LogData.din[i].GrapData != 0)
                    {
                        vSetGrapData(data.din[i], LogData.din[i].GrapData);
                    }
                    DinInput[1, i].Value = data.din[i];
                }
                DinInput.ClearSelection();

                uint RunTime = data.lua.time * 10;
                LUA_TIME.Text = RunTime.ToString("D");
                switch (data.lua.state)
                {
                    case 0:
                        LuaState.Text = "INIT";
                        break;
                    case 1:
                        LuaState.BackColor = Color.Green;
                        LuaState.Text = "В работе";
                        LuaState.ForeColor = Color.White;
                        break;
                    case 2:
                        LuaState.ForeColor = Color.Red;
                        if (ErrorStringIsRead)
                        {
                            LuaState.Text = data.lua.error;
                        }
                        else
                        {
                            LuaState.Text = "ERROR";
                            ErrorStringIsRead = true;
                            PDM.readErrorString();
                        }
                        break;
                    case 3:
                        LuaState.Text = "STOP";
                        break;
                    case 4:
                        LuaState.Text = "RESTART";
                        break;
                }
                if (record_enable)
                {
                    LogData.vAddDataToLog(logbuffer);
                }
                AddDataToCharts();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
            vSetTabPageButtn(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            vSetTabPageButtn(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            vSetTabPageButtn(2);
        }
        private void btnJournal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
            vSetTabPageButtn(3);
        }
        public void vParseLibList()
        {
            LibChecked.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(Settings.sGetLIBPath());
            if (dinfo.Exists)
            {
                FileInfo[] files = dinfo.GetFiles();
                foreach (FileInfo filenames in files)
                {
                    if (filenames.Extension == ".lua")
                    {
                        LibChecked.Items.Add(filenames);
                    }
                }
                for (int index = 0; index < LibChecked.Items.Count; index++)
                {
                    LibChecked.SetItemChecked(index, true);
                }
            }
        }
        private void LibFolderButton_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string sFileName = dlg.SelectedPath;
                Settings.vSetLIBPath(sFileName);
                vLUAConfigEnable(Settings.LIBPathValid, 3);

            };
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    ConsoleTextBox.Clear();
                    vLUAConfigEnable(Settings.LuacFileNameValid, 2);
                    vLUAConfigEnable(Settings.LuaFileNameValid, 0);
                    vLUAConfigEnable(Settings.UtilityPathValid, 1);
                    vLUAConfigEnable(Settings.LIBPathValid, 3);
                    break;
                case 2:

                    break;
            }
        }
        private void LuacLoadButton_Click(object sender, EventArgs e)
        {
            string LuacFileName;
            ConsoleTextBox.Clear();
            if (Settings.LuacFileNameValid)
            {
                LuacFileName = Settings.sGetLUACFileName();
            }
            else
                LuacFileName = "out.luac";
            ByteCodeLoad(LuacFileName);
        }
        private void LuacFileOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.Filter = "luac files (*.luac)| *.luac";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string sFileName = dlg.FileName;
                Settings.vSetLUACFile(sFileName);
                vLUAConfigEnable(true, 2);
            }
        }
        private void LuaFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "lua files (*.lua)| *.lua";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string sFileName = dlg.FileName;
                Settings.vSetLUAFile(sFileName);
                vLUAConfigEnable(true, 0);
            }
        }
        private void vLUAConfigEnable(bool enable, int mode)
        {
            switch (mode)
            {
                case 0:
                    LuaRunButton.Enabled = enable & Settings.UtilityPathValid & Settings.LIBPathValid;
                    LuaCompileButton.Enabled = enable & Settings.UtilityPathValid & Settings.LIBPathValid;
                    ConsoleTextBox.AppendText("Файл lua: ");
                    vColorText(enable ? Settings.sGetLuaFileName() : "Не найден", enable ? 0 : 1);
                    break;
                case 1:
                    LuaRunButton.Enabled = enable & Settings.LuaFileNameValid & Settings.LIBPathValid;
                    LuaCompileButton.Enabled = enable & Settings.LuaFileNameValid & Settings.LIBPathValid;
                    bool isExist = File.Exists(Settings.sGetUtilPath() + "\\luac.exe" + Environment.NewLine);
                    ConsoleTextBox.AppendText("Компилятор LUAC: ");
                    vColorText(isExist ? Settings.sGetUtilPath() + "//luac.exe" : "Не найден", isExist ? 0 : 1);
                    LuaCompileButton.Enabled = enable & Settings.LuaFileNameValid & Settings.LIBPathValid;
                    ConsoleTextBox.AppendText("Проверка синтаксиса LUACheck: ");
                    isExist = File.Exists(Settings.sGetUtilPath() + "\\luacheck.exe" + Environment.NewLine);
                    vColorText(isExist ? Settings.sGetUtilPath() + "//luacheck.exe" : "Не найден", isExist ? 0 : 1);
                    break;
                case 2:
                    LuacLoadButton.Enabled = enable;
                    ConsoleTextBox.AppendText("Файл байт кода: ");
                    vColorText(enable ? Settings.sGetLUACFileName() : "Не найден", enable ? 0 : 1);
                    break;
                case 3:
                    LuaRunButton.Enabled = enable & Settings.UtilityPathValid & Settings.LuaFileNameValid;
                    LuaCompileButton.Enabled = enable & Settings.UtilityPathValid & Settings.LuaFileNameValid;
                    ConsoleTextBox.AppendText("Библиотеки прикладных функций: ");
                    vColorText(enable ? Settings.sGetLIBPath() : "Не найден", enable ? 0 : 1);
                    if (enable)
                    {
                        vParseLibList();
                    }
                    break;
                default:
                    break;
            }
        }
        private void UtilFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string sFolderName = folderBrowserDialog1.SelectedPath;
                Settings.vSetUtilityPath(sFolderName);
                vLUAConfigEnable(Settings.UtilityPathValid, 1);
            }
        }
        private void LuaCompileButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Step = 35;
            vCompile();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            vSetState(AppStateType.CANSEL);
        }

        private bool ByteCodeLoad(string loadfile)
        {
            bool res = false;
            vSetState(AppStateType.DOWNLOAD_RUN);
            if (xGetState() == AppStateType.DOWNLOAD_RUN)
            {
                ConsoleTextBox.AppendText("Загрузка файла: " + Path.GetFullPath(loadfile) + Environment.NewLine);
                if (File.Exists(loadfile))
                {
                    FileStream fs = File.OpenRead(loadfile);
                    if (fs != null)
                    {
                        PDM.pdm.lua = new byte[fs.Length];
                        if (fs.Read(PDM.pdm.lua, 0, PDM.pdm.lua.Length) == fs.Length)
                        {
                            vSetTelemetryState(TelemetryState.DownLoad);
                            bool Connect = PDM.isConnected();
                            vStatusLinePrint(Connect ? load_begin_mes : conection_error_mes, Connect);
                            vColorText(Connect ? load_begin_mes : conection_error_mes, Connect ? 0 : 1);
                            stopwatch.Restart();
                            PDM.send(ProgressStep, isFinish);
                        }
                    }
                    fs.Close();
                }
                else ConsoleTextBox.AppendText("Невозможно открыть файл для загрузки!");
            }

            return res;
        }
        private void LuaRunButton_Click(object sender, EventArgs e)
        {
            vSetState(AppStateType.STOP);
            vSetTelemetryState(TelemetryState.Stop);
            ConsoleTextBox.Clear();
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            if (vCompile())
            {
                ByteCodeLoad("out.luac");
            }
        }

        void vSetGrapData(float Y, uint chart_index)
        {
            uint mask = 0x0001;
            for (int i = 0; i < Charts.Length; i++)
            {
                if ((chart_index & mask) != 0)
                {
                    Charts[i].AddNewPoint(Y, TimeStump, 0);
                }
                mask = mask << 1;
                if ((chart_index & mask) != 0)
                {
                    Charts[i].AddNewPoint(Y, TimeStump, 1);
                }
                mask = mask << 1;
            }
        }
        /*
         * Метод для обозначения названий осей в легенде
         */
        void vSetChartAxisName(string name, uint chart_index)
        {
            uint mask = 0x0001;
            for (int i = 0; i < Charts.Length; i++)
            {
                if ((chart_index & mask) != 0)
                {
                    Charts[i].SetName(name, false);
                    break;
                }
                mask = mask << 1;
                if ((chart_index & mask) != 0)
                {
                    Charts[i].SetName(name, true);
                    break;
                }
                mask = mask << 1;
            }
        }

        void vFindData(string name, uint chart_index)
        {
            if (TelStatus == TelemetryStatus.OnlineTelemetry)
            {
                for (int i = 0; i < PDM.pdm.DOUT_Count; i++)
                {
                    if (LogData.dout[i].ChannelName == name)
                    {
                        LogData.dout[i].GrapData |= chart_index;
                        vSetChartAxisName(name, chart_index);
                        return;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (LogData.system[i].ChannelName == name)
                    {
                        LogData.system[i].GrapData |= chart_index;
                        vSetChartAxisName(name, chart_index);
                        return;
                    }
                }
                for (int i = 0; i < LogData.ain.Count; i++)
                {
                    if (LogData.ain[i].ChannelName == name)
                    {
                        LogData.ain[i].GrapData |= chart_index;
                        vSetChartAxisName(name, chart_index);
                        return;
                    }
                }
                for (int i = 0; i < LogData.din.Count; i++)
                {
                    if (LogData.din[i].ChannelName == name)
                    {
                        LogData.din[i].GrapData |= chart_index;
                        vSetChartAxisName(name, chart_index);
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < LogData.OffLineData.channel_data.Count; i++)
                {
                    if (LogData.OffLineData.channel_data[i].Name == name)
                    {
                        vSetChartAxisName(name, chart_index);
                        return;
                    }
                }

            }
        }

        void vSetGraphicData()
        {
            vClearData();
            vSetAsisForm(0);
            vSetAsisForm(1);
            vSetAsisForm(2);
            vSetAsisForm(3);
            vSetAsisForm(4);
            vSetAsisForm(5);
            vSetAsisForm(6);
            vSetAsisForm(7);
        }
        private void btnTelemetryRun_Click(object sender, EventArgs e)
        {
            vSetGraphicData();
            vDisableChannelSelect();
            vSetState(AppStateType.UPLOAD_RUN);
            if (xGetState() == AppStateType.UPLOAD_RUN)
            {
                LuaState.ForeColor = Color.Black;
                vSetTelemetryState(TelemetryState.Run);

            }
        }
        private void btnTelemetryStop_Click(object sender, EventArgs e)
        {
            vSetState(AppStateType.STOP);
            vSetTelemetryState(TelemetryState.Stop);
            vEnableChannelSelect();
        }

        private void btnTelemetryPause_Click(object sender, EventArgs e)
        {
            vSetState(AppStateType.STOP);
            vSetTelemetryState(TelemetryState.Pause);
        }

        private void btnTelemetryRecord_Click(object sender, EventArgs e)
        {
            vSetTelemetryState(TelemetryState.Record);
        }
        private void LoopTime_TextChanged(object sender, EventArgs e)
        {
            PDM.setLoopTime(int.Parse(LoopTime.Text));
        }

        private void btnLUARestart_Click(object sender, EventArgs e)
        {
            vSetState(AppStateType.STOP);
            vSetTelemetryState(TelemetryState.Stop);
            vEnableChannelSelect();
            PDM.Restart();
        }



        private void Chart1Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(0);
        }

        private void Chart2Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(1);
        }

        private void Chart3Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(2);
        }

        private void Chart4Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(3);
        }

        private void buttChart5Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(4);
        }

        private void Chart6Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(5);
        }

        private void Chart7Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(6);
        }

        private void Chart8Window_Click(object sender, EventArgs e)
        {
            vOpenGraphWindow(7);
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "log files (*.cvs)| *.cvs";
            dlgSaveFile.InitialDirectory = Directory.GetCurrentDirectory();
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fsa = File.OpenRead("log.cvs"), sva = File.OpenWrite(dlgSaveFile.FileName))
                {
                    fsa.CopyToAsync(sva);
                }
            }
        }


        private void btnOnlineTelemetry_Click(object sender, EventArgs e)
        {
            vSetTelemetryStatus(TelemetryStatus.OnlineTelemetry);
            vChartDataInit();
        }

        private void btnOfflineTelemetry_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "log files (*.cvs)| *.cvs";
            dlgOpen.InitialDirectory = Directory.GetCurrentDirectory();
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                LogData.ReadOfflineData(dlgOpen.FileName);
                vInsertChannelOffLineListNames();
                vSetTelemetryStatus(TelemetryStatus.OffLineTelemetry);
                vChartDataInit();
            }

        }

        private void Chart1_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(0, 0, sender);
        }

        private void Chart1_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(0, 1, sender);
        }

        private void Chart2_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(1, 0, sender);
        }

        private void Chart2_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(1, 1, sender);
        }

        private void Chart3_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(2, 0, sender);
        }

        private void Chart3_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(2, 1, sender);
        }

        private void Chart4_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(3, 0, sender);
        }

        private void Chart4_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(3, 1, sender);
        }

        private void Chart5_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(4, 0, sender);
        }

        private void Chart5_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(4, 1, sender);
        }

        private void Chart6_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(5, 0, sender);
        }

        private void Chart6_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(5, 1, sender);
        }

        private void Chart7_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(6, 0, sender);
        }

        private void Chart7_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(6, 1, sender);
        }

        private void Chart8_1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(7, 0, sender);
        }

        private void Chart8_2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            vCheckChannelNames(7, 1, sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\PDM Help File.chm");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (vGetDevice() == 1)
            {
                InfoForm = new SystemInfo();
                InfoForm.SetHardvareVersion(PDM.pdm.SYSTEM.hardware);
                InfoForm.SetSoftwareVersion(PDM.pdm.SYSTEM.firmware);
                InfoForm.SetLuaVersion(PDM.pdm.SYSTEM.lua);
                InfoForm.Show();
            }
            else
                MessageBox.Show("Устройстов не обнаружено!");
        }

        private void btnReadTime_Click(object sender, EventArgs e)
        {
            if (vGetDevice() == 1)
            {
                PDM.GetTime();
                vGetPDMTime();
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            if (vGetDevice() == 1)
            {
                PDM.PDM_Time.Year = (byte)(DateTime.Now.Year - 2000);
                PDM.PDM_Time.Month = (byte)DateTime.Now.Month;
                PDM.PDM_Time.Day = (byte)DateTime.Now.Day;
                PDM.PDM_Time.Hour = (byte)DateTime.Now.Hour;
                PDM.PDM_Time.Minute = (byte)DateTime.Now.Minute;
                PDM.PDM_Time.Second = (byte)DateTime.Now.Second;
                vGetPDMTime();
                PDM.SetTime();
            }
        }



        private void RegisterView_MouseClick(object sender, MouseEventArgs e)
        {
            RegisteEnterDATA data_form = new RegisteEnterDATA();
            if ((RegisterView.CurrentCell.ColumnIndex % 3) == 1)
            {
                data_form.ShowDialog(this);

            }
        }

        private void btnConfigStorage_Click(object sender, EventArgs e)
        {
            int time_stamp_offset = timeStampCheck.Checked ? 1 : 0;
            ushort reg_count = (ushort)int.Parse(tbRgisterCount.Text);
            ushort record_len = (ushort)(RecordFormatView.Rows.Count + time_stamp_offset);
            byte[] record_type = new byte[record_len];

            if (time_stamp_offset != 0) { record_type[0] = 0; }


            for (int i = 0; i < record_len - time_stamp_offset; i++)
            {

                switch (RecordFormatView[1, i].Value.ToString())
                {
                    case "BYTE":
                        record_type[i + time_stamp_offset] = 1;
                        break;
                    case "SHORT":
                        record_type[i + time_stamp_offset] = 2;
                        break;
                    case "LUA_TYPE":
                        record_type[i + time_stamp_offset] = 3;
                        break;
                }
            }
            VMstorage.Estorage.ResetALL();
            if (VMstorage.Estorage.SetRecordSize(record_type))
            {
                if (VMstorage.Estorage.InitStorage((ushort)int.Parse(tbRgisterCount.Text)))
                {

                    vInitRecordSource();
                    vRegisterDataInit();
                    tbMaxRecord.Text = VMstorage.Estorage.record_count.ToString();

                }
            }

        }
        public bool TokenValid = false;
        private void btnAccess_Click(object sender, EventArgs e)
        {
            
            if (vGetDevice() == 1)
            {
                ushort size;
                TokenValid = PDM.SendToken((ushort)0x444, out size);
                VMstorage.Estorage.iEEPROMSize = size;
            }
            vSetStorageAccessVisible(TokenValid);
        }
        private void btnWriteES_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[VMstorage.Estorage.DataStorageSize];
            data = VMstorage.Estorage.bGetEEPROMData();

            PDM.SendEEPROM(data, ProgressEEPROM);
        }

        private void btnReadES_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[VMstorage.Estorage.DataStorageSize];
            if (PDM.GendEEPROM(VMstorage.Estorage.DataStorageSize, out data, ProgressEEPROM))
            {
                VMstorage.Estorage.vSetEEPROMData(data);
                tbRgisterCount.Text = VMstorage.Estorage.RegisetCount.ToString();
                vRegisterDataInit();
                vInitRecordSource();
            }

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            // vSetState(AppStateType.STOP);
            // vSetTelemetryState(TelemetryState.Stop);
            // vEnableChannelSelect();
            PDM.Stop();
        }


        private void DinInput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex > 0))
            {
                bool ColorType = DinInput[e.ColumnIndex, e.RowIndex].Value.ToString().Equals("0");
                DinInput[e.ColumnIndex, e.RowIndex].Style.BackColor = (ColorType) ? Color.White : Color.Green;
                DinInput[e.ColumnIndex, e.RowIndex].Style.ForeColor = (ColorType) ? Color.Black : Color.White;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RecordForamtSource.Add( new EEPROMRecordFormat(RecordFormatView.RowCount + 1, 0));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            RecordForamtSource.Clear(); 
        }

        private void btnComLoad_Click(object sender, EventArgs e)
        {
            ComLoadForm = new CanHACKERLoadForm();
            ComLoadForm.Show();
        }
    }   
}
