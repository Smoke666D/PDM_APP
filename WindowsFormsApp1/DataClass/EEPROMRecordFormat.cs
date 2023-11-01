using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class EEPROMRecordFormat
    {
        private int index;
        public string FieldNumber 
        { get { return index.ToString(); } set{ } }
        public string FieldType { get; set; }
        public  EEPROMRecordFormat()
        {
            index  = 0;
            FieldType = "";
        }

        public EEPROMRecordFormat(int index, byte type)
        {
            this.index = index;
            switch (type)
            {
                case 1:
                    FieldType = "BYTE";
                    break;
                case 3:

                    FieldType = "LUA_TYPE";
                    break;
                case 2:

                    FieldType = "SHORT";
                    break;
            }      
        }
    }
}
