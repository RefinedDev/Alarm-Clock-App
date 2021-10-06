using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Alarm_Clock_App
{
    public class ACATimer
    {
        public double TS { get; set; }
        public double OGTime { get; set; }
        public string ID { get; set; }
        public string NameOfTimer { get; set; }
        public Panel TimerFrame { get; set; }

        private Label TimerLable;
        private Button ToggleButton;
        private Button ResetButton;
        private Timer Ticker;
        private Label Name;

        public string GetFormattedTime
        {
            get
            {
                TimeSpan t = TimeSpan.FromSeconds(this.TS);
                return string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            }
        }

        private void Build(FlowLayoutPanel parent)
        {
            TimerFrame = new Panel();
            TimerLable = new Label();
            ToggleButton = new Button();
            ResetButton = new Button();
            Ticker = new Timer();
            Name = new Label();

            // MAKE TIMER
            Ticker.Enabled = false;
            Ticker.Interval = 100;
            Ticker.Tick += new EventHandler(TickTimer);

            // MAKE PANEL
            TimerFrame.BackColor = Color.FromArgb(44, 47, 51);
            TimerFrame.Size = new Size(382, 469);
            TimerFrame.Tag = this;
            parent.Controls.Add(TimerFrame);

            // Name Lable
            Name.Text = NameOfTimer;
            Name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Name.AutoSize = true;
            Name.ForeColor = Color.White;

            TimerFrame.Controls.Add(Name);

            // MAKE TIME LABLE
            TimerLable.Dock = DockStyle.Top;
            TimerLable.Padding = new Padding(80, 100, 0, 0);
            TimerLable.Size = new Size(271, 158);
            TimerLable.Text = GetFormattedTime;
            TimerLable.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TimerLable.AutoSize = true;
            TimerLable.ForeColor = Color.White;
            TimerLable.TabIndex = 0;

            TimerFrame.Controls.Add(TimerLable);

            // Toggle
            ToggleButton.Anchor = AnchorStyles.None;
            ToggleButton.AutoSize = true;
            ToggleButton.BackColor = Color.FromArgb(35, 39, 42);
            ToggleButton.FlatAppearance.BorderSize = 0;
            ToggleButton.FlatStyle = FlatStyle.Flat;
            ToggleButton.ForeColor = Color.FromArgb(44, 47, 51);
            ToggleButton.Image = Properties.Resources.playIcon;
            ToggleButton.Location = new Point(63, 240);
            ToggleButton.Size = new Size(107, 105);
            ToggleButton.TabIndex = 1;
            ToggleButton.UseVisualStyleBackColor = false;
            ToggleButton.Click += new EventHandler(Toggle);

            TimerFrame.Controls.Add(ToggleButton);

            // Reset
            ResetButton.Anchor = AnchorStyles.None;
            ResetButton.AutoSize = true;
            ResetButton.BackColor = Color.FromArgb(35, 39, 42);
            ResetButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.ForeColor = Color.FromArgb(44, 47, 51);
            ResetButton.Image = Properties.Resources.resetIcon;
            ResetButton.Location = new Point(214, 239); 
            ResetButton.Size = new Size(107, 105);
            ResetButton.TabIndex = 1;
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += new EventHandler(Reset);

            TimerFrame.Controls.Add(ResetButton);
        }

        private void TickTimer(object sender, EventArgs e)
        {
            TS = (TS - 0.1);
            TimerLable.Text = GetFormattedTime;
            DatabaseConnection.SaveTimerData(this,true);

            if (TS <= 0)
            {
                Main.MakeNotification("Timer done.",NameOfTimer);
                
                Ticker.Enabled = false;
                ToggleButton.Image = Properties.Resources.playIcon;

                SettingsClass s = DatabaseConnection.LoadSettingsData();
         
                if (s.DeleteTimersOnceDone == "True")
                {
                    DatabaseConnection.RemoveTimerData(this);
                    Tabs.Timer.loadtimersStatically();
                }
            }
        }

        private void Toggle(object sender, EventArgs e)
        {
            if (TS <= 0)
            {
                TS = OGTime;
                Ticker.Enabled = false;
                TimerLable.Text = GetFormattedTime;
                ToggleButton.Image = Properties.Resources.playIcon;
                DatabaseConnection.SaveTimerData(this, true);
            }

            Ticker.Enabled = !(Ticker.Enabled);
            if (Ticker.Enabled)
            {
                ToggleButton.Image = Properties.Resources.pauseIcon;
            }
            else
            {
                ToggleButton.Image = Properties.Resources.playIcon;
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            TS = OGTime;
            Ticker.Enabled = false;
            TimerLable.Text = GetFormattedTime;
            ToggleButton.Image = Properties.Resources.playIcon;
            DatabaseConnection.SaveTimerData(this, true);
        }

        public void OpenTimerFrame(FlowLayoutPanel parent)
        {
            if (TimerFrame != null)
            {
                if (TimerFrame.Visible == true)
                {
                    throw new Exception("Already open!");
                }
                else
                {
                    TimerFrame.Visible = true;
                }
            }
            else
            {
                Build(parent);
            }
        }

        public void RemoveTimerFrame()
        {
            if (TimerFrame != null)
            {
                TimerFrame.Visible = false;
            }
            else
            {
                throw new Exception("Timer is already closed!");
            }
        }
    }
}
