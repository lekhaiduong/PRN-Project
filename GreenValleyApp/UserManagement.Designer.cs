namespace GreenValleyApp
{
    partial class frmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            panel1 = new Panel();
            rtxtAddress = new RichTextBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            txtSearch = new TextBox();
            txtID = new TextBox();
            dtpDob = new DateTimePicker();
            txtStatus = new TextBox();
            label5 = new Label();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            dgvData = new DataGridView();
            lbNotify = new Label();
            txtTotalUser = new TextBox();
            lbTotalUser = new Label();
            grbFilter = new GroupBox();
            groupBox3 = new GroupBox();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cbxStatus = new ComboBox();
            txtActivate = new TextBox();
            label6 = new Label();
            txtDeactivate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grbFilter.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rtxtAddress);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(dtpDob);
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(dgvData);
            panel1.Controls.Add(lbNotify);
            panel1.Location = new Point(419, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 674);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(323, 270);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.ReadOnly = true;
            rtxtAddress.Size = new Size(296, 57);
            rtxtAddress.TabIndex = 77;
            rtxtAddress.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(236, 289);
            label12.Name = "label12";
            label12.Size = new Size(81, 25);
            label12.TabIndex = 76;
            label12.Text = "Address:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(818, 362);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(620, 359);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search here...";
            txtSearch.Size = new Size(226, 31);
            txtSearch.TabIndex = 74;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 93);
            txtID.Name = "txtID";
            txtID.Size = new Size(218, 31);
            txtID.TabIndex = 73;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(540, 93);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(300, 31);
            dtpDob.TabIndex = 72;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.ButtonHighlight;
            txtStatus.Location = new Point(540, 210);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(167, 31);
            txtStatus.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(445, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 70;
            label5.Text = "Status:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(540, 152);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 31);
            txtPass.TabIndex = 69;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 31);
            txtEmail.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 65;
            label4.Text = "Pasword:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 95);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 64;
            label3.Text = "Birth date:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Location = new Point(50, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 51);
            groupBox1.TabIndex = 63;
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
            label2.Location = new Point(50, 150);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 62;
            label2.Text = "User email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 95);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 61;
            label1.Text = "User ID:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(280, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 58;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(151, 356);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(21, 356);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 56;
            btnLoad.Text = "Delete";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(20, 396);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(826, 225);
            dgvData.TabIndex = 55;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // lbNotify
            // 
            lbNotify.AutoSize = true;
            lbNotify.BackColor = Color.FromArgb(128, 255, 128);
            lbNotify.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotify.Location = new Point(271, 14);
            lbNotify.Name = "lbNotify";
            lbNotify.Size = new Size(320, 48);
            lbNotify.TabIndex = 54;
            lbNotify.Text = "User management";
            // 
            // txtTotalUser
            // 
            txtTotalUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalUser.Location = new Point(182, 26);
            txtTotalUser.Name = "txtTotalUser";
            txtTotalUser.ReadOnly = true;
            txtTotalUser.Size = new Size(184, 37);
            txtTotalUser.TabIndex = 60;
            // 
            // lbTotalUser
            // 
            lbTotalUser.AutoSize = true;
            lbTotalUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalUser.Location = new Point(43, 26);
            lbTotalUser.Name = "lbTotalUser";
            lbTotalUser.Size = new Size(115, 30);
            lbTotalUser.TabIndex = 59;
            lbTotalUser.Text = "Total user:";
            // 
            // grbFilter
            // 
            grbFilter.Controls.Add(groupBox3);
            grbFilter.Controls.Add(label9);
            grbFilter.Controls.Add(cbxStatus);
            grbFilter.Location = new Point(14, 239);
            grbFilter.Name = "grbFilter";
            grbFilter.Size = new Size(399, 372);
            grbFilter.TabIndex = 1;
            grbFilter.TabStop = false;
            grbFilter.Text = "Filter";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpTo);
            groupBox3.Controls.Add(dtpFrom);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(2, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 170);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Create date";
            // 
            // dtpTo
            // 
            dtpTo.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTo.Location = new Point(69, 118);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(300, 31);
            dtpTo.TabIndex = 3;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFrom.Location = new Point(69, 46);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(300, 31);
            dtpFrom.TabIndex = 2;
            dtpFrom.Value = new DateTime(2024, 3, 19, 0, 22, 31, 0);
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 123);
            label11.Name = "label11";
            label11.Size = new Size(30, 25);
            label11.TabIndex = 1;
            label11.Text = "To";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 46);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 0;
            label10.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 88);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 1;
            label9.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "All", "Activate", "Deactivate" });
            cbxStatus.Location = new Point(81, 85);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(182, 33);
            cbxStatus.TabIndex = 0;
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // txtActivate
            // 
            txtActivate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtActivate.Location = new Point(182, 118);
            txtActivate.Name = "txtActivate";
            txtActivate.ReadOnly = true;
            txtActivate.Size = new Size(184, 31);
            txtActivate.TabIndex = 62;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(128, 255, 128);
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 118);
            label6.Name = "label6";
            label6.Size = new Size(115, 31);
            label6.TabIndex = 61;
            label6.Text = "Activate:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDeactivate
            // 
            txtDeactivate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDeactivate.Location = new Point(182, 184);
            txtDeactivate.Name = "txtDeactivate";
            txtDeactivate.ReadOnly = true;
            txtDeactivate.Size = new Size(184, 31);
            txtDeactivate.TabIndex = 64;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(255, 128, 128);
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(43, 184);
            label7.Name = "label7";
            label7.Size = new Size(115, 31);
            label7.TabIndex = 63;
            label7.Text = "Deactivate:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 75);
            label8.Name = "label8";
            label8.Size = new Size(355, 25);
            label8.TabIndex = 65;
            label8.Text = "-------------------------------------------------";
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 685);
            Controls.Add(label8);
            Controls.Add(txtDeactivate);
            Controls.Add(label7);
            Controls.Add(txtActivate);
            Controls.Add(label6);
            Controls.Add(grbFilter);
            Controls.Add(panel1);
            Controls.Add(txtTotalUser);
            Controls.Add(lbTotalUser);
            Name = "frmUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grbFilter.ResumeLayout(false);
            grbFilter.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbNotify;
        private Label lbTotalUser;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnLoad;
        private DataGridView dgvData;
        private TextBox txtTotalUser;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label3;
        private Label label4;
        private TextBox txtStatus;
        private Label label5;
        private TextBox txtPass;
        private TextBox textBox3;
        private TextBox txtEmail;
        private DateTimePicker dtpDob;
        private TextBox txtID;
        private GroupBox grbFilter;
        private TextBox txtActivate;
        private Label label6;
        private TextBox txtDeactivate;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private GroupBox groupBox3;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cbxStatus;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private RichTextBox rtxtAddress;
        private Label label12;
    }
}