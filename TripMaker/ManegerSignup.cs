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
    public partial class ManegerSignup : MetroFramework.Forms.MetroForm
    {
        public ManegerSignup()
        {
            InitializeComponent();
            
        }
    
        private void password_change(object sender, EventArgs e)
        {
              
            if (string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCpass.Text))
            {
                lblPdnm.Visible = false;
            }
            else if (txtPass.Text != txtCpass.Text)
            {
                lblPdnm.Visible = true;
            }
            else
            {
                lblPdnm.Visible = false;
            }

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            txtCpass.UseSystemPasswordChar = false;
            btnCloseps.Visible = true;
            btnopenps.Visible = false;
            btnClosecps.Visible = true;
            btnopencps.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtCpass.UseSystemPasswordChar = true;
            btnCloseps.Visible = false;
            btnopenps.Visible = true;
            btnClosecps.Visible = false;
            btnopencps.Visible = true;


        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtun.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtpn.Text) || string.IsNullOrEmpty(txtadrs.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCpass.Text))
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
            string email = txtemail.Text;
            Regex rv = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool valid = rv.IsMatch(txtemail.Text);
            if (!valid)
            {
                MessageBox.Show("Please Enter Valid Email Address");
                txtemail.Focus();
                return;
            }
            string PN = txtpn.Text;
            Regex rv1 = new Regex("^[0-9]{11}");
            bool valid1 = rv1.IsMatch(txtpn.Text);
            if (!valid1)
            {
                MessageBox.Show("Please Enter Valid Phone Number");
                txtpn.Focus();
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
            if (lblPdnm.Visible == true)
            {
                MessageBox.Show("Password Did Not Match \nPlease Match The Password");
                txtPass.Focus();
                txtCpass.Focus();
                return;
            }
            string adrs = txtadrs.Text;
            string id = txtid.Text;

            if (string.IsNullOrEmpty(id))
            {
                var query = "insert into user_table([name],userName,email,phone_number,[type],gender,[password],[address]) output inserted.Id values('" + name + "','" + un + "','" + email + "','" + PN + "','Castomer','" + gender + "','" + pass + "','" + adrs + "')";
                string error;
                var dt=DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                txtid.Text = dt.Rows[0]["Id"].ToString();
                MessageBox.Show("Saccessfully Signup");
            }
            else
            {
                var query = "update user_table set [name]='" + name + "',userName='" + un + "',email='" + email + "',phone_number='" + PN + "',gender='" + gender + "',[password]='" + pass + "',[address]='" + adrs + "' where id=" + id + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                MessageBox.Show("Update Signup");
            }
            this.loadgrid();
            for(int i=0;i<metroGrid.Rows.Count;i++)
            {
                if(metroGrid.Rows[i].Cells[0].Value.ToString()== txtid.Text)
                {
                    metroGrid.Rows[i].Selected = true;
                    break;
                }
            }
        }
        private void loadgrid()
        {
            string query = "select * from user_table";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            metroGrid.DataSource = dt;
            metroGrid.Refresh();
            metroGrid.ClearSelection();
        }

        private void ManegerSignup_Load(object sender, EventArgs e)
        {
            this.loadgrid();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0)
            {
                string id = metroGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(id);
            }
        }
        
        private void loaddetail(string id)
        {
            var query = "select * from user_table where id="+id+"";
            string error;
            var dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            txtid.Text = dt.Rows[0]["id"].ToString();
            txtName.Text = dt.Rows[0]["name"].ToString();
            txtun.Text = dt.Rows[0]["userName"].ToString();
            txtemail.Text = dt.Rows[0]["Email"].ToString();
            txtpn.Text = dt.Rows[0]["Phone_number"].ToString();
            string g = dt.Rows[0]["gender"].ToString().Trim();
            if (g=="Male")
            {
                rdbMale.Checked = true;
            }
            else 
            {
                rdbFemale.Checked = true;
            }
            
            txtPass.Text = dt.Rows[0]["Password"].ToString();
            txtCpass.Text = dt.Rows[0]["Password"].ToString();
            btnopenps.Visible = false;
            btnopencps.Visible = false;
            txtadrs.Text = dt.Rows[0]["Address"].ToString();

           
        }
        private void newdata()
        {
            txtid.Text = "";
            txtName.Text = "";
            txtun.Text = "";
            txtemail.Text = "";
            txtpn.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtPass.Text = "";
            txtCpass.Text = "";
            btnCloseps.Visible = false;
            btnopenps.Visible = true;
            btnClosecps.Visible = false;
            btnopencps.Visible = true;
            txtPass.UseSystemPasswordChar = false;
            txtCpass.UseSystemPasswordChar = false;
            txtadrs.Text = "";

            metroGrid.ClearSelection();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.newdata();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Please Select A Row");
                return;
            }
            var msg = MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.YesNo);
            if(msg==DialogResult.Yes)
            {
                var query = "delete from user_table where id="+txtid.Text;
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.loadgrid();
                this.newdata();
                MessageBox.Show("Deleted");
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.loadgrid();
            this.newdata();
        }
    }
}
