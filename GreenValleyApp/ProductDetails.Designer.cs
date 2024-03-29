namespace GreenValleyApp
{
    partial class frmProductDetails
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
            nudDiscount = new NumericUpDown();
            txtProductID = new TextBox();
            txtUnitsInStock = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbDiscount = new Label();
            lbProductName = new Label();
            lbCategoryID = new Label();
            lbProductID = new Label();
            lbNotify = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            rtxtDescription = new RichTextBox();
            btnUpload = new Button();
            pbProdcutImage = new PictureBox();
            lbImageName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProdcutImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxCategories);
            panel1.Controls.Add(nudDiscount);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(txtUnitsInStock);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtUnitPrice);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(lbUnitsInStock);
            panel1.Controls.Add(lbUnitPrice);
            panel1.Controls.Add(lbDiscount);
            panel1.Controls.Add(lbProductName);
            panel1.Controls.Add(lbCategoryID);
            panel1.Controls.Add(lbProductID);
            panel1.Location = new Point(35, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 439);
            panel1.TabIndex = 0;
            // 
            // cbxCategories
            // 
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Location = new Point(214, 88);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(159, 33);
            cbxCategories.TabIndex = 31;
            // 
            // nudDiscount
            // 
            nudDiscount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudDiscount.Location = new Point(214, 195);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(279, 31);
            nudDiscount.TabIndex = 30;
            nudDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(214, 37);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(279, 31);
            txtProductID.TabIndex = 29;
            txtProductID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(214, 293);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(279, 31);
            txtUnitsInStock.TabIndex = 28;
            txtUnitsInStock.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(214, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(381, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(214, 243);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(279, 31);
            txtUnitPrice.TabIndex = 26;
            txtUnitPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(214, 137);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(279, 31);
            txtProductName.TabIndex = 24;
            txtProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(82, 299);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(112, 25);
            lbUnitsInStock.TabIndex = 23;
            lbUnitsInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(82, 243);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(86, 25);
            lbUnitPrice.TabIndex = 22;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(82, 195);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(82, 25);
            lbDiscount.TabIndex = 21;
            lbDiscount.Text = "Discount";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(82, 137);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(126, 25);
            lbProductName.TabIndex = 20;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(82, 88);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(84, 25);
            lbCategoryID.TabIndex = 19;
            lbCategoryID.Text = "Category";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(82, 37);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(97, 25);
            lbProductID.TabIndex = 18;
            lbProductID.Text = "Product ID";
            // 
            // lbNotify
            // 
            lbNotify.AutoSize = true;
            lbNotify.BackColor = Color.FromArgb(128, 255, 128);
            lbNotify.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotify.Location = new Point(180, 28);
            lbNotify.Name = "lbNotify";
            lbNotify.Size = new Size(0, 48);
            lbNotify.TabIndex = 54;
            lbNotify.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rtxtDescription);
            groupBox1.Controls.Add(btnUpload);
            groupBox1.Controls.Add(pbProdcutImage);
            groupBox1.Location = new Point(599, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 439);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 292);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 3;
            label1.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(6, 320);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(304, 107);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(107, 241);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pbProdcutImage
            // 
            pbProdcutImage.Location = new Point(26, 30);
            pbProdcutImage.Name = "pbProdcutImage";
            pbProdcutImage.Size = new Size(265, 204);
            pbProdcutImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProdcutImage.TabIndex = 0;
            pbProdcutImage.TabStop = false;
            // 
            // lbImageName
            // 
            lbImageName.AutoSize = true;
            lbImageName.Location = new Point(625, 35);
            lbImageName.Name = "lbImageName";
            lbImageName.Size = new Size(0, 25);
            lbImageName.TabIndex = 56;
            lbImageName.Visible = false;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 555);
            Controls.Add(lbImageName);
            Controls.Add(groupBox1);
            Controls.Add(lbNotify);
            Controls.Add(panel1);
            Name = "frmProductDetails";
            Text = "ProductDetails";
            Load += frmProductDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProdcutImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtProductID;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbDiscount;
        private Label lbProductName;
        private Label lbCategoryID;
        private Label lbProductID;
        private Button btnCancel;
        private Button btnSave;
        private Label lbNotify;
        private NumericUpDown nudDiscount;
        private ComboBox cbxCategories;
        private GroupBox groupBox1;
        private PictureBox pbProdcutImage;
        private Label label1;
        private RichTextBox rtxtDescription;
        private Button btnUpload;
        private Label lbImageName;
    }
}