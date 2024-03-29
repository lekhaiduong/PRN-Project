namespace GreenValleyApp
{
    partial class frmAdmin
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
            panel1 = new Panel();
            menu = new MenuStrip();
            msDashboard = new ToolStripMenuItem();
            msProduct = new ToolStripMenuItem();
            msUser = new ToolStripMenuItem();
            msOrder = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 748);
            panel1.TabIndex = 0;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { msDashboard, msProduct, msUser, msOrder });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1370, 33);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // msDashboard
            // 
            msDashboard.Name = "msDashboard";
            msDashboard.Size = new Size(116, 29);
            msDashboard.Text = "Dashboard";
            msDashboard.Click += msDashboard_Click;
            // 
            // msProduct
            // 
            msProduct.Name = "msProduct";
            msProduct.Size = new Size(90, 29);
            msProduct.Text = "Product";
            msProduct.Click += msProduct_Click;
            // 
            // msUser
            // 
            msUser.Name = "msUser";
            msUser.Size = new Size(63, 29);
            msUser.Text = "User";
            msUser.Click += msUser_Click;
            // 
            // msOrder
            // 
            msOrder.Name = "msOrder";
            msOrder.Size = new Size(74, 29);
            msOrder.Text = "Order";
            msOrder.Click += msOrder_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 781);
            Controls.Add(panel1);
            Controls.Add(menu);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManagement";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menu;
        private ToolStripMenuItem msDashboard;
        private ToolStripMenuItem msProduct;
        private ToolStripMenuItem msUser;
        private ToolStripMenuItem msOrder;
    }
}