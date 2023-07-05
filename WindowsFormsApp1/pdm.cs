
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;









namespace WindowsFormsApp1
{

    public class Controller

    {

        public static float byteToFloat  (byte[] data, int adr) 
        {            
            if (data.Length >= ( 4 + adr ) ) 
            {
                return System.BitConverter.ToSingle(data, adr);
             }
            return 0;
        }

        const int IDlength = 12;
        public static uint bytesToUint32 (byte[] data, int adr)
        {
            uint Out = 0;
            if (data.Length >= (adr + 4))
            {
                for (int i = 0; i < 4; i++)
                {
                    Out += (uint)(data[adr + i] << (i * 8));
                }
            }
            return Out;
        }

        public static ushort bytesToUint16  (byte[] data) 
        {
            ushort Out = 0;
            if (data.Length == 2)
            {
                for (byte i = 0; i < 2; i++)
                {
                    Out += (ushort)( data[i] << (i * 8));
                }
            }
            return Out;
        }

        string byteToIDstring (byte[] data, int adr) 
        {
            string Out = "";
            for (var i = 0; i < IDlength; i++)
            {
                 string number = data[adr + i].ToString("X").ToUpper();
                if (number.Length == 1)
                {
                     number = '0' + number;
                 }
                Out += number + ':';
            }
             return Out.Substring(0, ( Out.Length - 1) );
        }

        public class Version
        {
            public int major = 0;
            public int minor = 0;
            public int patch = 0;
            public Version(byte major, byte minor, byte patch)
            {
                this.major = major;
                this.major = minor;
                this.patch = patch;
            }
            public string getString() =>
                this.major + "." + this.minor + "." + this.patch;
        }

        public class SYS
        {
            const byte IDlength = 12;
            enum pdmDataAdr : int
            {
                DATA_ADR_UNIQUE = 0,
                DATA_ADR_BOOTLOADER_MAJOR = 12,
                DATA_ADR_BOOTLOADER_MINOR = 13,
                DATA_ADR_BOOTLOADER_PATCH = 14,
                DATA_ADR_FIRMWARE_MAJOR = 15,
                DATA_ADR_FIRMWARE_MINOR = 16,
                DATA_ADR_FIRMWARE_PATCH = 17,
                DATA_ADR_HARDWARE_MAJOR = 18,
                DATA_ADR_HARDWARE_MINOR = 19,
                DATA_ADR_HARDWARE_PATCH = 20,
                DATA_ADR_LUA_MAJOR = 21,
                DATA_ADR_LUA_MINOR = 22,
                DATA_ADR_LUA_PATCH = 23
            }
            string byteToIDstring(List<byte> data, int adr)
            {
                String output = null;

                for (var i = 0; i < IDlength; i++)
                {
                    string number = data[adr + i].ToString("X").ToUpper();
                    if (number.Length == 1)
                    {
                        number = '0' + number;
                    }
                    output += number + ':';
                }
                char[] dest = new char[output.Length - 2];

                output.CopyTo(0, dest, 1, output.Length - 2);
                return dest.ToString();
            }


            string uid = "00:00:00:00:00:00:00:00:00:00:00:00";
            public Version bootloader = new Version(0, 0, 1);
            public Version firmware = new Version(0, 0, 1);
            public Version hardware = new Version(0, 0, 1);
            public Version lua = new Version(0, 0, 1);
            public int length = 12 + 4 * 3;


            public void parsing(List<byte> blob)
            {
                //uid = byteToIDstring(blob, (int)pdmDataAdr.DATA_ADR_UNIQUE);
                bootloader.major = blob[(int)pdmDataAdr.DATA_ADR_BOOTLOADER_MAJOR];
                bootloader.minor = blob[(int)pdmDataAdr.DATA_ADR_BOOTLOADER_MINOR];
                bootloader.patch = blob[(int)pdmDataAdr.DATA_ADR_BOOTLOADER_PATCH];
                firmware.major = blob[(int)pdmDataAdr.DATA_ADR_FIRMWARE_MAJOR];
                firmware.minor = blob[(int)pdmDataAdr.DATA_ADR_FIRMWARE_MINOR];
                firmware.patch = blob[(int)pdmDataAdr.DATA_ADR_FIRMWARE_PATCH];
                hardware.major = blob[(int)pdmDataAdr.DATA_ADR_HARDWARE_MAJOR];
                hardware.minor = blob[(int)pdmDataAdr.DATA_ADR_HARDWARE_MINOR];
                hardware.patch = blob[(int)pdmDataAdr.DATA_ADR_HARDWARE_PATCH];
                lua.major = blob[(int)pdmDataAdr.DATA_ADR_LUA_MAJOR];
                lua.minor = blob[(int)pdmDataAdr.DATA_ADR_LUA_MINOR];
                lua.patch = blob[(int)pdmDataAdr.DATA_ADR_LUA_PATCH];
                return;
            }
        }
        

