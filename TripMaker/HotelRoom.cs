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
    public partial class HotelRoom : UserControl
    {
        private HotelInfo[] listItem;
        private int[] index;
        private static string hotelName;
        public HotelRoom()
        {
            InitializeComponent();
        }


        private static HotelRoom instance;

        public static HotelRoom Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HotelRoom();
                }
                return instance;
            }
        }

        public static HotelRoom setInstance
        {
            set
            {
                instance = value;
            }
        }


        public static string HotelNamee
        {
            get
            {
                return hotelName;
            }
            set
            {
                hotelName = value;
            }
        }


        public void HotelRoom_Load()
        {

            lblHotelName.Text = hotelName;

            string query = "select * from hotel_room_table where hotel_id = (select hotel_id from hotel_table where hotel_name = '"+ hotelName + "')";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            listItem = new HotelInfo[dt.Rows.Count];

            index = new int[listItem.Length];

            if (listItem.Length == 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < listItem.Length; i++)
            {
                try
                {
                    listItem[i] = new HotelInfo();
                    listItem[i].RoomName = dt.Rows[i]["room_type"].ToString();
                    listItem[i].Breakfast = dt.Rows[i]["breakfast_include"].ToString();
                    listItem[i].Lunch = dt.Rows[i]["lunch_include"].ToString();
                    listItem[i].Dinner = dt.Rows[i]["dinner_include"].ToString();
                    listItem[i].Guest = dt.Rows[i]["guest_per_room"].ToString();
                    listItem[i].Price = dt.Rows[i]["price_per_night"].ToString() + "TK";

                    flowLayoutPanel1.Controls.Add(listItem[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < listItem.Length; i++)
            {
                if (listItem[i].checkBox_checker())
                {
                    list.Add(i);
                }
            }

            string s = "";
            foreach (int num in list)
            {
                
                s = num + s;
                
            }
            MessageBox.Show(s);
        }
    }
}
