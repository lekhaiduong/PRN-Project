namespace GreenValleyApp
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            cbxCategories = new ComboBox();
            label3 = new Label();
            cbxSorting = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            label4 = new Label();
            grbPrice = new GroupBox();
            txtMaxPrice = new MaskedTextBox();
            txtMinPrice = new MaskedTextBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pbProductImage = new PictureBox();
            groupBox1 = new GroupBox();
            txtSale = new TextBox();
            lbSale = new Label();
            txtStock = new TextBox();
            lbAvailable = new Label();
            btnAddCart = new Button();
            grbDescription = new GroupBox();
            richTextBox1 = new RichTextBox();
            txtDiscount = new TextBox();
            lbFinalPrice = new Label();
            txtPrice = new TextBox();
            lbFirstPrice = new Label();
            lbProductName = new Label();
            dgvProduct = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnExit = new Button();
            grbPrice.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            groupBox1.SuspendLayout();
            grbDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxCategories
            // 
            cbxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategories.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Location = new Point(16, 121);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(226, 33);
            cbxCategories.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 5;
            label3.Text = "Categories";
            // 
            // cbxSorting
            // 
            cbxSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSorting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSorting.FormattingEnabled = true;
            cbxSorting.Items.AddRange(new object[] { "All", "Ascending Price", "Descending Price", "Ascending name", "Descending name" });
            cbxSorting.Location = new Point(16, 193);
            cbxSorting.Name = "cbxSorting";
            cbxSorting.Size = new Size(226, 33);
            cbxSorting.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 167);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 3;
            label1.Text = "Sorting";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(16, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search here...";
            txtSearch.Size = new Size(226, 31);
            txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 111);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 1;
            label5.Text = "Max price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 53);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 0;
            label4.Text = "Min price";
            // 
            // grbPrice
            // 
            grbPrice.Controls.Add(txtMaxPrice);
            grbPrice.Controls.Add(txtMinPrice);
            grbPrice.Controls.Add(label5);
            grbPrice.Controls.Add(label4);
            grbPrice.Location = new Point(16, 247);
            grbPrice.Name = "grbPrice";
            grbPrice.Size = new Size(281, 254);
            grbPrice.TabIndex = 7;
            grbPrice.TabStop = false;
            grbPrice.Text = "Price";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaxPrice.Location = new Point(107, 111);
            txtMaxPrice.Mask = "0000000000";
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(150, 31);
            txtMaxPrice.TabIndex = 5;
            txtMaxPrice.Click += txtMaxPrice_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMinPrice.Location = new Point(107, 46);
            txtMinPrice.Mask = "0000000000";
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(150, 31);
            txtMinPrice.TabIndex = 4;
            txtMinPrice.ValidatingType = typeof(int);
            txtMinPrice.Click += txtMinPrice_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grbPrice);
            groupBox2.Controls.Add(cbxCategories);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbxSorting);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 507);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(214, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(6, 79);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(305, 264);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSale);
            groupBox1.Controls.Add(lbSale);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(lbAvailable);
            groupBox1.Controls.Add(btnAddCart);
            groupBox1.Controls.Add(grbDescription);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(lbFinalPrice);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(lbFirstPrice);
            groupBox1.Controls.Add(lbProductName);
            groupBox1.Controls.Add(pbProductImage);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(344, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 351);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtSale
            // 
            txtSale.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSale.Location = new Point(709, 145);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(80, 34);
            txtSale.TabIndex = 11;
            // 
            // lbSale
            // 
            lbSale.AutoSize = true;
            lbSale.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSale.Location = new Point(620, 151);
            lbSale.Name = "lbSale";
            lbSale.Size = new Size(82, 25);
            lbSale.TabIndex = 10;
            lbSale.Text = "Discount";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(709, 86);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(80, 34);
            txtStock.TabIndex = 9;
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAvailable.Location = new Point(620, 95);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new Size(83, 25);
            lbAvailable.TabIndex = 8;
            lbAvailable.Text = "Available";
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.FromArgb(0, 192, 0);
            btnAddCart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(838, 145);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(151, 34);
            btnAddCart.TabIndex = 7;
            btnAddCart.Text = "Add to cart";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // grbDescription
            // 
            grbDescription.Controls.Add(richTextBox1);
            grbDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grbDescription.Location = new Point(332, 186);
            grbDescription.Name = "grbDescription";
            grbDescription.Size = new Size(657, 153);
            grbDescription.TabIndex = 6;
            grbDescription.TabStop = false;
            grbDescription.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(633, 114);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.Location = new Point(443, 145);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(150, 34);
            txtDiscount.TabIndex = 5;
            // 
            // lbFinalPrice
            // 
            lbFinalPrice.AutoSize = true;
            lbFinalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbFinalPrice.Location = new Point(340, 151);
            lbFinalPrice.Name = "lbFinalPrice";
            lbFinalPrice.Size = new Size(91, 25);
            lbFinalPrice.TabIndex = 4;
            lbFinalPrice.Text = "Final price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(443, 92);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 34);
            txtPrice.TabIndex = 3;
            // 
            // lbFirstPrice
            // 
            lbFirstPrice.AutoSize = true;
            lbFirstPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstPrice.Location = new Point(340, 97);
            lbFirstPrice.Name = "lbFirstPrice";
            lbFirstPrice.Size = new Size(88, 25);
            lbFirstPrice.TabIndex = 2;
            lbFirstPrice.Text = "First price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(52, 33);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(0, 32);
            lbProductName.TabIndex = 1;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(344, 402);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(989, 225);
            dgvProduct.TabIndex = 13;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font(".VnArial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 39);
            label2.Name = "label2";
            label2.Size = new Size(187, 38);
            label2.TabIndex = 12;
            label2.Text = "Home Page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dgvProduct);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 680);
            panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1206, 643);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 34);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 691);
            Controls.Add(panel1);
            Name = "frmHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            grbPrice.ResumeLayout(false);
            grbPrice.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxCategories;
        private Label label3;
        private ComboBox cbxSorting;
        private Label label1;
        private TextBox txtSearch;
        private Label label5;
        private Label label4;
        private GroupBox grbPrice;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private PictureBox pbProductImage;
        private GroupBox groupBox1;
        private DataGridView dgvProduct;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lbProductName;
        private Label lbFinalPrice;
        private TextBox txtPrice;
        private Label lbFirstPrice;
        private TextBox txtDiscount;
        private GroupBox grbDescription;
        private RichTextBox richTextBox1;
        private Button btnAddCart;
        private TextBox txtStock;
        private Label lbAvailable;
        private TextBox txtSale;
        private Label lbSale;
        private MaskedTextBox txtMaxPrice;
        private MaskedTextBox txtMinPrice;
        private Button btnExit;
    }
}