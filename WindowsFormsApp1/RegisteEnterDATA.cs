using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{
    public partial class RegisteEnterDATA : Form
    {
        public byte data_type;
        public float floatdata;
        public byte booldata;
        public int intdata;
        public PDM_DateTime timedata;
        public RegisteEnterDATA()
        {
            InitializeComponent();
            cbDataType.Items.Add("Дата и время");
            cbDataType.Items.Add("LUA INT");
            cbDataType.Items.Add("LUA FLOAT");
            cbDataType.Items.Add("LUA BOOL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void RegisteEnterDATA_Load(object sender, EventArgs e)
        {
            cbDataType.SelectedIndex = 0;
            data_type = 0;
            error_label.Hide();
        }

       
      
        private void cbDataType_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string format_string;
            data_type = (byte)cbDataType.SelectedIndex;
            error_label.Hide();
            switch (cbDataType.SelectedIndex)
            {
                case 0:
                    txtDataEnter.Mask = "00/00/0000 00:00:00";
                    txtDataEnter.Text = "10/01/2000 19:44:13";
                    break;
                case 1:
                    txtDataEnter.Mask = "#999999990";
                    txtDataEnter.Text = "+000000000";
                    break;
                case 2:
                    txtDataEnter.Mask = "#99999.0999";
                    txtDataEnter.Text = "+00003.3001";
                    break;
                case 3:
                    txtDataEnter.Mask = "0";
                    txtDataEnter.Text = "0";
                    break;
                default: break;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool ValidData = false;
            data_type = (byte)cbDataType.SelectedIndex;
            Form1 F = (Form1)this.Owner;
            int addr = F.vSetData(data_type);
            switch (data_type)
            {
                case 0:
                    DateTime dt;
                    try
                    {
                        dt = DateTime.Parse(txtDataEnter.Text);//, CultureInfo.CreateSpecificCulture("fr-FR"));
                    }
                    catch
                    {
                        error_label.Show();
                        break;
                    }
                    ValidData = true;
                    F.VMstorage.Estorage.setRegisterDate((ushort)addr,in dt);
                    break;
                case 2:
                    NumberStyles styles = NumberStyles.Number;
                    
                    float floatdata;
                    try
                    {
                        floatdata = Single.Parse(txtDataEnter.Text,styles);//, cultures);
                    }
                    catch {
                        error_label.Show();
                        break;
                    }
                     ValidData = true;
                     F.VMstorage.Estorage.setRegisterFloat((ushort)addr, floatdata);
                    break;
                case 1:
                    ValidData = true;
                    int intdata = (int)Convert.ToInt32(txtDataEnter.Text);
                    F.VMstorage.Estorage.setRegisterInt((ushort)addr, intdata);
                    break;
                case 3:
                    ValidData = true;
                    bool booldata = (bool)Convert.ToBoolean(Convert.ToInt32(txtDataEnter.Text));
                    F.VMstorage.Estorage.setRegisterBool((ushort)addr, booldata);
                    break;

            }
            if (ValidData)
            {
                F.vRegisterDataInit();
                Hide();
            }
        }
    }
}
