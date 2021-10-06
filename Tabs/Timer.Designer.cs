
namespace Alarm_Clock_App.Tabs
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.timerContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.noTimers = new System.Windows.Forms.Label();
            this.buttonsHolder = new System.Windows.Forms.Panel();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.secondsBox = new System.Windows.Forms.Panel();
            this.nameOfTimer = new System.Windows.Forms.TextBox();
            this.timerFrame = new System.Windows.Forms.Panel();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.btnSaveTimer = new FontAwesome.Sharp.IconButton();
            this.btnCloseCreate = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorThing = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerContainer.SuspendLayout();
            this.buttonsHolder.SuspendLayout();
            this.secondsBox.SuspendLayout();
            this.timerFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThing)).BeginInit();
            this.SuspendLayout();
            // 
            // timerContainer
            // 
            this.timerContainer.AutoScroll = true;
            this.timerContainer.Controls.Add(this.noTimers);
            this.timerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerContainer.Location = new System.Drawing.Point(0, 0);
            this.timerContainer.Name = "timerContainer";
            this.timerContainer.Size = new System.Drawing.Size(1212, 638);
            this.timerContainer.TabIndex = 0;
            // 
            // noTimers
            // 
            this.noTimers.AutoSize = true;
            this.noTimers.Font = new System.Drawing.Font("Lucida Sans Unicode", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTimers.ForeColor = System.Drawing.Color.White;
            this.noTimers.Location = new System.Drawing.Point(3, 0);
            this.noTimers.Name = "noTimers";
            this.noTimers.Size = new System.Drawing.Size(1102, 81);
            this.noTimers.TabIndex = 0;
            this.noTimers.Text = "There are no Timers, Create one!";
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
            this.buttonsHolder.TabIndex = 1;
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
            this.secondsBox.Controls.Add(this.nameOfTimer);
            this.secondsBox.Controls.Add(this.timerFrame);
            this.secondsBox.Controls.Add(this.btnSaveTimer);
            this.secondsBox.Controls.Add(this.btnCloseCreate);
            this.secondsBox.Controls.Add(this.label1);
            this.secondsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsBox.Location = new System.Drawing.Point(0, 638);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(1212, 0);
            this.secondsBox.TabIndex = 2;
            this.secondsBox.Visible = false;
            // 
            // nameOfTimer
            // 
            this.nameOfTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.nameOfTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfTimer.ForeColor = System.Drawing.Color.White;
            this.nameOfTimer.Location = new System.Drawing.Point(385, -159);
            this.nameOfTimer.Name = "nameOfTimer";
            this.nameOfTimer.Size = new System.Drawing.Size(497, 64);
            this.nameOfTimer.TabIndex = 11;
            this.nameOfTimer.Text = "nameOftimer";
            // 
            // timerFrame
            // 
            this.timerFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerFrame.Controls.Add(this.secondBox);
            this.timerFrame.Controls.Add(this.label3);
            this.timerFrame.Controls.Add(this.minuteBox);
            this.timerFrame.Controls.Add(this.label2);
            this.timerFrame.Controls.Add(this.hourBox);
            this.timerFrame.Location = new System.Drawing.Point(385, -80);
            this.timerFrame.Name = "timerFrame";
            this.timerFrame.Size = new System.Drawing.Size(497, 102);
            this.timerFrame.TabIndex = 10;
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.secondBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.secondBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondBox.ForeColor = System.Drawing.Color.White;
            this.secondBox.Location = new System.Drawing.Point(336, 0);
            this.secondBox.MaxLength = 2;
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(105, 102);
            this.secondBox.TabIndex = 4;
            this.secondBox.Text = "s";
            this.secondBox.TextChanged += new System.EventHandler(this.secondBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 95);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
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
            this.minuteBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(443, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new timer";
            // 
            // errorThing
            // 
            this.errorThing.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorThing.ContainerControl = this;
            this.errorThing.Icon = ((System.Drawing.Icon)(resources.GetObject("errorThing.Icon")));
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.buttonsHolder);
            this.Controls.Add(this.timerContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timer";
            this.Text = "Form1";
            this.timerContainer.ResumeLayout(false);
            this.timerContainer.PerformLayout();
            this.buttonsHolder.ResumeLayout(false);
            this.secondsBox.ResumeLayout(false);
            this.secondsBox.PerformLayout();
            this.timerFrame.ResumeLayout(false);
            this.timerFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel timerContainer;
        private System.Windows.Forms.Panel buttonsHolder;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnRemove;
        private System.Windows.Forms.Panel secondsBox;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSaveTimer;
        private FontAwesome.Sharp.IconButton btnCloseCreate;
        private System.Windows.Forms.Panel timerFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.ErrorProvider errorThing;
        private System.Windows.Forms.Label noTimers;
        private System.Windows.Forms.TextBox nameOfTimer;
    }
}