using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CanUsbAdapterVcp
    {
        private bool _disposed;
        private readonly string _baudrate = CanUsbOption.BAUD_125K;
        private readonly SerialPort _port;

        public string AdapterName { get; }

        public string Baudrate { get; }

        public CanUsbStatus Status { private set; get; } = CanUsbStatus.Offline;

        public CanUsbAdapterVcp(string portName, int UARTRate, string baudrate)
        {
            _baudrate = ParseBaudrate(baudrate);
            _port = new SerialPort()
            {
                PortName = portName,
                BaudRate = UARTRate,
                NewLine = "\r",
                ReadTimeout = 1000,// 100,
                WriteTimeout = 1000,//1,
            };
        }


        public void Open()
        {

            _port.Open();
            InitPort(_port, _baudrate);
            Status = CanUsbStatus.Online;
        }
        public void Close()
        {
            if (_disposed) return;
            if (Status is CanUsbStatus.Offline) return;
            if (_port.IsOpen)
            {

                Status = CanUsbStatus.Offline;
                _port.WriteLine("C");
                Thread.Sleep(100);

                _port.Close();
            }
        }

        public void Write(CanMessage message)
        {
            if (_disposed) return;
            var msg = message.Flags is CanUsbOption.EXTENDED ? "T" : "t";
            msg += message.Id.ToString(msg is "t" ? "X3" : "X8");
            msg += message.Length;
            for (int i = 0; i < message.Length; i++)
            {
                byte temp = (byte)((message.Data >> (8 * i)));
                msg += temp.ToString("X2");
            }

            //  foreach (var d in BitConverter.GetBytes(message.Data))
            //    msg += d.ToString("X2");
            _port.WriteLine(msg);
        }

        public CanMessage Read()
        {
            if (_disposed) return null;
            if (_port.IsOpen)
            {
                CanMessage msg;
                if (_port.ReceivedBytesThreshold > 0)
                    try
                    {
                        var line = _port.ReadLine();
                        if (
                            TryParseMsgFrame(line, out msg)
                        )
                        {
                            return msg;
                        }
                    }
                    catch { }
                ;

            }
            return null;
        }
        public void ClearBuffer()
        {
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();

        }

        private static void InitPort(SerialPort port, string baudrate)
        {
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            port.WriteLine("v");
            port.ReadLine();
            port.WriteLine("CFFFFFF");
            // Thread.Sleep(1000);
            // port.ReadLine();

            port.WriteLine("S" + baudrate);
            //  port.ReadLine();
            //  Thread.Sleep(100);
            port.WriteLine("Z1");
            //   port.ReadLine();
            //   Thread.Sleep(100);
            port.WriteLine("O");
            //   Thread.Sleep(100);
            port.ReadLine();
        }
        private static string ParseBaudrate(string baudrate)
        {
            string res;
            switch (baudrate)
            {
                case CanUsbOption.BAUD_10K: res = "0"; break;
                case CanUsbOption.BAUD_20K: res = "1"; break;
                case CanUsbOption.BAUD_50K: res = "2"; break;
                case CanUsbOption.BAUD_100K: res = "3"; break;
                case CanUsbOption.BAUD_125K: res  = "4"; break;
                case CanUsbOption.BAUD_250K: res=  "5"; break;
                case CanUsbOption.BAUD_500K: res = "6"; break;
                case CanUsbOption.BAUD_800K: res = "7"; break;
                default: res = "8"; break;
            }
            return (res);
      
        }


        private static bool TryParseMsgFrame(string line, out CanMessage msg)
        {
            msg = null;
            var mode = line.FirstOrDefault();
            if (mode is 't')
            {
                if (
                    line.Length > 6 &&
                    uint.TryParse(line.Substring(1,3), NumberStyles.AllowHexSpecifier, null, out var id) &&
                    byte.TryParse(line.Substring(4,1), out var len)
                )
                {
                    var pos = 5 + len * 2;
                    if (
                        ulong.TryParse(line.Substring(5,pos-5), NumberStyles.AllowHexSpecifier, null, out var data) &&
                        uint.TryParse(line.Substring(pos,line.Length-pos), NumberStyles.AllowHexSpecifier, null, out var timestamp)
                    )
                    {
                        var ary = BitConverter.GetBytes(data).Reverse().ToArray();
                        // byte[] bdata = new byte[8];


                        msg = new CanMessage(id, ary, default, len, timestamp);
                        return true;
                    }
                }
            }
            return false;
        }

      
    }
    internal class CanMessage
    {
        public uint Id { get; }
        public uint Timestamp { get; }
        public byte Flags { get; }

        public byte Length { get; }

        public ulong Data { get; }
        public byte[] mdata;

        public CanMessage(uint id, ulong data, byte flags = CanUsbOption.EXTENDED, byte len = 8, uint timestamp = 0)
        {
            Id = id;
            Timestamp = timestamp;
            Flags = flags;
            Length = len;
            Data = data;
        }
        public CanMessage(uint id, byte[] data, byte flags = CanUsbOption.EXTENDED, byte len = 8, uint timestamp = 0)
        {
            if (data.Length != 8) throw new ArgumentException("data length must be 8.");
            Id = id;
            Timestamp = timestamp;
            Flags = flags;
            Length = len;
            mdata = new byte[8];
            for (int i = 0; i < len; i++)
            {
                mdata[i] = data[8 - len + i];
            }
            //  mdata = data;
            Data = BitConverter.ToUInt64(data,0);
        }

        /*public override string ToString()
        {
            var id = Id.ToString("X");
            var data = BitConverter.GetBytes(Data).Reverse().Select(x => x.ToString("X2")).ToArray();
            return $"0x{id}:{string.Join('-', data)}";
        }*/

        /*internal CANMsg ToCANMsg()
            => new(Id, Timestamp, Flags, Length, Data);
        */
        /*internal static CanMessage FromCANMsg(CANMsg msg)
            => new(msg.id, msg.data, msg.flags, msg.len, msg.timestamp);

        */
    }
    public class CanUsbOption
    {
        public const string BAUD_BTR_1M = "0x00:0x14";

        public const string BAUD_BTR_500K = "0x00:0x1C";

        public const string BAUD_BTR_250K = "0x01:0x1C";

        public const string BAUD_BTR_125K = "0x03:0x1C";

        public const string BAUD_BTR_100K = "0x43:0x2F";

        public const string BAUD_BTR_50K = "0x47:0x2F";

        public const string BAUD_BTR_20K = "0x53:0x2F";

        public const string BAUD_BTR_10K = "0x67:0x2F";

        public const string BAUD_BTR_5K = "0x7F:0x7F";

        public const string BAUD_1M = "1000";

        public const string BAUD_800K = "800";

        public const string BAUD_500K = "500";

        public const string BAUD_250K = "250";

        public const string BAUD_125K = "125";

        public const string BAUD_100K = "100";

        public const string BAUD_50K = "50";

        public const string BAUD_20K = "20";

        public const string BAUD_10K = "10";

        public const int ERROR_OK = 1;

        public const int ERROR_OPEN_SUBSYSTEM = -2;

        public const int ERROR_COMMAND_SUBSYSTEM = -3;

        public const int ERROR_NOT_OPEN = -4;

        public const int ERROR_TX_FIFO_FULL = -5;

        public const int ERROR_INVALID_PARAM = -6;

        public const int ERROR_NO_MESSAGE = -7;

        public const int ERROR_MEMORY_ERROR = -8;

        public const int ERROR_NO_DEVICE = -9;

        public const int ERROR_TIMEOUT = -10;

        public const int ERROR_INVALID_HARDWARE = -11;

        public const byte STANDARD = 0;

        public const byte EXTENDED = 128;

        public const byte RTR = 64;

        public const byte FLAG_TIMESTAMP = 1;

        public const byte FLAG_QUEUE_REPLACE = 2;

        public const byte FLAG_BLOCK = 4;

        public const byte FLAG_SLOW = 8;

        public const byte FLAG_NO_LOCAL_SEND = 16;

        public const uint ACCEPTANCE_CODE_ALL = 0u;

        public const uint ACCEPTANCE_MASK_ALL = uint.MaxValue;

        public const uint FLUSH_WAIT = 0u;

        public const uint FLUSH_DONTWAIT = 1u;

        public const uint FLUSH_EMPTY_INQUEUE = 2u;
    }
    public enum CanUsbStatus
    {
        Offline,
        Online
    }
    internal class ViewMessage
    {

        public const ushort PDO2 = 0xF5F6;
        public const ushort PROGRESS_STEP = 0xF5F5;
        public const ushort UPDATE = 0x5555;

        public const ushort CONNECT = 0x5656;
        public const ushort ODOMETRSTATE = 0x0F00;
        public const ushort HOURSTATE = 0x0F01;
        public const ushort ODOMETRCH = 0x0F02;
        public const ushort REV_CODE = 0x0F03;
        public const ushort RGB1CH = 0x1001;
        public const ushort RGB2CH = 0x1002;
        public const ushort RGB3CH = 0x1003;
        public const ushort RGB4CH = 0x1004;
        public const ushort RGB5CH = 0x1005;
        public const ushort RGB6CH = 0x1006;
        public const ushort RGB7CH = 0x1007;
        public const ushort RGB8CH = 0x1008;
        public const ushort RGB9CH = 0x1009;
        public const ushort RGB10CH = 0x100A;
        public const ushort RGB11CH = 0x100C;
        public const ushort RGB12CH = 0x100B;
        public const ushort RGB13CH = 0x100D;
        public const ushort RGB14CH = 0x100E;
        public const ushort BARCH = 0x100F;
        public const ushort RGB1GH = 0x2001;
        public const ushort RGB1GL = 0x3001;
        public const ushort RGB1RH = 0x4001;
        public const ushort RGB1RL = 0x5001;
        public const ushort RGB1BH = 0x6001;
        public const ushort RGB1BL = 0x7001;
        public const ushort RGB2GH = 0x2002;
        public const ushort RGB2GL = 0x3002;
        public const ushort RGB2RH = 0x4002;
        public const ushort RGB2RL = 0x5002;
        public const ushort RGB2BH = 0x6002;
        public const ushort RGB2BL = 0x7002;
        public const ushort RGB3GH = 0x2003;
        public const ushort RGB3GL = 0x3003;
        public const ushort RGB3RH = 0x4003;
        public const ushort RGB3RL = 0x5003;
        public const ushort RGB3BH = 0x6003;
        public const ushort RGB3BL = 0x7003;
        public const ushort RGB4GH = 0x2004;
        public const ushort RGB4GL = 0x3004;
        public const ushort RGB4RH = 0x4004;
        public const ushort RGB4RL = 0x5004;
        public const ushort RGB4BH = 0x6004;
        public const ushort RGB4BL = 0x7004;
        public const ushort RGB5GH = 0x2005;
        public const ushort RGB5GL = 0x3005;
        public const ushort RGB5RH = 0x4005;
        public const ushort RGB5RL = 0x5005;
        public const ushort RGB5BH = 0x6005;
        public const ushort RGB5BL = 0x7005;
        public const ushort RGB6GH = 0x2006;
        public const ushort RGB6GL = 0x3006;
        public const ushort RGB6RH = 0x4006;
        public const ushort RGB6RL = 0x5006;
        public const ushort RGB6BH = 0x6006;
        public const ushort RGB6BL = 0x7006;
        public const ushort RGB7GH = 0x2007;
        public const ushort RGB7GL = 0x3007;
        public const ushort RGB7RH = 0x4007;
        public const ushort RGB7RL = 0x5007;
        public const ushort RGB7BH = 0x6007;
        public const ushort RGB7BL = 0x7007;
        public const ushort RGB8GH = 0x2008;
        public const ushort RGB8GL = 0x3008;
        public const ushort RGB8RH = 0x4008;
        public const ushort RGB8RL = 0x5008;
        public const ushort RGB8BH = 0x6008;
        public const ushort RGB8BL = 0x7008;
        public const ushort RGB9GH = 0x2009;
        public const ushort RGB9GL = 0x3009;
        public const ushort RGB9RH = 0x4009;
        public const ushort RGB9RL = 0x5009;
        public const ushort RGB9BH = 0x6009;
        public const ushort RGB9BL = 0x7009;
        public const ushort RGB10GH = 0x200A;
        public const ushort RGB10GL = 0x300A;
        public const ushort RGB10RH = 0x400A;
        public const ushort RGB10RL = 0x500A;
        public const ushort RGB10BH = 0x600A;
        public const ushort RGB10BL = 0x700A;
        public const ushort RGB11GH = 0x200B;
        public const ushort RGB11GL = 0x300B;
        public const ushort RGB11RH = 0x400B;
        public const ushort RGB11RL = 0x500B;
        public const ushort RGB11BH = 0x600B;
        public const ushort RGB11BL = 0x700B;
        public const ushort RGB12GH = 0x200C;
        public const ushort RGB12GL = 0x300C;
        public const ushort RGB12RH = 0x400C;
        public const ushort RGB12RL = 0x500C;
        public const ushort RGB12BH = 0x600C;
        public const ushort RGB12BL = 0x700C;
        public const ushort RGB13GH = 0x200D;
        public const ushort RGB13GL = 0x300D;
        public const ushort RGB13RH = 0x400D;
        public const ushort RGB13RL = 0x500D;
        public const ushort RGB13BH = 0x600D;
        public const ushort RGB13BL = 0x700D;
        public const ushort RGB14GH = 0x200E;
        public const ushort RGB14GL = 0x300E;
        public const ushort RGB14RH = 0x400E;
        public const ushort RGB14RL = 0x500E;
        public const ushort RGB14BH = 0x600E;
        public const ushort RGB14BL = 0x700E;
        public const ushort BARGH = 0x8001;
        public const ushort BARGL = 0x8002;
        public const ushort BARRL = 0x8003;
        public const ushort BARRH = 0x8004;
        public const ushort BARSL = 0x8005;
        public const ushort BARSH = 0x8006;
        public const ushort BARMODE = 0x8007;
        public const ushort AIN1CH = 0x9100;
        public const ushort AIN2CH = 0x9200;
        public const ushort AIN3CH = 0x9300;

        public const ushort AIN1X1 = 0x9101;
        public const ushort AIN1Y1 = 0x9102;
        public const ushort AIN1X2 = 0x9103;
        public const ushort AIN1Y2 = 0x9104;
        public const ushort AIN1X3 = 0x9105;
        public const ushort AIN1Y3 = 0x9106;
        public const ushort AIN1X4 = 0x9107;
        public const ushort AIN1Y4 = 0x9108;
        public const ushort AIN1X5 = 0x9109;
        public const ushort AIN1Y5 = 0x910A;
        public const ushort AIN1X6 = 0x910B;
        public const ushort AIN1Y6 = 0x910C;
        public const ushort AIN1X7 = 0x910D;
        public const ushort AIN1Y7 = 0x910E;
        public const ushort AIN1X8 = 0x910F;
        public const ushort AIN1Y8 = 0x9110;
        public const ushort AIN1X9 = 0x9111;
        public const ushort AIN1Y9 = 0x9112;
        public const ushort AIN1X10 = 0x9113;
        public const ushort AIN1Y10 = 0x9114;
        public const ushort AIN1X11 = 0x9115;
        public const ushort AIN2X1 = 0x9201;
        public const ushort AIN2Y1 = 0x9202;
        public const ushort AIN2X2 = 0x9203;
        public const ushort AIN2Y2 = 0x9204;
        public const ushort AIN2X3 = 0x9205;
        public const ushort AIN2Y3 = 0x9206;
        public const ushort AIN2X4 = 0x9207;
        public const ushort AIN2Y4 = 0x9208;
        public const ushort AIN2X5 = 0x9209;
        public const ushort AIN2Y5 = 0x920A;
        public const ushort AIN2X6 = 0x920B;
        public const ushort AIN2Y6 = 0x920C;
        public const ushort AIN2X7 = 0x920D;
        public const ushort AIN2Y7 = 0x920E;
        public const ushort AIN2X8 = 0x920F;
        public const ushort AIN2Y8 = 0x9210;
        public const ushort AIN2X9 = 0x9211;
        public const ushort AIN2Y9 = 0x9212;
        public const ushort AIN2X10 = 0x9213;
        public const ushort AIN2Y10 = 0x9214;
        public const ushort AIN2X11 = 0x9215;
        public const ushort AIN3X1 = 0x9301;
        public const ushort AIN3Y1 = 0x9302;
        public const ushort AIN3X2 = 0x9303;
        public const ushort AIN3Y2 = 0x9304;
        public const ushort AIN3X3 = 0x9305;
        public const ushort AIN3Y3 = 0x9306;
        public const ushort AIN3X4 = 0x9307;
        public const ushort AIN3Y4 = 0x9308;
        public const ushort AIN3X5 = 0x9309;
        public const ushort AIN3Y5 = 0x930A;
        public const ushort AIN3X6 = 0x930B;
        public const ushort AIN3Y6 = 0x930C;
        public const ushort AIN3X7 = 0x930D;
        public const ushort AIN3Y7 = 0x930E;
        public const ushort AIN3X8 = 0x930F;
        public const ushort AIN3Y8 = 0x9310;
        public const ushort AIN3X9 = 0x9311;
        public const ushort AIN3Y9 = 0x9312;
        public const ushort AIN3X10 = 0x9313;
        public const ushort AIN3Y10 = 0x9314;
        public const ushort AIN3X11 = 0x9315;

        public const ushort RPMCOOF1 = 0xA000;
        public const ushort RPMCOOF2 = 0xA001;
        public const ushort SEGCH = 0xB000;
        public const ushort SEG1 = 0xB001;
        public const ushort SEG2 = 0xB002;
        public const ushort SEG3 = 0xB003;
        public const ushort SEG4 = 0xB004;
        public const ushort SEG5 = 0xB005;
        public const ushort SEG6 = 0xB006;
        public const ushort SEG7 = 0xB007;
        public const ushort SEG8 = 0xB008;
        public const ushort SEG9 = 0xB009;
        public const ushort Menu1 = 0XC000;
        public const ushort Menu2 = 0XC001;
        public const ushort Menu3 = 0XC002;
        public const ushort Menu4 = 0XC003;
        public const ushort Menu5 = 0XC004;
        public const ushort Menu6 = 0XC005;
        public const ushort Menu7 = 0XC006;
        public const ushort Menu8 = 0XC007;
        public const ushort Menu9 = 0XC008;
        public const ushort Menu10 = 0XC009;
        public const ushort MenuCurPos = 0xD000;
        public const ushort MenuHomePos = 0xD001;
        public const ushort MenuTimeOut = 0xD002;
        public const ushort SysyemBR = 0xE000;
        public const ushort SysyemRGBBrigth = 0xE001;
        public const ushort SysyemWhiteBrigth = 0xE002;
        public const ushort SysyemDACTIVEState = 0xE003;
        public const ushort SysyemNodeID = 0xE004;
        public const ushort SysyemTest = 0xE005;
        public const ushort VC1Config = 0XF000;
        public const ushort VC2Config = 0XF001;
        public const ushort VC3Config = 0XF002;
        public const ushort VC4Config = 0XF003;
        public const ushort VC5Config = 0XF004;
        public const ushort VC6Config = 0XF005;
        public const ushort VC7Config = 0XF006;
        public const ushort VC8Config = 0XF007;
        public const ushort VC9Config = 0XF008;
        public const ushort VC10Config = 0XF009;
        public const ushort VC11Config = 0XF00A;
        public const ushort VC12Config = 0XF00B;
        public const ushort VC13Config = 0XF00C;
        public const ushort VC14Config = 0XF00D;
        public const ushort VC15Config = 0XF00E;
        public const ushort VC16Config = 0XF00F;
        public const ushort VC17Config = 0XF010;
        public const ushort AIN1Config = 0XF011;
        public const ushort AIN2Config = 0XF012;
        public const ushort AIN3Config = 0XF013;
        public const ushort SwitchConfig = 0XF100;
        public const ushort HIsrRGB1 = 0xF200;
        public const ushort HIsrRGB2 = 0xF201;
        public const ushort HIsrRGB3 = 0xF202;
        public const ushort HIsrRGB4 = 0xF203;
        public const ushort HIsrRGB5 = 0xF204;
        public const ushort HIsrRGB6 = 0xF205;
        public const ushort HIsrRGB7 = 0xF206;
        public const ushort HIsrRGB8 = 0xF207;
        public const ushort HIsrRGB9 = 0xF208;
        public const ushort HIsrRGB10 = 0xF209;
        public const ushort HIsrRGB11 = 0xF20A;
        public const ushort HIsrRGB12 = 0xF20B;
        public const ushort HIsrRGB13 = 0xF20C;
        public const ushort HIsrRGB14 = 0xF20D;
        public const ushort HIsrBAR = 0xF20E;
        public const ushort BOOTVED = 0xF300;
        public const ushort BOOTEND = 0xF301;
        public const ushort KEYBOARD_TEST_STATE = 0xF400;
        public const ushort KEYBOARD_NODE_ID = 0xF401;
        public const ushort KEYBOARD_BITRATE = 0xF402;
        public const ushort KEYBOARD_KEY_STATE = 0xF403;
        public const ushort KEYBOARD_KEY_STATE_PDO = 0xF404;
        public const ushort KEYBOARD_LED_BRIGTH = 0xF500;
        public const ushort KEYBOARD_BACKKIGTH_BRIGTH = 0xF501;
        public const ushort KEYBOARD_BACKKIGTH_COLOR = 0xF502;
        public const ushort KEYBOARD_DEF_BACKKIGTH_COLOR = 0xF503;
        public const ushort KEYBOARD_DEF_BRIGTH = 0xF504;
        public const ushort KEYBOARD_DEF_BACKLIGTH_BRIGTH = 0xF505;
        public const ushort KEYBOARD_LED_STATE_RED = 0xF506;
        public const ushort KEYBOARD_LED_STATE_GREEN = 0xF507;
        public const ushort KEYBOARD_LED_STATE_BLUE = 0xF508;
        public const ushort KEYBOARD_BLINK_STATE_RED = 0xF509;
        public const ushort KEYBOARD_BLINK_STATE_GREEN = 0xF50A;
        public const ushort KEYBOARD_BLINK_STATE_BLUE = 0xF50B;


    }
    [Serializable]
    internal class APPData
    {
        public int AdapterBR { get; set; }
        public int CanBr { get; set; }
        public string AdapterBitrate { get; set; }
        public UInt16 DeviceCanId { get; set; }
        public string ComPort { get; set; }
        public string BootFileName { get; set; }

        public string ConfigFileName { get; set; }
        public APPData()
        {
            AdapterBR = 0;
            DeviceCanId = 0x20;
            CanBr = 2;

        }
        public int GetBR()
        {
            int[] UARTRate = new int[5] { 115200, 57600, 38400, 19200, 9600 };
            if (AdapterBR >= 0 && AdapterBR < (UARTRate.Length - 1))
                return UARTRate[AdapterBR];
            else
                return UARTRate[0];
        }

    }
}
