using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TripMaker
{
    public partial class Signup : UserControl
    {
        private static Signup instance;
        public static Signup Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Signup();
                }
                return instance;
            }
        }
        public static Signup setInstance
        {
            set
            {
                instance = value;
            }
        }

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
            txtPass.UseSystemPasswordChar = false;
            txtCpass.UseSystemPasswordChar = false;
            btncloseps.Visible = true;
            btnopenps.Visible = false;
            btnclosecp.Visible = true;
            btnopencp.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtCpass.UseSystemPasswordChar = true;
            btncloseps.Visible = false;
            btnopenps.Visible = true;
            btnclosecp.Visible = false;
            btnopencp.Visible = true;

        }
        private void newdata(object sender,EventArgs e)
        {
            txtName.Text = "";
            txtun.Text = "";
            txtEmail.Text = "";
            txtPN.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtPass.Text = "";
            txtCpass.Text = "";
            btncloseps.Visible = false;
            btnopenps.Visible = true;
            btnclosecp.Visible = false;
            btnopencp.Visible = true;
            txtPass.UseSystemPasswordChar = false;
            txtCpass.UseSystemPasswordChar = false;
            richTxtAdrs.Text = "";
        }
        private void singup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtun.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPN.Text) || string.IsNullOrEmpty(richTxtAdrs.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCpass.Text))
            {
                MessageBox.Show("Please Fill Up All Information");
                return;
            }
            string name = txtName.Text;
            Regex rvn = new Regex(@"^([a-z-A-z\s]+)$");
            bool validn = rvn.IsMatch(txtName.Text);
            if (!validn)
            {
                MessageBox.Show("Please Enter Valid Name");
                txtName.Focus();
                return;
            }
            string un = txtun.Text;
            Regex rvun = new Regex(@"^([a-zA-Z0-9]+)$");
            bool validun = rvun.IsMatch(txtun.Text);
            if (!validun)
            {
                MessageBox.Show("Please Enter Valid UserName");
                txtun.Focus();
                return;
            }
            string email = txtEmail.Text;
            Regex rv = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool valid = rv.IsMatch(txtEmail.Text);
            if(!valid)
            {
                MessageBox.Show("Please Enter Valid Email Address");
                txtEmail.Focus();
                return;
            }
            string PN = txtPN.Text;
            Regex rv1 = new Regex("^[0-9]{11}");
            bool valid1 = rv1.IsMatch(txtPN.Text);
            if (!valid1)
            {
                MessageBox.Show("Please Enter Valid Phone Number");
                txtPN.Focus();
                return;
            }
            string gender = "";
            if (rdbMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rdbFemale.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Invalid Gender");
                return;
            }
            string pass = txtPass.Text;
            Regex rvp = new Regex(@"^.{8,}$");
            bool validp = rvp.IsMatch(txtPass.Text);
            if (!validp)
            {
                MessageBox.Show("Please Enter Password At Least 8 Character");
                txtPass.Focus();
                return;
            }
            if (lblpdnm.Visible==true)
            {
                MessageBox.Show("Password Did Not Match \nPlease Match The Password");
                txtPass.Focus();
                txtCpass.Focus();
                return;
            }
            string adrs = richTxtAdrs.Text;

            string query = "insert into user_table([name],userName,email,phone_number,[type],gender,[password],[address]) values('" + name + "','" + un + "','" + email + "','" + PN + "','Castomer','" + gender + "','" + pass + "','" + adrs + "')";
            string error;
            DataAccess.ExecuteData(query,out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Saccessfully Signup \nPlease Login");
            this.newdata(sender,e);
            
        }

    }
}