        public class PDM
        {
            public int DIN_Count;
            public int AIN_Count;
            public int DOUT_Count;
            public  int dinN = 11;
            public  int doutN = 20;
            public  int ainN = 3;
            public  int velN = 2;
            public  int tempN = 1;
            public  int angleN = 2;
            public byte[] lua;
            public SYS SYSTEM;
            public Telemetry telemetry;
            public byte[] sysyBlob;
            public List<byte> telemetryBlob;
            public byte[] erorstringBlob;
            public PDM()
            {
                SYSTEM = new SYS();
                //telemetry = new Telemetry(dinN, doutN, ainN, velN, tempN, angleN);
                telemetryBlob = new List<byte>();
                lua = null;
                DIN_Count = 20;
                AIN_Count = 20;
                DOUT_Count = 20;
            }
            public void vReinit()
            {
                switch (SYSTEM.hardware.major) 
                {
                    case (int)Devices.PDM:
                        dinN = 11;
                        doutN = 20;
                        ainN = 3;
                        velN = 2;
                        tempN = 1;
                        angleN = 2;
                        telemetry = new Telemetry(dinN, doutN, ainN, velN, tempN, angleN);
                        break;
                    case (int)Devices.PCM:
                        dinN =  20;
                        doutN = 20;
                        ainN =  11;
                        velN = 2;
                        tempN = 1;
                        angleN = 2;
                        telemetry = new Telemetry(dinN, doutN, ainN, velN, tempN, angleN);
                        break;
                }
            }
        }
        public class LuaTelemetry
        {
            private const int errorStringLength = 100;
            private const int blobSize = 6;
            public uint time = 0;  /* The current time periode for the one LUA running */
            public int state = 0;  /* Current satate of the LUA machine */
            public int counter = 0;  /* Counter of the errors */
            public String error = ""; /* Rintime error string */
            public int getBlobLength() => blobSize;
            public int getErrorStringLength() => errorStringLength;

            public int parsing(byte[] blob, int adr)
            {
                time = bytesToUint32(blob, adr);
                state = blob[adr + 4];
                counter = blob[adr + 5];
                return blobSize;
            }
  
            public void errorParsing (List<byte> blob1) 
            { 
                error = Encoding.UTF8.GetString(blob1.ToArray());        
                return;
            }    
        }
        public class DoutTelemetry
        {
            public float current = 0;
            public float max = 0;
            public byte state = 0;
            public byte error = 0;
            public int parsing (byte[] blob, int adr) 
            {
                current = byteToFloat(blob, adr);
                max = byteToFloat(blob, (adr + 4));
                state = blob[adr + 8];
                error = blob[adr + 9];
                return 10;
            }
        } 
        public class  Telemetry
        {
            string[] angleNames = { "roll", "pitch", "yaw" };
            public int length;
            public float battery;
            public float[] voltage;
            public byte[] din;
            public DoutTelemetry[] dout ;
            public byte[][] velocity;
            public float[] temperature;
            public float[] angle;
            public LuaTelemetry lua;
           
            public Telemetry (int dinN, int doutN, int ainN,int velN, int tempN, int angleN)
            {
                angle = new float[angleN];
                for (var i =0; i < angleN; i++)
                {
                    angle[i] = 0;
                }
                temperature = new float[tempN];
                for (var i = 0; i < tempN; i++)
                {
                    temperature[i] = 0;
                }
                velocity = new byte[velN][];
                for (var i = 0; i < velN; i++)
                {
                    velocity[i] = new byte[] { 0, 0 };
                }
                voltage = new float[ainN];
                for (var i = 0; i < ainN; i++)
                {
                    voltage[i] = 0;
                }
                din = new byte[dinN];
                for (var i = 0; i < dinN; i++)
                {
                    din[0] = 0;
                }
                dout = new DoutTelemetry[doutN];
                for (var i=0; i< doutN; i++)
                {
                    dout[i] = new DoutTelemetry();
                }
                lua = new LuaTelemetry();
                length = (ainN + 1) * 4 + dinN + (doutN * 10) + lua.getBlobLength() + (velN * 2) + (tempN * 4) + (angleN * 4);
            }
            public void parsing (List<byte> blob1)
             {
                byte[] blob =  new byte[blob1.Count];
                blob1.CopyTo(blob);
                battery =  byteToFloat(blob, 0);
                var counter = 4;
                for (var i = 0; i <  voltage.Length; i++)
                {
                    voltage[i] = byteToFloat(blob, counter);
                    counter += 4;
                }
                for (var i = 0; i < din.Length; i++)
                {
                    din[i] = blob[counter];
                    counter += 1;
                }
                for (var i = 0; i < dout.Length; i++)
                {
                    counter += dout[i].parsing(blob, counter);
                }
                counter += lua.parsing(blob, counter);
                for (var i = 0; i < velocity.Length; i++)
                {
                    velocity[i][0] = blob[counter];
                    counter++;
                    velocity[i][1] = blob[counter];
                    counter++;
                }
                for (var i = 0; i < temperature.Length; i++)
                {
                    temperature[i] = byteToFloat(blob, counter);
                    counter += 4;
                }
                for (var i = 0; i < angle.Length; i++)
                {
                    angle[i] = byteToFloat(blob, counter);
                    counter += 4;
                }
                return;
            }
        }

    }

}
