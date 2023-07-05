using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> ChannelName = new List<string>();
        List<float> ChannelData = new List<float>();
        private void vDataGrindInit()
        {
            /*Таблица сисетмных парамертов */
            string[] Names = { "Канал", "Значение", "MAX", "МIN", "TRIP" };
            string[] DoutNames = { "Канал",  "Ток", "Уставка", "MAX", "МIN", "TRIP" };
            string[] DinColNames = { "Канал", "Состояние" };
            string[] RowNames = { "Наряжение АКБ", "Температура", "Тангаж", "Крен", "Оборты 1", "Оборты 2" };
            int[] Widths = { 100, 80, 80, 80, 80 };
            int[] DoutWidths = { 70, 80, 50, 50, 80, 80, 80 };
            int[] DinWidths = { 50, 80 };
            int[] AinWidths = { 50, 80, 80, 80, 80 };

            /*Заполнение таблицы дискрентых входов*/
            string Name;
            for (int i = 0; i < DoutNames.Length; i++)
            {
                DiscreteOut.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                DiscreteOut.Columns[i].HeaderText = DoutNames[i];
                DiscreteOut.Columns[i].Width = DoutWidths[i];
                DiscreteOut.Columns[i].ReadOnly = true;
                DiscreteOut.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DiscreteOut.RowHeadersVisible = false;
            for (int i = 0; i < PDM.pdm.DOUT_Count; i++)
            {
                Name = "DOUT" + (i + 1);
                DiscreteOut.Rows.Add(Name);
                LogData.dout[i].ChannelName = Name;
                //ChannelName.Add(Name);
                
            }
            for (int i = 0; i < Names.Length; i++)
            {
                System_Par.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                System_Par.Columns[i].HeaderText = Names[i];
                System_Par.Columns[i].Width = Widths[i];
                System_Par.Columns[i].ReadOnly = true;
                System_Par.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            System_Par.RowHeadersVisible = false;
            for (int i = 0; i < RowNames.Length; i++)
            {
                System_Par.Rows.Add(RowNames[i]);
                LogData.system[i].ChannelName = RowNames[i];
               // ChannelName.Add(RowNames[i]);
            }
            /*Заполение таблицы с данными дискретных входов*/
            for (int i = 0; i < DinColNames.Length; i++)
            {
                DinInput.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                DinInput.Columns[i].HeaderText = DinColNames[i];
                DinInput.Columns[i].Width = DinWidths[i];
                DinInput.Columns[i].ReadOnly = true;
                DinInput.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < PDM.pdm.DIN_Count; i++)
            {
                Name = "DIN" + (i + 1);
                DinInput.Rows.Add(Name);
                LogData.din[i].ChannelName = Name;
                //ChannelName.Add(Name);
            }
            DinInput.RowHeadersVisible = false;
            /*Заполнение таблицы аналоговых входов*/
            for (int i = 0; i < Names.Length; i++)
            {
                AnalogInput.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                AnalogInput.Columns[i].HeaderText = Names[i];
                AnalogInput.Columns[i].Width = AinWidths[i];
                AnalogInput.Columns[i].ReadOnly = true;
                AnalogInput.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < PDM.pdm.AIN_Count; i++)
            {
                Name = "AIN" + (i + 1);
                AnalogInput.Rows.Add(Name, 0, 0);
                LogData.ain[i].ChannelName = Name;
               // ChannelName.Add(Name);
            }
            AnalogInput.RowHeadersVisible = false;
            ChartControlBox = new ComboBox[,]{
                { Chart1_1Select,Chart1_2Select },
                { Chart2_1Select,Chart2_2Select },
                { Chart3_1Select,Chart3_2Select },
                { Chart4_1Select,Chart4_2Select },
                { Chart5_1Select,Chart5_2Select },
                { Chart6_1Select,Chart6_2Select },
                { Chart7_1Select,Chart7_2Select },
                { Chart8_1Select,Chart8_2Select },
            };
        }
        public void vInsertChannelOffLineListNames()
        {
            ChannelName.Clear();
            for (int i = 0; i < LogData.OffLineData.channel_data.Count; i++)
            {
                ChannelName.Add(LogData.OffLineData.channel_data[i].Name);
            }
            
        }
        public void vInsertChannelListNames()
        {
            ChannelName.Clear();
            for (int i = 0; i < PDM.pdm.doutN; i++)
            {
                ChannelName.Add(LogData.dout[i].ChannelName);
            } 
            for (int i = 0; i < 6; i++)
            { 
                ChannelName.Add(LogData.system[i].ChannelName);
            }
            for (int i = 0; i < PDM.pdm.dinN; i++)
            {
                ChannelName.Add(LogData.din[i].ChannelName);
            }
            for (int i = 0; i < PDM.pdm.ainN; i++)
            {
                ChannelName.Add(LogData.ain[i].ChannelName);
            }
        }
        private System.Windows.Forms.ComboBox[,] ChartControlBox;
        private void vChartDataInit()
        {
            if ( (PDM.isConnected() && (TelStatus == TelemetryStatus.OnlineTelemetry)) ||
                   ( TelStatus == TelemetryStatus.OffLineTelemetry) )
            {
                vInsertChannelListNames();
                for (int j = 0; j < 8; j++)
                {

                    for (int k = 0; k < 2; k++)
                    {
                        ChartControlBox[j, k].Items.Clear();
                        for (int i = 0; i < ChannelName.Count; i++)
                        {
                            ChartControlBox[j, k].Items.Add(ChannelName[i]);
                        }
                    }

                }
            }
        }
     
        private void AddDataToCharts()
        {
            
        }
        /* Метод для загшутения работы кнопок управления телеметрией
         */
        private void vTelemertyBtnState(TelemetryState state)
        {
            if (btnTelemetryRun.InvokeRequired)
            {
                var d = new SafeCallDelegate4(vTelemertyBtnState);
                System_Par.Invoke(d, new object[] { state });
            }
            else
            {
                bool RunBtnState = false;
                bool PauseBtnState = false;
                bool RecordBtnState = false;
                bool StopBtnState = false;
                switch (state)
                {
                    case TelemetryState.Pause:
                    case TelemetryState.PauseRecord:
                        RunBtnState  = true;
                        StopBtnState = true;
                        break;
                    case TelemetryState.Stop:
                        RunBtnState = true;
                        break;
                    case TelemetryState.Run:
                        PauseBtnState  = true;
                        StopBtnState   = true;
                        RecordBtnState = true;
                        break;
                    case TelemetryState.Record:
                        PauseBtnState  = true;
                        StopBtnState   = true;
                        break;
                    case TelemetryState.DownLoad:
                        break;
                }
                btnTelemetryRun.Enabled = RunBtnState;
                btnTelemetryRun1.Enabled = RunBtnState;
                LoopTime.Enabled = RunBtnState;
                btnTelemetryRecord.Enabled = RecordBtnState;
                btnTelemetryRecord1.Enabled = RecordBtnState;
                btnTelemetryPause1.Enabled = PauseBtnState;
                btnTelemetryPause.Enabled = PauseBtnState;
                btnTelemetryStop1.Enabled = StopBtnState;
                btnTelemetryStop.Enabled = StopBtnState;
            }
        }
        private TelemetryStatus eGetTelemetryStatus()
        {
            return TelStatus;
        }
        private void vSetTelemetryStatus(TelemetryStatus status)
        {
            TelStatus = status;
            btnOnlineTelemetry.BackColor =
                (status == TelemetryStatus.OnlineTelemetry) ? Color.LightGreen : SystemColors.Control;
            btnOfflineTelemetry.BackColor =
                (status == TelemetryStatus.OnlineTelemetry) ? SystemColors.Control : Color.LightGreen;
        }
        private void vSetTabPageButtn(int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    button1.BackColor = Color.LightGreen;
                    btnLoad.BackColor = SystemColors.Control;
                    button3.BackColor = SystemColors.Control;
                    break;
                case 1:
                    btnLoad.BackColor = Color.LightGreen;
                    button1.BackColor = SystemColors.Control;
                    button3.BackColor = SystemColors.Control;
                    break;
                case 2:
                    button3.BackColor = Color.LightGreen;
                    button1.BackColor = SystemColors.Control;
                    btnLoad.BackColor = SystemColors.Control;
                    break;

            }
        }

    }
}
