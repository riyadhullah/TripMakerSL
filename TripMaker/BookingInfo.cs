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

            string query3 = "select Id from user_table where userName = (select user_name from tmp_table)";
            string error3;

            DataTable dt3 = DataAccess.GetData(query3, out error3);
            int id = 0;

            if (dt3.Rows.Count == 0)
            {
                MessageBox.Show("Please login");
                return;
            }

            try
            {
                id = Int32.Parse(dt3.Rows[0][0].ToString());

            }
            catch (Exception ex)
            { }
            
            //MessageBox.Show(id+"");

            string query = @"select * from (select book_room_info.book_id, book_room_info.room_id, check_in, check_out, book_room_info.hotel_id, breakfast_include, 
                            lunch_include, dinner_include, guest_per_room, price_per_night , room_type from 
                            (select book_info.book_id, room_id, check_in, check_out, hotel_id  from (select * from hotel_book_info 
                            where [user_id] = "+id+") as book_info inner join book_room_relation on book_info.book_Id = book_room_relation.book_id) as book_room_info inner join hotel_room_table on hotel_room_table.room_id = book_room_info.room_id) as book_hotel_info inner join hotel_table on hotel_table.hotel_id = book_hotel_info.hotel_id";
            string error = "";
            
            DataTable dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            if (dt.Rows.Count == 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            Sub_HotelBookingInfo[] sub_HotelBookingInfo = new Sub_HotelBookingInfo[dt.Rows.Count];


            for (int i = sub_HotelBookingInfo.Length-1; i >= 0; i--)
            {
                sub_HotelBookingInfo[i] = new Sub_HotelBookingInfo();

                DateTime date1 = DateTime.Parse(dt.Rows[i]["check_in"].ToString());
                DateTime date2 = DateTime.Parse(dt.Rows[i]["check_out"].ToString());
                int day = (date2 - date1).Days;

                sub_HotelBookingInfo[i].HotelName = dt.Rows[i]["hotel_name"].ToString();
                sub_HotelBookingInfo[i].RoomName = dt.Rows[i]["room_type"].ToString();
                sub_HotelBookingInfo[i].Breakfast = dt.Rows[i]["breakfast_include"].ToString();
                sub_HotelBookingInfo[i].Lunch = dt.Rows[i]["lunch_include"].ToString();
                sub_HotelBookingInfo[i].Dinner = dt.Rows[i]["dinner_include"].ToString();
                sub_HotelBookingInfo[i].Guest = dt.Rows[i]["guest_per_room"].ToString();
                sub_HotelBookingInfo[i].BookingId = "Booking Id : " + dt.Rows[i]["book_id"].ToString();
                sub_HotelBookingInfo[i].Checkin = dt.Rows[i]["check_in"].ToString();
                sub_HotelBookingInfo[i].Checkout = dt.Rows[i]["check_out"].ToString();
                sub_HotelBookingInfo[i].NightStay = "Nights Stay : " + day;
                sub_HotelBookingInfo[i].TotalPrice = day +" * "+ dt.Rows[i]["price_per_night"]+" = " + (day* Int32.Parse(dt.Rows[i]["price_per_night"].ToString()));

                //MessageBox.Show(day+"");

                flowLayoutPanel1.Controls.Add(sub_HotelBookingInfo[i]);
                lblSelectOne.Visible = false;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Hotel.Instance.BringToFront();
        }

        private void btnFlightInfo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnBusInfo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
