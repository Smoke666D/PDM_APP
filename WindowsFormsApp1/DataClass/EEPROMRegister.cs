using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EEPROMRegister
    {
        private int regiser_first_number;
        private string[] Type;
        private string[] Data;
        public string N1 { get { return regiser_first_number.ToString(); } set { } }
        public string N2 { get { return (regiser_first_number +1).ToString(); } set { } }
        public string N3 { get { return (regiser_first_number + 2).ToString(); } set { } }
        public string N4 { get { return (regiser_first_number + 3).ToString(); } set { } }
        public string N5 { get { return (regiser_first_number + 4).ToString(); } set { } }
        public string D1 { get { return Data[0]; }set { } }
        public string D2 { get { return Data[1]; } set { } }
        public string D3 { get { return Data[2]; } set { } }
        public string D4 { get { return Data[3]; } set { } }
        public string D5 { get { return Data[4]; } set { } }
        public string T1 { get { return Type[0]; } set { } }
        public string T2 { get { return Type[1]; } set { } }
        public string T3 { get { return Type[2]; } set { } }
        public string T4 { get { return Type[3]; } set { } }
        public string T5 { get { return Type[4]; } set { } }
        public EEPROMRegister(int index, string[,] reg)
        {
            regiser_first_number = index;
            Data = new string[5];
            Type = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (i<= reg.Length / 2)
                {
                    Data[i] = reg[i,0];
                    Type[i] = reg[i,1];
                }
                else
                {
                    Data[i] = "";
                    Type[i] = "Не определено";
                }
            
            }
          
        }
    }
}
