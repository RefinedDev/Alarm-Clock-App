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
    public partial class Alarm : Form
    {
        private static FlowLayoutPanel container;
        private static List<Classes.ACAAlarm> allAlarms = new List<Classes.ACAAlarm>();
        private bool isDeleting = false;

        public Alarm()
        {
            InitializeComponent();
            container = alarmContainer;
            loadAlarms();
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

        private void saveAlarm()
        {
            try
            {
                errorThing.SetError(alarmFrame, null);

                int hour = Convert.ToInt32(hourBox.Text);
                int min = Convert.ToInt32(minuteBox.Text);

                int totalSeconds = (hour * 3600) + (min * 60);

                Classes.ACAAlarm d = new Classes.ACAAlarm();

                d.TS = totalSeconds;
                d.ID = Guid.NewGuid().ToString("N");
                d.NameOfAlarm = nameOfAlarm.Text;
                d.IsOn = "True";

                DatabaseConnection.SaveAlarmData(d);

                secondsBox.Visible = false;
                container.Visible = true;

                loadAlarms();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                alarmFrame.Focus();
                errorThing.SetError(alarmFrame, "make sure the time boxes have numbers.");
            }
        }

        private void loadAlarms()
        {
            if (allAlarms != null)
            {
                foreach (Classes.ACAAlarm t in allAlarms)
                {
                    t.RemoveAlarmFrame();
                }
            }

            allAlarms = DatabaseConnection.LoadAlarmData();
            noAlarms.Visible = true;

            if (allAlarms.Count != 0)
            {
                noAlarms.Visible = false;
                foreach (Classes.ACAAlarm t in allAlarms)
                {
                    t.OpenAlarmFrame(container);

                    if (isDeleting)
                    {
                        t.AlarmFrame.BackColor = Color.Firebrick;
                        t.AlarmFrame.Click += new EventHandler(DeleteAlarm);
                    }
                }
            }
            else
            {
                isDeleting = false;
            }
        }

        private void disableDeleting()
        {
            foreach (Classes.ACAAlarm t in allAlarms)
            {
                t.AlarmFrame.BackColor = Color.FromArgb(44, 47, 51);
                t.AlarmFrame.Click -= DeleteAlarm;
            }

            isDeleting = false;
        }

        private void DeleteAlarm(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            Classes.ACAAlarm at = (Classes.ACAAlarm)p.Tag;

            DatabaseConnection.RemoveAlarmData(at);

            loadAlarms();
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

        private void minuteBox_TextChanged(object sender, EventArgs e)
        {
            clamp(minuteBox, "59");
        }

        private void hourBox_TextChanged(object sender, EventArgs e)
        {
            clamp(hourBox, "23");
        }

        private void btnSaveTimer_Click(object sender, EventArgs e)
        {
            saveAlarm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                disableDeleting();
            }
            else
            {
                foreach (Classes.ACAAlarm t in allAlarms)
                {
                    t.AlarmFrame.BackColor = Color.Firebrick;
                    t.AlarmFrame.Click += new EventHandler(DeleteAlarm);
                }
                isDeleting = true;
            }
        }

        // HANDLE ALARM
        private void updateAlarm_Tick(object sender, EventArgs e)
        {
            foreach (Classes.ACAAlarm v in allAlarms)
            {
                v.InWhatTime.Text = v.GetWhen;

                TimeSpan t = DateTime.Now.TimeOfDay - TimeSpan.FromSeconds(v.TS);

                if (t.Hours == 0 & t.Minutes == 0 & t.Seconds == 0 & bool.Parse(v.IsOn))
                {
                    Main.MakeNotification("Alarm done.", v.NameOfAlarm);

                    SettingsClass s = DatabaseConnection.LoadSettingsData();
                    if (s.DeleteAlarmsOnceDone == "True")
                    {
                        DatabaseConnection.RemoveAlarmData(v);
                        loadAlarms();
                    }
                }

            }
        }
    }
}
