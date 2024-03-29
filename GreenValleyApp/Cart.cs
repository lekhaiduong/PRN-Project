using BusinessObject;
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

    public partial class frmCart : Form
    {
        SmartketContext context = new SmartketContext();
        BusinessObject.User user = frmLogin.userSession;
        int QuantityNumber = 0;
        double Total = 0;
        public frmCart()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var query = context.Carts.Include(x => x.Product).Where(x => x.UserId == user.UserId).Select(
                x => new
                {
                    x.Product.ProductName,
                    x.Quantity,
                    PricePerUnit = x.Product.UnitPrice,
                    Discount = (x.Product.Discount > 0) ? x.Product.Discount + "%" : "None",
                    TotalPrice = x.Quantity * (x.Product.UnitPrice * (100 - x.Product.Discount) / 100),
                    x.Product.UnitInStock,
                    ProductID = x.ProductId,
                }).ToList();

            dgvCartData.DataSource = query;
            rtxtAddress.Text = user.Address;
            foreach (DataGridViewColumn column in dgvCartData.Columns)
            {
                if (column.Name == "ProductID")
                {
                    column.Visible = false;
                }
            }
            if (dgvCartData.Rows.Count > 0)
            {
                processCell(new DataGridViewCellEventArgs(0, 0));
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.msHome_Click();
        }

        private void dgvCartData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            processCell(e);
        }
        private void processCell(DataGridViewCellEventArgs e)
        {
            int count = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCartData.Rows[e.RowIndex];
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                QuantityNumber = Convert.ToInt32(txtQuantity.Text);
                double subTotal = 0;

                foreach (DataGridViewRow row in dgvCartData.Rows)
                {
                    if (row.Cells["TotalPrice"].Value != null && double.TryParse(row.Cells["TotalPrice"].
                        Value.ToString(), out double cellSubTotal))
                    {
                        subTotal += cellSubTotal;
                        count++;
                    }
                }
                int shipping = 8000;
                txtShipping.Text = shipping.ToString() + "đ";

                txtSubTotal.Text = subTotal.ToString() + "đ";
                if (count == 0)
                {
                    lbItem.Text = $"You don't have any item in your cart";
                }
                else
                {
                    lbItem.Text = count == 1 ? $"Item in your cart: 1 item" : $"Items in your cart: {count} items";

                }
                Total = shipping + Convert.ToDouble(subTotal.ToString());
                txtTotal.Text = Total.ToString() + "đ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QuantityNumber == 0)
            {
                txtQuantity.Text = "0";
            }
            else
            {
                QuantityNumber -= 1;
            }

            txtQuantity.Text = QuantityNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuantityNumber += 1;
            txtQuantity.Text = QuantityNumber.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "0")
            {
                MessageBox.Show("Quantity cannot be 0!", "Wrong input");
                return;
            }else if(txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity cannot be null","Error");
                return;
            }
            else
            {
                int newQuantity = Convert.ToInt32(txtQuantity.Text);
                if (dgvCartData.SelectedRows.Count > 0)
                {
                    int Stock = Convert.ToInt32(dgvCartData.SelectedRows[0].Cells["UnitinStock"].Value.ToString());
                    if (Convert.ToInt32(txtQuantity.Text) >= Stock)
                    {
                        MessageBox.Show($"The most quantity you can buy is {Stock-1}", "Error");
                        txtQuantity.Text = $"{Stock-1}";
                        return;
                    }
                    string productIDString = dgvCartData.SelectedRows[0].Cells["ProductID"].Value.ToString();
                    int productID;

                    if (int.TryParse(productIDString, out productID))
                    {
                        Cart updateCart = context.Carts.FirstOrDefault(cart => cart.UserId == user.UserId && cart.ProductId == productID);

                        if (updateCart != null)
                        {
                            updateCart.Quantity = newQuantity;
                            context.SaveChanges();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Cart item not found.", "Error");
                        }
                    }
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvCartData.SelectedRows.Count > 0)
            {
                string productIDString = dgvCartData.SelectedRows[0].Cells["ProductID"].Value.ToString();
                int productID;

                if (int.TryParse(productIDString, out productID))
                {
                    Cart updateCart = context.Carts.FirstOrDefault(cart => cart.UserId == user.UserId && cart.ProductId == productID);
                    Product pro = context.Products.FirstOrDefault(x => x.ProductId == updateCart.ProductId);
                    if (updateCart != null)
                    {
                        context.Remove(updateCart);
                        context.SaveChanges();
                        MessageBox.Show($"Delete {pro.ProductName} successful!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Can find your item", "Error");
                    }
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete all you item in cart?", "Confirmation", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    if (dgvCartData.SelectedRows.Count > 0)
                    {
                        string productIDString = dgvCartData.SelectedRows[0].Cells["ProductID"].Value.ToString();
                        int productID;

                        if (int.TryParse(productIDString, out productID))
                        {
                            List<Cart> list = context.Carts.Where(x => x.UserId == user.UserId).ToList();
                            if (list.Count > 0)
                            {
                                foreach (Cart item in list)
                                {
                                    context.Remove(item);
                                    context.SaveChanges();
                                }
                                MessageBox.Show("Deleted success");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Can find your item", "Error");
                            }
                        }
                    }
                    break;

                case DialogResult.No:
                    return;
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCartData.SelectedRows.Count > 0)
            {
                // start add order
                int TotalQuantity = 0;
                List<Cart> list = context.Carts.Include(c => c.Product).Where(x => x.UserId == user.UserId).ToList();
                foreach (Cart item in list)
                {
                    TotalQuantity++;
                }
                Order order = new Order
                {
                    UserId = user.UserId,
                    TotalPrice = Total,
                    TotalQuantity = TotalQuantity,
                    OrderDate = DateTime.Today,
                    ShippedDate = null,
                    StatusId = 1
                };
                context.Add(order);
                context.SaveChanges();

                foreach (Cart item in list)
                {
                    if (item != null && item.Product != null)
                    {
                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderId = order.OrderId,
                            ProductId = item.Product.ProductId,
                            QuantityPerUnit = item.Quantity,
                            Discount = item.Product.Discount,
                            UnitPrice = Convert.ToDouble((item.Product.UnitPrice * (100 - item.Product.Discount) / 100) * item.Quantity)
                        };
                        context.Add(orderDetail);
                    }
                }
                context.SaveChanges();
                DeleteAllWhenCheckOut();
                MessageBox.Show("Check out complete!");
            }
        }
        private void DeleteAllWhenCheckOut()
        {
            if (dgvCartData.SelectedRows.Count > 0)
            {
                string productIDString = dgvCartData.SelectedRows[0].Cells["ProductId"].Value.ToString();
                int productID;

                if (int.TryParse(productIDString, out productID))
                {
                    List<Cart> list = context.Carts.Where(x => x.UserId == user.UserId).ToList();
                    if (list.Count > 0)
                    {
                        foreach (Cart item in list)
                        {
                            context.Remove(item);
                            context.SaveChanges();
                        }
                        LoadData();
                    }
                }
            }
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
