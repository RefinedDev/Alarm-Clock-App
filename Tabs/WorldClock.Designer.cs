
namespace Alarm_Clock_App.Tabs
{
    partial class WorldClock
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.buttonsHolder = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.buttonsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.SystemColors.Info;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(1194, 110);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "Write A Place Name";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Dock = System.Windows.Forms.DockStyle.Top;
            this.result.Font = new System.Drawing.Font("Lucida Sans Unicode", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Location = new System.Drawing.Point(0, 110);
            this.result.Name = "result";
            this.result.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.result.Size = new System.Drawing.Size(426, 131);
            this.result.TabIndex = 1;
            this.result.Text = "Local Time: ";
            // 
            // buttonsHolder
            // 
            this.buttonsHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonsHolder.Controls.Add(this.btnSearch);
            this.buttonsHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsHolder.Location = new System.Drawing.Point(0, 591);
            this.buttonsHolder.Name = "buttonsHolder";
            this.buttonsHolder.Size = new System.Drawing.Size(1194, 81);
            this.buttonsHolder.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(994, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearch.Size = new System.Drawing.Size(200, 81);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // WorldClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1194, 672);
            this.Controls.Add(this.buttonsHolder);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorldClock";
            this.Text = "WorldClock";
            this.Load += new System.EventHandler(this.WorldClock_Load);
            this.buttonsHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel buttonsHolder;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}