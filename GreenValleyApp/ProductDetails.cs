using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenValleyApp
{
    public partial class frmProductDetails : Form
    {
        SmartketContext context = new SmartketContext();
        public IProductRepository productRepo { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product productInfo { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
            cbxCategories.DataSource = context.Categories.Select(x => x.CategoryName).Distinct().ToList();
            txtProductID.Enabled = !InsertOrUpdate;
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (InsertOrUpdate && productInfo != null)
            {
                txtProductID.Text = productInfo.ProductId.ToString();
                Category checkCate = context.Categories.FirstOrDefault(c => c.CategoryId == productInfo.CategoryId);
                cbxCategories.SelectedItem = checkCate.CategoryName;
                txtProductName.Text = productInfo.ProductName;
                nudDiscount.Value = Convert.ToDecimal(productInfo.Discount);
                txtUnitPrice.Text = productInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = productInfo.UnitInStock.ToString();
                rtxtDescription.Text = productInfo.ProductDescription;
                pbProdcutImage.ImageLocation = productInfo.ProductImage;
            }
            else
            {
                string id = context.Products.Max(x => x.ProductId).ToString();
                txtProductID.Text = (Convert.ToInt32(id) + 1).ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = cbxCategories.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            Category selectedCategory = context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
            if (selectedCategory != null)
            {
                var product = new Product()
                {
                    CategoryId = selectedCategory.CategoryId,
                    ProductName = txtProductName.Text,
                    Discount = Convert.ToInt32(nudDiscount.Value),
                    UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitsInStock.Text),
                    ProductDescription = rtxtDescription.Text,
                    ProductImage = "Product/" + Path.GetFileName(pbProdcutImage.ImageLocation)
                };

                if (!InsertOrUpdate)
                {
                    context.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Product added successfully.");

                }
                else
                {
                    product.ProductId = Convert.ToInt32(txtProductID.Text);
                    context.Update(product);
                    context.SaveChanges();
                    MessageBox.Show("Product updated successfully.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(open.FileName);
                lbImageName.Text = fileName;
                pbProdcutImage.Image = new Bitmap(open.FileName);

                string destinationPath = Path.Combine(@"D:\fpt\Semeter_5\PRN211\Project\GreenValleyApp\Images\product\", fileName);
                File.Copy(open.FileName, destinationPath, true);
                pbProdcutImage.ImageLocation = destinationPath;
            }
        }
    }
}
