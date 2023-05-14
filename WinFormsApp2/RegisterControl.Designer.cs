namespace WinFormsApp2
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 72);
            label1.Name = "label1";
            label1.Size = new Size(83, 13);
            label1.TabIndex = 0;
            label1.Text = "Email Adsdress";
            label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 153);
            label2.Name = "label2";
            label2.Size = new Size(56, 13);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            textBox2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 232);
            label3.Name = "label3";
            label3.Size = new Size(100, 13);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            label3.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 5;
            textBox3.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(66, 295);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(203, 17);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Check the box before you regester";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(105, 337);
            button1.Name = "button1";
            button1.Size = new Size(97, 41);
            button1.TabIndex = 7;
            button1.Text = "REGESTER";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegisterControl";
            Size = new Size(364, 473);
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Button button1;
    }
}
