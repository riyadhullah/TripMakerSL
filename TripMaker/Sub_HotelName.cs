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
    public partial class Sub_HotelName : UserControl
    {
        public Sub_HotelName()
        {
            InitializeComponent();
        }

        private static Sub_HotelName instance;

        public static Sub_HotelName Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sub_HotelName();
                }
                return instance;
            }
        }

        public static Sub_HotelName setInstance
        {
            set
            {
                instance = value;
            }
        }

        private string hotelName;

        public string HotelNamee
        {
            get
            {
                return hotelName;
            }
            set
            {
                hotelName = value;
                lblName.Text = value;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            HotelRoom.HotelNamee = this.lblName.Text;
            HotelRoom.Instance.HotelRoom_Load();

            HotelRoom.Instance.BringToFront();

        }
    }
}
