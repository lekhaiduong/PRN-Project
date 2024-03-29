namespace GreenValleyApp
{
    partial class frmCart
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
            btnUpdate = new Button();
            txtQuantity = new MaskedTextBox();
            btnDeleteItem = new Button();
            button2 = new Button();
            button1 = new Button();
            lbItem = new Label();
            btnBack = new Button();
            grbCartDetail = new GroupBox();
            rtxtAddress = new RichTextBox();
            label4 = new Label();
            btnDeleteAll = new Button();
            txtTotal = new TextBox();
            txtShipping = new TextBox();
            txtSubTotal = new TextBox();
            btnCheckout = new Button();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvCartData = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            grbCartDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCartData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(btnDeleteItem);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbItem);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(grbCartDetail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dgvCartData);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 560);
            panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(656, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(774, 154);
            txtQuantity.Mask = "000";
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(84, 31);
            txtQuantity.TabIndex = 24;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.ValidatingType = typeof(int);
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(694, 511);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(164, 34);
            btnDeleteItem.TabIndex = 23;
            btnDeleteItem.Text = "Delete this item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(774, 114);
            button2.Name = "button2";
            button2.Size = new Size(39, 34);
            button2.TabIndex = 20;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(819, 114);
            button1.Name = "button1";
            button1.Size = new Size(39, 34);
            button1.TabIndex = 19;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbItem
            // 
            lbItem.AutoSize = true;
            lbItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbItem.Location = new Point(32, 139);
            lbItem.Name = "lbItem";
            lbItem.Size = new Size(0, 38);
            lbItem.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 511);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 34);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back to homepage";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // grbCartDetail
            // 
            grbCartDetail.Controls.Add(rtxtAddress);
            grbCartDetail.Controls.Add(label4);
            grbCartDetail.Controls.Add(btnDeleteAll);
            grbCartDetail.Controls.Add(txtTotal);
            grbCartDetail.Controls.Add(txtShipping);
            grbCartDetail.Controls.Add(txtSubTotal);
            grbCartDetail.Controls.Add(btnCheckout);
            grbCartDetail.Controls.Add(label6);
            grbCartDetail.Controls.Add(label3);
            grbCartDetail.Controls.Add(label1);
            grbCartDetail.Location = new Point(878, 15);
            grbCartDetail.Name = "grbCartDetail";
            grbCartDetail.Size = new Size(385, 542);
            grbCartDetail.TabIndex = 15;
            grbCartDetail.TabStop = false;
            grbCartDetail.Text = "Detail";
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(17, 374);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.ReadOnly = true;
            rtxtAddress.Size = new Size(353, 96);
            rtxtAddress.TabIndex = 23;
            rtxtAddress.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 255);
            label4.Name = "label4";
            label4.Size = new Size(362, 25);
            label4.TabIndex = 9;
            label4.Text = "--------------------------------------------------";
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Red;
            btnDeleteAll.ForeColor = SystemColors.ButtonFace;
            btnDeleteAll.Location = new Point(6, 496);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(148, 34);
            btnDeleteAll.TabIndex = 22;
            btnDeleteAll.Text = "Delete all";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(136, 297);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(182, 31);
            txtTotal.TabIndex = 8;
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(136, 152);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(182, 31);
            txtShipping.TabIndex = 7;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(136, 79);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(182, 31);
            txtSubTotal.TabIndex = 6;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.LimeGreen;
            btnCheckout.ForeColor = SystemColors.ButtonHighlight;
            btnCheckout.Location = new Point(231, 496);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(148, 34);
            btnCheckout.TabIndex = 17;
            btnCheckout.Text = "Check out";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 297);
            label6.Name = "label6";
            label6.Size = new Size(64, 30);
            label6.TabIndex = 5;
            label6.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Shipping:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 80);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 1;
            label1.Text = "Sub total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font(".VnArial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(144, 42);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 14;
            label2.Text = "My Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dgvCartData
            // 
            dgvCartData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartData.Location = new Point(18, 191);
            dgvCartData.Name = "dgvCartData";
            dgvCartData.RowHeadersWidth = 62;
            dgvCartData.RowTemplate.Height = 33;
            dgvCartData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartData.Size = new Size(840, 306);
            dgvCartData.TabIndex = 0;
            dgvCartData.CellClick += dgvCartData_CellClick;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 592);
            Controls.Add(panel1);
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += frmCart_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCartDetail.ResumeLayout(false);
            grbCartDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCartData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCartData;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnBack;
        private GroupBox grbCartDetail;
        private Label lbItem;
        private Button btnCheckout;
        private TextBox txtTotal;
        private TextBox txtShipping;
        private TextBox txtSubTotal;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button btnDeleteItem;
        private Button btnDeleteAll;
        private MaskedTextBox txtQuantity;
        private Button btnUpdate;
        private RichTextBox rtxtAddress;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}