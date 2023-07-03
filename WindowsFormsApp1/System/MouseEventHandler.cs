using System.Windows.Forms;

namespace System
{
    internal class MouseEventHandler
    {
        private Action<object, MouseEventArgs> chart1_MouseUp;

        public MouseEventHandler(Action<object, MouseEventArgs> chart1_MouseUp)
        {
            this.chart1_MouseUp = chart1_MouseUp;
        }
    }
}