using HidLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static WindowsFormsApp1.Controller;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{
    public delegate void CallBackFunction();
    public delegate void DataFinshCallBack();
    public delegate void DataProcessCallBack();
    public class USB_Exchange
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
        public enum msgSTAT : byte
        {
            USB_OK_STAT = 1,
            USB_BAD_REQ_STAT = 2,
            USB_NON_CON_STAT = 3,
            USB_STAT_UNAUTHORIZED = 4,
            USB_FORBIDDEN = 5,
            USB_INTERNAL = 6,
            USB_AUTO_MODE = 7
        }
        public enum msgCMD : byte
        {
            USB_REPORT_CMD_START_WRITING = 1,
            USB_REPORT_CMD_WRITE_SCRIPT = 2,
            USB_REPORT_CMD_END_WRITING = 3,
            USB_REPORT_CMD_READ_SCRIPT = 4,
            USB_REPORT_CMD_READ_DATA = 5,
            USB_REPORT_CMD_READ_TELEMETRY = 6,
            USB_REPORT_CMD_UPDATE_TELEMETRY = 7,
            USB_REPORT_CMD_RESTART_LUA = 8,
            USB_REPORT_CMD_READ_ERROR_STR = 9
        }
        public enum msgType : byte
        {
            lua = 1,
            data = 2,
            telemetry = 3,
            loop = 4,
            errorString = 5
        }
        public enum usbStat : byte
        {
            wait = 1,
            write = 2,
            read = 3,
            dash = 4,
            error = 5
        }

        const byte msgSIZE = 40;
        const byte USB_DIR_BYTE = 0;
        const byte USB_CMD_BYTE = 1;
        const byte USB_STAT_BYTE = 2;
        const byte USB_ADR0_BYTE = 3;
        const byte USB_ADR1_BYTE = 4;
        const byte USB_LEN0_BYTE = 5;
        const byte USB_DATA_BYTE = 6;
        const byte USB_DATA_SIZE = msgSIZE - USB_DATA_BYTE;
        const byte USB_CHART_HEADER_LENGTH = 54;
        private static ushort byteToUint16(byte byte0, byte byte1)

        {
            return (ushort)((byte0 & 0xFF) | ((byte1 & 0xFF) << 8));
        }
        

        public class USB_Message 
        {    
            //объявление членов
            public msgCMD command;
            public msgSTAT status;      /* Status of message    */
            public int adr;             /* Target address       */
            public byte length;         /* Length of full data  */
            public byte[] data;         /* Data of message      */
            public byte[] buffer;       /* Copy input buffer    */

            public USB_Message(byte[] buffer): this()
            {
                Array.Copy( buffer, this.buffer, buffer.Length);
            }

            public USB_Message(HidReport buffer) : this()
            {
                this.buffer[USB_DIR_BYTE] = buffer.ReportId;
                Array.Copy(buffer.Data, 0, this.buffer,1, buffer.Data.Length);
            }

            public USB_Message()
            {
                data    = new byte[USB_DATA_SIZE];
                buffer  = new byte[msgSIZE+1];
                command = 0;
                status  = 0;
                adr     = 0;
                length  = 0;
            }
         
            private static uint byteToUint32(byte byte0, byte byte1, byte byte2, byte byte3)
            {
                return (((uint)byte0 & 0x000000FF) | (((uint)byte1 << 8) & 0x0000FF00) | (((uint)byte2 << 16) & 0x00FF0000) | (((uint)byte3 << 24) & 0xFF000000));
            }
            private static void strToEncodeByte(String str, byte length, ref byte[] output)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    output[i] = (byte)Char.GetNumericValue(str[i]);
                }
                if (length > str.Length)
                {
                    for (var i = length; i < str.Length; i++)
                    {
                        output[i] = 0x00;
                    }
                }
                return;
            }
            private void setup()
            {
                buffer[USB_DIR_BYTE] =  0x01;          /* 1st channel for sending via USB */
                buffer[USB_CMD_BYTE] =  (byte)command;
                buffer[USB_STAT_BYTE] = (byte)status;
                buffer[USB_ADR0_BYTE] = (byte)(adr & 0xFF);
                buffer[USB_ADR1_BYTE] = (byte)((adr >> 8) & 0xFF);
                buffer[USB_LEN0_BYTE] = (byte)(length & 0xFF);
                return;
            }
            private void parsingCommandByte()
            {
                switch (buffer[USB_CMD_BYTE])
                {
                    case (byte)msgCMD.USB_REPORT_CMD_START_WRITING:
                        command = msgCMD.USB_REPORT_CMD_START_WRITING;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_WRITE_SCRIPT:
                        command = msgCMD.USB_REPORT_CMD_WRITE_SCRIPT;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_END_WRITING:
                        command = msgCMD.USB_REPORT_CMD_END_WRITING;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_READ_SCRIPT:
                        command = msgCMD.USB_REPORT_CMD_READ_SCRIPT;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_READ_DATA:
                        command = msgCMD.USB_REPORT_CMD_READ_DATA;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_READ_TELEMETRY:
                        command = msgCMD.USB_REPORT_CMD_READ_TELEMETRY;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_UPDATE_TELEMETRY:
                        command = msgCMD.USB_REPORT_CMD_UPDATE_TELEMETRY;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_RESTART_LUA:
                        command = msgCMD.USB_REPORT_CMD_RESTART_LUA;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_READ_ERROR_STR:
                        command = msgCMD.USB_REPORT_CMD_READ_ERROR_STR;
                        break;
                    default:
                        command = 0;
                        status = msgSTAT.USB_BAD_REQ_STAT;
                        
                        break;
                }
                return;
            }
            private void parsingStateByte()
            {
                switch (buffer[USB_STAT_BYTE])
                {
                    case (byte)msgSTAT.USB_OK_STAT:
                        status = msgSTAT.USB_OK_STAT;
                        break;
                    case (byte)msgSTAT.USB_BAD_REQ_STAT:
                        status = msgSTAT.USB_BAD_REQ_STAT;
                        break;
                    case (byte)msgSTAT.USB_NON_CON_STAT:
                        status = msgSTAT.USB_NON_CON_STAT;
                        break;
                    case (byte)msgSTAT.USB_STAT_UNAUTHORIZED:
                        status = msgSTAT.USB_STAT_UNAUTHORIZED;
                        break;
                    case (byte)msgSTAT.USB_FORBIDDEN:
                        status = msgSTAT.USB_FORBIDDEN;
                        break;
                    case (byte)msgSTAT.USB_INTERNAL:
                        status = msgSTAT.USB_INTERNAL;
                        break;
                    default:
                        status = msgSTAT.USB_BAD_REQ_STAT;
                        break;
                }
                return;
            }
            private void parsingAddressByte()
            {
                adr = byteToUint16(buffer[USB_ADR0_BYTE], buffer[USB_ADR1_BYTE]);
                return;
            }
            private void parsingLengthByte()
            {
                length = buffer[USB_LEN0_BYTE];
                return;
            }
            private void parsingDataBytes()
            {
                if (status != msgSTAT.USB_BAD_REQ_STAT)
                {
                    int k = 0;
                    for (var i = USB_DATA_BYTE; i < msgSIZE; i++)
                    {
                        data[k] = buffer[i];
                        k++;
                    }
                }
                return;
            }
            void setupLength(ref byte[] buffer)
            {
                buffer[USB_LEN0_BYTE] = length;
                return;
            }
 
            private void makeRequest(byte cmd, int adr)
            {
                this.status  = msgSTAT.USB_OK_STAT;
                this.command = (msgCMD)cmd;
                this.adr = adr;
                length = 0;
                Array.Clear(buffer, 0, msgSIZE);
                setup();
            }
            private void makeResponse(byte cmd,int adr, byte[] gdata, byte length)
            {
                this.status = msgSTAT.USB_OK_STAT;
                this.command = (msgCMD)cmd;
                this.adr = adr;
                this.length = length;
                
                Array.Clear(buffer, 0, msgSIZE);
                Array.Clear(data, 0, USB_DATA_SIZE);
                Array.Copy(gdata, this.data, length);
                Array.Copy(gdata, 0, buffer, USB_DATA_BYTE, length);
                setup();
            }
            private byte[] parseLua()
            {
                byte[] output = new byte[length];
                return output;
            }
            private byte[] parseData()
            {
                byte[] output = new byte[length];
                for (var i = 0; i < length; i++)
                {
                    output[i] = data[i];
                }
                return output;
            }
            /*--------------------------------------------------------------------------*/
            public void Init()
            {
                parsingCommandByte();  /* Parsing command byte */
                parsingStateByte();    /* Parsing state byte */
                parsingAddressByte();  /* Parsing address bytes */
                parsingLengthByte();   /* Parsing length bytes */
                parsingDataBytes();    /* Parsing data bytes */
                return;
            }
            public void makeLuaRequest()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_READ_SCRIPT, 0);
                return;
            }
            public void makeDataRequest(int adr)
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_READ_DATA, adr);
                return;
            }
            public void makeTelemetryRequest(int adr)
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_READ_TELEMETRY, adr);
                return;
            }
            public void makeErrorStringRequest(int adr)
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_READ_ERROR_STR, adr);
                return;
            }
            public void codeStartWriting()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_START_WRITING, 0);
                return;
            }
            public void codeUpdateTelemetry()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_UPDATE_TELEMETRY, 0);
                return;
            }
            public void codeFinishWriting()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_END_WRITING, 0);
                return;
            }
            public void codeRestartLua()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_RESTART_LUA, 0);
                return;
            }
            public void codeLuaLength(ushort adr, int length)
            {
               byte[] bufdata = new byte[4];
                for (var i = 0; i < 4; i++)
                {
                    bufdata[i] = (byte)((length >> (i * 8)) & 0xFF);
                }
                makeResponse((byte)msgCMD.USB_REPORT_CMD_WRITE_SCRIPT, adr, bufdata, 4);
                return;
            }
            public void codeLua(int adr, int Len, byte[] script)
            {
                byte[] data = new byte[Len];
                for (var i = 0; i < Len; i++)
                {
                    data[i] = (byte)(script[i] & 0xFF);
                }
                makeResponse((byte)msgCMD.USB_REPORT_CMD_WRITE_SCRIPT, adr, data, (byte)Len);
                return;
            }
            public void codeTerminator(ushort adr)
            {
                byte[] data = { 0 };
                makeResponse((byte)msgCMD.USB_REPORT_CMD_WRITE_SCRIPT, adr, data, 1);
            }
            public void parse(out msgType type, out byte[] output)
            {
                switch (command)
                {
                    case msgCMD.USB_REPORT_CMD_WRITE_SCRIPT:
                        output = parseLua();
                        type = msgType.lua;
                        break;
                    case msgCMD.USB_REPORT_CMD_READ_DATA:
                        output = parseData();
                        type = msgType.data;
                        break;
                    case msgCMD.USB_REPORT_CMD_READ_TELEMETRY:
                        output = parseData();
                        type = msgType.telemetry;
                        break;
                    case msgCMD.USB_REPORT_CMD_RESTART_LUA:
                        output = System.Text.Encoding.Default.GetBytes("Ok");
                        type = msgType.loop;
                        break;
                    case msgCMD.USB_REPORT_CMD_READ_ERROR_STR:
                        output = parseData();
                        type = msgType.errorString;
                        break;
                    default:
                        output = null;
                        type = 0;
                        break;
                }               
            }
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
                uint res = 0;
                float data = ((counter + 1) /(float) sequence.Count );
                res = (uint)(data*100);
                return res;
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
        class InputMessageArray
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
            uint getLength()
            {
                return length;
            }
        }

        class OutputMessageArray
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
            /*this.printState = () => {
            console.log((array.getCounter() * USB_DATA_SIZE) + '/' + (array.getLength() * USB_DATA_SIZE) + ' bytes ( ' + (array.getCounter() / array.getLength() * 100) + '% )');
            return;*/
        }
        public delegate void IndicatoStep(uint par);
        public delegate void ProccesEndFinisgCallBack(Int32 statu_ok);
        public class Alert
        {
            public IndicatoStep  st;
            public Alert()
            {
                
            }
            public void close(int timeout)
            {

            }
            public void setProgressBar(uint progress)
            {
                st.Invoke(progress);
            }
        }
        public class USBtransport
        {
            /*------------------ Private ------------------*/
            string[] usbStrStat = { "none", "wait", "write", "read", "dash", "error" };
            public Int32 USB_PID = 0x0201;
            public Int32 USB_VID = 0x1A40;
            private InsertedEventHandler OnConnectCallback;
            private RemovedEventHandler OnDisConnectCallback;
            private DataFinshCallBack OnDataFinsh;
            private DataProcessCallBack OnDataRocess;
            private OutputMessageArray output;
            private InputMessageArray input;
            private usbStat status;
            private Alert alert;
            private static HidDevice device;
            

            /*------------------- Pablic ------------------*/
            //this.error = [];

            //this.errorCounter = 0;
            /*------------------ Private ------------------*/
            public USBtransport(int PID, int VID, InsertedEventHandler onConnect, RemovedEventHandler onDisconect, DataFinshCallBack c, DataProcessCallBack pDPCallBack)
            {
                USB_PID = PID;
                USB_VID = VID;
                OnConnectCallback = onConnect;
                OnDisConnectCallback = onDisconect;
                OnDataFinsh = c;
                OnDataRocess = pDPCallBack;
                status = usbStat.wait;
                output = new OutputMessageArray();
                input = new InputMessageArray();
            }
            public usbHandler isEnd()
            {
                return output.isEnd();
            }
            void write(byte[] data)
            {
               
                if ( device != null ) 
                {
                    HidReport report = new HidReport(data.Length, new HidDeviceData(data, HidDeviceData.ReadStatus.Success));
                    try
                    {
                        device.WriteReport(report);
                    }
                    catch (Exception e)
                    {
                        device.Dispose();
                    }
                    
                }
                return;
            }
            public void handler(HidReport msg)
            {
                    usbHandler result = usbHandler.finish;
                    USB_Message input = new USB_Message(msg);
                     switch (status)
                     {
                         case usbStat.wait:
                             break;
                         case usbStat.write:
                             result = writeHandler(input);
                             break;
                         case usbStat.read:
                            result = readHandler(input);
                             break;
                         default:
                             break;
                     } 
                    if (result == usbHandler.finish)
                    {
                        OnDataFinsh();
                        status = usbStat.wait;
                    }   
                    else if (result == usbHandler.continue_)
                    {
                        
                    }
                try
                {
                    device.ReadReport(handler);
                }
                catch (Exception e) 
                {
                    device.Dispose(); 
                }
            }

            usbHandler writeHandler(USB_Message response)
            {
                usbHandler result = usbHandler.continue_;
                response.Init();
                if (response.status == msgSTAT.USB_OK_STAT)
                {
                        if ((response.command == msgCMD.USB_REPORT_CMD_START_WRITING) ||
                             (response.command == msgCMD.USB_REPORT_CMD_WRITE_SCRIPT) ||
                             (response.command == msgCMD.USB_REPORT_CMD_END_WRITING) ||
                             (response.command == msgCMD.USB_REPORT_CMD_READ_SCRIPT) ||
                             (response.command == msgCMD.USB_REPORT_CMD_READ_DATA) ||
                             (response.command == msgCMD.USB_REPORT_CMD_READ_TELEMETRY) ||
                             (response.command == msgCMD.USB_REPORT_CMD_UPDATE_TELEMETRY) ||
                             (response.command == msgCMD.USB_REPORT_CMD_RESTART_LUA) ||
                             (response.command == msgCMD.USB_REPORT_CMD_READ_ERROR_STR))
                        {
                            result = output.isEnd();
                            if (result == usbHandler.continue_)
                            {
                                if (alert != null)
                                {
                                    OnDataRocess();
                                    alert.setProgressBar(output.getProgress());
                                }
                                write(output.nextMessage());
                            }
                        }
                        else
                        {
                            result = usbHandler.finish;
                        }
                }
                if (alert != null)
                {
                    alert.close(0);
                }
                return result;
            }

            usbHandler readHandler(USB_Message message)
            {
                message.Init();
                usbHandler result = input.process(message);
                if ((result == usbHandler.finish) && (input.isEnd() == usbHandler.continue_))
                {
                        if (alert != null)
                        {
                            alert.setProgressBar(input.getProgress());
                        }
                        write(input.nextRequest());
                        result = usbHandler.continue_;
                }
                else if ((result == usbHandler.error) || (result == usbHandler.unauthorized))
                {
                     if (alert != null)
                     {
                         alert.close(0);
                     }
                 }
                return result;
            }

            public usbInit scan()
            {

                usbInit res;
                device =  HidDevices.Enumerate(USB_VID, USB_PID).FirstOrDefault();
                if ( device != null)
                {
                    res = usbInit.done;
                    device.OpenDevice();
                    device.Inserted += OnConnectCallback;
                    device.Removed += OnDisConnectCallback;
                    device.ReadReport(handler);
                    device.MonitorDeviceEvents = true;
                }
                else
                {
                    res = usbInit.fail;
                }
                return res;
            }
 
            public void close()
            {
                if (device != null)
                {
                    if (device.IsOpen)
                    {
                        device.Dispose();
                        OnDisConnectCallback();
                    }
                }
                return;
            }
            public USB_Message[] getInput()
            {
                return input.getData();
            }


            public usbStat getStatus() => status;
            public void setRead() => status = usbStat.read;
            public void setWait() => status= usbStat.wait;
            
            public string getStringStatus() => usbStrStat[(int)status];
        
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
         

            public void start_write(Alert alertIn)
            {
                while (output.isEnd() != usbHandler.finish)
                {
                    status = usbStat.write;
                    if (alertIn != null)
                    {
                        alert.setProgressBar(output.getProgress());
                    }
                    write(output.nextMessage());
                }
                status = usbStat.wait;
            }
         

            public void start (usbStat dir, Alert alertIn) 
            {
                alert = alertIn;
                switch (dir)
                {
                    case usbStat.write:
                        status = usbStat.write;
                        if (alertIn != null)
                        {
                            alert.setProgressBar(output.getProgress());
                        }
                        write(output.nextMessage()) ;
                        break;
                    case usbStat.read:
                        status = usbStat.read;
                        if (alertIn != null)
                        {
                            alert.setProgressBar(input.getProgress());
                        }
                        write(input.nextRequest());
                        break;
                    case usbStat.dash:
                        status = usbStat.dash;
                        if (alertIn != null)
                        {
                            alert.setProgressBar(input.getProgress());
                        }
                        write(input.nextRequest());
                        break;
                }
                return;
            }
        }
        public delegate void RedrawHandler(Telemetry data);
        
        public class PdmController
        {
            
            public USBtransport transport;
            Alert alert;
            public Controller.PDM pdm;
            private byte loopActive;
            private bool connected;
            private bool finish;
            public bool newdata = false;
            private bool ReadErrorString = false;
            private bool ReadDeviceData = false;
            private bool LUARestart = false;
           
            private bool loop_enable;
            RedrawHandler RedrawCallback;
            private int USB_VID;
            private int USB_PID;
            private int loopTime;
            AutoResetEvent USBDataFinish = new AutoResetEvent(false);
            AutoResetEvent USBDataProcess = new AutoResetEvent(false);
            AutoResetEvent USBDataCancel = new AutoResetEvent(false);
            public Thread TelemetryThread;
            public Thread DataLoadThread;
            public bool isDataLoad;
            private ProccesEndFinisgCallBack FinishCallBack;
            /*---------------------------------------------*/

            public PdmController(int usbtimeout, bool loop, int VID, int PID, InsertedEventHandler onConnect, RemovedEventHandler onDisconect, RedrawHandler RedrawCallback,Semaphore s)
            {
                USB_VID = VID;
                USB_PID = PID;
                isDataLoad = false;
                this.loop_enable = loop;
                loopTime = 100;
                transport = null;
                this.RedrawCallback = RedrawCallback;                  
                loopActive = 0;
                connected = false;
                finish = false;
                alert = new Alert();
                pdm = new Controller.PDM();
                transport = new USBtransport(USB_PID, USB_VID, onConnect, onDisconect, DataF, DataProcces);             
            }
            
            public void DataF()
            {
                USBDataFinish.Set();
            }
            public void setLoopTime(int lt)
            {
                if (lt!=0)
                {
                    loopTime = (int)lt;
                }
            }
            public void DataProcces() => USBDataProcess.Set();
            public void TelemetryRun(ProccesEndFinisgCallBack finishcall)
            {
                FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                USBDataFinish.Reset();
                USBDataCancel.Reset();
                transport.clean();
                TelemetryThread = new Thread(TelemetryLoop); 
                TelemetryThread.Start();
            }
            public void TelemetryRun()
            {
                USBDataFinish.Reset();
                USBDataCancel.Reset();
                transport.clean();
                TelemetryThread = new Thread(TelemetryLoop);
                TelemetryThread.Start();
            }
           
            public void readErrorString()
            {   
                ReadErrorString = true;
                return;
            }
            public void parsingFullMessage()
            {
                bool dashFl = false;
                bool dataFl = false;
                bool errorFl = false;
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
                            break;
                        case msgType.data:
                            dataFl = true;
                            for (var j = 0; j < buffer[i].length; j++)
                            {
                                pdm.telemetryBlob.Add(data[j]);
                            }
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
                    }
                }
                if (dashFl  == true) pdm.telemetry.parsing(pdm.telemetryBlob);
                else
                if (errorFl == true) pdm.telemetry.lua.errorParsing(pdm.telemetryBlob);
                else
                if (dataFl  == true) pdm.SYSTEM.parsing(pdm.telemetryBlob);
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
            public void Restart()
            {
                LUARestart = true;
                if (TelemetryThread == null)
                {
                    TelemetryRun();
                }
                else
                if (!TelemetryThread.IsAlive)
                {
                    TelemetryRun();
                }
            }
            public void vGetDeviceInfo(ProccesEndFinisgCallBack finishcall)
            {
                ReadDeviceData = true;
                if (TelemetryThread == null)
                {
                    FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                    TelemetryRun(FinishCallBack);
                }
                else
                if (!TelemetryThread.IsAlive)
                {
                    FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                    TelemetryRun(FinishCallBack);
                }
            }
            public bool isConnected() => connected;
            public void setConnected()

            { connected = true; }
            public void setDisconected()
            {
                cancel();
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
            public void TelemetryLoop()
            {
                while (true)
                {
                    transport.clean();
                    USB_Message msg = new USB_Message();
                    if (LUARestart)
                    {
                        LUARestart = false;
                        msg.codeRestartLua();
                        transport.addToOutput(msg);
                        transport.start(usbStat.write, null);
                    }
                    else
                    {
                        if (ReadDeviceData)
                        {
                            msg.codeUpdateTelemetry();
                            transport.addRequest(msg);
                            for (var i = 0; i < (pdm.SYSTEM.length / USB_DATA_SIZE)+1; i++)
                            {
                                msg.makeDataRequest(i * USB_DATA_SIZE);
                                transport.addRequest(msg);
                            }
                        }
                        else
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
                        transport.start(usbStat.read, null);
                    }
                    var res = AutoResetEvent.WaitAny(new WaitHandle[] { USBDataCancel, USBDataFinish }, 2000);
                    if ((res == WaitHandle.WaitTimeout) || (res == 0))
                    {
                        transport.clean();
                        FinishCallBack(3);
                        break;
                    }
                    else
                    {
                        parsingFullMessage();
                        if (ReadDeviceData == false)
                        {
                            if (bCanselDataFlag == false)
                            {
                                RedrawCallback(pdm.telemetry);
                            }
                            else
                                bCanselDataFlag = false;
                        }
                        else
                        {
                            ReadDeviceData = false;
                            FinishCallBack(3);
                            break;
                        }
                        
                    }
                }
            }
            private bool bCanselDataFlag = false;
            private void DataLoad()
            {
                Int32 res;
                USBDataProcess.Reset();
                while (true)
                {
                    res = AutoResetEvent.WaitAny(new WaitHandle[] { USBDataProcess, USBDataCancel, USBDataFinish },2000);
                    if (res == WaitHandle.WaitTimeout)
                    {
                        transport.clean();
                        res = 1;
                        break;
                    }
                    if (res == 1)
                    {
                        transport.clean();
                        res = 2;
                        break;
                    }
                    if (res == 2)
                    {
                        res = 0;
                        break;  
                    }
                }
                FinishCallBack(res);
            }
            public void cancel()
            {
                if (DataLoadThread != null)
                {
                    if (DataLoadThread.IsAlive)
                    {
                        USBDataCancel.Set();
                        return;
                    }
                }
                if (TelemetryThread != null)
                {
                    if (TelemetryThread.IsAlive)
                    {
                        bCanselDataFlag = true;
                        USBDataCancel.Set();
                    }
                }
            }
            public void send(IndicatoStep callbac, ProccesEndFinisgCallBack finishcall)
            {
                if (isConnected())
                {
                    FinishCallBack = new ProccesEndFinisgCallBack(finishcall);
                    alert.st = new IndicatoStep(callbac);
                    DataLoadThread = new Thread(DataLoad);
                    initWriteSequency();
                    transport.start(usbStat.write, alert);
                    USBDataFinish.Reset();
                    USBDataProcess.Reset();
                    USBDataCancel.Reset();
                    DataLoadThread.Start();
                }
                return;
            }
        }
    }  
}
