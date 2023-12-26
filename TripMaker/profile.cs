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

        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter= "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if(open.ShowDialog()==DialogResult.OK)
            {
                txtpath.Text = open.FileName;
                picturebox.Image = new Bitmap(open.FileName);
            }
            btnadd.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            File.Copy(txtpath.Text, Path.Combine(@"D:\project\TripMakerSL\TripMaker\photo\", Path.GetFileName(txtpath.Text)), true);
            MessageBox.Show("Picture Saccessfully Add");
            btnsave.Visible = false;
        }
    }
}
