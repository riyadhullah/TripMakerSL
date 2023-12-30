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
    public partial class AdminHome : MetroFramework.Forms.MetroForm
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageHotelRooms obj = new ManageHotelRooms();
            obj.Show();

            this.Hide();
        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            FlightManagerView obj = new FlightManagerView();
            obj.Show();

            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string error;
            string query = "delete from tmp_table";

            DataAccess.ExecuteData(query, out error);

            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManegerBus obj = new ManegerBus();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManegerSignup obj = new ManegerSignup();
            obj.Show();
        }

        private void btnHotels_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageHotels obj = new ManageHotels();
            obj.Show();
        }
    }
}
