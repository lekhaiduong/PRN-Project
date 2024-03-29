using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GreenValleyApp
{
    public partial class dashboard : Form
    {

        SmartketContext context = new SmartketContext();
        private List<Product> products;
        private int currentIndex = 0;
        public dashboard()
        {
            InitializeComponent();
            groupBox2.MouseDoubleClick += GroupBox2_DoubleClick;
            groupBox3.MouseDoubleClick += GroupBo3_DoubleClick;
            groupBox4.MouseDoubleClick += GroupBox4_DoubleClick;
            LoadData();
        }

        private void GroupBox4_DoubleClick(object? sender, MouseEventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.msUser_Click();
        }

        private void GroupBox2_DoubleClick(object? sender, MouseEventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.msProduct_Click();
        }

        private void GroupBo3_DoubleClick(object? sender, MouseEventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.msOrder_Click();
        }

        public void LoadData()
        {
            //start overall product
            txtTotalProduct.Text = context.Products.Count().ToString();
            txtTotalCategories.Text = context.Categories.Count().ToString();
            //end overrall product

            //start overall user
            txtTotalUser.Text = context.Users.Count().ToString();
            txtTotalDeactivate.Text = context.Users.Where(x => x.UserStatus == false).Count().ToString();
            //end overrall user

            //start overall order
            txtTotalOrder.Text = context.Orders.Count().ToString();
            txtRevenue.Text = context.Orders.Where(x=>x.StatusId == 3).Select(x => x.TotalPrice).Sum().ToString() + " VND";
            //end overrall order

            //start order infor
            txtOrder1.Text = context.Orders.Where(x => x.StatusId == 1).Count().ToString();
            txtOrder2.Text = context.Orders.Where(x => x.StatusId == 2).Count().ToString();
            txtOrder3.Text = context.Orders.Where(x => x.StatusId == 3).Count().ToString();
            //end order infor

            //start feature product
            LoadTopProducts();

        }

        private void LoadTopProducts()
        {
            products = context.Products.OrderBy(product => product.UnitInStock).Take(5).ToList();
            ShowProductAtIndex(currentIndex);
        }

        private void ShowProductAtIndex(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                btnCount.Text = (index+1).ToString();
                Product product = products[index];
                name.Text = product.ProductName;
                pbFeatureImageProduct.ImageLocation = $"D:\\fpt\\Semeter_5\\PRN211\\Project\\GreenValleyApp\\Images\\{product.ProductImage}";
                txtSold.Text = "Product's Sold: "+(100 - product.UnitInStock).ToString();
                txtFeaturePrice.Text = product.UnitPrice.ToString() + " VND";
                txtFeatureUnitInStock.Text = product.UnitInStock.ToString();
                txtFeatureDiscount.Text = product.Discount > 0 ? product.Discount.ToString() + "%" : "None";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= products.Count)
            {
                currentIndex = 0;
            }
            ShowProductAtIndex(currentIndex);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
