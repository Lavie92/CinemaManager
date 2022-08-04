namespace CinemaManager
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.ManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.SystemToolStripMenuItem.Text = "Hệ thống";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.LoginToolStripMenuItem.Text = "Đăng nhập";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.LogoutToolStripMenuItem.Text = "Đăng xuất";
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TicketSaleToolStripMenuItem,
            this.BillToolStripMenuItem,
            this.CustomerToolStripMenuItem});
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ManagerToolStripMenuItem.Text = "Quản lý";
            // 
            // TicketSaleToolStripMenuItem
            // 
            this.TicketSaleToolStripMenuItem.Name = "TicketSaleToolStripMenuItem";
            this.TicketSaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TicketSaleToolStripMenuItem.Text = "Bán vé";
            this.TicketSaleToolStripMenuItem.Click += new System.EventHandler(this.TicketSaleToolStripMenuItem_Click);
            // 
            // BillToolStripMenuItem
            // 
            this.BillToolStripMenuItem.Name = "BillToolStripMenuItem";
            this.BillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BillToolStripMenuItem.Text = "Hoá đơn";
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomerToolStripMenuItem.Text = "Khách hàng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 463);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
    }
}