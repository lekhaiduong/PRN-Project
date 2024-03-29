using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BusinessObject;
using DataAccess.Repository;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Channels;

namespace GreenValleyApp
{
    public partial class frmChangePass : Form
    {
        SmartketContext context = new SmartketContext();
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            User userSession = frmLogin.userSession;
            if (userSession != null)
            {
                if (txtCurrentPass.Text == userSession.Password)
                {
                    if (txtNewPass.Text == txtRepass.Text)
                    {
                        userSession.Password = txtNewPass.Text;
                        context.Update(userSession);
                        context.SaveChanges();
                        MessageBox.Show("Change successfully");
                        frmCustomer customer = new frmCustomer();
                        this.Close();
                        customer.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Repassword must be equal to your new password");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Your current password is not correct");
                    return;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }
        private void Back()
        {
            this.Close();
        }
    }
}
