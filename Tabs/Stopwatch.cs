using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock_App.Tabs
{
    public partial class Stopwatch : Form
    {
        private double stopwatchTime;
        private bool isrunning = false;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void start()
        {
            stopWatchTimer.Enabled = true;
            isrunning = true;
            btnToggle.Image = Properties.Resources.pauseIcon;
        }

        private void stop()
        {
            stopWatchTimer.Enabled = false;
            isrunning = false;
            btnToggle.Image = Properties.Resources.playIcon;
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchTime = stopwatchTime + 0.1;

            TimeSpan t = TimeSpan.FromSeconds(stopwatchTime);
           
            timerShower.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            lblmilli.Text = string.Format(".{0}", t.Milliseconds.ToString()[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatchTime = 0;
            timerShower.Text = "00:00:00";
            lblmilli.Text = ".0";
            stop();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (isrunning)
            {
                stop();
            }
            else
            {
                start();
            }
        }
    }
}
