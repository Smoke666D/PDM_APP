using HidLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class USB_Exchange
    {
        const byte msgSIZE       = 40;
        const byte USB_DIR_BYTE  = 0;
        const byte USB_CMD_BYTE  = 1;
        const byte USB_STAT_BYTE = 2;
        const byte USB_ADR0_BYTE = 3;
        const byte USB_ADR1_BYTE = 4;
        const byte USB_LEN0_BYTE = 5;
        const byte USB_DATA_BYTE = 6;
        const byte USB_DATA_SIZE = msgSIZE - USB_DATA_BYTE;
        public enum msgCMD : byte
        {
            USB_REPORT_CMD_START_WRITING     = 1,
            USB_REPORT_CMD_WRITE_SCRIPT      = 2,
            USB_REPORT_CMD_END_WRITING       = 3,
            USB_REPORT_CMD_READ_SCRIPT       = 4,
            USB_REPORT_CMD_READ_DATA         = 5,
            USB_REPORT_CMD_READ_TELEMETRY    = 6,
            USB_REPORT_CMD_UPDATE_TELEMETRY  = 7,
            USB_REPORT_CMD_RESTART_LUA       = 8,
            USB_REPORT_CMD_READ_ERROR_STR    = 9,
            USB_REPORT_CMD_GET_TIME_DATE     = 10,           
            USB_REPORT_CMD_SET_TIME_DATE     = 11,
            USB_REPORT_CMD_SEND_ACCESS_TOKEN = 12,
            USB_REPORT_CMD_GET_EEPROM_SIZE  = 13,
            USB_REPORT_CMD_GET_EEPROM       = 14,
            USB_REPORT_CMD_SET_EEPROM       = 15,
            USB_REPORT_CMD_STOP_LUA          = 18,
        }
        public enum msgSTAT : byte
        {
            USB_OK_STAT                     = 1,
            USB_BAD_REQ_STAT                = 2,
            USB_NON_CON_STAT                = 3,
            USB_STAT_UNAUTHORIZED           = 4,
            USB_FORBIDDEN                   = 5,
            USB_INTERNAL                    = 6,
            USB_AUTO_MODE                   = 7
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
            public USB_Message()
            {
                data    = new byte[USB_DATA_SIZE];
                buffer  = new byte[msgSIZE + 1];
                command = 0;
                status  = 0;
                adr     = 0;
                length  = 0;
            }
            public USB_Message(byte[] buffer) : this()
            {
                Array.Copy(buffer, this.buffer, buffer.Length);
            }
            public USB_Message(HidReport buffer) : this()
            {
                this.buffer[USB_DIR_BYTE] = buffer.ReportId;
                Array.Copy(buffer.Data, 0, this.buffer, 1, buffer.Data.Length);
            }
            private void setup()
            {
                buffer[USB_DIR_BYTE] = 0x01;          /* 1st channel for sending via USB */
                buffer[USB_CMD_BYTE] = (byte)command;
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
                    case (byte)msgCMD.USB_REPORT_CMD_GET_EEPROM:
                        command = msgCMD.USB_REPORT_CMD_GET_EEPROM;
                        break;
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
                    case (byte)msgCMD.USB_REPORT_CMD_GET_TIME_DATE:
                        command = msgCMD.USB_REPORT_CMD_GET_TIME_DATE;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_GET_EEPROM_SIZE:
                        command = msgCMD.USB_REPORT_CMD_GET_EEPROM_SIZE;
                        break;
                    case (byte)msgCMD.USB_REPORT_CMD_SET_EEPROM:
                        command = msgCMD.USB_REPORT_CMD_SET_EEPROM;
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
          
            private void makeRequest(byte cmd, int adr)
            {
                this.status = msgSTAT.USB_OK_STAT;
                this.command = (msgCMD)cmd;
                this.adr = adr;
                length = 0;
                Array.Clear(buffer, 0, msgSIZE);
                setup();
            }
            private void makeResponse(byte cmd, int adr, byte[] gdata, byte length)
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
                adr     = byteToUint16(buffer[USB_ADR0_BYTE], buffer[USB_ADR1_BYTE]);
                length  = buffer[USB_LEN0_BYTE];
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
            public void makeEEPROMRequest(int adr)
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_GET_EEPROM, adr);
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
            public void codeSetTime(byte H,byte M, byte S, byte Y,byte MON,byte D)
            {
                byte[] data = new byte[6];
                data[0] = H;
                data[1] = M;
                data[2] = S;
                data[5] = Y;
                data[4] = MON;
                data[3] = D;
                makeResponse((byte)msgCMD.USB_REPORT_CMD_SET_TIME_DATE, 0, data, 6);
            }
            public void codeSendToken(ushort token)
            {
                byte[] data = new byte[2];
                data[0] = (byte)(token >>8);
                data[1] = (byte)(token & 0xFF);
                makeResponse((byte)msgCMD.USB_REPORT_CMD_SEND_ACCESS_TOKEN, 0, data, 2);
             
            }
            public void codeUpdateTelemetry()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_UPDATE_TELEMETRY, 0);
                return;
            }
          
            public void codeGetSize()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_GET_EEPROM_SIZE, 0);
                return;
            }
            public void codeGetTime()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_GET_TIME_DATE, 0);
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
            public void codeStopLua()
            {
                makeRequest((byte)msgCMD.USB_REPORT_CMD_STOP_LUA, 0);
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
            public void codeEEPROM(int adr, int Len, byte[] script)
            {
                byte[] data = new byte[Len];
                for (var i = 0; i < Len; i++)
                {
                    data[i] = (byte)(script[i] & 0xFF);
                }
                makeResponse((byte)msgCMD.USB_REPORT_CMD_SET_EEPROM, adr, data, (byte)Len);
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
                    case msgCMD.USB_REPORT_CMD_GET_EEPROM_SIZE:
                        output = parseData();
                        type = msgType.eeprom_size;
                        break;
                    case msgCMD.USB_REPORT_CMD_GET_EEPROM:
                        output = parseData();
                        type = msgType.eeprom_data;
                        break;
                    case msgCMD.USB_REPORT_CMD_GET_TIME_DATE:
                        output = parseData();
                        type = msgType.time_date;
                        break;
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
        }
    }
