namespace GreenValleyApp
{
    partial class frmRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRepassword = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 109);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 374);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 432);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Repassword:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 174);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "Birth date: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(160, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 63);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(186, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 304);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 5;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 238);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 374);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 31);
            txtPassword.TabIndex = 8;
            // 
            // txtRepassword
            // 
            txtRepassword.Location = new Point(160, 429);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.PasswordChar = '*';
            txtRepassword.Size = new Size(300, 31);
            txtRepassword.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(160, 297);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(300, 61);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(0, 192, 0);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(25, 9);
            label7.Name = "label7";
            label7.Padding = new Padding(10);
            label7.Size = new Size(474, 72);
            label7.TabIndex = 12;
            label7.Text = "Register form";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(110, 492);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 13;
            button1.Text = "Register now";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(264, 502);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(186, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "already have account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 539);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtRepassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRepassword;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private Label label7;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}