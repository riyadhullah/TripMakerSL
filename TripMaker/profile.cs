using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TripMaker
{
    public partial class profile : UserControl
    {
        private static profile instance;
        public static profile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new profile();
                }
                return instance;
            }
        }
        public static profile setInstance
        {
            set
            {
                instance = value;
            }
        }
        public profile()
        {
            InitializeComponent();
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter= "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if(open.ShowDialog()==DialogResult.OK)
            {
              
                picturebox.Image =Image.FromFile(open.FileName);
               
            }
            btnadd.Visible = false;
        }
        public void Insert(string un, byte[] image)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\TripMakerSL\New mdf file\TripMakerDB.mdf;Integrated Security=True;Connect Timeout=30");
            var query = "update user_table set ImagePath=@image1 where userName=@un";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@image1", image);
                cmd.Parameters.AddWithValue("@un", un);
                cmd.ExecuteNonQuery();
                cn.Close();
                string error = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                
                Insert( un, convertImageToBytes(picturebox.Image));
                MessageBox.Show("Picture Saccessfully Add");
                btnsave.Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Please Add Picture");
            }
       }
        string un;
        private void profile_Load(object sender, EventArgs e)
        {
            try
            {
                var query = "select user_table. * from user_table join tmp_table on user_table.userName = tmp_table.[user_name]";
                string error;
                DataTable dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }

                lblname.Text = dt.Rows[0]["name"].ToString();
                lblun.Text = dt.Rows[0]["userName"].ToString();
                lblemail.Text = dt.Rows[0]["Email"].ToString();
                lblpn.Text = dt.Rows[0]["Phone_number"].ToString();
                lblgender.Text = dt.Rows[0]["gender"].ToString();
                lbladrs.Text = dt.Rows[0]["Address"].ToString();

                picturebox.Image = convertByteArrayToImage((byte[])dt.Rows[0]["imagePath"]);


                un = lblun.Text;
                if ((byte[])dt.Rows[0]["imagePath"] != null)
                {
                   btnsave.Visible = false;
                   btnadd.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnup_Click(object sender, EventArgs e)
        {

        }
    }
}
