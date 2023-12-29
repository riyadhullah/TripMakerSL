using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripMaker
{
    public partial class Profileedit : UserControl
    {
        private static Profileedit instance;
        public static Profileedit Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Profileedit();
                }
                return instance;
            }
        }
        public static Profileedit setInstance
        {
            set
            {
                instance = value;
            }
        }
        public Profileedit()
        {
            InitializeComponent();
        }
       
        public void Insert(string name,string email,string pn,string gender,string adrs,string un, byte[] image)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\TripMakerSL\New mdf file\TripMakerDB.mdf;Integrated Security=True;Connect Timeout=30");
            var query = "update user_table set name=@name,email=@email,phone_number=@pn,gender=@gender,address=@adrs,ImagePath=@image1 where userName=@un";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@image1", image);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pn", pn);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@adrs", adrs);
                cmd.Parameters.AddWithValue("@un", un);
                cmd.ExecuteNonQuery();
                cn.Close();
                string error = "";

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }


        }
        private void btnup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtun.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtpn.Text) || string.IsNullOrEmpty(richTxtAdrs.Text))
            {
                MessageBox.Show("Please Fill Up All Information");
                return;
            }
            string name = txtname.Text;
            Regex rvn = new Regex(@"^([a-z-A-z\s]+)$");
            bool validn = rvn.IsMatch(txtname.Text);
            if (!validn)
            {
                MessageBox.Show("Please Enter Valid Name");
                txtname.Focus();
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

            string adrs = richTxtAdrs.Text;

            try
            {

                Insert(name,email,PN,gender,adrs,un, convertImageToBytes(picturebox.Image));
                MessageBox.Show("Successfully Update Signup");
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            



        }
        string un;
        private void Profileedit_Load(object sender, EventArgs e)
        {
            var query = "select user_table. * from user_table join tmp_table on user_table.userName = tmp_table.[user_name]";
            string error;
            var dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            try
            {
                txtname.Text = dt.Rows[0]["name"].ToString();
                txtun.Text = dt.Rows[0]["userName"].ToString();
                txtemail.Text = dt.Rows[0]["Email"].ToString();
                txtpn.Text = dt.Rows[0]["Phone_number"].ToString();
                string g = dt.Rows[0]["gender"].ToString().Trim();
                if (g == "Male")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }


                richTxtAdrs.Text = dt.Rows[0]["Address"].ToString();
                picturebox.Image = convertByteArrayToImage((byte[])dt.Rows[0]["imagePath"]);

                un = txtun.Text;
            }
            catch (Exception ex)
            {

            }

           // richTxtAdrs.Text = dt.Rows[0]["Address"].ToString();
            //picturebox.Image = convertByteArrayToImage((byte[])dt.Rows[0]["imagePath"]);

            
            

        }

        byte[] convertImageToBytes(Image img)
        {

            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();

        }
        public Image convertByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);

        }

        
        private void btnnew_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                picturebox.Image = Image.FromFile(open.FileName);

            }
        }

        private void txtun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name Can Not Be Changed");
        }
    }
}
