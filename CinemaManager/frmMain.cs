using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager;

namespace CinemaManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SetMenu(false);
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.LoginToolStripMenuItem.PerformClick();
        }

        private void SetMenu(bool status)
        {
            this.LogoutToolStripMenuItem.Enabled = status;
            this.TicketSaleToolStripMenuItem.Enabled = status;
            this.BillToolStripMenuItem.Enabled = status;
            this.CustomerToolStripMenuItem.Enabled = status;
            this.LoginToolStripMenuItem.Enabled = !status;
        }
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(x => x.Name == "frmLogin"))
            {
                this.MdiChildren.FirstOrDefault(x => x.Name == "frmLogin").Activate();
                return;
            }
            frmLogin frmLogin = new frmLogin();
            frmLogin.MdiParent = this;
            frmLogin.DelegateLogin += frmLoginDelegateLogin;
            frmLogin.Show();
        }
        private bool OpenChildForm(string formName)
        {
            if (this.MdiChildren.Any(x => x.Name == formName))
            {
                this.MdiChildren.FirstOrDefault(x => x.Name == formName).Activate();
                return true;
            }
            return false;
        }
        private void frmLoginDelegateLogin(object sender)
        {
            string role = (string)sender;
            if (role == "admin")
            {
                SetMenu(true);
            }
            else if (role == "staff")
            {
                this.BillToolStripMenuItem.Enabled = true;
            }
            //}
        }

        private void TicketSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenChildForm("frmTicket")) {
                frmTicket frmTicket = new frmTicket();
                //frmTicket.MdiParent = this;
                frmTicket.StartPosition = FormStartPosition.CenterScreen;
                frmTicket.ShowDialog();
            }
        }
    }
}
