﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginControl1 = new WinFormsApp1.LoginControl();
            SuspendLayout();
            // 
            // loginControl1
            // 
            loginControl1.BackColor = Color.FromArgb(255, 192, 255);
            loginControl1.ForeColor = Color.FromArgb(255, 224, 192);
            loginControl1.Location = new Point(194, 0);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(317, 447);
            loginControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(loginControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsApp1.LoginControl loginControl1;
    }
}