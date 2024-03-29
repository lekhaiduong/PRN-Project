using BusinessObject;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GreenValleyApp
{
    public partial class frmUserDetail : Form
    {
        SmartketContext context = new SmartketContext();
        public IUserRepository userRepo { get; set; }
        public bool InsertOrUpdate { get; set; }
        public BusinessObject.User userInfo { get; set; }
        public frmUserDetail()
        {
            InitializeComponent();
            txtID.Enabled = !InsertOrUpdate;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var user = new BusinessObject.User()
            {
              
                Email = txtEmail.Text,
                Gender = rdMale.Checked == true ? true : false,
                BirthDate = dtpDob.Value,
                Address = rtxtAddress.Text,
                Password = txtPass.Text,
                CreateDate = DateTime.Today,
                UserStatus = cbxStatus.SelectedItem.ToString() == "Activate" ? true : false
            };
            if (!InsertOrUpdate)
            {
                BusinessObject.User check = context.Users.Where(x => x.Email == txtEmail.Text).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show("Email has been taken by another user.");
                    return;
                }
               userRepo.InsertUser(user);
                MessageBox.Show("User added successfully.");
                LoadData();
            }
            else
            {
                user.UserId = Convert.ToInt32(txtID.Text);
                userRepo.UpdateUser(user);
                MessageBox.Show("User updated successfully.");
                LoadData();
            }
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (InsertOrUpdate && userInfo != null)
            {
                txtID.Text = userInfo.UserId.ToString();
                txtEmail.Text = userInfo.Email;
                rdMale.Checked = userInfo.Gender == true;
                rdFemale.Checked = userInfo.Gender == false;
                rtxtAddress.Text = userInfo.Address;
                dtpDob.Value = userInfo.BirthDate ?? DateTime.Today;
                txtPass.Text = userInfo.Password;
                if (userInfo.UserStatus.HasValue)
                {
                    cbxStatus.SelectedItem = userInfo.UserStatus == true ? "Activate" : "Deactivate";
                }
            }
            else
            {
                int maxUserID = context.Users.Max(x => x.UserId); 
                txtID.Text = (maxUserID + 1).ToString();
                cbxStatus.SelectedIndex = 0;
            }
        }
    }
}
