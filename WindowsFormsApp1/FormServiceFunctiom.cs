using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string byte_code_ok_mes = "Байт код готов!";
        private const string byte_code_error_mes = "Ошибка компиляции!";
        private const string luacheck_begin_mes = "Проверка синтаксиса...";
        private const string luacheck_error_mes = "Ошибка синтаксиса!";
        private const string luac_begin_mes = "Компиляция в байт код...";
        private const string lualink_error_mes = "Ошибка создания файла!";
        private const string lualink_begin_mes = "Сборка программы...";
        private const string load_begin_mes = "Загрузка...";
        private const string conection_error_mes = "Нет связи с усртойстовм";
        private const string load_4_mes = "Загрузка...";
        private const string load_3_mes = "Загрузка..";
        private const string load_2_mes = "Загрузка.";
        private const string load_end_mes = "Загрузка завершена";
        private const string load_cancel_mes = "Загрузка прервана";
        private const string lost_conection_error_mes = "Потеряна связь с устройством!";
        private uint LoadingStep;
        ToolTip toolTip;
        //ToolTipService toolTipSetv;
        /*Метод для созадние подсказок к элементам управления*/
        private void vInitInterface()
        {
            LoadingStep = 0;
            vCreatToolTip();
        }
        private void vCreatToolTip()
        {
            
            toolTip = new ToolTip();
            
            
            toolTip.SetToolTip(this.btnTelemetryStop, "Остоновка телеметрии");
            toolTip.SetToolTip(this.LuacLoadButton, "Загрузка файла байткода");
            toolTip.SetToolTip(this.LuaCompileButton, "Компиляция без загрузки");
            toolTip.SetToolTip(this.btnCancel, "Отмена загрузки");
            toolTip.SetToolTip(this.LuaRunButton, "Компиляция и загрузка");
            toolTip.SetToolTip(this.LibFolderButton, "Выбор папки с библиотеками");
            toolTip.SetToolTip(this.btnTelemetryRun, "Запуск телеметрии");
            toolTip.SetToolTip(this.btnTelemetryPause, "Приостоновка записи телеметрии");
            toolTip.SetToolTip(this.btnTelemetryRecord, "Запись телеметрии");
            toolTip.SetToolTip(this.btnOnlineTelemetry, "Вывод текущей телеметрии в графики");
            toolTip.SetToolTip(this.btnOfflineTelemetry, "Загрузка лога и вывод в графики сохраненных данных");
            toolTip.SetToolTip(this.btnSaveLog, "Сохранение лога в файла");
            toolTip.SetToolTip(this.btnConnect, "Инофрмация о подключенном устройстве");
            toolTip.SetToolTip(this.btnLUARestart, "Перезапуск вертуальной машины");
            toolTip.SetToolTip(this.LuacFileOpenButton, "Выбор файла байт-кода для загрузки");
            toolTip.SetToolTip(this.LuaFileButton, "Выбор LUA файла для компиляции и загрузки");
            toolTip.SetToolTip(this.UtilFolderButton, "Выбор папки с утилитами для компиляции");
            toolTip.SetToolTip(this.LibFolderButton, "Выбор папки с библиотеками для компиляции");
            toolTip.SetToolTip(this.LibChecked, "Список найденых библиотек");
            toolTip.SetToolTip(this.ConsoleTextBox, "Окно вывода результатов работы программы");
            toolTip.SetToolTip(this.btnHelp, "Справка по системе");
            toolTip.SetToolTip(this.StatusLine, "Строка статуса");
            toolTip.SetToolTip(this.btnLoad, "Сборка и загрузка прикладной программы");
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
        }
        
        private void vStatusLinePrint(string text, bool color)
        {
            StatusLine.Text = text;
            StatusLine.ForeColor = color ? Color.Black : Color.Red;
        }
        private void vColorText(string sText, int iColor)
        {
            switch (iColor)
            {
                case 0:
                    ConsoleTextBox.AppendText(sText + Environment.NewLine);
                    break;
                case 1:
                    ConsoleTextBox.SelectionStart = ConsoleTextBox.TextLength;
                    ConsoleTextBox.SelectionLength = 0;
                    ConsoleTextBox.SelectionColor = Color.Red;
                    ConsoleTextBox.AppendText(sText + Environment.NewLine);
                    ConsoleTextBox.SelectionColor = ConsoleTextBox.ForeColor;
                    break;
                default:
                    break;
            }
            ConsoleTextBox.ScrollToCaret();
        }
        private void ProgressStep(uint data)
        {
            if (FormCloseStatus) { return; }
            if (progressBar1.InvokeRequired)
            {
                var d = new SafeCallDelegate1(ProgressStep);
                progressBar1.Invoke(d, new object[] { data });
            }
            else
            {
                switch (LoadingStep++)
                {
                    case 0:
                        StatusLine.Text = load_2_mes;
                        break;
                    case 15:
                        StatusLine.Text = load_3_mes;
                        break;
                    case 30:
                        StatusLine.Text = load_4_mes;
                        break;
                    case 44 :
                        LoadingStep = 0;
                        break;
                    default:
                        break;
                }    
                progressBar1.Value = (int)data + 3;
            }
        }
        private void isNoTelemetryFinish(Int32 status_ok)
        {
            USBDataNoProcess.Set();
        }
        private void isFinish( Int32 status_ok)
        {
            USBDataNoProcess.Set();
            if (FormCloseStatus) 
            {
                return;
            }
            if (ConsoleTextBox.InvokeRequired)
            {
                
                var d = new SafeCallDelegate2(isFinish);
                ConsoleTextBox.Invoke(d, new object[] { status_ok  });
            }
            else
            {
                vSetState(AppStateType.FINISH);
                switch (status_ok)
                {
                    case 0:
                        vStatusLinePrint( load_end_mes ,true);
                        vColorText(load_end_mes, 0);
                        vSetTelemetryState(TelemetryState.Stop);
                        break;
                    case 1:
                        vStatusLinePrint(lost_conection_error_mes, false);
                        vColorText(lost_conection_error_mes, 1);
                        progressBar1.Value = 0;
                        vSetTelemetryState(TelemetryState.Stop);
                        break;
                    case 2:
                        vStatusLinePrint(load_cancel_mes, false);
                        vColorText(load_cancel_mes, 1);
                        progressBar1.Value = 0;
                        vSetTelemetryState(TelemetryState.Stop);
                        break;
                    case 3:
                        break;

                }
                
                ConsoleTextBox.ScrollToCaret();
                
            }
        }
        void vSetTelemetryState( TelemetryState state)
        {
            vTelemertyBtnState(state);
            switch (state)
            {
                case TelemetryState.Stop:
               
                    //Если шла запись, то закываем файл лога и востанавливаем цвет кнопок
                    if ((TelState == TelemetryState.PauseRecord) || (TelState == TelemetryState.Record))
                    { 
                        btnTelemetryRecord1.BackColor = SystemColors.Control;
                        btnTelemetryRecord.BackColor = SystemColors.Control;
                        LogData.vStopRecord();
                    }
                    btnTelemetryRun.BackColor = SystemColors.Control;
                    btnTelemetryRun1.BackColor = SystemColors.Control;
                    btnTelemetryPause.BackColor = SystemColors.Control;
                    btnTelemetryPause1.BackColor = SystemColors.Control;
                    TelState = state;
                    break;
                case TelemetryState.Run:
                    if (TelState == TelemetryState.Stop)
                        LogData.ResetLog();
                    if (TelState == TelemetryState.PauseRecord)
                    {
                        TelState = TelemetryState.Record;
                        btnTelemetryRecord1.BackColor = Color.Red;
                        btnTelemetryRecord.BackColor = Color.Red;
                    }
                    else
                    TelState = state;
                    btnTelemetryPause.BackColor =  SystemColors.Control;
                    btnTelemetryPause1.BackColor = SystemColors.Control;
                    btnTelemetryRun.BackColor = Color.Green;
                    btnTelemetryRun1.BackColor = Color.Green;
                    break;
                case TelemetryState.Pause:
                   
                    if (TelState == TelemetryState.Record)
                    {
                        TelState = TelemetryState.PauseRecord;
                        btnTelemetryRecord1.BackColor = Color.Yellow;
                        btnTelemetryRecord.BackColor = Color.Yellow;
                  
                    }
                    else
                    {
                        TelState = state;
                    }
                    btnTelemetryRun.BackColor = SystemColors.Control;
                    btnTelemetryRun1.BackColor = SystemColors.Control;
                    btnTelemetryPause.BackColor = Color.Yellow;
                    btnTelemetryPause1.BackColor = Color.Yellow;
                    break;
                case TelemetryState.Record:
                    if (TelState == TelemetryState.Stop)
                        LogData.ResetLog();
                    btnTelemetryRecord1.BackColor = Color.Red;
                    btnTelemetryRecord.BackColor  = Color.Red;
                    LogData.vStartRecord();
                    TelState = state;
                    break;
            }
        }
        private void vGetDevice()
        {
            if (!PDM.isConnected())
            {
                
                if (PDM.Init() == usbInit.done)
                {
                    PDM.setLoopTime(int.Parse(LoopTime.Text));
                    if (PDM.isConnected())
                    {
                        USBDataNoProcess.Reset();
                        PDM.vGetDeviceInfo(isNoTelemetryFinish);
                        USBDataNoProcess.WaitOne();
                        PDM.pdm.vReinit();
                        LogData.AinCount = PDM.pdm.ainN;
                        LogData.DinCount = PDM.pdm.dinN;
                        LogData.DoutCount = PDM.pdm.doutN;
                        LogData.SystemCount = 6;
                    }
                }
                if (TelStatus == TelemetryStatus.OnlineTelemetry)
                    vChartDataInit();
                
            }
        }
        void vClearData()
        {
            for (int i = 0; i < PDM.pdm.DOUT_Count; i++)
            {
                LogData.dout[i].GrapData = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                LogData.system[i].GrapData = 0;
            }
            for (int i = 0; i < LogData.ain.Count; i++)
            {
                LogData.ain[i].GrapData = 0;
            }
            for (int i = 0; i < LogData.din.Count; i++)
            {
                LogData.din[i].GrapData = 0;
            }
        }
        AppStateType xGetState()
        {
            return this.State;
        }
        bool bStateChangeEnable = true;
        bool vSetState(AppStateType state)
        {
            bool res = true;
            if (bStateChangeEnable)
            {
                bStateChangeEnable = false;
                switch (state)
                {
                    case AppStateType.CONNECTED:
                        switch (this.State)
                        {
                            case AppStateType.IDLE:
                                vGetDevice();
                                this.State = AppStateType.CONNECTED;  
                                break;
                            case AppStateType.CONNECTED:
                                PDM.close();
                                this.State = AppStateType.IDLE;
                                break;
                            case AppStateType.DOWNLOAD_RUN:
                            case AppStateType.UPLOAD_RUN:
                                bStateChangeEnable = true;
                                vSetState(AppStateType.CANSEL);
                                PDM.close();
                                this.State = AppStateType.IDLE;
                                break;
                        }
                        break;
                    case AppStateType.IDLE:
                        if (this.State != AppStateType.IDLE)
                        {
                            bStateChangeEnable = true;
                            vSetState(AppStateType.CONNECTED);
                        }
                        this.State = AppStateType.IDLE;
                        break;
                    case AppStateType.CANSEL:
                        PDM.cancel();
                        USBDataNoProcess.WaitOne();
                        this.State = AppStateType.IDLE;
                        USBDataNoProcess.Set();
                        break;
                    case AppStateType.INIT:
                        this.State = AppStateType.IDLE;
                        USBDataNoProcess.Set();
                        break;
                    case AppStateType.FINISH:
                        this.State = AppStateType.CONNECTED;
                        USBDataNoProcess.Set();
                        break;
                    case AppStateType.STOP:
                         PDM.cancel();
                         USBDataNoProcess.WaitOne();
                        if  (this.State != AppStateType.IDLE)
                        {
                            this.State = AppStateType.CONNECTED;
                        }
                         USBDataNoProcess.Set();
                         
                        break;
                    case AppStateType.DOWNLOAD_RUN:
                        switch (this.State)
                        {
                            case AppStateType.IDLE:
                                bStateChangeEnable = true;
                                vSetState(AppStateType.CONNECTED);
                                break;
                            case AppStateType.UPLOAD_RUN:
                                bStateChangeEnable = true;
                                vSetState(AppStateType.STOP);
                                vSetTelemetryState(TelemetryState.Stop);
                                break;
                        }
                        if (this.State == AppStateType.CONNECTED)
                        {
                            this.State = AppStateType.DOWNLOAD_RUN;
                            USBDataNoProcess.Reset();
                        }
                        break;
                    case AppStateType.UPLOAD_RUN:
                        switch(this.State)
                        {
                            case AppStateType.IDLE:
                                bStateChangeEnable = true;
                                vSetState(AppStateType.CONNECTED);
                                bStateChangeEnable = true;
                                vSetState(AppStateType.UPLOAD_RUN);
                                break;
                            case AppStateType.CONNECTED:
                                PDM.setLoopTime(int.Parse(LoopTime.Text));
                                if (PDM.isConnected())
                                {
                                    ErrorStringIsRead = false;
                                    PDM.TelemetryRun(isFinish);
                                    this.State = AppStateType.UPLOAD_RUN;
                                }
                                 break;
                            case AppStateType.DOWNLOAD_RUN:
                                break;
                        }
                        break;
                }
                bStateChangeEnable = true;
            }
            return res;

        }
    }
}
