﻿namespace ReToolNaming
{
    partial class ConsoleLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleLog));
            this.lConsoleLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lConsoleLog
            // 
            this.lConsoleLog.BackColor = System.Drawing.Color.Black;
            this.lConsoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lConsoleLog.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lConsoleLog.ForeColor = System.Drawing.Color.Lime;
            this.lConsoleLog.Location = new System.Drawing.Point(0, 0);
            this.lConsoleLog.Multiline = true;
            this.lConsoleLog.Name = "lConsoleLog";
            this.lConsoleLog.ReadOnly = true;
            this.lConsoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lConsoleLog.Size = new System.Drawing.Size(800, 450);
            this.lConsoleLog.TabIndex = 0;
            this.lConsoleLog.Text = "Wait. Processing...";
            // 
            // ConsoleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lConsoleLog);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleLog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsoleLog";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleLog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lConsoleLog;
    }
}