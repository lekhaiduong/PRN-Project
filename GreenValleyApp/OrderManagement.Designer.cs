namespace GreenValleyApp
{
    partial class frmOrderManagement
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
            txtSubTotal = new TextBox();
            txtCountItem = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtName = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            pbImageProduct = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            comboBox1 = new ComboBox();
            label10 = new Label();
            txtTotal = new TextBox();
            rtxtAddress = new RichTextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lbNotify = new Label();
            dgvOrder = new DataGridView();
            dgvOrderDetail = new DataGridView();
            btnExit = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageProduct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(txtCountItem);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dgvOrderDetail);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 676);
            panel1.TabIndex = 0;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(1195, 345);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(165, 31);
            txtSubTotal.TabIndex = 60;
            // 
            // txtCountItem
            // 
            txtCountItem.Location = new Point(963, 345);
            txtCountItem.Name = "txtCountItem";
            txtCountItem.ReadOnly = true;
            txtCountItem.Size = new Size(102, 31);
            txtCountItem.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1093, 345);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 58;
            label6.Text = "Sub total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(844, 345);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 57;
            label5.Text = "Count item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(996, 46);
            label1.Name = "label1";
            label1.Size = new Size(215, 48);
            label1.TabIndex = 56;
            label1.Text = "Order detail";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtName);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(pbImageProduct);
            groupBox3.Location = new Point(844, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 220);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product info";
            // 
            // txtName
            // 
            txtName.Location = new Point(306, 48);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(190, 31);
            txtName.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(232, 48);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 62;
            label9.Text = "Name:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(351, 91);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(102, 31);
            txtPrice.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(232, 97);
            label8.Name = "label8";
            label8.Size = new Size(58, 28);
            label8.TabIndex = 60;
            label8.Text = "Price:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(351, 140);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(102, 31);
            txtQuantity.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(232, 140);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 60;
            label7.Text = "Count item:";
            // 
            // pbImageProduct
            // 
            pbImageProduct.Location = new Point(8, 30);
            pbImageProduct.Name = "pbImageProduct";
            pbImageProduct.Size = new Size(213, 175);
            pbImageProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pbImageProduct.TabIndex = 0;
            pbImageProduct.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lbNotify);
            groupBox1.Controls.Add(dgvOrder);
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 590);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orders";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(rtxtAddress);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(8, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 220);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(704, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 34);
            btnUpdate.TabIndex = 56;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "In process", "Shipping", "Complete" });
            comboBox1.Location = new Point(492, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 33);
            comboBox1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(396, 137);
            label10.Name = "label10";
            label10.Size = new Size(90, 32);
            label10.TabIndex = 6;
            label10.Text = "Status:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Yellow;
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(492, 65);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(192, 34);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // rtxtAddress
            // 
            rtxtAddress.BorderStyle = BorderStyle.FixedSingle;
            rtxtAddress.Location = new Point(125, 119);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.ReadOnly = true;
            rtxtAddress.Size = new Size(238, 73);
            rtxtAddress.TabIndex = 5;
            rtxtAddress.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(398, 62);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 2;
            label4.Text = "Total:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 141);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 1;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 0;
            label2.Text = "Email:";
            // 
            // lbNotify
            // 
            lbNotify.AutoSize = true;
            lbNotify.BackColor = Color.FromArgb(128, 255, 128);
            lbNotify.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotify.Location = new Point(193, 27);
            lbNotify.Name = "lbNotify";
            lbNotify.Size = new Size(341, 48);
            lbNotify.TabIndex = 54;
            lbNotify.Text = "Order management";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(16, 86);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(806, 268);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(844, 105);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.RowTemplate.Height = 33;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(513, 216);
            dgvOrderDetail.TabIndex = 1;
            dgvOrderDetail.CellClick += dgvOrderDetail_CellClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1237, 622);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 38);
            btnExit.TabIndex = 61;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 674);
            Controls.Add(panel1);
            Name = "frmOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvOrder;
        private GroupBox groupBox1;
        private DataGridView dgvOrderDetail;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label lbNotify;
        private Label label1;
        private TextBox txtTotal;
        private Label label4;
        private RichTextBox rtxtAddress;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txtSubTotal;
        private TextBox txtCountItem;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txtQuantity;
        private Label label7;
        private PictureBox pbImageProduct;
        private TextBox textBox1;
        private Label label9;
        private TextBox txtName;
        private Button btnExit;
        private ComboBox comboBox1;
        private Label label10;
        private Button btnUpdate;
    }
}