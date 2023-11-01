using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.USB_Exchange;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void vGetPDMTime()
        {
            YTxtb.Text = "20" + PDM.PDM_Time.Year.ToString("D2");
            MonTxtb.Text = PDM.PDM_Time.Month.ToString();
            DTxtb.Text = PDM.PDM_Time.Day.ToString();
            HTxtb.Text = PDM.PDM_Time.Hour.ToString();
            MTxtb.Text = PDM.PDM_Time.Minute.ToString();
            STxtb.Text = PDM.PDM_Time.Second.ToString();
        }
        private void ProgressEEPROM(uint data)
        {
            if (progressBar1.InvokeRequired)
            {
                var d = new SafeCallDelegate1(ProgressEEPROM);
                progressBar2.Invoke(d, new object[] { data });
            }
            else
            {
                if ((int)data <= 100)

                    progressBar2.Value = (int)data;
            }
        }

        string[] sLuaTypeNmes = { "Не определено", "Дата и время", "LUA_INT", "LUA_FLOAT", "LUA_BOOL" };
        public void vRegisterDataInit()
        {
    
            byte[] data = VMstorage.Estorage.GetRecordData();
            if (data != null)
            {
                tbMaxRecord.Text = VMstorage.Estorage.record_count.ToString();
                txRecordCount.Text = VMstorage.Estorage.current_reccord_count.ToString();

                RecordFormatView.Rows.Clear();
                if (data[0] == 0x00)
                {
                    timeStampCheck.Checked = true;
                }
                else
                {
                    timeStampCheck.Checked = false;
                }
                
            }
            RecordForamtSource.Clear();
            VMstorage.Estorage.UpdateEEPROMFieldFormat();
            RecordForamtSource.DataSource = VMstorage.Estorage.eEPROMRecordFormats;
            RecordForamtSource.ResetBindings(false);
            RegisterSource.Clear();
            RegisterSource.DataSource = VMstorage.Estorage.GetEEPROMRegister();
            RegisterSource.ResetBindings(false);   
        }
        public int vSetData(int index)
        {
            int i = RegisterView.CurrentCell.ColumnIndex;
            int j = RegisterView.CurrentCell.RowIndex;
            int addr = (i / 3) + j*5;
            return addr;
        }  
        private void vInitRecordSource()
        {
            RecordSource.Clear();
            for (int i = 0; i < VMstorage.Estorage.record_data_size+1; i++)
            {
                RecordView.Columns[i].Visible = true;
            }
            RecordSource.DataSource = VMstorage.Estorage.GetEPROMRecords1();
            RecordSource.ResetBindings(false);
            for (int i = 0; i < RecordView.ColumnCount; i++)
            {
                RecordView.Columns[i].Visible = (i < VMstorage.Estorage.record_data_size + 1) ? true : false;
            }
            
        }

       
        public bool bGetDeviceAcces(ushort token, out ushort e_size)
        {
            if (vGetDevice() == 1)
            {
                ushort size;
                TokenValid = PDM.SendToken((ushort)token, out size);
                VMstorage.Estorage.iEEPROMSize = size;
                e_size = size;
                return true;
            }
            else
            {
                e_size = 0;
                return false;
            }

        }
    }
   
}
