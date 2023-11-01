using HidLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.Controller;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{
    public delegate void CallBackFunction();
    public delegate void DataFinshCallBack();
  
    public partial class  USB_Exchange
    {
        public enum usbInit : byte
        {
            fail = 0,
            done = 1
        }
        public delegate void NewDelegate(ref usbInit res);

        public enum usbHandler : byte
        {
            finish = 1,
            error = 2,
            continue_ = 3,
            unauthorized = 4,
            forbidden = 5,
            autoMode = 6
        }
       
       
        public enum msgType : byte
        {
            lua = 1,
            data = 2,
            telemetry = 3,
            loop = 4,
            errorString = 5,
            time_date = 6,
            eeprom_size = 7,
            eeprom_data = 8,
        }
        public enum usbStat : byte
        {
            wait = 1,
            write = 2,
            read = 3,
            dash = 4,
            error = 5
        }

        
        
        private static ushort byteToUint16(byte byte0, byte byte1)

        {
            return (ushort)((byte0 & 0xFF) | ((byte1 & 0xFF) << 8));
        }
        

        
        struct MessageUnit
        {
            public byte[] data;
            public ushort adr;
            public MessageUnit(byte[] data, ushort adr)
            {
                this.data = new byte[data.Length];
                Array.Copy(data, this.data, data.Length);
                this.adr = adr;
            }
        }
        struct MessageArray
        {
            private List<MessageUnit> sequence ;
            private ushort counter;
  
            public void addMessage(USB_Message message)
            { 
                if (sequence == null) { sequence = new List<MessageUnit>(); }
                sequence.Add(new MessageUnit(message.buffer, (ushort)message.adr));
            }
            public ushort getCurrentAdr()
            { 
                if (sequence.Count == 0)
                {
                    return 0xFFFF;
                }
                else
                {
                    return sequence[sequence.Count- 1].adr;
                }
            }
            public uint getLength()
            {
                if (sequence == null)
                    return 0;
                else
                
                return (uint)sequence.Count;
            }
            public int getCounter() => counter;
            public uint getProgress()
            {
                float data = ((counter + 1) /(float) sequence.Count );
                return (uint)(data * 100);
            }
               
            public void incCounter() => counter++;
            public byte[] getData(int n) => sequence[n].data;

            public void getrefData(ref byte[] output, int n)
            {
                Array.Copy(sequence[n].data, output, sequence[n].data.Length);
            }
            
            public USB_Message[] getFullData()
            {
                USB_Message[] outdata1 = new USB_Message[sequence.Count];
                for (int i = 0; i < sequence.Count; i++)
                {
                    outdata1[i] = new USB_Message(sequence[i].data);
                }
                return outdata1;
            }
            public void clean()
            {
                if (sequence!=null) sequence.Clear();
                counter = 0;
                return;
            }
            public void resetCounter()=> counter = 0;
     
        }
        public class InputMessageArray
        {
            uint length;
            MessageArray response;
            MessageArray request;

            public InputMessageArray()
            {
                response = new MessageArray();
                request = new MessageArray();
                length = 0;
            }
            public int getCurrentAdr()
            {
                return response.getCurrentAdr();
            }
            public byte[] nextRequest()
            {
                byte[] output = null;
                if (request.getCounter() < request.getLength())
                {
                    output = new byte[request.getData(request.getCounter()).Length];
                    Array.Copy( request.getData(request.getCounter()),output, request.getData(request.getCounter()).Length);
                    request.incCounter();
                }
                return output;
            }

            public uint getProgress()
            {
                return request.getProgress();
            }

            public usbHandler process(USB_Message message)
            {
                usbHandler result = usbHandler.error;
                if (message.status == msgSTAT.USB_OK_STAT)
                {
                    if (response.getLength() > 0)
                    {
                        if (response.getCurrentAdr() != message.adr)
                        {
                            length = 0;
                        }
                    }
                    else
                    {
                        length = 0;
                    }
                    response.addMessage(message);
                    length += USB_DATA_SIZE;
                    result = usbHandler.finish;
                }
                else
                {
                    if (message.status == msgSTAT.USB_BAD_REQ_STAT)
                    {
                        result = usbHandler.error;
                    }
                    else if (message.status == msgSTAT.USB_NON_CON_STAT)
                    {
                        result = usbHandler.error;
                    }
                    else if (message.status == msgSTAT.USB_FORBIDDEN)
                    {
                        result = usbHandler.forbidden;
                    }
                    else if (message.status == msgSTAT.USB_STAT_UNAUTHORIZED)
                    {
                        result = usbHandler.unauthorized;
                    }
                    else if (message.status == msgSTAT.USB_AUTO_MODE)
                    {
                        result = usbHandler.autoMode;
                    }
                }
                return result;
            }
            public usbHandler isEnd()
            {
                if (request.getCounter() < request.getLength())
                {
                    return usbHandler.continue_;
                }
                return usbHandler.finish;
            }
            public void clean()
            {
                response.clean();
                request.clean();
                return;
            }
            public void addRequest(USB_Message message)
            {
                request.addMessage(message);
                request.resetCounter();
                return;
            }
            public USB_Message[] getData()
            {
                return response.getFullData();
            }
        }

        public class OutputMessageArray
        {
            private MessageArray array;
            public OutputMessageArray()
            {
                array = new MessageArray();
            }
            public int getCurrentAdr()
            {
                return array.getCurrentAdr();
            }
            
            public byte[] nextMessage()
            {
                byte[] output = null;
                int len = array.getData(array.getCounter()).Length;
                if (array.getCounter() < array.getLength())
                {
                    output = new byte[len];
                    Array.Copy( array.getData(array.getCounter()), output, len);
                    array.incCounter();
                }
                return output;
            }
            public uint getProgress()
            {
                return array.getProgress();
            }
            public usbHandler isEnd()
            {
                if (array.getCounter() < array.getLength())
                {
                    return usbHandler.continue_;
                }
                return usbHandler.finish;
            }
            public void clean()
            {
                array.clean();
                return;
            }
            public void addMessage(USB_Message message)
            {
                array.addMessage(message);
                return;
            }
        }
        public delegate void IndicatoStep(uint par);
        public delegate void ProccesEndFinisgCallBack(Int32 statu_ok);
        public class Alert
        {
            public IndicatoStep  st;
            public Alert()
            {
                
            }
            public void setProgressBar(uint progress)
            {
                st.Invoke(progress);
            }
        }
        
        public delegate void RedrawHandler(Telemetry data);
        public struct PDM_DateTime
        {
            public byte Year;
            public byte Month;
            public byte Day;
            public byte Hour;
            public byte Minute;
            public byte Second;
        }
        public class PdmController
        {
            public PDM_DateTime PDM_Time;
            public bool PDM_Access_token;
            public ushort PDM_EEPROM_size;
            public USBtransport transport;
            Alert alert;
            public Controller.PDM pdm;
            private bool connected;
            private bool ReadErrorString = false;    
           
            RedrawHandler RedrawCallback;
            private int USB_VID;
            private int USB_PID;
            public int loopTime;
            AutoResetEvent USBDataCancel = new AutoResetEvent(false);
            private ProccesEndFinisgCallBack FinishCallBack;
            private Task telemetry_task;
            private Task data_load_task;
            private Task eeprom_load_task;


            /*---------------------------------------------*/

            public PdmController(int usbtimeout,  int VID, int PID, InsertedEventHandler onConnect, RemovedEventHandler onDisconect, RedrawHandler RedrawCallback,Semaphore s)
            {
                USB_VID = VID;
                USB_PID = PID;
                loopTime = 100;
                transport = null;
                this.RedrawCallback = RedrawCallback;                  
                connected = false;
                alert = new Alert();
                pdm = new Controller.PDM();
                transport = new USBtransport(USB_PID, USB_VID, onConnect, onDisconect);             
            }
            public void setLoopTime(int lt)
            {
                if (lt>0)
                {
                    loopTime = (int)lt;
                }
            }
           
            public void TelemetryRun(ProccesEndFinisgCallBack finishcall)
            {
                FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                USBDataCancel.Reset(); 
                transport.vsetProgressBar(null);
                transport.clean();
                if (telemetry_task== null)
                {
                    telemetry_task = new Task(TelemetryLoop);
                    telemetry_task.Start();
                }
            }
           
           
            public void readErrorString()
            {   
                ReadErrorString = true;
                return;
            }
            private Task< int> parsingData()
            {
                bool DataError = true;
                transport.getInput();
                USB_Message[] buffer = new USB_Message[transport.getInput().Length];
                msgType type;
                byte[] data = new byte[41];
                buffer = transport.getInput();
                pdm.telemetryBlob.Clear();
                for (var i = 0; i < buffer.Length; i++)
                {
                    buffer[i].Init();
                    buffer[i].parse(out type, out data);
                    if (type == msgType.data)
                    {
                            for (var j = 0; j < buffer[i].length; j++)
                            {
                                pdm.telemetryBlob.Add(data[j]);
                            }
                            DataError = false;
                    }    
                }
                if (!DataError)
                {
                    pdm.SYSTEM.parsing(pdm.telemetryBlob);
                    return Task.FromResult(1);
                }
                return Task.FromResult(0);
            }
            public Task<int> parsingSize()
            {
                USB_Message[] buffer = new USB_Message[transport.getInput().Length];
                msgType type;
                byte[] data = new byte[41];
                buffer = transport.getInput();
                pdm.telemetryBlob.Clear();
                for (var i = 0; i < buffer.Length; i++)
                {
                    buffer[i].Init();
                    buffer[i].parse(out type, out data);
                    if (type == msgType.eeprom_size)
                    {
                        if (data[0] == 1)
                        {
                            PDM_EEPROM_size = (ushort)((data[1] << 8) | data[2]);
                            PDM_Access_token = true;
                        }
                        else
                        {
                            PDM_Access_token = false;
                            PDM_EEPROM_size = 0;
                        }
                    }
                }
                return Task.FromResult(1);
            }
            public Task<int> parsingTime()
            {
                bool DataError = true;
                USB_Message[] buffer = new USB_Message[transport.getInput().Length];
                msgType type;
                byte[] data = new byte[41];
                buffer = transport.getInput();
                pdm.telemetryBlob.Clear();
                for (var i = 0; i < buffer.Length; i++)
                {
                    buffer[i].Init();
                    buffer[i].parse(out type, out data);
                    if (type == msgType.time_date)
                    {
                        PDM_Time.Year = data[5];
                        PDM_Time.Month = data[4];
                        PDM_Time.Day = data[3];
                        PDM_Time.Hour = data[0];
                        PDM_Time.Minute = data[1];
                        PDM_Time.Second =data[2];
                    }
                }
                return Task.FromResult(1);
             
            }
            public void parsingFullMessage()
            {
                bool dashFl = false;
                bool errorFl = false;
                bool eepromFL = false;
                transport.getInput();
                USB_Message[] buffer= new USB_Message[transport.getInput().Length];
                msgType type;
                byte[] data = new byte[41];
                buffer = transport.getInput();
                pdm.telemetryBlob.Clear();
                for (var i = 0; i<buffer.Length;i++)
                {
                    buffer[i].Init();                    
                    buffer[i].parse(out type, out data);
                    switch (type)
                    {
                        case msgType.lua:
                        case msgType.loop:                  
                        case msgType.data:
                            break;
                        case msgType.telemetry:
                            dashFl = true;
                            for (var j=0; j< buffer[i].length;j++)
                            {
                                pdm.telemetryBlob.Add(data[j]);
                            }                                                    
                            break;
                        case msgType.errorString:
                            errorFl = true;
                            for (var j = 0; j < buffer[i].length; j++)
                            {
                                pdm.telemetryBlob.Add(data[j]);
                            }
                            break;
                        case msgType.eeprom_data:
                            eepromFL = true;
                            for (var j = 0; j < buffer[i].length; j++)
                            {
                                pdm.telemetryBlob.Add(data[j]);
                            }
                            break;
                            
                    }
                }
                if (dashFl  == true) pdm.telemetry.parsing(pdm.telemetryBlob);
                else
                if (errorFl == true) pdm.telemetry.lua.errorParsing(pdm.telemetryBlob);
                



            }
            int initEEPROMWriteSequency(byte[] data,int offset)
            {
                byte[] buffer = new byte[data.Length-offset];
                int total = (buffer.Length-offset) / USB_DATA_SIZE +(( (buffer.Length - offset) % USB_DATA_SIZE) == 0 ? 0: 1);
                byte[] output = new byte[USB_DATA_SIZE];
                int length = 0;
                int address = offset;
                Array.Copy(data,address, buffer, 0, data.Length-offset);
                transport.clean();
                USB_Message msg = new USB_Message();
                for (var i = 0; i < total; i++)
                {
                    if (buffer.Length > USB_DATA_SIZE)
                    {
                        List<byte> nums = new List<byte>(buffer);
                        nums.CopyTo(0, output, 0, USB_DATA_SIZE);
                        nums.RemoveRange(0, USB_DATA_SIZE);
                        Array.Resize(ref buffer, nums.ToArray().Length);
                        buffer = nums.ToArray();
                        length = USB_DATA_SIZE;
                    }
                    else
                    {
                        List<byte> nums = new List<byte>(buffer);
                        output = new byte[nums.ToArray().Length];
                        output = nums.ToArray();
                        length = output.Length;
                    }
                    msg.codeEEPROM(address, length, output);
                    transport.addToOutput(msg);
                    address += USB_DATA_SIZE;
                }

                return 0;
            }
            int initWriteSequency()
            {
                byte[] buffer = new byte[pdm.lua.Length];
                int total = buffer.Length / USB_DATA_SIZE +1;
                byte[] output = new byte[USB_DATA_SIZE];
                int length = 0;
                int address = 4;
                Array.Copy(pdm.lua, buffer, pdm.lua.Length);
                transport.clean();
                USB_Message msg = new USB_Message();
                msg.codeStartWriting();
                transport.addToOutput(msg);
                msg.codeLuaLength(0, pdm.lua.Length); ;
                transport.addToOutput(msg);
                for (var i = 0; i < total; i++)
                {
                    if (buffer.Length > USB_DATA_SIZE)
                    {
                        List<byte> nums = new List<byte>(buffer);
                        nums.CopyTo(0, output, 0, USB_DATA_SIZE);
                        nums.RemoveRange(0, USB_DATA_SIZE);
                        Array.Resize(ref buffer, nums.ToArray().Length);
                        buffer = nums.ToArray();
                        length = USB_DATA_SIZE;
                    }
                    else
                    {
                        List<byte> nums = new List<byte>(buffer);
                        output = new byte[nums.ToArray().Length];
                        output = nums.ToArray();
                        length = output.Length;
                    }
                    msg.codeLua(address, length, output );
                    transport.addToOutput(msg);
                    address += USB_DATA_SIZE;
                }
                //if (pdm.isCompil == false)
                //{
                    
               // msg.codeTerminator((ushort)(pdm.lua.Length + 4));
               // transport.addToOutput(msg);
                msg.codeFinishWriting();
                transport.addToOutput(msg);
                return 0;
            }
            public usbInit Init()
            {
                usbInit result;
                if (isConnected()!= true)
                {
                    result = transport.scan();
                    if (result == usbInit.done)
                    {
                        connected = true;
                    }
                }
                else
                {
                    result = usbInit.done;
                }
                return result;
            }
            public async void Restart()
            {
                if (isConnected())
                {
                    cancel();
                    USBDataCancel.Reset();
                    await transport.vPDMReset(); 
                }
                return;
               
            }
            public async void Write()
            {
                await transport.vPDMWriteEEPROM();
                
            }

            public async void Stop()
            {
                if (isConnected())
                {
                    cancel();
                    USBDataCancel.Reset();
                    await transport.vPDMstop();
                    System.Threading.Thread.Sleep(1000);
                }
                return;

            }
            public bool SendToken(ushort token, out ushort EEPROM_SIZE)
            {
                USB_Message msg = new USB_Message();
                EEPROM_SIZE = 0;
                transport.clean();
                transport.vsetProgressBar(null);
                msg.codeSendToken(token);
                transport.addToOutput(msg);
                transport.taskSetData();
                msg.codeGetSize();
                transport.addRequest(msg);
                transport.taskGetData();
                parsingSize();
                if (PDM_Access_token)
                {
                    EEPROM_SIZE = PDM_EEPROM_size; 
                }
                return (PDM_Access_token);

            }
           
            
            public bool GendEEPROM(int size, out byte[] outdata, IndicatoStep callbac)
            {
                bool result = false;
                byte[] data = new byte[size];
                outdata = null;
                if (isConnected())
                {
                    cancel();
                    Stop();
                    alert.st = new IndicatoStep(callbac);
                    USBDataCancel.Reset();
                    usbHandler res;
                    USB_Message msg = new USB_Message();               
                    transport.clean();
                    for (var i = 0; i < size / USB_DATA_SIZE + 1; i++)
                    {
                          msg.makeEEPROMRequest(i * USB_DATA_SIZE);
                          transport.addRequest(msg);
                    }
                    transport.vsetProgressBar1(alert);
                    while (true)
                    {
                        try
                        {
                            transport.vStartRead();
                            res= transport.ReadDataStep();
                        }
                        catch
                        {
                            transport.clean();
                            result =  false;
                            break;
                         }
                         if (res == usbHandler.finish)
                         {
                            parsingFullMessage();
                            outdata = pdm.telemetryBlob.ToArray();
                            result  = true;
                            break;
                         }
                    }
                    Restart(); 
                }
                return result;
            }
           
            public void  SetTime()
            {
                USB_Message msg = new USB_Message();
                transport.clean();
                msg.codeSetTime(PDM_Time.Hour,PDM_Time.Minute,PDM_Time.Second,PDM_Time.Year,PDM_Time.Month,PDM_Time.Day);
                transport.addToOutput(msg);
                transport.taskSetData();
             
            }
            public async Task GetTime()
            {
                USB_Message msg = new USB_Message();
                transport.clean();
                msg.codeGetTime();
                transport.addRequest(msg);
                await transport.taskGetData();
                await parsingTime();
            }
            public bool isConnected() => connected;
            public void setConnected()

            { connected = true; }
            public void setDisconected()
            {
                cancel();
                close();
                connected = false;
            }
            public void close()
            {
                connected = false;
                if (transport != null)
                {
                    transport.close();
                }
                return;
            }

            public async void syncDataGet()
            {
                USB_Message msg = new USB_Message();
                transport.clean();
                msg.codeUpdateTelemetry();
                transport.addRequest(msg);
                for (var i = 0; i < (pdm.SYSTEM.length / USB_DATA_SIZE) + 1; i++)
                {
                    msg.makeDataRequest(i * USB_DATA_SIZE);
                    transport.addRequest(msg);
                }
                await transport.taskGetData();
                await parsingData(); 
            }
            public void cancel()
            {
                vTelemetryStop();
                vDataLoadStop();
            }
            public void vTelemetryStop()
            {
                if (telemetry_task != null)
                {
                    USBDataCancel.Set();
                    telemetry_task.Wait(2000);
                    telemetry_task = null;
                }
            }
            public void TelemetryLoop()
            {
                usbHandler res;
                USB_Message msg = new USB_Message();
                while (true)
                {
                    transport.clean();               
                    if (ReadErrorString)
                    {
                        ReadErrorString = false;
                        for (var i = 0; i < (pdm.telemetry.lua.getErrorStringLength() / USB_DATA_SIZE); i++)
                        {
                             msg.makeErrorStringRequest(i * USB_DATA_SIZE);
                             transport.addRequest(msg);
                         }
                    }
                    else
                    {
                        msg.codeUpdateTelemetry();
                        transport.addRequest(msg);
                        for (var i = 0; i < pdm.telemetry.length / USB_DATA_SIZE + 1; i++)
                        {
                                msg.makeTelemetryRequest(i * USB_DATA_SIZE);
                                transport.addRequest(msg);
                        }
                    }
         
                    while(true)
                    {
                        try
                        {
                            transport.vStartRead();
                            res = transport.ReadDataStep();
                        }
                        catch
                        {
                            transport.clean();
                            return;
                        }
                        if (res == usbHandler.finish)
                        {
                            parsingFullMessage();
                            RedrawCallback(pdm.telemetry);
                            if (USBDataCancel.WaitOne(loopTime) == true)
                            {
                                transport.clean();
                                return;
                            }
                            break;
                        }
                        if (USBDataCancel.WaitOne(0) == true)
                        {
                            transport.clean();
                            return;
                        }
                    }
                }   
            }
            
            public void vDataLoadStop()
            {
                if (data_load_task != null)
                {
                    USBDataCancel.Set();
                    data_load_task.Wait(1000);
                    data_load_task = null;
                }
            }
            private void DataLoad()
            {
                usbHandler result;
                transport.vsetProgressBar( alert );
                while (true)
                {
                    transport.vDataLoadWrite();
                    result = transport.DataLoadStep();
                    if (result == usbHandler.finish)
                    {
                        FinishCallBack(0);
                        break;
                    }
                    if (result == usbHandler.error)
                    {
                        FinishCallBack(1);
                        break;
                    }
                    if (USBDataCancel.WaitOne(0) == true)
                    {
                        transport.clean();
                        FinishCallBack(2);
                        break;
                    }
                }
                return;
            }

            public void SendEEPROM(byte[] data, IndicatoStep callbac)
            {
                if (isConnected())
                {
                    cancel();
                    Stop();
                    USBDataCancel.Reset();
                    alert.st = new IndicatoStep(callbac);
                    initEEPROMWriteSequency(data, 3);
                    usbHandler result;
                    transport.vsetProgressBar(alert);
                    while (true)
                    {
                        transport.vDataLoadWrite();
                        result = transport.DataLoadStep();
                        if ((result == usbHandler.finish) || (result == usbHandler.error))
                        {
                            break;
                        }                     
                    }
                    Restart();
                }
                return;
            }

            public void send(IndicatoStep callbac, ProccesEndFinisgCallBack finishcall)
            {
                if (isConnected())
                {
                    FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                    alert.st = new IndicatoStep(callbac);
                    USBDataCancel.Reset();
                    if (data_load_task == null) 
                    {
                        data_load_task = new Task(DataLoad);
                        initWriteSequency();
                        data_load_task.Start();
                    }
                }
                return;
            }
        }
    }  
}
