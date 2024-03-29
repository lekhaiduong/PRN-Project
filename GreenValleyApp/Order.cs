using BusinessObject;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmOrder : Form
    {
        SmartketContext context = new SmartketContext();
        IOrderRepository orderRepository = new OrderRepository();
        IUserRepository userRepository = new UserRepository();
        public frmOrder()
        {
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
            txtQuantity.Visible = false;
            txtPrice.Visible = false;
            LoadData();
            var orders = context.Orders.Where(o => o.OrderDate != null).ToList();
            if (orders.Any())
            {
                dtpFromDate.Value = orders.Min(o => o.OrderDate.Value);
                dtpToDate.Value = orders.Max(o => o.OrderDate.Value);
            }
            else
            {
                dtpFromDate.Value = DateTime.Now;
                dtpToDate.Value = DateTime.Now;
            }
         
            dtpFromDate.ValueChanged += new System.EventHandler(GroupBoxComboBoxChange);
            dtpOrderDate.ValueChanged += new System.EventHandler(GroupBoxComboBoxChange);
            
        }
        public void LoadData()
        {
            frmLogin login = new frmLogin();
            User u = frmLogin.userSession;
            dgvDataOrder.DataSource =
                context.Orders.Where(x => x.OrderDate <= dtpToDate.Value && x.OrderDate >= dtpFromDate.Value
                && x.UserId == u.UserId).Select(x => new
                {
                    x.OrderId,
                    x.UserId,
                    x.TotalPrice,
                    x.TotalQuantity,
                    x.OrderDate,
                    ShippedDate = (x.ShippedDate == null) ? "In process" : x.ShippedDate.ToString()
                }).ToList();

            foreach (DataGridViewColumn column in dgvDataOrder.Columns)
            {
                if (column.Name == "UserId")
                {
                    column.Visible = false;
                }
            }

        }

        private void dgvDataOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDataOrder.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDataOrder.Rows[e.RowIndex];
                int orderID = (int)dgvDataOrder.Rows[e.RowIndex].Cells["OrderID"].Value;
                dgvDataOrderDetail.DataSource = context.OrderDetails.Include(x => x.Product)
                    .Where(x => x.OrderId == orderID).Select(o => new
                    {
                        o.Product.ProductName,
                        o.Product.ProductImage,
                        o.QuantityPerUnit,
                        price = o.Product.UnitPrice,
                        UnitPrice = o.UnitPrice + "d",
                        Discount = o.Discount == 0 ? "None" : +o.Discount + "%"
                    }).ToList();
                dgvDataOrderDetail.Columns[0].Width = 250;
                foreach (DataGridViewColumn column in dgvDataOrderDetail.Columns)
                {
                    if (column.Name == "ProductImage" || column.Name == "price")
                    {
                        column.Visible = false;
                    }
                }
                Order o = orderRepository.GetOrderByID(orderID);
                if (o != null)
                {
                    User u = userRepository.GetUserByID(o.UserId.Value);
                    Status s = context.Statuses.Where(x => x.StatusId == o.StatusId).SingleOrDefault();
                    txtProductName.Text = u.Email;
                    txtAddress.Text = u.Address;
                    txtTotalPrice.Text = o.TotalPrice.ToString();
                    dtpOrderDate.Value = o.OrderDate.Value;
                    txtShipping.Text = "8000";
                    txtStatus.Text = s.StatusName;
                }
            }
        }

        private void dgvDataOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            txtQuantity.Visible = true;
            txtPrice.Visible = true;
            if (e.RowIndex >= 0 && e.RowIndex < dgvDataOrderDetail.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDataOrderDetail.Rows[e.RowIndex];
                string url = (string)selectedRow.Cells["ProductImage"].Value;
                double price = (double)selectedRow.Cells["price"].Value;
                int quantity = (int)selectedRow.Cells["QuantityPerUnit"].Value;
                pbProductImage.ImageLocation = $"D:\\fpt\\Semeter_5\\PRN211\\Project\\GreenValleyApp\\Images\\{url}";
                txtQuantity.Text = quantity.ToString();
                txtPrice.Text = price.ToString();
            }
        }
        private void GroupBoxComboBoxChange(object sender, EventArgs e)
        {
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("Input date again! "+dtpFromDate.Value.ToString() + " > "+dtpToDate.Value.ToString());
                dtpFromDate.Value = dtpToDate.Value;
            }
            else
            {
                LoadData();
            }
        }
    }
}
