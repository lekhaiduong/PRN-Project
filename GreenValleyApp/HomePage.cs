using System.Data;
using System.Globalization;
using BusinessObject;
using DataAccess.Repository;
namespace GreenValleyApp
{

    public partial class frmHomePage : Form
    {
        SmartketContext context = new SmartketContext();
        IProductRepository productRepository = new ProductRepository();
        ICategoriesRepository categoriesRepository = new CategoriesRepository();
        IUserRepository userRepository = new UserRepository();
        ICartRepository cartRepository = new CartRepository();

        private object selectedRow;

        public frmHomePage()
        {
            InitializeComponent();
            // Setup ComboBoxes
            cbxCategories.Items.Clear();
            cbxCategories.Items.Add("All");
            cbxCategories.SelectedIndex = 0;
            cbxSorting.SelectedIndex = 0;
            // Load Categories
            List<Category> categories = context.Categories.ToList();
            foreach (Category category in categories)
            {
                cbxCategories.Items.Add(category.CategoryName);
            }
            LoadData();
            cbxCategories.SelectedIndexChanged += new System.EventHandler(GroupBoxComboBoxChange);
            cbxSorting.SelectedIndexChanged += new System.EventHandler(GroupBoxComboBoxChange);
            txtSearch.TextChanged += new System.EventHandler(GroupBoxComboBoxChange);
            txtMinPrice.TextChanged += new System.EventHandler(GroupBoxComboBoxChange);
            txtMaxPrice.TextChanged += new System.EventHandler(GroupBoxComboBoxChange);
            if (dgvProduct.Rows.Count > 0)
            {
                processCell(new DataGridViewCellEventArgs(0, 0));
            }
        }
        #region load data from database to datagridview

