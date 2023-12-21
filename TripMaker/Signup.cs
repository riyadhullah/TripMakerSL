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
        private void newdata()
        {
            txtName.Text = "";
            txtun.Text = "";
            txtEmail.Text = "";
            txtPN.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtPass.Text = "";
            txtCpass.Text = "";

            richTxtAdrs.Text = "";
        }
        private void singup_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string un = txtun.Text;
            string email = txtEmail.Text;
            string PN = txtPN.Text;
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
            string adrs = richTxtAdrs.Text;
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtun.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPN.Text) || string.IsNullOrWhiteSpace(richTxtAdrs.Text)|| string.IsNullOrWhiteSpace(txtPass.Text)|| string.IsNullOrWhiteSpace(txtCpass.Text))
            {
                MessageBox.Show("Please Fill Up All Information");
                return;
            }
            if (lblpdnm.Visible==true)
            {
                MessageBox.Show("Password Did Not Match \nPlease Match The Password");
                return;
            }

            string query = "insert into user_table([name],userName,email,phone_number,[type],gender,[password],[address]) values('" + name + "','" + un + "','" + email + "','" + PN + "','Castomer','" + gender + "','" + pass + "','" + adrs + "')";
            string error;
            DataAccess.ExecuteData(query,out error);
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Saccessfully Signup \nPlease Login");
            this.newdata();
            
        }

    }
}
