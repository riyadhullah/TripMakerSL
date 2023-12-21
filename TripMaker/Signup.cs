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
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void password_change(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCpass.Text))
            {
                lblpdnm.Visible = false;
            }
            else if (txtPass.Text != txtCpass.Text)
            {
                lblpdnm.Visible = true;
            }
            else
            {
                lblpdnm.Visible = false;
            }

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtCpass.UseSystemPasswordChar = true;
            btncloseps.Visible = true;
            btnopenps.Visible = false;
            btnclosecp.Visible = true;
            btnopencp.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            txtCpass.UseSystemPasswordChar = false;
            btncloseps.Visible = false;
            btnopenps.Visible = true;
            btnclosecp.Visible = false;
            btnopencp.Visible = true;
        }
    }
}
