using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripMaker
{
    public partial class Login : UserControl
    {
        private static Login instance;
        public static Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }

        public static Login setInstance
        {
            set
            {
                instance = value;
            }
        }


        public Login()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnClose.Visible = true;
            btnOpen.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnClose.Visible = false;
            btnOpen.Visible = true;
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string un = txtUN.Text;
            string pass = txtPassword.Text;

            string query = "select * from user_table where userName = '" + un + "' and [password] = '" + pass + "'; ";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Home.Instance.BringToFront();
            LogoutPanel.Instance.BringToFront();

        }

    }
}
