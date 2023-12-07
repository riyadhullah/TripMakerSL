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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void red_panel_changed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Home")
            {
                pnlHome.Visible = true;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = false;
            }
            else if (btn.Text == "Bus")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = true;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = false;
            }
            else if (btn.Text == "Flight")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = true;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = false;
            }
            else if (btn.Text == "Hotel")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = true;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = false;
            }
            else if (btn.Text == "Packages")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = true;
                pnlWallet.Visible = false;
                pnlAbout.Visible = false;
            }
            else if (btn.Text == "Wallet")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = true;
                pnlAbout.Visible = false;
            }
            else
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = true;
            }

            //siam

        }


    }
}
