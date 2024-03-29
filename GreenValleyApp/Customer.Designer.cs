namespace GreenValleyApp
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msHome = new ToolStripMenuItem();
            msCart = new ToolStripMenuItem();
            msOrder = new ToolStripMenuItem();
            msProfile = new ToolStripMenuItem();
            menu = new MenuStrip();
            plData = new Panel();
            msLogout = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // msHome
            // 
            msHome.Name = "msHome";
            msHome.Size = new Size(77, 29);
            msHome.Text = "Home";
            msHome.Click += msHome_Click;
            // 
            // msCart
            // 
            msCart.Name = "msCart";
            msCart.Size = new Size(87, 29);
            msCart.Text = "My cart";
            msCart.Click += msCart_Click;
            // 
            // msOrder
            // 
            msOrder.Name = "msOrder";
            msOrder.Size = new Size(101, 29);
            msOrder.Text = "My order";
            msOrder.Click += msOrder_Click;
            // 
            // msProfile
            // 
            msProfile.Name = "msProfile";
            msProfile.Size = new Size(109, 29);
            msProfile.Text = "my profile";
            msProfile.Click += msProfile_Click;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { msHome, msCart, msOrder, msProfile, msLogout });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1386, 33);
            menu.TabIndex = 5;
            menu.Text = "menuStrip1";
            // 
            // plData
            // 
            plData.Location = new Point(12, 36);
            plData.Name = "plData";
            plData.Size = new Size(1348, 640);
            plData.TabIndex = 6;
            // 
            // msLogout
            // 
            msLogout.Name = "msLogout";
            msLogout.Size = new Size(85, 29);
            msLogout.Text = "Logout";
            msLogout.Click += msLogout_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 692);
            Controls.Add(plData);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem msHome;
        private ToolStripMenuItem msCart;
        private ToolStripMenuItem msOrder;
        private ToolStripMenuItem msProfile;
        private MenuStrip menu;
        private Panel plData;
        private ToolStripMenuItem msLogout;
    }
}