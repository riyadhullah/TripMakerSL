using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        byte[] img;
        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter= "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if(open.ShowDialog()==DialogResult.OK)
            {
               txtpath.Text = open.FileName;
                picturebox.Image = new Bitmap(open.FileName);
                 img=convertImageToBytes(picturebox.Image);
            }
            btnadd.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
               // File.Copy(txtpath.Text, Path.Combine(@"D:\project\TripMakerSL\TripMaker\photo\", Path.GetFileName(txtpath.Text)), true);
          
                var query = "update user_table set ImagePath='"+ img + "' where userName='"+un+"'";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
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
            var query = "select user_table. * from user_table join tmp_table on user_table.userName = tmp_table.[user_name]";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }

            try
            {
                lblname.Text = dt.Rows[0]["name"].ToString();
                lblun.Text = dt.Rows[0]["userName"].ToString();
                lblemail.Text = dt.Rows[0]["Email"].ToString();
                lblpn.Text = dt.Rows[0]["Phone_number"].ToString();
                lblgender.Text = dt.Rows[0]["gender"].ToString();
                lbladrs.Text = dt.Rows[0]["Address"].ToString();
                //picturebox.Image = convertByteArrayToImage((byte[])dt.Rows[0]["ImagePath"]);



                un = lblun.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("fahad");
            }
            
        }
         byte[] convertImageToBytes(Image img)
        {
              using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image convertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {

                return Image.FromStream(ms);
            }
        }
    }
}
