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
        private Sub_HotelName[] sub_HotelName;
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
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbDestination.Items.Add(dt.Rows[i]["destination_loc"].ToString());
                }
            }
            catch(Exception ex)
            {

            }
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(cmbDestination.Text) == true)
            {
                return;
            }

            string query = "select hotel_name from hotel_table  where destination_id = (select destination_id from destination_table where destination_loc = '"+ cmbDestination.Text + "')";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            sub_HotelName = new Sub_HotelName[dt.Rows.Count];

            index = new int[sub_HotelName.Length];

            if (sub_HotelName.Length == 0)
            {
                panel.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }

            dateTimePicker11 = dateTimePicker1.Value.ToShortDateString();
            dateTimePicker22 = dateTimePicker2.Value.ToShortDateString();

            //MessageBox.Show(dateTimePicker11);
            //MessageBox.Show(dateTimePicker22);

            for (int i = 0; i < sub_HotelName.Length; i++)
            {
                try
                {
                    sub_HotelName[i] = new Sub_HotelName();
                    sub_HotelName[i].HotelNamee = dt.Rows[i]["hotel_name"].ToString();

                    flowLayoutPanel1.Controls.Add(sub_HotelName[i]);
                    panel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

    }
}
