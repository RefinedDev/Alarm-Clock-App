using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm_Clock_App
{
    public partial class Main : Form
    {
        // FIELDS
        private FontAwesome.Sharp.IconButton currentSelectedBtn;
        private Panel blueBorder;
        private Form CurrentTab;
        private static SoundPlayer alarm = new SoundPlayer(Properties.Resources.Alarm);
        private static bool isPlaying = false;

        // TABS
        private Form Alarm = new Tabs.Alarm();
        private Form Settings = new Tabs.Settings();
        private Form Stopwatch = new Tabs.Stopwatch();
        private Form Timer = new Tabs.Timer();

        public static NotifyIcon AC { get; set; }
        public Main()
        {
            InitializeComponent();

            blueBorder = new Panel();
            blueBorder.Size = new Size(6, 80);
            blueBorder.BackColor = Color.White;
            blueBorder.Location = new Point(2, btnAlarm.Location.Y);
            pnlIndex.Controls.Add(blueBorder);

            AC = AlarmClockApp;
            AlarmClockApp.Icon = Properties.Resources.ACA;
            AC.Visible = true;
        }

        public static void MakeNotification(string message, string title = "Alarm Clock App")
        {
            if (! isPlaying)
            {
                AC.BalloonTipTitle = title;
                AC.BalloonTipText = message;
                AC.ShowBalloonTip(2000);
                alarm.Play();
                isPlaying = true;
            }
            
        }

        private void ClickOnButton(object sender)
        {
            DisableOtherButtons();
            if (sender != null)
            {
                currentSelectedBtn = (FontAwesome.Sharp.IconButton)sender;

                blueBorder.Visible = true;
                blueBorder.BringToFront();
                blueBorder.Location = new Point(2, currentSelectedBtn.Location.Y);
            }
        }

        private void DisableOtherButtons()
        {
            if (currentSelectedBtn != null)
            {
                blueBorder.Visible = false;
            }
        }

        private void OpenFrame(Form sender)
        {
            if (CurrentTab == sender) { return;  }

            CurrentTab = sender;
            lblTabTitle.Text = CurrentTab.Name;

            CurrentTab.TopLevel = false;
            CurrentTab.Dock = DockStyle.Fill;
            HomePagePanel.Controls.Add(CurrentTab);
            CurrentTab.BringToFront();
            CurrentTab.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender);
            OpenFrame(Alarm);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender);
            OpenFrame(Timer);
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender);
            OpenFrame(Stopwatch);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender);
            OpenFrame(Settings);
        }

        private void AlarmClockApp_BalloonTipClosed(object sender, EventArgs e)
        {
            alarm.Stop();
            isPlaying = false;
        }

        private void AlarmClockApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        private void qUITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (minimizeToTrayToolStripMenuItem.Text == "Minimize To Tray") {
                this.ShowInTaskbar = false;
                this.Hide();
                minimizeToTrayToolStripMenuItem.Text = "Open";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;
                this.Show();
                minimizeToTrayToolStripMenuItem.Text = "Minimize To Tray";
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (! this.ShowInTaskbar) { return; }
            Application.Exit();
            AC.Visible = false;
        }

        private void AlarmClockApp_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            this.Show();
            minimizeToTrayToolStripMenuItem.Text = "Minimize To Tray";
            alarm.Stop();
            isPlaying = false;
        }
    }
}
