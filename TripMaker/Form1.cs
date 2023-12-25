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


        private void red_panel_changed(bool home, bool bus, bool flight, bool hotel, bool packages, bool wallet, bool about)
        {
            pnlHome.Visible = home;
            pnlBus.Visible = bus;
            pnlFlight.Visible = flight;
            pnlHotel.Visible = hotel;
            pnlPackages.Visible = packages;
            pnlWallet.Visible = wallet;
            pnlAbout.Visible = about;
        }



        private void btn_function(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Home")
            {
                red_panel_changed(true, false, false, false, false, false, false);
            }
            else if (btn.Text == "Bus")
            {
                red_panel_changed(false, true, false, false, false, false, false);

                if (!panel.Controls.Contains(Bus.Instance))
                {
                    panel.Controls.Add(Bus.Instance);
                    Bus.Instance.Dock = DockStyle.Fill;
                    Bus.Instance.BringToFront();
                }
                else
                {
                    Bus.Instance.BringToFront();
                }
            }
            else if (btn.Text == "Flight")
            {
                red_panel_changed(false, false, true, false, false, false, false);

                if (!panel.Controls.Contains(Flight.Instance))
                {
                    panel.Controls.Add(Flight.Instance);
                    Flight.Instance.Dock = DockStyle.Fill;
                    Flight.Instance.BringToFront();
                }
                else
                {
                    Flight.Instance.BringToFront();
                }
            }
            else if (btn.Text == "Hotel")
            {
                red_panel_changed(false, false, false, true, false, false, false);

            }
            else if (btn.Text == "Packages")
            {
                red_panel_changed(false, false, false, false, true, false, false);
            }
            else if (btn.Text == "Wallet")
            {
                red_panel_changed(false, false, false, false, false, true, false);

            }
            else if (btn.Text == "About")
            {
                red_panel_changed(false, false, false, false, false, false, true);
            }
            else if (btn.Text == "Signup")
            {
                if (!panel.Controls.Contains(Signup.Instance))
                {
                    panel.Controls.Add(Signup.Instance);
                    Signup.Instance.Dock = DockStyle.Fill;
                    Signup.Instance.BringToFront();
                }
                else
                {
                    Signup.Instance.BringToFront();
                }
            }
            else if (btn.Text == "Login")
            {
                if (!panel.Controls.Contains(Login.Instance))
                {
                    panel.Controls.Add(Login.Instance);
                    Login.Instance.Dock = DockStyle.Fill;
                    Login.Instance.BringToFront();
                }
                else
                {
                    Login.Instance.BringToFront();
                }
            }

        }





    }
}
