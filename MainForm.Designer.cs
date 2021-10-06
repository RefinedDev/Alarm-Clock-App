
namespace Alarm_Clock_App
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopwatch = new FontAwesome.Sharp.IconButton();
            this.btnTimer = new FontAwesome.Sharp.IconButton();
            this.btnAlarm = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlarmClockApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qUITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlIndex.SuspendLayout();
            this.HomePagePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TrayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIndex
            // 
            this.pnlIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnlIndex.Controls.Add(this.btnSettings);
            this.pnlIndex.Controls.Add(this.label3);
            this.pnlIndex.Controls.Add(this.btnStopwatch);
            this.pnlIndex.Controls.Add(this.btnTimer);
            this.pnlIndex.Controls.Add(this.btnAlarm);
            this.pnlIndex.Controls.Add(this.panel1);
            this.pnlIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIndex.Location = new System.Drawing.Point(0, 0);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(305, 755);
            this.pnlIndex.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 634);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(305, 100);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "© 2021 Refined ";
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStopwatch.FlatAppearance.BorderSize = 0;
            this.btnStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopwatch.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnStopwatch.ForeColor = System.Drawing.Color.White;
            this.btnStopwatch.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnStopwatch.IconColor = System.Drawing.Color.White;
            this.btnStopwatch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnStopwatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopwatch.Location = new System.Drawing.Point(0, 217);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStopwatch.Size = new System.Drawing.Size(305, 100);
            this.btnStopwatch.TabIndex = 5;
            this.btnStopwatch.Text = "Stopwatch";
            this.btnStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopwatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopwatch.UseVisualStyleBackColor = true;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnTimer.IconColor = System.Drawing.Color.White;
            this.btnTimer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimer.Location = new System.Drawing.Point(0, 117);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTimer.Size = new System.Drawing.Size(305, 100);
            this.btnTimer.TabIndex = 4;
            this.btnTimer.Text = "Timer";
            this.btnTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlarm.FlatAppearance.BorderSize = 0;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarm.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAlarm.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnAlarm.IconColor = System.Drawing.Color.White;
            this.btnAlarm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarm.Location = new System.Drawing.Point(0, 17);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlarm.Size = new System.Drawing.Size(305, 100);
            this.btnAlarm.TabIndex = 3;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 17);
            this.panel1.TabIndex = 2;
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Controls.Add(this.panel2);
            this.HomePagePanel.Controls.Add(this.label2);
            this.HomePagePanel.Controls.Add(this.label1);
            this.HomePagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePagePanel.Location = new System.Drawing.Point(305, 0);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(878, 755);
            this.HomePagePanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.lblTabTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 151);
            this.panel2.TabIndex = 5;
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 50F);
            this.lblTabTitle.ForeColor = System.Drawing.Color.White;
            this.lblTabTitle.Location = new System.Drawing.Point(279, 17);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(283, 103);
            this.lblTabTitle.TabIndex = 4;
            this.lblTabTitle.Text = "Home";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(781, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select one of the options from the Index on the left!";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 50F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 103);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarm Clock App";
            // 
            // AlarmClockApp
            // 
            this.AlarmClockApp.BalloonTipTitle = "Alarm Clock App";
            this.AlarmClockApp.ContextMenuStrip = this.TrayList;
            this.AlarmClockApp.Icon = ((System.Drawing.Icon)(resources.GetObject("AlarmClockApp.Icon")));
            this.AlarmClockApp.Text = "Alarm Clock App";
            this.AlarmClockApp.Visible = true;
            this.AlarmClockApp.BalloonTipClicked += new System.EventHandler(this.AlarmClockApp_BalloonTipClicked);
            this.AlarmClockApp.BalloonTipClosed += new System.EventHandler(this.AlarmClockApp_BalloonTipClosed);
            this.AlarmClockApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlarmClockApp_MouseDown);
            // 
            // TrayList
            // 
            this.TrayList.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.TrayList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITToolStripMenuItem,
            this.minimizeToTrayToolStripMenuItem});
            this.TrayList.Name = "TrayList";
            this.TrayList.Size = new System.Drawing.Size(184, 52);
            // 
            // qUITToolStripMenuItem
            // 
            this.qUITToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.qUITToolStripMenuItem.Name = "qUITToolStripMenuItem";
            this.qUITToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.qUITToolStripMenuItem.Text = "Close Application";
            this.qUITToolStripMenuItem.Click += new System.EventHandler(this.qUITToolStripMenuItem_Click);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize To Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1183, 755);
            this.Controls.Add(this.HomePagePanel);
            this.Controls.Add(this.pnlIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.pnlIndex.ResumeLayout(false);
            this.pnlIndex.PerformLayout();
            this.HomePagePanel.ResumeLayout(false);
            this.HomePagePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TrayList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIndex;
        private FontAwesome.Sharp.IconButton btnAlarm;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTimer;
        private FontAwesome.Sharp.IconButton btnStopwatch;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.Panel HomePagePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTabTitle;
        public System.Windows.Forms.NotifyIcon AlarmClockApp;
        private System.Windows.Forms.ContextMenuStrip TrayList;
        private System.Windows.Forms.ToolStripMenuItem qUITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
    }
}