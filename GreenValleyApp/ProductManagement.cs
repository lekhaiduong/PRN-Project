using BusinessObject;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmProductManagement : Form
    {
        SmartketContext context = new SmartketContext();
        ICategoriesRepository categoriesRepository = new CategoriesRepository();
        IProductRepository productRepository = new ProductRepository();
        public bool InsertOrUpdate { get; set; }
        public frmProductManagement()
        {
            InitializeComponent();
            cbxCategories.DataSource = context.Categories.Select(x => x.CategoryName).Distinct().ToList();
            cbxCategories.SelectedIndex = 0;
            LoadData();
        }
        private void LoadData()
        {
            string key = txtSearch.Text;

            dgvProduct.DataSource = context.Products.Include(x => x.Category).Where(x => x.CategoryId == x.Category.CategoryId
            && x.ProductName.Contains(key)).Select(x => new
            {
                x.ProductId,
                x.ProductName,
                Category = x.Category.CategoryName,
                CategoryId = x.Category.CategoryId,
                x.UnitPrice,
                x.Discount,
                x.UnitInStock,
                ProductImage = x.ProductImage,
                ProductDescription = x.ProductDescription
            }).ToList();
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                if (column.Name == "ProductID" || column.Name == "CategoryId"
                    || column.Name == "ProductImage"
                    || column.Name == "ProductDescription")
                {
                    column.Visible = false;
                }
            }
            if (dgvProduct.Rows.Count > 0)
            {
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dgvProduct_CellClick(dgvProduct, args);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];
                txtProductID.Text = selectedRow.Cells["ProductId"].Value.ToString();
                txtProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                Category cate = categoriesRepository.GetCategoryByID((int)selectedRow.Cells["CategoryId"].Value);
                if (cate != null)
                {
                    cbxCategories.SelectedItem = cate.CategoryName;
                }
                txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value.ToString();
                txtDiscount.Text = selectedRow.Cells["Discount"].Value.ToString();
                txtUnitsInStock.Text = selectedRow.Cells["UnitInStock"].Value.ToString();
                pbProductImage.ImageLocation
                    = $"D:\\fpt\\Semeter_5\\PRN211\\Project\\GreenValleyApp\\Images\\{selectedRow.Cells["ProductImage"].Value.ToString()}";
                rtxtDescription.Text = selectedRow.Cells["ProductDescription"].Value.ToString() == null ? "This product dont have description" : selectedRow.Cells["ProductDescription"].Value.ToString();

            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmP = new frmProductDetails
            {
                productInfo = GetProductObject(),
                Text = "Add a Product",
                InsertOrUpdate = false,
                productRepo = productRepository
            };
            if (frmP.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails frmP = new frmProductDetails
            {
                Text = "Update a product",
                InsertOrUpdate = true,
                productInfo = GetProductObject(),
                productRepo = productRepository
            };
            if (frmP.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                int productId = int.Parse(txtProductID.Text);
                string categoryName = cbxCategories.SelectedItem.ToString();
                Category selectedCategory = context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                if (selectedCategory != null)
                {
                    int categoryId = selectedCategory.CategoryId;
                    string productName = txtProductName.Text;
                    int discount = Convert.ToInt32(txtDiscount.Text);
                    double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    int unitInStock = Convert.ToInt32(txtUnitsInStock.Text);
                    string productDescription = rtxtDescription.Text;
                    string productImage = pbProductImage.ImageLocation;

                    product = new Product
                    {
                        ProductId = productId,
                        CategoryId = categoryId,
                        ProductName = productName,
                        Discount = discount,
                        UnitPrice = unitPrice,
                        UnitInStock = unitInStock,
                        ProductDescription = productDescription,
                        ProductImage = productImage
                    };
                }
                else
                {
                    MessageBox.Show("Selected category not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": Error while getting product");
            }
            return product;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        int ProductID = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductID"].Value.ToString());
                        Product product = context.Products.Where(x => x.ProductId == ProductID).SingleOrDefault();
                        if (product != null)
                        {
                            context.Remove(product);
                            context.SaveChanges();
                            MessageBox.Show("delete successful");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Can find any product");
                            return;
                        }
                        break;

                    case DialogResult.No:
                        return;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
