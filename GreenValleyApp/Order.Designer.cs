namespace GreenValleyApp
{
    partial class frmOrder
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
            lbCount = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            grbxFilter = new GroupBox();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            dgvDataOrder = new DataGridView();
            groupBox2 = new GroupBox();
            txtStatus = new TextBox();
            label7 = new Label();
            txtTotalPrice = new TextBox();
            label6 = new Label();
            dtpOrderDate = new DateTimePicker();
            txtAddress = new RichTextBox();
            txtShipping = new TextBox();
            txtProductName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvDataOrderDetail = new DataGridView();
            grbxDetail = new GroupBox();
            label10 = new Label();
            lbProductName = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label9 = new Label();
            label8 = new Label();
            pbProductImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrder).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrderDetail).BeginInit();
            grbxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(grbxFilter);
            panel1.Controls.Add(dgvDataOrder);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(dgvDataOrderDetail);
            panel1.Controls.Add(grbxDetail);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 706);
            panel1.TabIndex = 0;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCount.Location = new Point(474, 46);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(0, 32);
            lbCount.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font(".VnArial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(153, 30);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 16;
            label2.Text = "My Order";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // grbxFilter
            // 
            grbxFilter.Controls.Add(dtpToDate);
            grbxFilter.Controls.Add(dtpFromDate);
            grbxFilter.Controls.Add(label12);
            grbxFilter.Controls.Add(label11);
            grbxFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            grbxFilter.Location = new Point(9, 94);
            grbxFilter.Name = "grbxFilter";
            grbxFilter.Size = new Size(465, 194);
            grbxFilter.TabIndex = 4;
            grbxFilter.TabStop = false;
            grbxFilter.Text = "Filter";
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpToDate.Location = new Point(98, 129);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(300, 31);
            dtpToDate.TabIndex = 3;
            dtpToDate.Value = new DateTime(2024, 3, 19, 0, 0, 0, 0);
            dtpToDate.ValueChanged += GroupBoxComboBoxChange;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFromDate.Location = new Point(98, 62);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(300, 31);
            dtpFromDate.TabIndex = 2;
            dtpFromDate.ValueChanged += GroupBoxComboBoxChange;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(38, 134);
            label12.Name = "label12";
            label12.Size = new Size(34, 25);
            label12.TabIndex = 1;
            label12.Text = "To:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(38, 62);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 0;
            label11.Text = "From:";
            // 
            // dgvDataOrder
            // 
            dgvDataOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataOrder.Location = new Point(486, 108);
            dgvDataOrder.Name = "dgvDataOrder";
            dgvDataOrder.RowHeadersWidth = 62;
            dgvDataOrder.RowTemplate.Height = 33;
            dgvDataOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataOrder.Size = new Size(837, 180);
            dgvDataOrder.TabIndex = 3;
            dgvDataOrder.CellClick += dgvDataOrder_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStatus);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTotalPrice);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(txtShipping);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(486, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(837, 180);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.LimeGreen;
            txtStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtStatus.ForeColor = Color.White;
            txtStatus.Location = new Point(536, 140);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(300, 34);
            txtStatus.TabIndex = 11;
            txtStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(464, 140);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 10;
            label7.Text = "Status:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(100, 143);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(260, 34);
            txtTotalPrice.TabIndex = 9;
            txtTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 143);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 8;
            label6.Text = "Total: ";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(536, 31);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(300, 34);
            dtpOrderDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(100, 75);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(260, 54);
            txtAddress.TabIndex = 6;
            txtAddress.Text = "";
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(536, 88);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(300, 34);
            txtShipping.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(100, 31);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(260, 34);
            txtProductName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 88);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 3;
            label5.Text = "Shipping cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 34);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 2;
            label4.Text = "Order time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // dgvDataOrderDetail
            // 
            dgvDataOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataOrderDetail.Location = new Point(486, 494);
            dgvDataOrderDetail.Name = "dgvDataOrderDetail";
            dgvDataOrderDetail.RowHeadersWidth = 62;
            dgvDataOrderDetail.RowTemplate.Height = 33;
            dgvDataOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataOrderDetail.Size = new Size(837, 171);
            dgvDataOrderDetail.TabIndex = 1;
            dgvDataOrderDetail.CellContentClick += dgvDataOrderDetail_CellClick;
            // 
            // grbxDetail
            // 
            grbxDetail.Controls.Add(label10);
            grbxDetail.Controls.Add(lbProductName);
            grbxDetail.Controls.Add(txtPrice);
            grbxDetail.Controls.Add(txtQuantity);
            grbxDetail.Controls.Add(label9);
            grbxDetail.Controls.Add(label8);
            grbxDetail.Controls.Add(pbProductImage);
            grbxDetail.Location = new Point(9, 293);
            grbxDetail.Name = "grbxDetail";
            grbxDetail.Size = new Size(465, 372);
            grbxDetail.TabIndex = 0;
            grbxDetail.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(78, 15);
            label10.Name = "label10";
            label10.Size = new Size(277, 45);
            label10.TabIndex = 6;
            label10.Text = "Order information";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(6, 87);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(0, 30);
            lbProductName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(346, 262);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(113, 31);
            txtPrice.TabIndex = 4;
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(344, 202);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.RightToLeft = RightToLeft.Yes;
            txtQuantity.Size = new Size(115, 31);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 265);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 2;
            label9.Text = "SubTotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 205);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 1;
            label8.Text = "Quantity:";
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(6, 90);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(244, 241);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 752);
            Controls.Add(panel1);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbxFilter.ResumeLayout(false);
            grbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrder).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrderDetail).EndInit();
            grbxDetail.ResumeLayout(false);
            grbxDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDataOrderDetail;
        private GroupBox grbxDetail;
        private DataGridView dgvDataOrder;
        private GroupBox groupBox2;
        private GroupBox grbxFilter;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbCount;
        private DateTimePicker dtpOrderDate;
        private RichTextBox txtAddress;
        private TextBox txtShipping;
        private TextBox txtProductName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtStatus;
        private Label label7;
        private TextBox txtTotalPrice;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label9;
        private Label label8;
        private PictureBox pbProductImage;
        private Label label10;
        private Label lbProductName;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label label12;
        private Label label11;
    }
}