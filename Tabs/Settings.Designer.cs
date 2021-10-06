
namespace Alarm_Clock_App.Tabs
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DAAOD = new System.Windows.Forms.CheckBox();
            this.DTAOD = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DAAOD);
            this.panel1.Controls.Add(this.DTAOD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 719);
            this.panel1.TabIndex = 1;
            // 
            // DAAOD
            // 
            this.DAAOD.AutoSize = true;
            this.DAAOD.Dock = System.Windows.Forms.DockStyle.Top;
            this.DAAOD.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAAOD.ForeColor = System.Drawing.Color.White;
            this.DAAOD.Location = new System.Drawing.Point(0, 96);
            this.DAAOD.Name = "DAAOD";
            this.DAAOD.Padding = new System.Windows.Forms.Padding(20, 50, 0, 0);
            this.DAAOD.Size = new System.Drawing.Size(962, 96);
            this.DAAOD.TabIndex = 2;
            this.DAAOD.Text = "Delete Alarms Automatically Once Done";
            this.DAAOD.UseVisualStyleBackColor = true;
            this.DAAOD.Click += new System.EventHandler(this.DAAOD_Click);
            // 
            // DTAOD
            // 
            this.DTAOD.AutoSize = true;
            this.DTAOD.Dock = System.Windows.Forms.DockStyle.Top;
            this.DTAOD.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTAOD.ForeColor = System.Drawing.Color.White;
            this.DTAOD.Location = new System.Drawing.Point(0, 0);
            this.DTAOD.Name = "DTAOD";
            this.DTAOD.Padding = new System.Windows.Forms.Padding(20, 50, 0, 0);
            this.DTAOD.Size = new System.Drawing.Size(962, 96);
            this.DTAOD.TabIndex = 1;
            this.DTAOD.Text = "Delete Timers Automatically Once Done";
            this.DTAOD.UseVisualStyleBackColor = true;
            this.DTAOD.Click += new System.EventHandler(this.DTAOD_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox DAAOD;
        private System.Windows.Forms.CheckBox DTAOD;
    }
}