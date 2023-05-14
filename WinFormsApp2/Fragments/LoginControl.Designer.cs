namespace WinFormsApp1
{
    partial class LoginControl
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
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(105, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(65, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 22);
            textBox1.TabIndex = 1;
            textBox1.Text = "Email or username";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(65, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 22);
            textBox2.TabIndex = 2;
            textBox2.Text = "password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(65, 223);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 17);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(105, 267);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 5;
            button1.Text = "sign in";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(70, 311);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 6;
            label2.Text = "forgot ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(74, 327);
            label3.Name = "label3";
            label3.Size = new Size(0, 13);
            label3.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(112, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 13);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Username/Passord?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(71, 330);
            label4.Name = "label4";
            label4.Size = new Size(128, 13);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(195, 328);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 224, 192);
            Name = "LoginControl";
            Size = new Size(317, 443);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel linkLabel2;
    }
}
