using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TripMaker
{
    public partial class Login : UserControl
    {
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

            //MessageBox.Show(un + " " + pass);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# project\TripMakerSL\TripMakerDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                string query = "select * from user_table where userName = '"+un+"' and [password] = '"+pass+"'; ";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                MessageBox.Show(query);  

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex");
            }
        }
    }
}
