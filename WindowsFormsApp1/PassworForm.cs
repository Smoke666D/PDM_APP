using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PassworForm : Form
    {
        public PassworForm()
        {
            InitializeComponent();
        }
        public bool Access;
        public Form1 parent_form;
        public ushort size;
        

        private void btnAcces_Click(object sender, EventArgs e)
        {
            Form1 F = (Form1)this.Owner;
            if (F != null ) 
            {
                int token;
                int.TryParse(txtPas.Text, out token);
                F.bGetDeviceAcces((ushort)token, out size);
                if (F.TokenValid)
                {
                    //F.TokenValid = true;
                    Close();
                }
                else
                {
                    pasInformLebel.Text = "Неврый код доступа!";
                }
            }
            
        }

        private void PassworForm_Shown(object sender, EventArgs e)
        {
            txtPas.Text = "";
            Form1 F = (Form1)this.Owner;
            if (F != null)
            {
                if (F.TokenValid)
                {
                    pasInformLebel.Text = "Изменить код доступа";
                }
                else
                {
                    pasInformLebel.Text = "Ввести код доступа";
                }
            }
        }
    }
}
