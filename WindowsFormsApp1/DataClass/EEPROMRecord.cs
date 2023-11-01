using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EEPROMRecord
    {
        private string[] P;
        private int record_id;
        public string index
        {
            get { return record_id.ToString(); }
            set { }
        }
        public string P1
        {
            get { return (P.Length > 0) ? P[0] : ""; }
            set { }
        }
        public string P2
        {
            get { return (P.Length > 1) ? P[1] : ""; }
            set { }
        }
        public string P3
        {
            get { return (P.Length > 2) ? P[2] : "1"; }
            set { }
        }
        public string P4
        {
            get { return (P.Length > 3) ? P[3] : "1"; }
            set { }
        }
        public string P5
        {
            get { return (P.Length > 4) ? P[4] : ""; }
            set { }
        }
        public string P6
        {
            get { return (P.Length > 5) ? P[5] : ""; }
            set { }
        }
        public string P7
        {
            get { return (P.Length > 6) ? P[6] : ""; }
            set { }
        }
        public string P8
        {
            get { return (P.Length > 7) ? P[7] : ""; }
            set { }
        }
        public string P9
        {
            get { return (P.Length > 8) ? P[8] : ""; }
            set { }
        }
        public string P10
        {
            get { return (P.Length > 9) ? P[9] : ""; }
            set { }
        }
        public string P11
        {
            get { return (P.Length > 10) ? P[10] : ""; }
            set { }
        }
        public string P12
        {
            get { return (P.Length > 11) ? P[11] : ""; }
            set { }
        }
        public string P13
        {
            get { return (P.Length > 12) ? P[12] : ""; }
            set { }
        }
        public string P14
        {
            get { return (P.Length > 13) ? P[13] : ""; }
            set { }
        }
        public string P15
        {
            get { return (P.Length > 14) ? P[14] : ""; }
            set { }
        }
        public string P16
        {
            get { return (P.Length > 15) ? P[15] : ""; }
            set { }
        }
        public string P17
        {
            get { return (P.Length > 16) ? P[16] : ""; }
            set { }
        }
        public string P18
        {
            get { return (P.Length > 17) ? P[17] : ""; }
            set { }
        }
        public string P19
        {
            get { return (P.Length > 18) ? P[18] : ""; }
            set { }
        }
        public string P20
        {
            get { return (P.Length > 19) ? P[19] : ""; }
            set { }
        }
        public string P21
        {
            get { return (P.Length > 20) ? P[20] : ""; }
            set { }
        }
        public string P22
        {
            get { return (P.Length > 21) ? P[21] : ""; }
            set { }
        }
        public string P23
        {
            get { return (P.Length > 22) ? P[22] : ""; }
            set { }
        }
        public string P24
        {
            get { return (P.Length > 23) ? P[23] : ""; }
            set { }
        }
        public string P25
        {
            get { return (P.Length > 24) ? P[24] : ""; }
            set { }
        }
        public string P26
        {
            get { return (P.Length > 25) ? P[25] : ""; }
            set { }
        }
        public string P27
        {
            get { return (P.Length > 26) ? P[26] : ""; }
            set { }
        }
        public string P28
        {
            get { return (P.Length > 27) ? P[27] : ""; }
            set { }
        }
        public string P29
        {
            get { return (P.Length > 28) ? P[28] : ""; }
            set { }
        }
        public string P30
        {
            get { return (P.Length > 29) ? P[29] : ""; }
            set { }
        }
        public string P31
        {
            get { return (P.Length > 30) ? P[30] : ""; }
            set { }
        }
        public string P32
        {
            get { return (P.Length > 31) ? P[31] : "0"; }
            set { }
        }


        public EEPROMRecord(int ind, string[] P2)
        {
            P = new string[P2.Length];
            record_id = ind;
            for (int i = 0; i < P.Length; i++)
            {
                P[i] = P2[i];
            }
        }

    }
}
