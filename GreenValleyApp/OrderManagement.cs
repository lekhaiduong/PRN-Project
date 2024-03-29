using BusinessObject;
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

namespace GreenValleyApp
{
    public partial class frmOrderManagement : Form
    {
        SmartketContext context = new SmartketContext();
        int OrderID = 0;
        public frmOrderManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvOrder.DataSource = context.Orders.
                OrderBy(x => x.OrderId).Select(x => new
                {
                    OrderId = x.OrderId,
                    x.UserId,
                    StatusId = x.StatusId,
                    UserName = context.Users.Where(y => y.UserId == x.UserId).FirstOrDefault().Email,
                    x.OrderDate,
                    ShippedDate = x.ShippedDate == null ? "Updating" : x.ShippedDate.ToString(),
                    x.TotalPrice,
                    x.TotalQuantity,
                    Status = x.StatusId == 1 ? "In process" : x.StatusId == 2 ? "Shipping" : "Complete"
                }).ToList();
            foreach (DataGridViewColumn column in dgvOrder.Columns)
            {
                if (column.Name == "UserId" || column.Name == "StatusId" || column.Name == "TotalQuantity")
                {
                    column.Visible = false;
                }
            }
            if (dgvOrder.Rows.Count > 0)
            {
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dgvOrder_CellClick(dgvOrder, args);
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvOrder.Rows[e.RowIndex];
                int UserID = Convert.ToInt32(selectedRow.Cells["UserID"].Value.ToString());
                User user = context.Users.Where(x => x.UserId == UserID).SingleOrDefault();
                if (user != null)
                {
                    txtEmail.Text = user.Email;
                    rtxtAddress.Text = user.Address;
                }
                txtTotal.Text = selectedRow.Cells["TotalPrice"].Value.ToString();
                if (selectedRow.Cells["StatusId"].Value.ToString() == "1")
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (selectedRow.Cells["StatusId"].Value.ToString() == "2")
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (selectedRow.Cells["StatusId"].Value.ToString() == "3")
                {
                    comboBox1.SelectedIndex = 2;
                }
                OrderID = Convert.ToInt32(selectedRow.Cells["OrderId"].Value.ToString());
                //order detail 
                dgvOrderDetail.DataSource = context.OrderDetails.Where(x => x.OrderId == OrderID)
                    .Select(x => new
                    {
                        x.OrderId,
                        x.ProductId,
                        x.QuantityPerUnit,
                        x.UnitPrice,
                        x.Discount,
                    }).ToList();
                if (dgvOrderDetail.Rows.Count > 0)
                {
                    DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                    dgvOrderDetail_CellClick(dgvOrderDetail, args);
                }
            }
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvOrderDetail.Rows[e.RowIndex];
                int OrderID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value.ToString());
                int ProductID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value.ToString());
                int Quantity = Convert.ToInt32(selectedRow.Cells["QuantityPerUnit"].Value.ToString());
                txtCountItem.Text = context.OrderDetails.Where(x => x.OrderId == OrderID).Count().ToString();
                txtSubTotal.Text = context.OrderDetails.Where(x => x.OrderId == OrderID).Select(x => x.UnitPrice).Sum().ToString();

                //product info
                Product pro = context.Products.Where(x => x.ProductId == ProductID).FirstOrDefault();
                if (pro != null)
                {
                    txtName.Text = pro.ProductName;
                    pbImageProduct.ImageLocation = $"D:\\fpt\\Semeter_5\\PRN211\\Project\\GreenValleyApp\\Images\\{pro.ProductImage}";
                    txtPrice.Text = pro.UnitPrice.ToString();
                    txtQuantity.Text = Quantity.ToString();
                }
                else
                {
                    MessageBox.Show("Not found any product");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Order order = context.Orders.Where(x => x.OrderId == OrderID).FirstOrDefault();
            if (order != null)
            {
                if (order.StatusId == 2 && comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("order has been shipping and cannot call back");
                    return;
                }
                else if (order.StatusId == 3 && (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1))
                {
                    MessageBox.Show("order is completed");
                    return;
                }
                else if (order.StatusId == 1 && (comboBox1.SelectedIndex == 2))
                {
                    MessageBox.Show("order mustbe ship first");
                    return;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        order.StatusId = 1;
                        context.Update(order);
                        context.SaveChanges();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        order.StatusId = 2;
                        context.Update(order);
                        context.SaveChanges();
                    }
                    else
                    {
                        order.StatusId = 3;
                        order.ShippedDate = DateTime.Today;
                        List<OrderDetail> list = context.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();
                        foreach (var item in list)
                        {
                            Product pro = context.Products.Where(y => y.ProductId == item.ProductId).FirstOrDefault();
                            if (pro != null)
                            {
                                pro.UnitInStock -= item.QuantityPerUnit;
                            }
                        }
                        context.Update(order);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Update success");
                LoadData();
            }
        }
    }
}
