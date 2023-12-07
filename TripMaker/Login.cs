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
        public Login()
        {
            InitializeComponent();
        }

        private void pass_show_hide(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == ".")
            { 
                btnClose.Visible = true;
                btnOpen.Visible = false;
                //btnClose.Show();
                //btnOpen.Hide();
            }
            else
            {
                //btnClose.Hide();
                //btnOpen.Show();
            }
        }

    }
}
