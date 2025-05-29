using HidLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class USB_Exchange
    {

       
        public class USBtransport
        {
            
            /*-------------------Public-------------------*/
            public InsertedEventHandler OnConnectCallback;
            public RemovedEventHandler OnDisConnectCallback;
            public OutputMessageArray output;
            public InputMessageArray input;
            public Alert alert;
            /*------------------ Private ------------------*/
            private Int32 USB_PID = 0x0201;
            private Int32 USB_VID = 0x1A40;
            private static HidDevice device;
            /*---------------Public----------------------*/
            public USBtransport(int PID, int VID, InsertedEventHandler onConnect, RemovedEventHandler onDisconect)
            {
                USB_PID = PID;
                USB_VID = VID;
                OnConnectCallback = onConnect;
                OnDisConnectCallback = onDisconect;
                output = new OutputMessageArray();
                input = new InputMessageArray();
            }
            public void vDataLoadWrite()
            {
                write(output.nextMessage());
            }
            public usbHandler DataLoadStep()
            {
                return writedatahandler(device.ReadReport(3000));
            }

            public usbHandler ReadDataStep()
            {
                return readdatahandler(device.ReadReport(1000));
            }
            public void vStartRead()
            {
                write(input.nextRequest());
            }
            public usbInit scan()
            {
                device = HidDevices.Enumerate(USB_VID, USB_PID).FirstOrDefault();
                if (device != null)
                {
                    device.OpenDevice();
                    device.Inserted += OnConnectCallback;
                    device.Removed += OnDisConnectCallback;
                    device.MonitorDeviceEvents = true;
                    return (usbInit.done);
                }
                return (usbInit.fail);
            }
            public void close()
            {
                if (device != null)
                {
                    if (device.IsOpen)
                    {
                        device.CloseDevice();
                        device.Dispose();
                    }
                }
                return;
            }
            public USB_Message[] getInput()
            {
                return input.getData();
            }
            public void clean()
            {
                output.clean();
                input.clean();
                return;
            }
            public void addToOutput(USB_Message message)
            {
                output.addMessage(message);
                return;
            }
            public void addRequest(USB_Message message)
            {
                input.addRequest(message);
                return;
            }
            public void vsetProgressBar(Alert alertIn)
            {
                alert = alertIn;
                if (alertIn != null)
                {
                    alert.setProgressBar(input.getProgress());
                }
                return;
            }
            public void vsetProgressBar1(Alert alertIn)
            {
                alert = alertIn;
                if (alertIn != null)
                {
                    alert.setProgressBar(output.getProgress());
                }
                return;
            }
            public usbHandler asynchandler(HidReport msg)
            {
                USB_Message InputData = new USB_Message(msg);
                InputData.Init();
                usbHandler result = input.process(InputData);
                if ((result == usbHandler.finish) && (input.isEnd() == usbHandler.continue_))
                {
                    write(input.nextRequest());
                    result = usbHandler.continue_;
                }
                return result;
            }
           
            public Task<int> vPDMReset()
            {
                clean();
                usbHandler result;
                USB_Message msg = new USB_Message();
                //msg.codeEEPROMWriting();
                msg.codeRestartLua();
                addToOutput(msg);
                while (true)
                {
                    vDataLoadWrite();
                    result = DataLoadStep();
                    if ((result == usbHandler.finish) || (result == usbHandler.error))
                    {
                        break;
                    }

                }
                return Task.FromResult(1); 
            }


            public Task<int> vPDMWriteEEPROM()
            {
                clean();
                usbHandler result;
                USB_Message msg = new USB_Message();
       
                addToOutput(msg);
                while (true)
                {
                    vDataLoadWrite();
                    result = DataLoadStep();
                    if ((result == usbHandler.finish) || (result == usbHandler.error))
                    {
                        break;
                    }

                }
                return Task.FromResult(1);
            }

            public Task<int> vPDMstop()
            {
                clean();
                usbHandler result;
                USB_Message msg = new USB_Message();
               // msg.codeEEPROMWriting();
                msg.codeStopLua();
                addToOutput(msg);
                while (true)
                {
                    vDataLoadWrite();
                    result = DataLoadStep();
                    if ((result == usbHandler.finish) || (result == usbHandler.error))
                    {
                        break;
                    }

                }
                return Task.FromResult(1);
            }
            public void taskSetData()
            {
                //clean();
                usbHandler result;
                while (true)
                {
                    write(output.nextMessage());
                    result = DataLoadStep();
                    if ((result == usbHandler.finish) || (result == usbHandler.error))
                    {
                        break;
                    }
                }
                return;
            }
            public Task<int> taskGetData()
            {
                usbHandler result;
                write(input.nextRequest());
                do
                {
                    result = asynchandler(device.ReadReport(1000));
                }
                while (result == usbHandler.continue_);
                return Task.FromResult(1);
            }
            /*----------------Private---------------------*/
            private void write(byte[] data)
            {
                if (device.IsConnected)
                {
                    if (data != null)
                    {
                        try
                        {
                            HidReport report = new HidReport(data.Length, new HidDeviceData(data, HidDeviceData.ReadStatus.Success));
                            device.WriteReport(report, 1000);
                        }
                        catch (Exception e)
                        {
                            device.Dispose();
                        }
                    }
                }
                return;
            }
            private usbHandler writedatahandler(HidReport msg)
            {
                USB_Message response = new USB_Message(msg);
                response.Init();
                if (response.status == msgSTAT.USB_OK_STAT)
                {       
                     if (alert != null)
                     {
                        alert.setProgressBar(output.getProgress());
                     }
                    return (output.isEnd());
                }
                return usbHandler.error;
            }
            private usbHandler readdatahandler(HidReport msg)
            {
                USB_Message response = new USB_Message(msg);
                response.Init();
                usbHandler result = input.process(response);
                if ((result == usbHandler.finish) && (input.isEnd() == usbHandler.continue_))
                {
                    if (alert != null)
                    {
                        alert.setProgressBar(input.getProgress());
                    }
                    result = usbHandler.continue_;
                }
                return result;
            }
            
        }
    }
}
