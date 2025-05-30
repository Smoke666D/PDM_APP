using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    
    public partial class CanHACKERLoadForm : Form
    {
        private APPData Config;
        private bool adapter_connect = false;
        private bool Bootloader;
        private int BootloaderState;
        private DateTime datetime;
        private CanUsbAdapterVcp adapter;
        private DateTime dateTime;
        private ulong[] writepakect;
        private byte[] bootfile;
        private long filesize;
        private UInt32 CRCCODE;
        private ushort dev_id;
        private bool DataUpdate;
        private UInt32 addres_offset = 0;
        enum FormViewState
        {
            UploadConfig,
            ConnectView,
            DisconectView,
        }
        public CanHACKERLoadForm()
        {
            InitializeComponent();
            UpdateSeriaPortName();
            cboxComPortName.SelectedIndex = 0;
            cbCOMBrate.SelectedIndex = 0;
            BtnConfig(FormViewState.DisconectView);
            writepakect = new ulong[300];
            Config = new APPData();
            pbDataLoad.Step = 1;
            pbDataLoad.Minimum = 0;
            BootloaderState = 0;
        }
        private void UpdateSeriaPortName()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                string[] displyports = null;
                for (int i = 0; i < ports.Length; i++)
                {
                    if (displyports == null)
                    {
                        displyports = new string[1];
                        displyports[0] = ports[i];
                    }
                    else
                    {
                        bool Addnew = true;
                        for (int j = 0; j < displyports.Length; j++)
                        {
                            if (ports[i] == displyports[j])
                            {
                                Addnew = false;
                                break;
                            }
                        }
                        if (Addnew == true)
                        {
                            Array.Resize(ref displyports, displyports.Length + 1);
                            displyports[displyports.Length - 1] = ports[i];
                        }
                    }
                }
                Array.Sort(displyports);
                cboxComPortName.Items.Clear();
                cboxComPortName.Items.AddRange(displyports);
            }
        }

        private void cboxComPortName_DropDown(object sender, EventArgs e)
        {
            UpdateSeriaPortName();
        }

        private void backgroundCanHackerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            datetime = DateTime.Now;
            e.Result = TimeConsumingOperation(bw);
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

   
        private void backgroundCanHackerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnConfig(FormViewState.ConnectView);
            TimeSpan timeout = DateTime.Now - datetime;
            tbTimeElpsed.Text = timeout.ToString();
            DataUpdate = false;
      
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (adapter_connect)
            {
                lbBootDeviceList.Items.Clear();
                Bootloader = true;
                pbDataLoad.Maximum = 1000;
                pbDataLoad.Value = 0;
                BootloaderState = 0;
                BtnConfig(FormViewState.UploadConfig);
                backgroundCanHackerLoad.RunWorkerAsync();
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (adapter_connect == false)
            {
                if (cboxComPortName.SelectedIndex < 0) { MessageBox.Show("Невыбран номер порта!"); return; }
                string rate = "";

                Config.CanBr = cbBRateConnect.SelectedIndex;
                switch (cbBRateConnect.SelectedIndex)
                {
                    case 0:
                        rate = CanUsbOption.BAUD_1M;
                        break;
                    case 1:
                        rate = CanUsbOption.BAUD_500K;
                        break;
                    case 2:
                        rate = CanUsbOption.BAUD_250K;
                        break;
                    case 3:
                        rate = CanUsbOption.BAUD_100K;
                        break;
                    case 4:
                        rate = CanUsbOption.BAUD_50K;
                        break;
                    case 5:
                        rate = CanUsbOption.BAUD_20K;
                        break;
                    default:
                        rate = CanUsbOption.BAUD_10K;
                        break;
                }
                if (cbCOMBrate.SelectedIndex >= 0)
                {
                    Config.AdapterBR = cbCOMBrate.SelectedIndex;
                    Config.ComPort = cboxComPortName.SelectedItem.ToString();
                    Config.AdapterBitrate = rate;
                    adapter = new CanUsbAdapterVcp(Config.ComPort, Config.GetBR(), Config.AdapterBitrate);
                    adapter_connect = true;
                    try { adapter.Open(); }
                    catch
                    {
                        adapter_connect = false;
                        adapter.Close();
                    }

                }
                if (adapter_connect == false) { MessageBox.Show("Нет связи с адаптером!"); }
                else
                {

                    BtnConfig(FormViewState.ConnectView);
                }
            }
            else
            {
                BtnConfig(FormViewState.DisconectView);
            }
        }
        private void BtnConfig(FormViewState config)
        {
            switch (config)
            {
                case FormViewState.UploadConfig:
                    btLoadData.Enabled = false;
                    btnStop.Enabled = true;
                    btnScan.Enabled = false;
                    btLoadData.Enabled = false;
                    break;
                case FormViewState.ConnectView:
                    adapter_connect = true;
                    Bootloader = false;
                    btLoadData.Enabled = true;
                    btnScan.Enabled = true;
                    btnStop.Enabled = false;
                    btLoadData.Enabled = true;
                    btnConnect.BackColor = Color.Green;
                    break;
                case FormViewState.DisconectView:
                    adapter_connect = false;
                    btLoadData.Enabled = false;
                    btnStop.Enabled = false;
                    btnScan.Enabled = false;
                    btLoadData.Enabled = false;
                    btnConnect.BackColor = Color.White;
                    break;
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.Filter = "bin files (*.bin)|*.bin|LuaC fules (*.luac)|*.luac|Lua fules (*.lua)|*.lua";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Config.BootFileName = dlg.FileName;
                tbSystemFileName.Text = dlg.FileName;
            }
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            if (adapter_connect)
            {
                try
                {
                    using (FileStream BootloadFileStram = new FileStream(Config.BootFileName, FileMode.Open))
                    {
                        bootfile = new byte[BootloadFileStram.Length];
                        filesize = BootloadFileStram.Read(bootfile,0,bootfile.Length);
                    }
                }
                catch { MessageBox.Show("Поблемы с файлом для загрузки!"); return; }
                CRCCODE = CRC_CALC(bootfile, false);
                Bootloader = true;
                BootloaderState = 2;
                addres_offset = 0;
                if (lbBootDeviceList.SelectedIndex >= 0)
                    dev_id = Convert.ToUInt16(lbBootDeviceList.SelectedItem.ToString());
                pbDataLoad.Maximum = (int)filesize / 8;
                pbDataLoad.Value = 0;
                backgroundCanHackerLoad.RunWorkerAsync();
                BtnConfig(FormViewState.UploadConfig);
            }

        }

        private void CanHACKERLoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adapter.Close();
        }

        private void btnLoadLua_Click(object sender, EventArgs e)
        {

            if (adapter_connect)
            {
                try
                {
                    using (FileStream BootloadFileStram = new FileStream(Config.BootFileName, FileMode.Open))
                    {
                        byte[] bootfiletemp;
                        byte end_of =(byte)((Path.GetExtension(Config.BootFileName) == ".lua") ? 0x00 : 0xFF);
                        bootfiletemp = new byte[BootloadFileStram.Length ];
                        
                        int real_filesize = BootloadFileStram.Read(bootfiletemp, 0, bootfiletemp.Length);
                        filesize = real_filesize;
                        UInt16 size = (UInt16)(4 - (filesize % 4));

                        bootfile = new byte[filesize + size+ 8];
                
                        for (UInt32 k=0;k< (BootloadFileStram.Length); k++)
                            {
                                bootfile[k + 4] = bootfiletemp[k];
                            }
                        for (int i = 0; i < size; i++)
                            bootfile[filesize + i + 4] = end_of;
                           for (int i = 0; i < 4; i++)
                              bootfile[filesize + size+4+i] = end_of;
                        filesize = (filesize + size + 8);
                        bootfile[0] = (byte)(real_filesize & 0xFF);
                        bootfile[1] = (byte)(real_filesize >> 8 & 0xFF);
                        bootfile[2] = (byte)(real_filesize >> 16 & 0xFF);
                        bootfile[3] = (byte)(real_filesize >> 24 & 0xFF);
                    }
                }
                catch { MessageBox.Show("Поблемы с файлом для загрузки!"); return; }
                UInt32 temp_addr;
                if (uint.TryParse(tbStartAddres.Text, NumberStyles.AllowHexSpecifier, null, out temp_addr) ==false)
                {
                    MessageBox.Show("Неверно введено смещение файла");
                }
                addres_offset = temp_addr;


                CRCCODE = CRC_CALC(bootfile, false);
                Bootloader = true;
                BootloaderState = 2;
                if (lbBootDeviceList.SelectedIndex >= 0)
                    dev_id = Convert.ToUInt16(lbBootDeviceList.SelectedItem.ToString());
                pbDataLoad.Maximum = (int)(filesize+4) / 8;
                pbDataLoad.Value = 0;
                backgroundCanHackerLoad.RunWorkerAsync();
                BtnConfig(FormViewState.UploadConfig);
            }
        }
    }
}
