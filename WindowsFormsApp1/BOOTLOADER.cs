using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CanHACKERLoadForm : Form
    {
        private UInt32 CRC_CALC(byte[] data, bool swaped)
        {
            UInt32 POLYNOMIAL = 0x04c11db7;
            UInt32 InitialSimpleRegister = 0xFFFFFFFF;
            int len = data.Length;
            uint[] crc_table = new uint[256];
            UInt32 register;
            UInt32 crc;
            for (UInt32 i = 0; i < 256; i++)
            {

                crc = i << 24;
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x80000000) != 0)
                    {
                        crc = (crc << 1) ^ POLYNOMIAL;
                    }
                    else
                    {
                        crc = crc << 1;
                    }
                }

                crc_table[i] = crc;
            }

            register = InitialSimpleRegister;
            int k = 0;
            int ind = data.Length;
            while (ind >= 4)
            {
                UInt32 wd = (UInt32)((data[k])) << 24 | (UInt32)data[k + 1] << 16 | (UInt32)data[k + 2] << 8 | (UInt32)data[k + 3]; //htonl(data[i]);// (UInt32)data[i+3] | (UInt32)data[i + 2] << 8 | (UInt32)data[i + 1] << 16 | (UInt32)data[i ] << 24;
                ind = ind - 4;
                k = k + 4;
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ wd) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 8)) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 16)) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 24)) & 0xff)];
            }
            if (ind > 0)
            {
                UInt32 wd = 0xE339E339;
                switch (ind)
                {

                    case 1:
                        wd = (wd & 0x000000FF) | (UInt32)((data[k])) << 24 | (UInt32)data[k + 1] << 16 | (UInt32)data[k + 2] << 8;
                        break;
                    case 2:
                        wd = (wd & 0x0000FFFF) | (UInt32)((data[k])) << 24 | (UInt32)data[k + 1] << 16;

                        break;
                    case 3:
                        wd = (wd & 0x00FFFFFF) | (UInt32)((data[k])) << 24;

                        break;
                }
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ wd) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 8)) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 16)) & 0xff)];
                register = ((register << 8)) ^ crc_table[(((register >> 24) ^ (wd >> 24)) & 0xff)];
            }
            return ~register;
        }

        private void backgroundCanHackerLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int index;
            int[] tem1;
            ulong tempulong;
            char led_state;
            long temp_long;
            bool res;
            float temp_float;
            int i, j;
            switch (e.ProgressPercentage)
            {
                case ViewMessage.PROGRESS_STEP:
                    pbDataLoad.PerformStep();
                    break;
                case ViewMessage.BOOTVED:
                    if (Convert.ToUInt16(e.UserState) < 255)
                    {
                        lbBootDeviceList.Items.Insert(0, e.UserState.ToString());
                    }
                    else
                    {
                        if (Convert.ToUInt16(e.UserState) == 258)

                            MessageBox.Show("Загрузка успешно завершена! ");
                        else
                            MessageBox.Show("Ошибка загрузки! ");

                    }
                    break;


                case ViewMessage.UPDATE:

                    DataUpdate = false;
                    //backgroundWorker1.CancelAsync();
                    break;
   
 
  
               case ViewMessage.CONNECT:

                    //MessageBox.Show("Установлена связь "  + e.UserState.ToString());
                    break;

     
            }
        }
        private int TimeConsumingOperation(BackgroundWorker bw)
        {
            int DataUpdateState = 0;
            int k = 0;
            int i = 0;
            int result = 0;
            bool AnswerIsRecive = true;
            bool now_answer = false;
            long datasend = 0;
            int data_to_send = 0;
            int connection_error = 0;
            ulong dataadress = 0x1000;
            long packetsend = 0;
            byte paketsize = 0;
            adapter.ClearBuffer();
            TimeSpan timeout1;


            CanMessage message = new CanMessage(0x00, writepakect[0], CanUsbOption.STANDARD, 1);
            CanMessage message1 = new CanMessage(0x00, writepakect[0], CanUsbOption.STANDARD, 1);
     
            dateTime = DateTime.Now;
            while (!bw.CancellationPending)
            {
                if (Bootloader)
                {
                    TimeSpan timeout = DateTime.Now - dateTime;
                    if ((timeout.TotalMilliseconds > 5000) && (BootloaderState < 2))
                    {
                        return result;
                    }
                    switch (BootloaderState)
                    {
                        case 0:
                            writepakect[0] = 0x22;
                            message1 = new CanMessage(0x01, writepakect[0], CanUsbOption.STANDARD, 1);
                            try { adapter.Write(message1); }
                            catch { }
                            backgroundCanHackerLoad.ReportProgress(ViewMessage.PROGRESS_STEP, 0);
                            Thread.Sleep(1);
                            break;
                        case 2:
                            writepakect[0] = 0x23 | (ulong)dev_id << 8;
                            message1 = new CanMessage(0x01, writepakect[0], CanUsbOption.STANDARD, 2);
                            BootloaderState = 3;
                            try { adapter.Write(message1); }
                            catch { }
                            break;

                        case 4:
                            if (datasend >= filesize)
                            {
                                writepakect[0] = 0x55;
                                writepakect[0] |= (ulong)((CRCCODE >> 24) & 0xFF) << 8;
                                writepakect[0] |= (ulong)((CRCCODE >> 16) & 0xFF) << 16;
                                writepakect[0] |= (ulong)((CRCCODE >> 8) & 0xFF) << 24;
                                writepakect[0] |= (ulong)(((CRCCODE) & 0xFF)) << 32;
                                message1 = new CanMessage(0x31, writepakect[0], CanUsbOption.STANDARD, 5);
                                adapter.Write(message1);
                                BootloaderState = 8;

                            }
                            else
                            {
                                dataadress = addres_offset+ (ulong)datasend;
                                paketsize = (byte)(((filesize - datasend) >= 256) ? 255 : (filesize - datasend - 1));
                                writepakect[0] = paketsize | (ulong)(dataadress & 0xFF) << 8 | (ulong)(dataadress >> 8 & 0xFF) << 16 | (ulong)((dataadress >> 16) & 0xFF) << 24;
                                message1 = new CanMessage(0x31, writepakect[0], CanUsbOption.STANDARD, 4);
                                BootloaderState = 5;
                                try { adapter.Write(message1); }
                                catch
                                {
                                    MessageBox.Show("Tran error");
                                }
                                dateTime = DateTime.Now;
                            }
                            break;

                        case 6:
                            long index = datasend + packetsend;
                            int max_data = (int)(((paketsize + 1 - packetsend) >= 8) ? 8 : (paketsize + 1 - packetsend));
                            writepakect[0] = 0;
                            for (i = 0; i < max_data; i++)
                            {
                                writepakect[0] |= (ulong)bootfile[index + i] << (8 * i);
                            }
                            message1 = new CanMessage(0x04, writepakect[0], CanUsbOption.STANDARD, (byte)i);
                            try { adapter.Write(message1); }
                            catch
                            {
                                MessageBox.Show("Tran error");
                            }

                            BootloaderState = 7;
                            break;
                        default:

                            break;
                    }

                    message = adapter.Read();
                    if (message != null)
                    {
                        switch (BootloaderState)
                        {
                            case 0:
                                if ((message.Length == 2) && (message.Id == 0x01))
                                {
                                    if (message.mdata[0] == 0x79)
                                    {
                                        backgroundCanHackerLoad.ReportProgress((int)ViewMessage.BOOTVED, message.mdata[1]);
                                    }
                                }
                                break;
                            case 3:
                                if (message != null)
                                {
                                    if ((message.Id == 0x01) && (message.mdata[0] == 0x79))
                                    {
                                        dateTime = DateTime.Now;
                                        BootloaderState = 4;
                                    }
                                }
                                break;
                            case 5:

                                if ((message.Id == 0x01) && (message.mdata[0] == 0x79))
                                {
                                    dateTime = DateTime.Now;
                                    connection_error = 0;
                                    BootloaderState = 6;
                                    packetsend = 0;
                                }

                                break;
                            case 7:
                                if ((message.Id == 0x04) && (message.mdata[0] == 0x79))
                                {
                                    // dateTime = DateTime.Now;
                                    connection_error = 0;
                                    packetsend = packetsend + i;
                                    backgroundCanHackerLoad.ReportProgress(ViewMessage.PROGRESS_STEP, 0);
                                    BootloaderState = 6;
                                }
                                else
                                if ((message.Id == 0x01) && (message.mdata[0] == 0x79))
                                {
                                    BootloaderState = 4;
                                    packetsend = packetsend + i;
                                    datasend = datasend + packetsend;
                                    backgroundCanHackerLoad.ReportProgress(ViewMessage.PROGRESS_STEP, 0);
                                    // dateTime = DateTime.Now;
                                }
                                break;
                            case 8:
                                if ((message.Id == 0x01))
                                {
                                    if (message.mdata[0] == 0x79)
                                    {

                                        backgroundCanHackerLoad.ReportProgress((int)ViewMessage.BOOTVED, 258);
                                    }
                                    else
                                    {
                                        backgroundCanHackerLoad.ReportProgress((int)ViewMessage.BOOTVED, 259);
                                    }
                                    return result;

                                }
                                break;
                        }
                    }
                }   
            }
            return result;
        }

    }
}
