
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
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
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.iconButton1.IconColor = System.Drawing.Color.Turquoise;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(962, 679);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(250, 40);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "@OHrefineddev";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(962, 639);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton2.Size = new System.Drawing.Size(250, 40);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Refined#9910";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}