using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties.DataSources
{
    public class TelemtryFull
    {
        public string ChannelName { get; set; }
        public string Value { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string Trip { get; set; }
        public TelemtryFull(string name) 
        {
            ChannelName = name;
        }
    }
}
