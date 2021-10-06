
namespace Alarm_Clock_App.Tabs
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.buttonsHolder = new System.Windows.Forms.Panel();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.secondsBox = new System.Windows.Forms.Panel();
            this.nameOfAlarm = new System.Windows.Forms.TextBox();
            this.alarmFrame = new System.Windows.Forms.Panel();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.btnSaveTimer = new FontAwesome.Sharp.IconButton();
            this.btnCloseCreate = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.noAlarms = new System.Windows.Forms.Label();
            this.errorThing = new System.Windows.Forms.ErrorProvider(this.components);
            this.alarmHandler = new System.Windows.Forms.Timer(this.components);
            this.buttonsHolder.SuspendLayout();
            this.secondsBox.SuspendLayout();
            this.alarmFrame.SuspendLayout();
            this.alarmContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThing)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsHolder
            // 
            this.buttonsHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonsHolder.Controls.Add(this.btnRemove);
            this.buttonsHolder.Controls.Add(this.btnCreate);
            this.buttonsHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsHolder.Location = new System.Drawing.Point(0, 638);
            this.buttonsHolder.Name = "buttonsHolder";
            this.buttonsHolder.Size = new System.Drawing.Size(1212, 81);
            this.buttonsHolder.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(787, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRemove.Size = new System.Drawing.Size(225, 81);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCreate.IconColor = System.Drawing.Color.White;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(1012, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCreate.Size = new System.Drawing.Size(200, 81);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // secondsBox
            // 
            this.secondsBox.Controls.Add(this.nameOfAlarm);
            this.secondsBox.Controls.Add(this.alarmFrame);
            this.secondsBox.Controls.Add(this.btnSaveTimer);
            this.secondsBox.Controls.Add(this.btnCloseCreate);
            this.secondsBox.Controls.Add(this.label1);
            this.secondsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsBox.Location = new System.Drawing.Point(0, 638);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(1212, 0);
            this.secondsBox.TabIndex = 4;
            this.secondsBox.Visible = false;
            // 
            // nameOfAlarm
            // 
            this.nameOfAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.nameOfAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfAlarm.ForeColor = System.Drawing.Color.White;
            this.nameOfAlarm.Location = new System.Drawing.Point(425, -175);
            this.nameOfAlarm.Name = "nameOfAlarm";
            this.nameOfAlarm.Size = new System.Drawing.Size(381, 64);
            this.nameOfAlarm.TabIndex = 11;
            this.nameOfAlarm.Text = "nameOfalarm";
            // 
            // alarmFrame
            // 
            this.alarmFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarmFrame.Controls.Add(this.minuteBox);
            this.alarmFrame.Controls.Add(this.label2);
            this.alarmFrame.Controls.Add(this.hourBox);
            this.alarmFrame.Location = new System.Drawing.Point(425, -96);
            this.alarmFrame.Name = "alarmFrame";
            this.alarmFrame.Size = new System.Drawing.Size(308, 102);
            this.alarmFrame.TabIndex = 10;
            // 
            // minuteBox
            // 
            this.minuteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.minuteBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.minuteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteBox.ForeColor = System.Drawing.Color.White;
            this.minuteBox.Location = new System.Drawing.Point(168, 0);
            this.minuteBox.MaxLength = 2;
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(105, 102);
            this.minuteBox.TabIndex = 2;
            this.minuteBox.Text = "m";
            this.minuteBox.TextChanged += new System.EventHandler(this.minuteBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 95);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.hourBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.hourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourBox.ForeColor = System.Drawing.Color.White;
            this.hourBox.Location = new System.Drawing.Point(0, 0);
            this.hourBox.MaxLength = 2;
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(105, 102);
            this.hourBox.TabIndex = 0;
            this.hourBox.Text = "hr";
            this.hourBox.TextChanged += new System.EventHandler(this.hourBox_TextChanged);
            // 
            // btnSaveTimer
            // 
            this.btnSaveTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnSaveTimer.FlatAppearance.BorderSize = 0;
            this.btnSaveTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTimer.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnSaveTimer.ForeColor = System.Drawing.Color.White;
            this.btnSaveTimer.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveTimer.IconColor = System.Drawing.Color.White;
            this.btnSaveTimer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSaveTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTimer.Location = new System.Drawing.Point(385, 88);
            this.btnSaveTimer.Name = "btnSaveTimer";
            this.btnSaveTimer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSaveTimer.Size = new System.Drawing.Size(225, 81);
            this.btnSaveTimer.TabIndex = 9;
            this.btnSaveTimer.Text = "Save";
            this.btnSaveTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTimer.UseVisualStyleBackColor = false;
            this.btnSaveTimer.Click += new System.EventHandler(this.btnSaveTimer_Click);
            // 
            // btnCloseCreate
            // 
            this.btnCloseCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnCloseCreate.FlatAppearance.BorderSize = 0;
            this.btnCloseCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCreate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnCloseCreate.ForeColor = System.Drawing.Color.White;
            this.btnCloseCreate.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCloseCreate.IconColor = System.Drawing.Color.White;
            this.btnCloseCreate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCloseCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCreate.Location = new System.Drawing.Point(616, 88);
            this.btnCloseCreate.Name = "btnCloseCreate";
            this.btnCloseCreate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCloseCreate.Size = new System.Drawing.Size(225, 81);
            this.btnCloseCreate.TabIndex = 8;
            this.btnCloseCreate.Text = "Close";
            this.btnCloseCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseCreate.UseVisualStyleBackColor = false;
            this.btnCloseCreate.Click += new System.EventHandler(this.btnCloseCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new alarm";
            // 
            // alarmContainer
            // 
            this.alarmContainer.AutoScroll = true;
            this.alarmContainer.Controls.Add(this.noAlarms);
            this.alarmContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.alarmContainer.Location = new System.Drawing.Point(0, 0);
            this.alarmContainer.Name = "alarmContainer";
            this.alarmContainer.Size = new System.Drawing.Size(1212, 638);
            this.alarmContainer.TabIndex = 3;
            // 
            // noAlarms
            // 
            this.noAlarms.AutoSize = true;
            this.noAlarms.Font = new System.Drawing.Font("Lucida Sans Unicode", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAlarms.ForeColor = System.Drawing.Color.White;
            this.noAlarms.Location = new System.Drawing.Point(3, 0);
            this.noAlarms.Name = "noAlarms";
            this.noAlarms.Size = new System.Drawing.Size(1106, 81);
            this.noAlarms.TabIndex = 0;
            this.noAlarms.Text = "There are no Alarms, Create one!";
            // 
            // errorThing
            // 
            this.errorThing.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorThing.ContainerControl = this;
            this.errorThing.Icon = ((System.Drawing.Icon)(resources.GetObject("errorThing.Icon")));
            // 
            // alarmHandler
            // 
            this.alarmHandler.Enabled = true;
            this.alarmHandler.Tick += new System.EventHandler(this.updateAlarm_Tick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.alarmContainer);
            this.Controls.Add(this.buttonsHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarm";
            this.Text = "Form1";
            this.buttonsHolder.ResumeLayout(false);
            this.secondsBox.ResumeLayout(false);
            this.secondsBox.PerformLayout();
            this.alarmFrame.ResumeLayout(false);
            this.alarmFrame.PerformLayout();
            this.alarmContainer.ResumeLayout(false);
            this.alarmContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsHolder;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnCreate;
        private System.Windows.Forms.Panel secondsBox;
        private System.Windows.Forms.TextBox nameOfAlarm;
        private System.Windows.Forms.Panel alarmFrame;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hourBox;
        private FontAwesome.Sharp.IconButton btnSaveTimer;
        private FontAwesome.Sharp.IconButton btnCloseCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel alarmContainer;
        private System.Windows.Forms.Label noAlarms;
        private System.Windows.Forms.ErrorProvider errorThing;
        private System.Windows.Forms.Timer alarmHandler;
    }
}