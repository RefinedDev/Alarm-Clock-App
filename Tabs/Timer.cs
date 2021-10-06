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
    public partial class Timer : Form
    {
        private static FlowLayoutPanel container;
        private static List<ACATimer> allTimers = new List<ACATimer>();
        private bool isDeleting = false;

        public Timer()
        {
            InitializeComponent();

            container = timerContainer;
            loadTimers();
        }
        
        private void clamp(TextBox box, string clampValue)
        {
            if (box.Text == "") { return; }
            try
            {
                int inp = Convert.ToInt32(box.Text);
                if (inp > Convert.ToInt32(clampValue))
                {
                    box.Text = clampValue;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void saveTimer()
        {
            try
            {
                errorThing.SetError(timerFrame, null);

                int hour = Convert.ToInt32(hourBox.Text);
                int sec = Convert.ToInt32(secondBox.Text);
                int min = Convert.ToInt32(minuteBox.Text);

                int totalSeconds = (hour * 3600) + (min * 60) + sec;

                ACATimer d = new ACATimer();

                d.TS = totalSeconds;
                d.OGTime = d.TS;
                d.ID = Guid.NewGuid().ToString("N");
                d.NameOfTimer = nameOfTimer.Text;

                DatabaseConnection.SaveTimerData(d);

                secondsBox.Visible = false;
                container.Visible = true;

                loadTimers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                timerFrame.Focus();
                errorThing.SetError(timerFrame, "make sure the time boxes have numbers.");
            }

        }

        private void loadTimers()
        {
            if (allTimers != null)
            {
                foreach (ACATimer t in allTimers)
                {
                    t.RemoveTimerFrame();
                }
            }

            allTimers = DatabaseConnection.LoadTimerData();
            noTimers.Visible = true;

            if (allTimers.Count != 0)
            {
                noTimers.Visible = false;
                foreach (ACATimer t in allTimers)
                {
                    t.OpenTimerFrame(container);    
                    
                    if (isDeleting)
                    {
                        t.TimerFrame.BackColor = Color.Firebrick;
                        t.TimerFrame.Click += new EventHandler(DeleteTimer);
                    }
                }
            }
            else
            {
                isDeleting = false;
            }
        }

        public static void loadtimersStatically()
        {
            foreach (ACATimer t in allTimers)
            {
                t.RemoveTimerFrame();
            }

            allTimers = DatabaseConnection.LoadTimerData();

            if (allTimers.Count != 0)
            {
                foreach (ACATimer t in allTimers)
                {
                    t.OpenTimerFrame(container);
                }
            }
        }

        public void DeleteTimer(object sender, System.EventArgs e)
        {
            Panel p = (Panel)sender;
            ACATimer at = (ACATimer)p.Tag;

            DatabaseConnection.RemoveTimerData(at);

            loadTimers();
        }

        private void disableDeleting()
        {
            foreach (ACATimer t in allTimers)
            {
                t.TimerFrame.BackColor = Color.FromArgb(44, 47, 51);
                t.TimerFrame.Click -= DeleteTimer;
            }

            isDeleting = false;
        }

        // FORM FUNCTIONS
        private void btnCreate_Click(object sender, EventArgs e)
        {
            secondsBox.Visible = !(secondsBox.Visible);
            container.Visible = !(container.Visible);
        }

        private void btnCloseCreate_Click(object sender, EventArgs e)
        {
            secondsBox.Visible = false;
            container.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clamp(minuteBox, "60");
        }

        private void secondBox_TextChanged(object sender, EventArgs e)
        {
            clamp(secondBox, "60");
        }

        private void hourBox_TextChanged(object sender, EventArgs e)
        {
            clamp(hourBox, "10");
        }

        private void btnSaveTimer_Click(object sender, EventArgs e)
        {
            saveTimer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                disableDeleting();
            }
            else
            {
                foreach (ACATimer t in allTimers)
                {
                    t.TimerFrame.BackColor = Color.Firebrick;
                    t.TimerFrame.Click += new EventHandler(DeleteTimer);
                }
                isDeleting = true;
            }
        }
    }
}
