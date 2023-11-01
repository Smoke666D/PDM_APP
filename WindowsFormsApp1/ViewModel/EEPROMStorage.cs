using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using WindowsFormsApp1;
using static WindowsFormsApp1.DataStorageViewModel;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{





    public class DataStorageViewModel : INotifyPropertyChanged
    {

        string[] sLuaTypeNmes = { "Не определено", "Дата и время", "LUA_INT", "LUA_FLOAT", "LUA_BOOL" };
        public EEPROMStorage Estorage;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public DataStorageViewModel()
        {
            Estorage = new EEPROMStorage();
            Estorage.PropertyChanged += model_PropertyChanged;
        }

        private void model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "iEEPROMSize")
            {
                sEEPROMSize = "";
            }
        }
        public string sEEPROMSize
        {
            get { return Estorage.iEEPROMSize.ToString(); }
            set { OnPropertyChanged(); }
        }

    }  

    public class EEPROMStorage : INotifyPropertyChanged
    {
        public enum EEPROM_DATA_TYPE:byte
        {
            LUA_IDLE  = 0x00,
            DATA_TIME = 0x80,
            LUA_INT   = 0x40,
            LUA_FLOAT = 0x20,
            LUA_BOOL  = 0x10,
        };
        private const int Register_Size = 5;
        private const int ValidCodeAddr = 0;
        private const int AccessTokenAddr = ( ValidCodeAddr + 1 ); //3
        private const int RegisterCountAddr = ( AccessTokenAddr + 2 );//5
        private const int RecordCountAddr = ( RegisterCountAddr + 2 );//7
        private const int RecordPointerAddr = ( RecordCountAddr + 2 );//9
        private const int RecordLenAddr = (RecordPointerAddr + 2);//11
        private const int RecordFormatAddr = ( RecordLenAddr + 1 );//12
        private const int RegisterOffset = (RecordFormatAddr + 4);//16
        public const ushort MAX_RECORD_SIZE = 32;
        private byte[] record_type;
        public int DataStorageSize;
        public byte[] DataStorage;
        private byte[] record_type_data;
        public ushort RegisetCount;
        public ushort RecordOffser;
        public int AccesToken;
        public ushort record_count;
        public ushort current_reccord_count;
        public ushort record_poiter;
        public ushort record_size;
        public ushort record_data_size;
        public ushort current_record_pointer;
        private int pEEPROMSize;
        public event PropertyChangedEventHandler PropertyChanged;

        public List<EEPROMRecordFormat> eEPROMRecordFormats = new List<EEPROMRecordFormat>();

        public void UpdateEEPROMFieldFormat()
        {
            eEPROMRecordFormats.Clear();
            int rec = 0;
            byte[] buf; //= new (GetRecordData());
            buf = GetRecordData();
            if (buf != null)
            {
                if (buf[0] == 0x00) rec = 1;
                for (int i = rec; i < record_data_size; i++)
                {
                    eEPROMRecordFormats.Add(new EEPROMRecordFormat(i, buf[i]));
                }
            }
            
        }
        
        public List<EEPROMRecordFormat> getEEPROMFieldFormat()
        {
            eEPROMRecordFormats.Clear();
            int rec = 0;
            byte[] buf; //= new (GetRecordData());
            buf = GetRecordData();
            if (buf != null)
            {
                if (buf[0] == 0x00) rec = 1;
                for (int i = rec; i < record_data_size; i++)
                {
                    eEPROMRecordFormats.Add(new EEPROMRecordFormat(i, buf[i]));
                }
            }
            return eEPROMRecordFormats;
        }
       public List <EEPROMRecord> GetEPROMRecords1()
        {
            List<EEPROMRecord> buffer_list = new List <EEPROMRecord>();
            for (int i = 0; i < current_reccord_count; i++)
            {
                buffer_list.Add(new EEPROMRecord(i+1,getRecordData(i)));
            }
            return buffer_list;
        }

        public List <EEPROMRegister> GetEEPROMRegister()
        {
            
            List<EEPROMRegister> buffer_list = new List <EEPROMRegister>();
            for (int i = 0;i< RegisetCount;i=i+5)
            {
                buffer_list.Add(new EEPROMRegister(i,getRegisterData(i)));
            }
            return buffer_list;
        }
        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public EEPROMStorage()
        {
            DataStorageSize = 2048;
            DataStorage = new byte[DataStorageSize];
            for ( int i = 0; i < DataStorageSize; i++ ) 
            {
                DataStorage[i] = 0;
            }
            record_type_data = new byte[4];
            AccesToken = 0x00;
            RegisetCount = 0;
            record_count = 0;
            record_size = 0;
            record_data_size = 0;
            current_reccord_count = 0;
            current_record_pointer = 0;
            pEEPROMSize = 0;
        }
      
        public int iEEPROMSize { 
            get { return pEEPROMSize; } 
            set { if (pEEPROMSize != value)
                     {
                        pEEPROMSize = value;
                        OnPropertyChanged("iEEPROMSize");
                }
                } 
        }

        public void ResetALL()
        {
            for (int i = 0; i < DataStorageSize; i++)
            {
                DataStorage[i] = 0;
            }
        }
        public void setRegisterBool(ushort addr, bool data )
        {
            int reg_index = (addr ) * 5 + RegisterOffset;
            DataStorage[reg_index] = (byte)EEPROM_DATA_TYPE.LUA_BOOL;
            DataStorage[reg_index + 4] = 0;
            DataStorage[reg_index + 3] = 0;
            DataStorage[reg_index + 2] = 0;
            DataStorage[reg_index + 1] = (data == true) ? (byte)1 : (byte)0;
        }
        public void setRegisterInt(ushort addr, int data)
        {
            int reg_index = addr * 5 + RegisterOffset;
            DataStorage[reg_index] = (byte)EEPROM_DATA_TYPE.LUA_INT;
            DataStorage[reg_index + 4] = (byte) ((data >> 24) & 0xFF) ;
            DataStorage[reg_index + 3] = (byte)((data >> 16) & 0xFF);
            DataStorage[reg_index + 2] = (byte)((data >> 8) & 0xFF);
            DataStorage[reg_index + 1] = (byte)(data & 0xFF);
        }
       
        public void setRegisterFloat(ushort addr, float data)
        {
            int reg_index = ( addr  )*5 + RegisterOffset;
            byte[] buffer = BitConverter.GetBytes(data);
            DataStorage[reg_index] = (byte)EEPROM_DATA_TYPE.LUA_FLOAT;
            DataStorage[reg_index + 1] = buffer[0];
            DataStorage[reg_index + 2] = buffer[1];
            DataStorage[reg_index + 3] = buffer[2]; 
            DataStorage[reg_index + 4] = buffer[3];
        }
        public void setRegisterDate(ushort addr, in DateTime data)
        {
            int reg_index = (addr) * 5 + RegisterOffset;
            uint date_time;
            date_time = (uint)(data.Second & 0x3F); // 6 бит, 0-5
            date_time |= (uint)(data.Minute & 0x3F) << 6; //6 бит 6-11
            date_time |= (uint)(data.Hour & 0x1F) << 12; //5 бит 12 -17
            date_time |= (uint)((data.Year-2000) & 0x7F) << 17; //7 бит 18 -25
            date_time |= (uint)(data.Month & 0xF) << 24; //4 бит 26 -29
            date_time |= (uint)(data.Day & 0x0F) << 28; // 5 бит 30-35
            DataStorage[reg_index] = (byte)((byte)EEPROM_DATA_TYPE.DATA_TIME | ((data.Day & 0x10) >> 4));
            DataStorage[reg_index + 1] = (byte)((date_time >> 24) & 0xFF);
            DataStorage[reg_index + 2] = (byte)((date_time >> 16) & 0xFF);
            DataStorage[reg_index + 3] = (byte)((date_time >> 8) & 0xFF);
            DataStorage[reg_index + 4] = (byte)(date_time & 0xFF);
        }

        private PDM_DateTime getTimeDateFromStorage(int reg_index)
        {
            PDM_DateTime date_time;
            uint temp_data = (uint)DataStorage[reg_index + 1] << 24 |
                             (uint)DataStorage[reg_index + 2] << 16 |
                             (uint)DataStorage[reg_index + 3] << 8 |
                             (uint)DataStorage[reg_index + 4];

            date_time.Second = (byte)(temp_data & 0x3F);
            date_time.Minute = (byte)((temp_data >> 6) & 0x3F);
            date_time.Hour = (byte)((temp_data >> 12) & 0x1F);
            date_time.Year = (byte)((temp_data >> 17) & 0x7F);
            date_time.Month = (byte)((temp_data >> 24) & 0xF);
            date_time.Day = (byte)( ( (temp_data >> 28) & 0x0F) | ((DataStorage[reg_index] & 0x01) << 4) );
            return date_time;
        }
        private string sgetTimeDateFromStorage( int reg_index)
        {
            PDM_DateTime date_time = new PDM_DateTime();
            date_time = getTimeDateFromStorage(reg_index);
            return  (date_time.Hour.ToString("00") + ":" +
            date_time.Minute.ToString("00") + ":" +
            date_time.Second.ToString("00") + "  " +
            date_time.Day.ToString("00") + "." +
            date_time.Month.ToString("00") + ".20" +
            date_time.Year.ToString("00"));
        }
    
        /*
         * Метод для получения данный типа LUA из хранилища в строковомв
         */
        private string sGetLUADataFormSotrage( int addr)
       {
            string temp = "";

            switch ((EEPROM_DATA_TYPE)(DataStorage[addr] & 0xF0))
            {
                case EEPROM_DATA_TYPE.DATA_TIME:
                    temp = sgetTimeDateFromStorage(addr);
                    break;
                case EEPROM_DATA_TYPE.LUA_INT:
                    int itemp = (DataStorage[addr + 4] << 24) | (DataStorage[addr + 3] << 16)
                              | (DataStorage[addr + 2] << 8) | DataStorage[addr + 1];
                    temp = Convert.ToString(itemp);
                    break;
                case EEPROM_DATA_TYPE.LUA_FLOAT:
                    float ftemp = BitConverter.ToSingle(DataStorage, addr + 1);
                    temp = ftemp.ToString();
                    break;
                case EEPROM_DATA_TYPE.LUA_BOOL:
                    temp = (((DataStorage[addr + 4] == 1))) ? "true" : "false";
                    break;
                default:
                    temp = "0";
                    break;
            }
            return temp;
        }
        public  string sgetRegisterData( int addr)
        {
            return sGetLUADataFormSotrage(addr * 5 + RegisterOffset);
        }
        public bool TokenChange(ushort new_token)
        {
            AccesToken = new_token;
            vSetShort(new_token, AccessTokenAddr);
            return true;
        }
        public bool SetRecordSize(byte[] data)
        {
            
            if (data.Length <= MAX_RECORD_SIZE)
            {
                record_type = new byte[data.Length];
                Array.Copy(data,record_type, data.Length);
                ushort rec_size = 0;
                int buf_record_type = 0;
                for (int i = data.Length-1; i >= 0; i--)
                {
                    buf_record_type = buf_record_type << 2;
                    switch (data[i])
                    {
                        case 0x00:
                        case 0x03:
                            rec_size = (ushort)(rec_size + 5);
                            break;
                        case 0x01:
                            rec_size++;
                            break;
                        case 0x02:
                            rec_size = (ushort)(rec_size + 2);
                            break;
                    }
                    buf_record_type = buf_record_type | (data[i] & 0x03);
                    

                }
                record_data_size = (ushort)data.Length;
                record_type_data[3] = (byte)((buf_record_type >> 24) & 0xFF);
                record_type_data[2] = (byte)((buf_record_type >> 16) & 0xFF);
                record_type_data[1] = (byte)((buf_record_type >> 8) & 0xFF);
                record_type_data[0] = (byte)((buf_record_type ) & 0xFF);
                record_size = rec_size;
                return true;
            }
            return false;
        }

        
        public byte[] GetRecordData() 
        {
            int rec_size = 0;
            
            if (record_size != 0)
            {
                int buf_record_type = record_type_data[3] << 24 | record_type_data[2] << 16
                    | record_type_data[1] << 8 | record_type_data[0];
                if ((buf_record_type & 0x03) == 0x00)
                {
                    rec_size++;
                    buf_record_type >>= 2;
                }
                for (int i = 0; i < 16; i++)
                {
                    if ((buf_record_type & 0x03) == 0x00)
                        break;
                    else
                    {
                        rec_size++;
                        buf_record_type >>= 2;
                    }
                }
                byte[] data = new byte[rec_size];
                buf_record_type = record_type_data[3] << 24 | record_type_data[2] << 16
                    | record_type_data[1] << 8 | record_type_data[0];
                for (int i = 0;i<rec_size;i++)
                {
                    data[i] = (byte)(buf_record_type & 0x03);
                    buf_record_type >>= 2;
                }
                record_data_size = (ushort)rec_size;
                return data;
             }
            return null;
        }
      
        public EEPROM_DATA_TYPE getRegisterType(int addr)
        {
            int reg_index = addr*5 + RegisterOffset;
            return (EEPROM_DATA_TYPE)(DataStorage[reg_index] & 0xF0);
        }
        public byte[] bGetEEPROMData()
        {
            byte[] data = new byte[DataStorage.Length-1];
            vSetShort( RegisetCount, RegisterCountAddr);
            vSetShort( 0, RecordCountAddr);
            vSetShort( 0, RecordPointerAddr);
            DataStorage[RecordLenAddr] = (byte)record_size;
            Array.Copy(record_type_data,0, DataStorage, RecordFormatAddr,  4);
            Array.Copy( DataStorage, data, data.Length);
           // iGvoidetMaxRecordCount();
            return data;
        }
        public void vSetEEPROMData(byte[] data)
        {
            Array.Copy( data, DataStorage, data.Length);
            RegisetCount =GetShortFromStorage(RegisterCountAddr);
            uGetShort( RecordCountAddr, out current_reccord_count);
            uGetShort(RecordPointerAddr, out record_poiter);
            record_size = DataStorage[RecordLenAddr];
            Array.Copy(DataStorage, RecordFormatAddr, record_type_data,0, 4);
            iGvoidetMaxRecordCount();

        }
        private bool vSetShort(ushort data, int addres)
        {
            if (addres < (DataStorageSize - 2))
            {
                DataStorage[addres] = (byte)((data >> 8) & 0xFF);
                DataStorage[addres + 1] = (byte)(data & 0xFF);
                return true;
            }
            return false;
        }
        private bool uGetShort(int addres, out ushort data)
        {
            ushort res_data;
            if (addres < (DataStorageSize - 2))
            {
                res_data = (ushort)((DataStorage[addres]<<8) | DataStorage[addres+1]);
                data = res_data;
                return true;
            }
            data = 0;
            return false;
            
        }
        public ushort GetShortFromStorage( int addres)
        {
            return (addres < (DataStorageSize - 2)) ? (ushort)((DataStorage[addres] << 8) | DataStorage[addres + 1]) : (ushort)0;
        }
        public void  iGvoidetMaxRecordCount()
        {
            int data_for_reg = RegisetCount * Register_Size;
            RecordOffser = (ushort)(data_for_reg + RegisterOffset);
            if (record_size != 0)
            {
                record_count = (ushort)((DataStorageSize - RecordOffser) / record_size);
                current_record_pointer = (ushort)((int)record_poiter * (int)DataStorage[RecordLenAddr] + (int)RecordLenAddr);
            }
            else
            {
                current_record_pointer = 0;
                record_count = 0;
            }
        }
        public bool InitStorage(ushort register_count)
        {
            Boolean res = false;
            int data_for_reg = register_count * Register_Size;
            if ((data_for_reg + RegisterOffset) <= DataStorageSize)
            {
                RegisetCount = register_count;
                vSetShort(RegisetCount, RegisterCountAddr);
                iGvoidetMaxRecordCount();
                
                res = true;
            }
            return res;

        }


       

   
              
         public string[,] getRegisterData(int first_index)
        {
            string[,] data = new string[5,2];
            for (int i = 0;i<5;i++)
            {
           
                if (first_index+i < RegisetCount)
                {
                    data[i, 0] = sgetRegisterData(first_index + i);
                    switch (getRegisterType(first_index + i))
                    {
                             case EEPROM_DATA_TYPE.LUA_IDLE:
                                         data[i, 1] = "Не определено";
                                          break;
                            case EEPROM_DATA_TYPE.DATA_TIME:
                                        data[i, 1] = "Дата и время";
                                        break;
                            case EEPROM_DATA_TYPE.LUA_INT:
                            data[i, 1] = "LUA_INT";
                            break;
                            case EEPROM_DATA_TYPE.LUA_FLOAT:
                            data[i, 1] = "LUA_FLOAT";
                            break;
                        case EEPROM_DATA_TYPE.LUA_BOOL:
                            data[i, 1] = "LUA_BOOL";
                            break;

                        }
       
                }
                else
                {
                    data[i, 0] = "0";
                    data[i, 1] = "Не определено";
                }
               
            }
            return data;
        }
        public string[] getRecordData(int record_index)
        {
            List <string> data = new List<string>();
            int data_offset = 0;
            int offs;
            if ( record_index < current_reccord_count)
            {
                
                if (( record_poiter -record_index) <= 0)
                {
                     offs = RecordOffser + (record_count + (record_poiter - (record_index+1)))  * DataStorage[RecordLenAddr];
                }
                    else
                    {
                        offs = RecordOffser + (record_poiter - (record_index + 1)) * DataStorage[RecordLenAddr];
                    }
                
                byte[] temp = GetRecordData();
                
                for (int i = 0; i < temp.Length; i++) 
                {
                    switch(temp[i]) 
                    {
                        case 0:
                            data.Add ( sgetTimeDateFromStorage(offs+ data_offset));
                            data_offset += 5;
                            break;
                        case 1:
                            data.Add(DataStorage[offs + data_offset].ToString());
                            data_offset += 1;
                            break;
                        case 2:
                            ushort temp_short;
                            uGetShort(offs + data_offset, out temp_short);
                            data.Add( temp_short.ToString());
                            data_offset += 2;
                            break;
                        case 3:
                            data.Add (sGetLUADataFormSotrage(offs + data_offset));
                            data_offset += 5;
                            break;
                        default:
                            break;
                    
                    }
                }

            }
            return data.ToArray();
        }
    }
   
}
