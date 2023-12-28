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
    public partial class HotelName : UserControl
    {
        public HotelName()
        {
            InitializeComponent();
        }

        private static HotelName instance;

        public static HotelName Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HotelName();
                }
                return instance;
            }
        }

        public static HotelName setInstance
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
