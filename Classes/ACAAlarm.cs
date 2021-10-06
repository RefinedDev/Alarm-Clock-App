using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Alarm_Clock_App.Classes
{
    public class ACAAlarm
    {
        public double TS { get; set; }
        public string IsOn { get; set; }
        public string ID { get; set; }
        public string NameOfAlarm { get; set; }

        public Panel AlarmFrame { get; set; }
        public Label InWhatTime { get; set; }

        private Label TimeLable;
        private CheckBox ToggleButton;
        private Label NameLable;

        public string GetFormattedTime
        {
            get
            {
                TimeSpan t = TimeSpan.FromSeconds(this.TS);
                return string.Format("{0:D2}:{1:D2}", t.Hours, t.Minutes);
            }
        }

        public string GetWhen {
            get
            {
                if (DateTime.Now.TimeOfDay > TimeSpan.FromSeconds(this.TS))
                {
                    TimeSpan t = DateTime.Now.TimeOfDay - TimeSpan.FromSeconds(this.TS);
                    return string.Format("In {0} hours and {1} minutes", Math.Abs(23 - t.Hours), Math.Abs(60 - t.Minutes));
                }
                else
                {
                    TimeSpan t = DateTime.Now.TimeOfDay - TimeSpan.FromSeconds(this.TS);
                    return string.Format("In {0} hours and {1} minutes", Math.Abs(t.Hours), Math.Abs(t.Minutes));
                }
                
            } 
        }

        private void Build(FlowLayoutPanel parent)
        {
            AlarmFrame = new Panel();
            TimeLable = new Label();
            InWhatTime = new Label();
            ToggleButton = new CheckBox();
            NameLable = new Label();

            AlarmFrame.BackColor = Color.FromArgb(44,47,51);
            AlarmFrame.Location = new Point(3, 84);
            AlarmFrame.Size = new Size(384, 177);
            AlarmFrame.TabIndex = 1;
            AlarmFrame.Tag = this;

            parent.Controls.Add(AlarmFrame);

            TimeLable.AutoSize = true;
            TimeLable.Font = new Font("Lucida Sans Unicode", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeLable.ForeColor = Color.White;
            TimeLable.Location = new Point(3, 0);
            TimeLable.Size = new Size(251, 92);
            TimeLable.TabIndex = 0;
            TimeLable.Text = GetFormattedTime;

            AlarmFrame.Controls.Add(TimeLable);

            InWhatTime.AutoSize = true;
            InWhatTime.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InWhatTime.ForeColor = Color.White;
            InWhatTime.Location = new Point(25, 92);
            InWhatTime.Size = new Size(93, 42);
            InWhatTime.TabIndex = 1;
            InWhatTime.Text = GetWhen;

            AlarmFrame.Controls.Add(InWhatTime);

            ToggleButton.AutoSize = true;
            ToggleButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToggleButton.Location = new Point(339, 18);
            ToggleButton.Size = new Size(18, 17);
            ToggleButton.TabIndex = 2;
            ToggleButton.Checked = bool.Parse(IsOn);
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.Click += new EventHandler(Toggle);

            AlarmFrame.Controls.Add(ToggleButton);

            NameLable.AutoSize = true;
            NameLable.Font = new Font("Lucida Sans Unicode", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLable.ForeColor = Color.White;
            NameLable.Location = new Point(124, 135);
            NameLable.Name = "label5";
            NameLable.Size = new Size(196, 42);
            NameLable.TabIndex = 3;
            NameLable.Text = NameOfAlarm;

            AlarmFrame.Controls.Add(NameLable);

            EnablenDisable();
        }

        public void OpenAlarmFrame(FlowLayoutPanel parent)
        {
            if (AlarmFrame != null)
            {
                if (AlarmFrame.Visible == true)
                {
                    throw new Exception("Already open!");
                }
                else
                {
                    AlarmFrame.Visible = true;
                }
            }
            else
            {
                Build(parent);
            }
        }

        public void RemoveAlarmFrame()
        {
            if (AlarmFrame != null)
            {
                AlarmFrame.Visible = false;
            }
            else
            {
                throw new Exception("Timer is already closed!");
            }
        }

        private void Toggle(object sender, EventArgs e)
        {
            IsOn = ToggleButton.Checked.ToString();
            DatabaseConnection.SaveAlarmData(this, true);

            EnablenDisable();
        }

        private void EnablenDisable()
        {
            if (bool.Parse(IsOn))
            {
                TimeLable.ForeColor = Color.White;
                InWhatTime.ForeColor = Color.White;
                NameLable.ForeColor = Color.White;
            }
            else
            {
                TimeLable.ForeColor = Color.Gray;
                InWhatTime.ForeColor = Color.Gray;
                NameLable.ForeColor = Color.Gray;
            }
        }
    }
}
