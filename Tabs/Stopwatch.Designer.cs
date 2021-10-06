
namespace Alarm_Clock_App.Tabs
{
    partial class Stopwatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.timerShower = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblmilli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopWatchTimer
            // 
            this.stopWatchTimer.Tick += new System.EventHandler(this.stopWatchTimer_Tick);
            // 
            // timerShower
            // 
            this.timerShower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerShower.AutoSize = true;
            this.timerShower.Font = new System.Drawing.Font("Lucida Sans Unicode", 55F);
            this.timerShower.ForeColor = System.Drawing.Color.White;
            this.timerShower.Location = new System.Drawing.Point(420, 99);
            this.timerShower.Name = "timerShower";
            this.timerShower.Size = new System.Drawing.Size(453, 111);
            this.timerShower.TabIndex = 0;
            this.timerShower.Text = "00:00:00";
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggle.AutoSize = true;
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnToggle.Image = global::Alarm_Clock_App.Properties.Resources.playIcon;
            this.btnToggle.Location = new System.Drawing.Point(450, 300);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(106, 106);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnReset.Image = global::Alarm_Clock_App.Properties.Resources.resetIcon;
            this.btnReset.Location = new System.Drawing.Point(750, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 106);
            this.btnReset.TabIndex = 1;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmilli
            // 
            this.lblmilli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmilli.AutoSize = true;
            this.lblmilli.Font = new System.Drawing.Font("Lucida Sans Unicode", 30F);
            this.lblmilli.ForeColor = System.Drawing.Color.White;
            this.lblmilli.Location = new System.Drawing.Point(960, 250);
            this.lblmilli.Name = "lblmilli";
            this.lblmilli.Size = new System.Drawing.Size(75, 61);
            this.lblmilli.TabIndex = 2;
            this.lblmilli.Text = ".0";
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.lblmilli);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.timerShower);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stopwatch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.Label timerShower;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblmilli;
    }
}