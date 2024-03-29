using BusinessObject;
using Microsoft.Extensions.Configuration;
using DataAccess.Repository;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Design;
using Microsoft.VisualBasic.ApplicationServices;
namespace GreenValleyApp
{
    public partial class frmLogin : Form
    {
        SmartketContext context = new SmartketContext();
        IUserRepository userRepository = new UserRepository();
        private frmRegister registerForm;

        public static string email = "";
        public static string password = "";
        public static BusinessObject.User userSession = new BusinessObject.User();
        public frmLogin()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            email = config["Email"];
            password = config["Password"];
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (registerForm == null)
            {
                registerForm = new frmRegister();
                registerForm.FormClosed += (s, args) =>
                {
                    registerForm.Dispose();
                    registerForm = null;
                };
            }
            this.Hide();
            registerForm.Show();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger btnLogin_Click event
                btnLogin_Click(sender, e);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (email == (txtUsername.Text) && password == (txtPassword.Text))
            {
                email = txtUsername.Text;
                password = txtPassword.Text;
                userSession = context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
                frmAdmin admin = new frmAdmin();
                this.Hide();
                admin.ShowDialog();

            }
            else
            {
                email = txtUsername.Text;
                password = txtPassword.Text;
                userSession = context.Users.Where(x => x.Email == email
                && x.Password == password).FirstOrDefault();
                if (userSession != null)
                {
                    userSession.Email = email;
                    userSession.Password = password;
                    frmCustomer customer = new frmCustomer
                    {
                        Text = $"Welcome, {userSession.Email}",
                    };
                    this.Hide();
                    customer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong email or password");
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger btnLogin_Click event
                btnLogin_Click(sender, e);
            }
        }
        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger btnLogin_Click event
                btnLogin_Click(sender, e);
            }
        }
    }
}
