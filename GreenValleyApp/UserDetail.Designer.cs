namespace GreenValleyApp
{
    partial class frmUserDetail
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
            rtxtAddress = new RichTextBox();
            label1 = new Label();
            cbxStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rtxtAddress);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbxStatus);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(dtpDob);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 598);
            panel1.TabIndex = 0;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(229, 359);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(300, 63);
            rtxtAddress.TabIndex = 89;
            rtxtAddress.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 378);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 88;
            label1.Text = "Address:";
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Activate", "Deactivate" });
            cbxStatus.Location = new Point(229, 439);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(194, 33);
            cbxStatus.TabIndex = 87;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(115, 515);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 85;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(365, 515);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 86;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(238, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(218, 31);
            txtID.TabIndex = 84;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(229, 240);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(300, 31);
            dtpDob.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 447);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 81;
            label5.Text = "Status:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(229, 299);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 31);
            txtPass.TabIndex = 80;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 31);
            txtEmail.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 305);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 78;
            label4.Text = "Pasword:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 243);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 77;
            label3.Text = "Birth date:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Location = new Point(134, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 51);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(186, 16);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 64;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(53, 16);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 126);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 75;
            label2.Text = "User email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 70);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 74;
            label6.Text = "User ID:";
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 596);
            Controls.Add(panel1);
            Name = "frmUserDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDetail";
            Load += frmUserDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtID;
        private DateTimePicker dtpDob;
        private Label label5;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label2;
        private Label label6;
        private ComboBox cbxStatus;
        private Button btnSave;
        private Button btnCancel;
        private RichTextBox rtxtAddress;
        private Label label1;
    }
}