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

        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        public void red_panel_changed(bool home, bool bus, bool flight, bool hotel, bool packages, bool wallet, bool about)
        {
            pnlHome.Visible = home;
            pnlBus.Visible = bus;
            pnlFlight.Visible = flight;
            pnlHotel.Visible = hotel;
            pnlWallet.Visible = wallet;
            pnlAbout.Visible = about;
        }


        private void btn_function(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Home")
            {
                //MessageBox.Show("home");
                red_panel_changed(true, false, false, false, false, false, false);
                
                Home.Instance.BringToFront();
            }
            else if (btn.Text == "Bus")
            {
                //MessageBox.Show("bus");
                red_panel_changed(false, true, false, false, false, false, false);

                Bus.Instance.BringToFront();
                
            }
            else if (btn.Text == "Flight")
            {
                red_panel_changed(false, false, true, false, false, false, false);

                Flight.Instance.BringToFront();
                
            }
            else if (btn.Text == "Hotel")
            {
                red_panel_changed(false, false, false, true, false, false, false);
                HotelRoom.Instance.flowLayoutPanel_clear();
                Hotel.Instance.BringToFront();
            }
            else if (btn.Text == "Booking Info")
            {
                red_panel_changed(false, false, false, false, false, true, false);
                BookingInfo.Instance.BringToFront();
            }
            else if (btn.Text == "About")
            {
                red_panel_changed(false, false, false, false, false, false, true);
                Profileedit.Instance.BringToFront();
            }
            
            
            /*else if (btn.Text == "Signup")
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
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("asd");

            panel.Controls.Add(Home.Instance);
            Home.Instance.Dock = DockStyle.Fill;
            Home.Instance.BringToFront();

            panelUp.Controls.Add(LoginAndSignupPanel.Instance);
            LoginAndSignupPanel.Instance.Dock = DockStyle.Fill;
            LoginAndSignupPanel.Instance.BringToFront();

            panelUp.Controls.Add(LogoutPanel.Instance);
            LogoutPanel.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Login.Instance);
            Login.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Signup.Instance);
            Signup.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Bus.Instance);
            Bus.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Flight.Instance);
            Flight.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Hotel.Instance);
            Hotel.Instance.Dock = DockStyle.Fill;
           
            
            panel.Controls.Add(profile.Instance);
            profile.Instance.Dock = DockStyle.Fill;
            
            panel.Controls.Add(Profileedit.Instance);
            Profileedit.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(HotelRoom.Instance);
            HotelRoom.Instance.Dock = DockStyle.Fill;
            
            panel.Controls.Add(BookingInfo.Instance);
            BookingInfo.Instance.Dock = DockStyle.Fill;

            red_panel_changed(true, false, false, false, false, false, false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*public void load()
        {
            panel.Controls.Add(Home.Instance);
            Home.Instance.Dock = DockStyle.Fill;
            Home.Instance.BringToFront();

            panelUp.Controls.Add(LoginAndSignupPanel.Instance);
            LoginAndSignupPanel.Instance.Dock = DockStyle.Fill;
            LoginAndSignupPanel.Instance.BringToFront();

            panelUp.Controls.Add(LogoutPanel.Instance);
            LogoutPanel.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Login.Instance);
            Login.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Signup.Instance);
            Signup.Instance.Dock = DockStyle.Fill;


            panel.Controls.Add(Bus.Instance);
            Bus.Instance.Dock = DockStyle.Fill;

            panel.Controls.Add(Flight.Instance);
            Flight.Instance.Dock = DockStyle.Fill;

            red_panel_changed(true, false, false, false, false, false, false);
        }*/


        }
        


    }

