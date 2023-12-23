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

        private void btn_function(object sender, EventArgs e)
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

                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
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

                bus1.Visible = true;
                flight1.Visible = false;
                signup.Visible = false;
                login.Visible = false;
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

                flight1.Visible = true;
                bus1.Visible = false;
                signup.Visible = false;
                login.Visible = false;
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

                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
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

                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
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

                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
               
            }
            else if (btn.Text == "About")
            {
                pnlHome.Visible = false;
                pnlBus.Visible = false;
                pnlFlight.Visible = false;
                pnlHotel.Visible = false;
                pnlPackages.Visible = false;
                pnlWallet.Visible = false;
                pnlAbout.Visible = true;

                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
            }
            else if(btn.Text == "Signup")
            {
                signup.Visible = true;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = false;
            }
            else if (btn.Text == "Login")
            {
                signup.Visible = false;
                bus1.Visible = false;
                flight1.Visible = false;
                login.Visible = true;
            }

        }

        
    }
}
