using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        void vSetAsisForm(int GraphIndex)
        {
            uint[,] graphs = { {(uint)Graph.G11, (uint)Graph.G12 },
                               { (uint)Graph.G21, (uint)Graph.G22},
                               { (uint)Graph.G31, (uint)Graph.G32 },
                               { (uint)Graph.G41, (uint)Graph.G42 },
                               { (uint)Graph.G51, (uint)Graph.G52 },
                               { (uint)Graph.G61, (uint)Graph.G62 },
                               { (uint)Graph.G71, (uint)Graph.G72 },
                               { (uint)Graph.G81, (uint)Graph.G82 }
            };
            if (ChartControlBox[GraphIndex, 0].SelectedIndex != -1)
            {
                vFindData(ChartControlBox[GraphIndex, 0].SelectedItem.ToString(), graphs[GraphIndex, 0]);
            }
            if (ChartControlBox[GraphIndex, 1].SelectedIndex != -1)
            {
                vFindData(ChartControlBox[GraphIndex, 1].SelectedItem.ToString(), graphs[GraphIndex, 1]);
            }
        }
        private void vLoadOffLineDataForm(int GraphIndex)
        {
            if (ChartControlBox[GraphIndex, 0].SelectedIndex != -1)
            {
                for (int i = 0; i < LogData.OffLineData.channel_data.Count; i++)
                {
                    Charts[GraphIndex].ClearSerries(0);
                    if (LogData.OffLineData.channel_data[i].Name == ChartControlBox[GraphIndex, 0].SelectedItem.ToString())
                    {
                        for (int j = 0; j < LogData.OffLineData.channel_data[i].Values.Count; j++)
                        {
                            Charts[GraphIndex].AddNewPoint(LogData.OffLineData.channel_data[i].Values[j],
                                (int)LogData.OffLineData.channel_data[0].Values[j], 0);
                        }
                        break;
                    }
                }
            }
            if (ChartControlBox[GraphIndex, 1].SelectedIndex != -1)
            {
                for (int i = 0; i < LogData.OffLineData.channel_data.Count; i++)
                {
                    Charts[GraphIndex].ClearSerries(1);
                    if (LogData.OffLineData.channel_data[i].Name == ChartControlBox[GraphIndex, 1].SelectedItem.ToString())
                    {
                        for (int j = 0; j < LogData.OffLineData.channel_data[i].Values.Count; j++)
                        {
                            Charts[GraphIndex].AddNewPoint(LogData.OffLineData.channel_data[i].Values[j],
                                (int)LogData.OffLineData.channel_data[0].Values[j], 1);
                        }
                        break;
                    }
                }
            }
        }
        private void vDisableChannelSelect( )
        {
            for (int i = 0; i < 7; i++)
            {
                ChartControlBox[i, 0].Enabled = false;
                ChartControlBox[i, 1].Enabled = false;
            }
        }
        private void vEnableChannelSelect( ) 
        {
            for (int i = 0; i < 7; i++)
            {
                ChartControlBox[i, 0].Enabled = true;
                ChartControlBox[i, 1].Enabled = true;
            }
        }
        private void vOpenGraphWindow(int GraphIndex)
        {
            if (bIsSetData(GraphIndex) == true)
            {
                vSetAsisForm(GraphIndex);
                if (TelStatus == TelemetryStatus.OffLineTelemetry)
                {
                    vLoadOffLineDataForm(GraphIndex);
                }
                Charts[GraphIndex].Show();
            }
        }
        /*Метод проверяет что для графика выбран хотя бы один канал
         * и что для одного графика не выбраны одинаковые каналы
         */
        bool bIsSetData(int GraphIndex)
        {
            bool res = false;
            if ((ChartControlBox[GraphIndex, 0].SelectedIndex != -1) ||
                    (ChartControlBox[GraphIndex, 1].SelectedIndex != -1))
            {
                res = true;
            }
            else
            {
                MessageBox.Show("Ошибка: Для графика не выбраны каналы отображения!");
            }
            return (res);
        }
        /*Метод проверяет, что бы в один график не выводились одни и те же каналы
         */
        void vCheckChannelNames(int GraphIndex, int BoxIndex, object sender)
        {
            int iBoxIndex = (BoxIndex == 0) ? 1 : 0;
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            if (ChartControlBox[GraphIndex, iBoxIndex].SelectedIndex != -1)
            {
                if (comboBox.SelectedItem ==
                    ChartControlBox[GraphIndex, iBoxIndex].SelectedItem)
                {
                    comboBox.SelectedIndex = -1;
                    MessageBox.Show("Ошибка: на одном графике не возможно дважды отобразить один и тот же канал!");
                }
            }
        }
    }
}
