namespace GreenValleyApp
{
    partial class frmProfile
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
            panel1 = new Panel();
            txtOrder = new TextBox();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            rtxtAddress = new RichTextBox();
            dtpDob = new DateTimePicker();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnChange = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 623);
            panel1.TabIndex = 0;
            // 
            // txtOrder
            // 
            txtOrder.Location = new Point(458, 74);
            txtOrder.Name = "txtOrder";
            txtOrder.ReadOnly = true;
            txtOrder.Size = new Size(109, 31);
            txtOrder.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdate.Location = new Point(207, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 34);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Location = new Point(355, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 54);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(131, 19);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 1;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(16, 19);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 0;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(556, 233);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(300, 67);
            rtxtAddress.TabIndex = 25;
            rtxtAddress.Text = "";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(556, 169);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(300, 31);
            dtpDob.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(161, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(243, 31);
            txtPassword.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(243, 31);
            txtEmail.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(435, 169);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 21;
            label7.Text = "Birth date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(310, 74);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 20;
            label6.Text = "Order bought:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(264, 340);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 19;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(435, 253);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 18;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 256);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 17;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 172);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 16;
            label1.Text = "Email:";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(192, 192, 255);
            btnChange.Location = new Point(497, 413);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(206, 34);
            btnChange.TabIndex = 15;
            btnChange.Text = "Change password";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font(".VnArial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(144, 28);
            label2.Name = "label2";
            label2.Size = new Size(157, 38);
            label2.TabIndex = 14;
            label2.Text = "My profile";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtOrder);
            groupBox2.Controls.Add(btnChange);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rtxtAddress);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpDob);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Location = new Point(178, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(924, 489);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 621);
            Controls.Add(panel1);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnChange;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private RichTextBox rtxtAddress;
        private DateTimePicker dtpDob;
        private Button btnUpdate;
        private TextBox txtOrder;
        private GroupBox groupBox2;
    }
}