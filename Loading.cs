using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Alarm_Clock_App
{
    public partial class Loading : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private int loadLimit = 30;
        private int loadTimeSpent = 0;
        public Loading()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {

            loadTimeSpent++;

            if (loadTimeSpent == loadLimit)
            {
                loadingTimer.Enabled = false;

                this.Hide();
                Main form2 = new Main();
                form2.ShowDialog();
            }
        }
    }
}
