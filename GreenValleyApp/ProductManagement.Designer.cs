namespace GreenValleyApp
{
    partial class frmProductManagement
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
            cbxCategories = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            dgvProduct = new DataGridView();
            lbNotify = new Label();
            txtProductID = new TextBox();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtDiscount = new TextBox();
            txtProductName = new TextBox();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbProductName = new Label();
            lbCategoryID = new Label();
            lbProductID = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            rtxtDescription = new RichTextBox();
            pbProductImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxCategories);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(dgvProduct);
            panel1.Controls.Add(lbNotify);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(txtUnitsInStock);
            panel1.Controls.Add(txtUnitPrice);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(lbUnitsInStock);
            panel1.Controls.Add(lbUnitPrice);
            panel1.Controls.Add(lbWeight);
            panel1.Controls.Add(lbProductName);
            panel1.Controls.Add(lbCategoryID);
            panel1.Controls.Add(lbProductID);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 652);
            panel1.TabIndex = 1;
            // 
            // cbxCategories
            // 
            cbxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Location = new Point(164, 187);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(279, 33);
            cbxCategories.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(683, 291);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 60;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(753, 288);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search...";
            txtSearch.Size = new Size(201, 31);
            txtSearch.TabIndex = 59;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(198, 288);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 56;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(32, 288);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 55;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(32, 336);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(922, 251);
            dgvProduct.TabIndex = 54;
            dgvProduct.CellClick += dgvProduct_CellClick;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            // 
            // lbNotify
            // 
            lbNotify.AutoSize = true;
            lbNotify.BackColor = Color.FromArgb(128, 255, 128);
            lbNotify.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotify.Location = new Point(310, 9);
            lbNotify.Name = "lbNotify";
            lbNotify.Size = new Size(376, 48);
            lbNotify.TabIndex = 53;
            lbNotify.Text = "Product management";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(164, 84);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(279, 31);
            txtProductID.TabIndex = 52;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(675, 184);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(279, 31);
            txtUnitsInStock.TabIndex = 51;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(675, 80);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(279, 31);
            txtUnitPrice.TabIndex = 50;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(675, 131);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(279, 31);
            txtDiscount.TabIndex = 49;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(164, 141);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(279, 31);
            txtProductName.TabIndex = 47;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(557, 187);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(112, 25);
            lbUnitsInStock.TabIndex = 46;
            lbUnitsInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(557, 131);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(82, 25);
            lbUnitPrice.TabIndex = 45;
            lbUnitPrice.Text = "Discount";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(557, 80);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(87, 25);
            lbWeight.TabIndex = 44;
            lbWeight.Text = "Unit price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(32, 144);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(126, 25);
            lbProductName.TabIndex = 43;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(32, 187);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(84, 25);
            lbCategoryID.TabIndex = 42;
            lbCategoryID.Text = "Category";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(32, 84);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(97, 25);
            lbProductID.TabIndex = 41;
            lbProductID.Text = "Product ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rtxtDescription);
            groupBox1.Controls.Add(pbProductImage);
            groupBox1.Location = new Point(987, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 587);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 0);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(137, 24);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 3;
            label3.Text = "Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(119, 369);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(6, 402);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ReadOnly = true;
            rtxtDescription.Size = new Size(351, 144);
            rtxtDescription.TabIndex = 1;
            rtxtDescription.Text = "";
            // 
            // pbProductImage
            // 
            pbProductImage.BorderStyle = BorderStyle.FixedSingle;
            pbProductImage.Location = new Point(34, 62);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(296, 238);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 653);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private DataGridView dgvProduct;
        private Label lbNotify;
        private TextBox txtProductID;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtDiscount;
        private TextBox txtProductName;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbProductName;
        private Label lbCategoryID;
        private Label lbProductID;
        private ComboBox cbxCategories;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private RichTextBox rtxtDescription;
        private PictureBox pbProductImage;
    }
}