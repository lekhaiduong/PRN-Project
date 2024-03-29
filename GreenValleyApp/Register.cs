using BusinessObject;
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
    public partial class frmRegister : Form
    {
        SmartketContext context = new SmartketContext();
        private frmLogin loginForm;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToLoginForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtRepassword.Text))
            {
                MessageBox.Show("Password must be equal to repassword.");
                return;
            }
            else
            {
                if (txtEmail.Text == null || dateTimePicker1.Value == null
                    || radioButton1 == null || radioButton2 == null
                    || richTextBox1.Text == null)
                {
                    MessageBox.Show("Please fill all the option.");
                    return;
                }
                else if (dateTimePicker1.Value >= DateTime.Today)
                {
                    MessageBox.Show("Input date again");
                    return;
                }
                else
                {
                    string email = txtEmail.Text;
                    DateTime dob = dateTimePicker1.Value;
                    Boolean gender = true;
                    gender = radioButton1.Checked ? true : false;
                    string address = richTextBox1.Text;
                    string pass = txtPassword.Text;
                    User regUser = new User
                    {
                        Email = email,
                        Address = address,
                        Gender = gender,
                        BirthDate = dob,
                        Password = pass
                    };
                    User check = context.Users.Where(x => x.Email == email).FirstOrDefault();
                    if (check != null)
                    {
                        MessageBox.Show("Your email has been used.");
                        return;
                    }
                    else
                    {
                        context.Add(regUser);
                        context.SaveChanges();
                        MessageBox.Show("Register successfully!");
                        SwitchToLoginForm();
                    }
                }
            }
        }
        private void SwitchToLoginForm()
        {
            if (loginForm == null)
            {
                loginForm = new frmLogin();
                loginForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    loginForm.Dispose();
                    loginForm = null;
                };
            }
            this.Hide();
            loginForm.Show();
        }
    }
}