        private void LoadData()
        {
            // Keyword search filter
            string keyword = txtSearch.Text.ToLower();

            // Price filter
            double? minPrice = string.IsNullOrWhiteSpace(txtMinPrice.Text) ?
                context.Products.Min(p => (double?)p.UnitPrice) :
                double.Parse(txtMinPrice.Text);

            double? maxPrice = string.IsNullOrWhiteSpace(txtMaxPrice.Text) ?
                context.Products.Max(p => (double?)p.UnitPrice) :
                double.Parse(txtMaxPrice.Text);

            // Category filter
            int selectedCategoryId = cbxCategories.SelectedIndex == 0 ? 0 :
                context.Categories.FirstOrDefault(c => c.CategoryName == cbxCategories.SelectedItem.ToString())?.CategoryId ?? 0;

            // Sorting filter
            switch (cbxSorting.SelectedItem.ToString())
            {
                case "Ascending Price":
                    #region order by unit price ascending
                    var query = from p in context.Products
                                join c in context.Categories on p.CategoryId equals c.CategoryId
                                where (selectedCategoryId == 0 || p.CategoryId == selectedCategoryId) &&
                                      (string.IsNullOrWhiteSpace(keyword) || p.ProductName.ToLower().Contains(keyword)) &&
                                      (minPrice == null || p.UnitPrice >= minPrice) &&
                                      (maxPrice == null || p.UnitPrice <= maxPrice)
                                orderby p.UnitPrice ascending
                                select new
                                {
                                    p.ProductId,
                                    p.ProductName,
                                    c.CategoryName,
                                    p.UnitPrice,
                                    p.Discount,
                                    p.UnitInStock
                                };
                    dgvProduct.DataSource = query.ToList();
                    #endregion
                    break;

                case "Descending Price":
                    #region order by unit price descending
                    var query2 = from p in context.Products
                                 join c in context.Categories on p.CategoryId equals c.CategoryId
                                 where (selectedCategoryId == 0 || p.CategoryId == selectedCategoryId) &&
                                       (string.IsNullOrWhiteSpace(keyword) || p.ProductName.ToLower().Contains(keyword)) &&
                                       (minPrice == null || p.UnitPrice >= minPrice) &&
                                       (maxPrice == null || p.UnitPrice <= maxPrice)
                                 orderby p.UnitPrice descending
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     c.CategoryName,
                                     p.UnitPrice,
                                     p.Discount,
                                     p.UnitInStock
                                 };
                    dgvProduct.DataSource = query2.ToList();
                    #endregion
                    break;
                case "Ascending name":
                    #region order by unit name ascending
                    var query3 = from p in context.Products
                                 join c in context.Categories on p.CategoryId equals c.CategoryId
                                 where (selectedCategoryId == 0 || p.CategoryId == selectedCategoryId) &&
                                       (string.IsNullOrWhiteSpace(keyword) || p.ProductName.ToLower().Contains(keyword)) &&
                                       (minPrice == null || p.UnitPrice >= minPrice) &&
                                       (maxPrice == null || p.UnitPrice <= maxPrice)
                                 orderby p.ProductName ascending
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     c.CategoryName,
                                     p.UnitPrice,
                                     p.Discount,
                                     p.UnitInStock
                                 };
                    dgvProduct.DataSource = query3.ToList();
                    break;
                #endregion
                case "Descending name":
                    #region order by unit name descending
                    var query4 = from p in context.Products
                                 join c in context.Categories on p.CategoryId equals c.CategoryId
                                 where (selectedCategoryId == 0 || p.CategoryId == selectedCategoryId) &&
                                       (string.IsNullOrWhiteSpace(keyword) || p.ProductName.ToLower().Contains(keyword)) &&
                                       (minPrice == null || p.UnitPrice >= minPrice) &&
                                       (maxPrice == null || p.UnitPrice <= maxPrice)
                                 orderby p.ProductName descending
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     c.CategoryName,
                                     p.UnitPrice,
                                     p.Discount,
                                     p.UnitInStock
                                 };
                    dgvProduct.DataSource = query4.ToList();
                    #endregion
                    break;
                default:
                    #region defaultL order by Id
                    var query5 = from p in context.Products
                                 join c in context.Categories on p.CategoryId equals c.CategoryId
                                 where (selectedCategoryId == 0 || p.CategoryId == selectedCategoryId) &&
                                       (string.IsNullOrWhiteSpace(keyword) || p.ProductName.ToLower().Contains(keyword)) &&
                                       (minPrice == null || p.UnitPrice >= minPrice) &&
                                       (maxPrice == null || p.UnitPrice <= maxPrice)
                                 orderby p.ProductId ascending
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     c.CategoryName,
                                     p.UnitPrice,
                                     p.Discount,
                                     p.UnitInStock
                                 };
                    dgvProduct.DataSource = query5.ToList();
                    #endregion
                    break;
            }
            // LINQ query with placeholders for dynamic conditions


        }
        #endregion

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Call the processCell method and pass the event arguments
            processCell(e);
        }
        #region logic code when click a cell
        private void processCell(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];
                string ProductID = selectedRow.Cells["ProductID"].Value.ToString();
                Product pro = productRepository.GetProductByID(Convert.ToInt32(ProductID));
                pbProductImage.ImageLocation = $"D:\\fpt\\Semeter_5\\PRN211\\Project\\GreenValleyApp\\Images\\{pro.ProductImage}";
                lbProductName.Text = pro.ProductName;
                double unitPrice = pro.UnitPrice.HasValue ? pro.UnitPrice.Value : 0.0;
                double discount = pro.Discount.HasValue ? pro.Discount.Value : 0.0;
                txtPrice.Text = ConvertToVietnameseCurrency(unitPrice);

                richTextBox1.Text = pro.ProductDescription;
                if (pro.Discount > 0)
                {
                    lbFinalPrice.Visible = true;
                    lbSale.Visible = true;
                    txtDiscount.Visible = true;
                    txtSale.Visible = true;
                    //set new location
                    lbFirstPrice.Location = new Point(340, 97);
                    txtPrice.Location = new Point(443, 92);

                    lbAvailable.Location = new Point(620, 95);
                    txtStock.Location = new Point(709, 86);
                    txtDiscount.Text = ConvertToVietnameseCurrency(unitPrice * (100 - discount) / 100);
                    txtSale.Text = pro.Discount + "%";
                    txtStock.Text = pro.UnitInStock.ToString();
                }
                else
                {
                    lbFinalPrice.Visible = false;
                    lbSale.Visible = false;
                    txtDiscount.Visible = false;
                    txtSale.Visible = false;
                    //set new location
                    lbFirstPrice.Location = new Point(340, 151);
                    txtPrice.Location = new Point(443, 145);
                    lbAvailable.Location = new Point(620, 151);
                    txtStock.Location = new Point(709, 145);
                    txtDiscount.Text = ConvertToVietnameseCurrency(unitPrice * (100 - discount) / 100);
                    txtSale.Text = pro.Discount + "%";
                    txtStock.Text = pro.UnitInStock.ToString();
                }
            }
        }
        #endregion
        #region convert to vietnamese currency (10000 -> 10.000)
        private string ConvertToVietnameseCurrency(double number)
        {
            // Create a NumberFormatInfo for Vietnamese culture
            var vietnameseCulture = new CultureInfo("vi-VN");
            NumberFormatInfo numberFormat = vietnameseCulture.NumberFormat;

            // Format the number using Vietnamese currency format
            return number.ToString("N0", numberFormat);
        }
        #endregion
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int? Quantity = 0;
            string ProductName = "";
            int UnitInStock = 0;
            string email = "", password = "";
            email = frmLogin.userSession.Email;
            password = frmLogin.userSession.Password;
            User user = context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if (dgvProduct.SelectedRows.Count > 0)
            {
                ProductName = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
                UnitInStock = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["UnitInStock"].Value.ToString());
            }
            if (user != null)
            {
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    string productIDString = dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString();
                    int productID;
                    if (int.TryParse(productIDString, out productID))
                    {
                        Cart checkCart = context.Carts.FirstOrDefault(cart => cart.UserId == user.UserId && cart.ProductId == productID);

                        if (checkCart == null)
                        {
                            Cart cart = new Cart
                            {
                                UserId = user.UserId,
                                ProductId = Convert.ToInt32(productID),
                                Quantity = 1
                            };
                            try
                            {
                                if (UnitInStock >= 1)
                                {
                                    context.Add(cart);
                                    context.SaveChanges();
                                    MessageBox.Show("Added successfully!");
                                    frmCustomer customer = new frmCustomer();
                                    customer.msCart_Click();
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, this product is out of stock", "Out of Stock");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                            }
                        }
                        else
                        {
                            checkCart.Quantity = checkCart.Quantity + 1;

                            try
                            {
                                context.Update(checkCart);
                                context.SaveChanges();
                                MessageBox.Show("Quantity updated successfully!");
                                frmCustomer customer = new frmCustomer();
                                customer.msCart_Click();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User is null");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GroupBoxComboBoxChange(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMinPrice_Click(object sender, EventArgs e)
        {
            txtMinPrice.SelectAll();
        }

        private void txtMaxPrice_Click(object sender, EventArgs e)
        {
            txtMaxPrice.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
