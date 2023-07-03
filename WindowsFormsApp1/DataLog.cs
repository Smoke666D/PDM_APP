using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApp1
{ 
    public enum Graph
    {
        G11 = 0x0001,
        G12 = 0x0002,
        G21 = 0x0004,
        G22 = 0x0008,
        G31 = 0x0010,
        G32 = 0x0020,
        G41 = 0x0040,
        G42 = 0x0080,
        G51 = 0x0100,
        G52 = 0x0200,
        G61 = 0x0400,
        G62 = 0x0800,
        G71 = 0x1000,
        G72 = 0x2000,
        G81 = 0x4000,
        G82 = 0x8000
    }
    
    public class data_point
    {
        public float Value;
        public int TimeStamp;
    }

    public class log_unit
    {
        public string Name;
        public List<float> Values;
    }
    public class read_log_data
    {
        public List<log_unit> channel_data;
    }

  
    public class data_unit
    {
        
        public List<data_point> points;
        public float MaxValue;
        public float TripValue;
        public float MinValue;
        public uint GrapData;
        public string ChannelName;
        private int point_counts;
        public bool record = false;
        public data_unit()
        {
            ChannelName = "";
            GrapData = 0;
            points = new List<data_point>();
            Reset();
        }
        public void Reset()
        {
            MaxValue = 0;
            TripValue = 0;
            MinValue = 0;
            point_counts = 0;
        }
      
        public void AddPoint(float Y, int x, bool enable_stat)
        {
            if (record)
            {
                data_point data = new data_point();
                data.Value = Y;
                data.TimeStamp = x;
                points.Add(data);
            }
            if (enable_stat) 
            {
                if (record)
                {
                    if (points.Count > 1)
                    {
                        TripValue = (TripValue * (points.Count - 1) / points.Count) + points[points.Count - 1].Value / points.Count;
                    }
                }
                else
                {
                    point_counts++;
                    TripValue = (TripValue * (point_counts - 1) / point_counts) + Y / point_counts;
                }
                if (MaxValue == 0) MaxValue = Y;
                if (MinValue == 0) MinValue = Y;
                if (Y > MaxValue) MaxValue = Y;
                if (Y < MinValue) MinValue = Y;
            }

        }
    }
    internal class DataLog
    {
        public List<data_unit> din;
        public List<data_unit> dout;
        public List<data_unit> ain;
        public List<data_unit> system;
        public read_log_data OffLineData;
        public int DinCount;
        public int DoutCount;
        public int AinCount;
        public int SystemCount;
        private bool bRecordEnable = false;
        StreamWriter fsa;
        // public void vStartRecord
        public DataLog(int dincount,int doutcount,int aincount,int systemcount)   
        {  
            
            din = new List<data_unit>();
            for (int i = 0;i < dincount;i++) 
            {
                din.Add(new data_unit());
            }
            dout = new List<data_unit>();
            for (int i = 0;i<doutcount;i++) 
            { 
                dout.Add(new data_unit());
            }
            ain = new List<data_unit>();
            for (int i = 0;i<aincount;i++)
            {
                ain.Add(new data_unit());
            }
            system = new List<data_unit>();
            for (int i = 0;i<systemcount;i++)
            { 
                system.Add(new data_unit());
            }
        }
        public async void ReadOfflineData(string file_name)
        {
            using (StreamReader fsa = new StreamReader(file_name))
            {
                string line;
                bool headerisRead = false;
                int ch_count  = 0;
                if (OffLineData == null)
                {
                    OffLineData = new read_log_data();
                    OffLineData.channel_data = new List<log_unit>();
                }
                else
                {
                    OffLineData.channel_data.Clear();
                }
                while ((line = await fsa.ReadLineAsync()) != null)
                {
                    string data = "";
                    ch_count = 0;
                    if (headerisRead == false)
                    {
                        headerisRead = true;
                        for (int i = 0;i < line.Length;i++) 
                        {
                            if (line[i]!=';')
                            {
                                data = data+ line[i];
                            }
                            else
                            {
                                OffLineData.channel_data.Add( new log_unit() );
                                OffLineData.channel_data[ch_count].Name = data;
                                OffLineData.channel_data[ch_count].Values = new List<float>();
                                ch_count++;
                                data = "";
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] != ';')
                            {
                                data = data + line[i];
                            }
                            else
                            { 
                                OffLineData.channel_data[ch_count].Values.Add(Convert.ToSingle(data));
                                ch_count++;
                                data = "";
                            }
                        }
                    }
                }
            }
        }
        public void vAddDataToLog(string buffer)
        {
            if (fsa != null)
            {
                fsa.WriteLine(buffer);
            }
        }
        public string sCreatLogHeader()
        {
            string buffer = "Time;"; 
            for (int i = 0; i < DoutCount; i++)
            {
                buffer += (dout[i].ChannelName) + ';';
            }
            for (int i = 0; i < SystemCount; i++)
            {
                buffer += (system[i].ChannelName) + ';';
            }
            for (int i = 0; i < AinCount; i++)
            {
                buffer += (ain[i].ChannelName) + ';';
            }
            for (int i = 0; i < DinCount; i++)
            {
                buffer += (din[i].ChannelName) + ';';  
            }     
            return ((buffer));
        }
        public void vStopRecord()
        {
            if (fsa!=null)
            fsa.Close();
        }
        public void vStartRecord()
        {
             fsa = new StreamWriter("log.cvs");
             string buffer =  sCreatLogHeader();
             if (fsa !=null)
                  fsa.WriteLine(buffer);
        }
        public void ResetLog()
        {
            /*Сбрасываем состояние дискретных входов*/
            for (int i = 0; i < din.Count;i++)
            {
                din[i].points.Clear();
                din[i].Reset();
            }
            /**/
            for(int i = 0; i<dout.Count;i++)
            {
                dout[i].points.Clear();
                dout[i].Reset();
            }
            /**/
            for (int i = 0; i<ain.Count;i++)
            {
                ain[i].points.Clear();
                ain[i].Reset();
            }
            for (int i =0; i<system.Count;i++)
            {   
                system[i].points.Clear();
                system[i].Reset();
             
            }
            

        }
        
        public void vAddRecord()
        {
            
        }
        public void SaveLog()
        {
        }
        public void LoadLog() { }
    }
}
