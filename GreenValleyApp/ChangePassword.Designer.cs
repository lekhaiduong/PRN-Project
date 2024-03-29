namespace GreenValleyApp
{
    partial class frmChangePass
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
            txtCurrentPass = new TextBox();
            txtNewPass = new TextBox();
            txtRepass = new TextBox();
            btnChange = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(91, 18);
            label1.Name = "label1";
            label1.Size = new Size(272, 45);
            label1.TabIndex = 0;
            label1.Text = "Change password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter current password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter new password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 3;
            label4.Text = "Enter repassword:";
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Location = new Point(216, 98);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PasswordChar = '*';
            txtCurrentPass.Size = new Size(231, 31);
            txtCurrentPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(216, 163);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(231, 31);
            txtNewPass.TabIndex = 5;
            // 
            // txtRepass
            // 
            txtRepass.Location = new Point(216, 222);
            txtRepass.Name = "txtRepass";
            txtRepass.PasswordChar = '*';
            txtRepass.Size = new Size(231, 31);
            txtRepass.TabIndex = 6;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(75, 299);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(112, 34);
            btnChange.TabIndex = 7;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(251, 299);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRepass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNewPass);
            panel1.Controls.Add(txtCurrentPass);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 374);
            panel1.TabIndex = 9;
            // 
            // frmChangePass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 373);
            Controls.Add(panel1);
            Name = "frmChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCurrentPass;
        private TextBox txtNewPass;
        private TextBox txtRepass;
        private Button btnChange;
        private Button btnBack;
        private Panel panel1;
    }
}