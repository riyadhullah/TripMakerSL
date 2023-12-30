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
        private Sub_RoomInfo[] Sub_RoomInfo;
        private static string hotelName;
        private DataTable dt;
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

            dt = DataAccess.GetData(query, out error);

            Sub_RoomInfo = new Sub_RoomInfo[dt.Rows.Count];


            if (Sub_RoomInfo.Length == 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < Sub_RoomInfo.Length; i++)
            {
                try
                {
                    Sub_RoomInfo[i] = new Sub_RoomInfo();
                    Sub_RoomInfo[i].RoomName = dt.Rows[i]["room_type"].ToString();
                    Sub_RoomInfo[i].Breakfast = dt.Rows[i]["breakfast_include"].ToString();
                    Sub_RoomInfo[i].Lunch = dt.Rows[i]["lunch_include"].ToString();
                    Sub_RoomInfo[i].Dinner = dt.Rows[i]["dinner_include"].ToString();
                    Sub_RoomInfo[i].Guest = dt.Rows[i]["guest_per_room"].ToString();
                    Sub_RoomInfo[i].Price = dt.Rows[i]["price_per_night"].ToString() + "TK";

                    flowLayoutPanel1.Controls.Add(Sub_RoomInfo[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            string query3 = "select Id from user_table where userName = (select user_name from tmp_table)";
            string error3;
            int id = 0;

            DataTable dt3 = DataAccess.GetData(query3, out error3);
            try
            {
                id = Int32.Parse(dt3.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {

            }
            MessageBox.Show(id+" id sdds");


            if (dt3.Rows.Count == 0)
            {
                MessageBox.Show("Please login");
                return;
            }


            List<int> index = new List<int>();

            for (int i = 0; i < Sub_RoomInfo.Length; i++)
            {
                if (Sub_RoomInfo[i].checkBox_checker())
                {
                    index.Add(i);
                }
            }
            
            if (index.Count == 0)
            {
                MessageBox.Show("Please select rooms");
                return;
            }


            string dtp1 = Hotel.Instance.DateTimePicker11;
            string dtp2 = Hotel.Instance.DateTimePicker22;

            string query = "select hotel_id from hotel_table where hotel_name = '" + hotelName + "'";
            string error;

            DataTable dt1 = DataAccess.GetData(query, out error);

            if(!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            int hotel_id = Int32.Parse(dt1.Rows[0][0].ToString());
            //MessageBox.Show(hotel_id+" hotel id");

            


            string query1 = "insert into hotel_book_info output inserted.book_id values ('" + dtp1+"', '"+dtp2+"', "+ id + ", "+hotel_id+")";
            string error1;

            DataTable dt2 = DataAccess.GetData(query1, out error1);

            if (!string.IsNullOrEmpty(error1))
            {
                MessageBox.Show(error1);
                return;
            }

            int book_id = Int32.Parse(dt2.Rows[0][0].ToString());
            //MessageBox.Show(book_id + " booking id");

            for (int i = 0; i < index.Count; i++)
            {
                int room_id = Int32.Parse(dt.Rows[index[i]]["room_id"].ToString());

                string query2 = "insert into book_room_relation values (" + book_id + ", " + room_id + ", " + 1 + " )";
                string error2;
                //MessageBox.Show(query2);
                DataAccess.ExecuteData(query2, out error2);
            }

            MessageBox.Show("Successfully booked");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_clear();
            Hotel.Instance.BringToFront();
        }

        public void flowLayoutPanel_clear()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
