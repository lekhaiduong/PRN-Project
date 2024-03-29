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
    public partial class frmProfile : Form
    {
        frmChangePass change = new frmChangePass();
        SmartketContext context = new SmartketContext();
        public frmProfile()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            if (frmLogin.userSession != null)
            {
                txtOrder.Text = context.Orders.Where(x => x.UserId == frmLogin.userSession.UserId && x.StatusId == 3).Count().ToString();
                txtEmail.Text = frmLogin.userSession.Email;
                txtPassword.Text = frmLogin.userSession.Password;
                rtxtAddress.Text = frmLogin.userSession.Address;
                dtpDob.Value = frmLogin.userSession.BirthDate ?? DateTime.Now;
                if (frmLogin.userSession.Gender == true)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (change == null)
            {
                change = new frmChangePass();
                change.FormClosed += (s, args) =>
                {
                    change.Dispose();
                    change = null;
                };
            }
            this.Hide();
            change.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = frmLogin.userSession;
            if (user != null)
            {
                if (dtpDob.Value > DateTime.Today)
                {
                    MessageBox.Show("Input your birth date", "Wrong format");
                    return;
                }
                else
                {
                    user.Address = rtxtAddress.Text;
                    user.Gender = rdMale.Checked ? true : false;
                    user.BirthDate = dtpDob.Value;
                    context.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Update success");
                }

            }
        }
    }
}
