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
    public partial class BookingInfo : UserControl
    {
        public BookingInfo()
        {
            InitializeComponent();
        }

        private static BookingInfo instance;
        public static BookingInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingInfo();
                }
                return instance;
            }
        }

        private void btnHotelInfo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();


            string query = @"select * from (select book_room_info.book_id, book_room_info.room_id, check_in, check_out, book_room_info.hotel_id, breakfast_include, 
                            lunch_include, dinner_include, guest_per_room, price_per_night , room_type from 
                            (select book_info.book_id, room_id, check_in, check_out, hotel_id  from (select * from hotel_book_info where user_id = 1006) as book_info
                            inner join book_room_relation on book_info.book_Id = book_room_relation.book_id) as book_room_info
                            inner join hotel_room_table on hotel_room_table.room_id = book_room_info.room_id) as book_hotel_info
                            inner join hotel_table on hotel_table.hotel_id = book_hotel_info.hotel_id";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (dt.Rows.Count == 0)
            {
                panelHotelBook.Visible = true;
                flowLayoutPanel1.Controls.Clear();
            }

            Sub_HotelBookingInfo[] listItem = new Sub_HotelBookingInfo[dt.Rows.Count];


            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new Sub_HotelBookingInfo();

                DateTime date1 = DateTime.Parse(dt.Rows[i]["check_in"].ToString());
                DateTime date2 = DateTime.Parse(dt.Rows[i]["check_out"].ToString());
                int day = (date2 - date1).Days;

                listItem[i].HotelName = dt.Rows[i]["hotel_name"].ToString();
                listItem[i].RoomName = dt.Rows[i]["room_type"].ToString();
                listItem[i].Breakfast = dt.Rows[i]["breakfast_include"].ToString();
                listItem[i].Lunch = dt.Rows[i]["lunch_include"].ToString();
                listItem[i].Dinner = dt.Rows[i]["dinner_include"].ToString();
                listItem[i].Guest = dt.Rows[i]["guest_per_room"].ToString();
                listItem[i].BookingId = "Booking Id : " + dt.Rows[i]["book_id"].ToString();
                listItem[i].Checkin = dt.Rows[i]["check_in"].ToString();
                listItem[i].Checkout = dt.Rows[i]["check_out"].ToString();
                listItem[i].NightStay = "Nights Stay : " + day;
                listItem[i].TotalPrice = day +" * "+ dt.Rows[i]["price_per_night"]+" = " + (day* Int32.Parse(dt.Rows[i]["price_per_night"].ToString()));

                //MessageBox.Show(day+"");

                flowLayoutPanel1.Controls.Add(listItem[i]);
                lblSelectOne.Visible = false;
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hotel.Instance.BringToFront();
        }
    }
}
