using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenValleyApp
{
    public partial class frmCustomer : Form
    {
        frmHomePage homepage = new frmHomePage();
        frmCart cart = new frmCart();
        frmOrder order = new frmOrder();
        frmProfile profile = new frmProfile();
        frmLogin login = new frmLogin();
        public frmCustomer()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string email = frmLogin.email;
            //label1.Text = email;
            menu.Focus();
            msHome_Click();
            Text = $"Welcome, {email}";
        }

        private void msHome_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            clickedItem.BackColor = Color.LightGreen;
            clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
            homepage.TopLevel = false;
            plData.Controls.Clear();
            homepage.FormBorderStyle = FormBorderStyle.None;
            plData.Controls.Add(homepage);
            homepage.Location = new Point(9, 26);
            homepage.Dock = DockStyle.Fill;
            homepage.Show();
        }

        private void msCart_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            clickedItem.BackColor = Color.LightGreen;
            clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
            cart.LoadData();
            cart.TopLevel = false;
            plData.Controls.Clear();
            cart.FormBorderStyle = FormBorderStyle.None;
            plData.Controls.Add(cart);
            cart.Location = new Point(0, 0);
            cart.Dock = DockStyle.Fill;
            cart.Show();
        }

        private void msOrder_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            clickedItem.BackColor = Color.LightGreen;
            clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
            order.TopLevel = false;
            plData.Controls.Clear();
            order.FormBorderStyle = FormBorderStyle.None;
            plData.Controls.Add(order);
            order.Location = new Point(0, 0);
            order.Dock = DockStyle.Fill;
            order.Show();
            order.LoadData();
        }

        private void msProfile_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msProfile");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                profile.LoadData();
                profile.TopLevel = false;
                plData.Controls.Clear();
                profile.FormBorderStyle = FormBorderStyle.None;
                plData.Controls.Add(profile);
                profile.Location = new Point(9, 26);
                profile.Dock = DockStyle.Fill;
                profile.Show();
            }
        }
        public void msHome_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msHome");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                homepage.TopLevel = false;
                plData.Controls.Clear();
                homepage.FormBorderStyle = FormBorderStyle.None;
                plData.Controls.Add(homepage);
                homepage.Location = new Point(9, 26);
                homepage.Dock = DockStyle.Fill;
                homepage.Show();
            }
        }
        public void msCart_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msCart");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                cart.LoadData();
                cart.TopLevel = false;
                plData.Controls.Clear();
                cart.FormBorderStyle = FormBorderStyle.None;
                plData.Controls.Add(cart);
                cart.Location = new Point(9, 26);
                cart.Dock = DockStyle.Fill;
                cart.Show();
            }
        }
        public void msProfile_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msProfile");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                profile.LoadData();
                profile.TopLevel = false;
                plData.Controls.Clear();
                profile.FormBorderStyle = FormBorderStyle.None;
                plData.Controls.Add(profile);
                profile.Location = new Point(9, 26);
                profile.Dock = DockStyle.Fill;
                profile.Show();
            }
        }

        private void msLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
            
        }
        
    }
}
