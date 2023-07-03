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
    enum Devices
    {
        PDM = 3,
        PCM = 2
    }
    public partial class SystemInfo : Form
    {
        int devivetype = 0;
        
        public SystemInfo()
        {
            InitializeComponent();
        }
        public void SetLuaVersion(Controller.Version version)
        {
            if (version != null)
            {
                LuaVersion.Text = version.major.ToString() + "." +
                    version.minor.ToString() + "." +
                    version.patch.ToString();
            }
        }
        public void SetSoftwareVersion(Controller.Version version)
        {
            if (version != null)
            {
                SoftwareVersion.Text = version.major.ToString() + "." +
                    version.minor.ToString() + "." +
                    version.patch.ToString();
            }
        }
        public void SetHardvareVersion(Controller.Version version)
        {
            if (version != null)
            {
                device_status.Text = "Обнаружено устройство";
                devivetype = version.major;
                switch (version.major)
                {
                    case (int)Devices.PDM:
                        DeviceVersion.Text = "PDM";
                        break;
                    case (int)Devices.PCM:
                        DeviceVersion.Text = "PCM";
                        break;
                }
                ControllerRevision.Text = version.minor.ToString();

              
            }
        }
    }
    
}
