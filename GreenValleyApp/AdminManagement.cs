using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace GreenValleyApp
{
    public partial class frmAdmin : Form
    {
        frmProductManagement product = new frmProductManagement();
        frmUserManagement user = new frmUserManagement();
        frmOrderManagement order = new frmOrderManagement();
        dashboard dashboard = new dashboard();
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string email = frmLogin.email;
            //label1.Text = email;
            menu.Focus();
            msDashboard_Click();
        }

        public void msDashboard_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msDashboard");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                dashboard.TopLevel = false;
                panel1.Controls.Clear();
                dashboard.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(dashboard);
                dashboard.Location = new Point(9, 26);
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
                dashboard.LoadData();
            }
        }

        public void msProduct_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msProduct");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                product.TopLevel = false;
                panel1.Controls.Clear();
                product.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(product);
                product.Location = new Point(9, 26);
                product.Dock = DockStyle.Fill;
                product.Show();
            }
        }

        public void msOrder_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msOrder");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                order.TopLevel = false;
                panel1.Controls.Clear();
                order.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(order);
                order.Location = new Point(9, 26);
                order.Dock = DockStyle.Fill;
                order.Show();
            }
        }

        public void msUser_Click()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            ToolStripMenuItem clickedItem = menu.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "msUser");

            if (clickedItem != null)
            {
                clickedItem.BackColor = Color.LightGreen;
                clickedItem.Font = new Font(clickedItem.Font, FontStyle.Bold);
                user.TopLevel = false;
                panel1.Controls.Clear();
                user.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(user);
                user.Location = new Point(9, 26);
                user.Dock = DockStyle.Fill;
                user.Show();
            }
        }
        private void msProduct_Click(object sender, EventArgs e)
        {
            msProduct_Click();
        }

        private void msUser_Click(object sender, EventArgs e)
        {
            msUser_Click();
        }

        private void msOrder_Click(object sender, EventArgs e)
        {

            msOrder_Click();
        }

        private void msDashboard_Click(object sender, EventArgs e)
        {
            msDashboard_Click();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
