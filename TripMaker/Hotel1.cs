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
    public partial class Hotel : UserControl
    {
        private HotelName[] listItem;
        private int[] index;
        private static Hotel instance;
        private string dateTimePicker11;
        private string dateTimePicker22;

        public string DateTimePicker11
        {
            get { return dateTimePicker11; }
        }
        
        public string DateTimePicker22
        {
            get { return dateTimePicker22; }
        }

        public static Hotel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Hotel();
                }
                return instance;
            }
        }

        public static Hotel setInstance
        {
            set
            {
                instance = value;
            }
        }

        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            string query = "select * from destination_table";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbDestination.Items.Add(dt.Rows[i]["destination_loc"].ToString());
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*if(string.IsNullOrEmpty(cmbDestination.Text) == true)
            {
                return;
            }

            string query = "select hotel_name, price_per_night, guest_per_room, breakfast_include, lunch_include, dinner_include, room_type from hotel_table inner join hotel_room_table on hotel_room_table.hotel_id = hotel_table.hotel_id where destination_id = (select destination_id from destination_table where destination_loc = '" + cmbDestination.Text+"')";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            listItem = new HotelInfo[dt.Rows.Count];

            index = new int[listItem.Length];

            if (listItem.Length == 0)
            {
                panel.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < listItem.Length; i++)
            {
                try
                {
                    listItem[i] = new HotelInfo();
                    listItem[i].HotelName = dt.Rows[i]["hotel_name"].ToString();
                    listItem[i].RoomName = dt.Rows[i]["room_type"].ToString();
                    listItem[i].Breakfast = dt.Rows[i]["breakfast_include"].ToString();
                    listItem[i].Lunch = dt.Rows[i]["lunch_include"].ToString();
                    listItem[i].Dinner = dt.Rows[i]["dinner_include"].ToString();
                    listItem[i].Guest = dt.Rows[i]["guest_per_room"].ToString();
                    listItem[i].Price = dt.Rows[i]["price_per_night"].ToString()+"TK";

                    flowLayoutPanel1.Controls.Add(listItem[i]);
                    panel.Visible = true;
                }
                catch (Exception ex) 
                {

                }*/
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(cmbDestination.Text) == true)
            {
                return;
            }

            string query = "select hotel_name from hotel_table  where destination_id = (select destination_id from destination_table where destination_loc = '"+ cmbDestination.Text + "')";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            listItem = new HotelName[dt.Rows.Count];

            index = new int[listItem.Length];

            if (listItem.Length == 0)
            {
                panel.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }

            dateTimePicker11 = dateTimePicker1.Value.ToShortDateString();
            dateTimePicker22 = dateTimePicker2.Value.ToShortDateString();

            MessageBox.Show(dateTimePicker11);

            for (int i = 0; i < listItem.Length; i++)
            {
                try
                {
                    listItem[i] = new HotelName();
                    listItem[i].HotelNamee = dt.Rows[i]["hotel_name"].ToString();

                    flowLayoutPanel1.Controls.Add(listItem[i]);
                    panel.Visible = true;
                }
                catch (Exception ex)
                {

                }

            }

        }

    }
}
