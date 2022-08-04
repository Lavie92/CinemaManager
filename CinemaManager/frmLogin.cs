using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Model;
namespace CinemaManager
{
    public partial class frmLogin : Form
    {
        public event DelegateLogin DelegateLogin;
        CinemaContext CinemaContext;
        public frmLogin()
        {
            InitializeComponent();
            CinemaContext = new CinemaContext();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (CinemaContext.Accounts.Any(x => x.Username == username && x.Password == password))
            {
                List<int> listRole = CinemaContext.Accounts.Include("Permissions").FirstOrDefault(x => x.Password == password && x.Username == username).Permissions.Select(x => x.RoleId).ToList();
                if (listRole.Contains(CinemaContext.Roles.FirstOrDefault(x => x.RoleName == "admin").RoleId))
                {
                    DelegateLogin("admin");
                }
                else
                {
                    DelegateLogin("staff");
                }
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Sai MK");
            }
            this.Close();
        }
    }
}
