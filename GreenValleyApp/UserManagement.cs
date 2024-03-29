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
    public partial class frmUserManagement : Form
    {
        SmartketContext context = new SmartketContext();
        IUserRepository userRepository = new UserRepository();
        public bool InsertOrUpdate { get; set; }
        public frmUserManagement()
        {
            InitializeComponent();
            cbxStatus.SelectedIndex = 0;
            var minCreateDate = context.Users.Min(x => x.CreateDate);
            var maxCreateDate = context.Users.Max(x => x.CreateDate);
            if (minCreateDate != null && maxCreateDate != null)
            {
                dtpFrom.Value = minCreateDate.Value.Date;
                dtpTo.Value = maxCreateDate.Value.Date;
            }
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                txtTotalUser.Text = (context.Users.Count() - 1).ToString();
                txtActivate.Text = context.Users.Count(x => x.UserStatus == true).ToString();
                txtDeactivate.Text = context.Users.Count(x => x.UserStatus == false).ToString();

                if (dtpFrom.Value > dtpTo.Value)
                {
                    MessageBox.Show("Invalid date range. From date cannot be greater than To date.");
                    dtpFrom.Value = dtpTo.Value;
                    return;
                }

                IQueryable<User> query = context.Users
                    .Where(u => u.CreateDate >= dtpFrom.Value
                             && u.CreateDate <= dtpTo.Value
                             && u.Email.Contains(txtSearch.Text));

                if (cbxStatus.SelectedItem.ToString() == "Activate")
                {
                    query = query.Where(u => u.UserStatus == true);
                }
                else if (cbxStatus.SelectedItem.ToString() == "Deactivate")
                {
                    query = query.Where(u => u.UserStatus == false);
                }

                var userData = query.Select(x => new
                {
                    x.UserId,
                    x.Email,
                    Gender = x.Gender == true ? "Male" : "Female",
                    x.BirthDate,
                    x.Address,
                    x.Password,
                    x.CreateDate,
                    Status = x.UserStatus == true ? "Activate" : "Deactivate"
                }).ToList();

                dgvData.DataSource = userData;
                if (dgvData.Rows.Count > 0)
                {
                    DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                    dgvData_CellClick(dgvData, args);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                txtID.Text = selectedRow.Cells["UserId"].Value.ToString();
                txtEmail.Text = (selectedRow.Cells["Email"].Value.ToString());
                rdMale.Checked = selectedRow.Cells["Gender"].Value.ToString() == "Male";
                rdFemale.Checked = !rdMale.Checked;

                if (DateTime.TryParse(selectedRow.Cells["BirthDate"].Value.ToString(), out DateTime birthDate))
                {
                    dtpDob.Value = birthDate;
                }
                rtxtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                if (selectedRow.Cells["Password"].Value != null)
                {
                    txtPass.Text = (selectedRow.Cells["Password"].Value.ToString());
                }

                if (selectedRow.Cells["Status"].Value.ToString() == "Activate")
                {
                    txtStatus.BackColor = Color.Green;
                    txtStatus.ForeColor = Color.White;
                    txtStatus.Text = selectedRow.Cells["Status"].Value.ToString();
                }
                else
                {
                    txtStatus.BackColor = Color.IndianRed;
                    txtStatus.ForeColor = Color.White;
                    txtStatus.Text = selectedRow.Cells["Status"].Value.ToString();
                }
            }
            //LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["UserId"].Value.ToString());
                userRepository.DeleteUser(Id);
                MessageBox.Show("Delete success");
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUserDetail frmP = new frmUserDetail
            {
                Text = "Update user",
                InsertOrUpdate = true,
                userInfo = GetUserObject(),
                userRepo = userRepository
            };
            if (frmP.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserDetail frmP = new frmUserDetail
            {
                Text = "add user",
                InsertOrUpdate = false,
                userInfo = GetUserObject(),
                userRepo = userRepository
            };
            if (frmP.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserDetail frmP = new frmUserDetail
            {
                Text = "Update user",
                InsertOrUpdate = true,
                userInfo = GetUserObject(),
                userRepo = userRepository
            };
            if (frmP.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private User GetUserObject()
        {
            User u = null;
            try
            {
                int UserID = int.Parse(txtID.Text);
                string Email = txtEmail.Text;
                Boolean Gender = rdMale.Checked ? true : false;
                DateTime BirthDate = dtpDob.Value;
                string Address = rtxtAddress.Text;
                string Password = txtPass.Text;
                Boolean Status = txtStatus.Text == "Activate" ? true : false;
                u = new User
                {
                    UserId = UserID,
                    Email = Email,
                    Gender = Gender,
                    BirthDate = BirthDate,
                    Address = Address,
                    Password = Password,
                    CreateDate = DateTime.Now,
                    UserStatus = Status
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": Error while getting user");
            }
            return u;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
