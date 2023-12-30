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
    public partial class Flight : UserControl
    {

        private static Flight instance;
        private sub_Flight[] sub_Flight;

        public string dateTimePicker11;

        public string DateTimePicker11
        {
            get { return dateTimePicker11; }
        }

        public static Flight Instance
        {
            get
            {
                if (instance == null)
                {
                    //MessageBox.Show("Null");
                    instance = new Flight();
                }
                return instance;
            }
        }
        public static Flight setInstance
        {
            set
            {
                instance = value;
            }
        }

        public Flight()
        {
            InitializeComponent();
        }

        private void Flight_Load(object sender, EventArgs e)
        {


            /*string query = "select * from flight_table inner join airport_table on flight_id=airport_id";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);


              
            try
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbFromAirport.Items.Add(dt.Rows[i]["airport_name"].ToString());
                    
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    cbToAirport.Items.Add(dt.Rows[i]["airport_name"].ToString());

                }
            }
            catch (Exception ex)
            {

            }*/




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbFromAirport.Text==cbToAirport.Text)
            {
                MessageBox.Show("Airports must be different!");
            }
            if (cbFromAirport.Text.Contains("Chittagong Airport") && cbToAirport.Text.Contains("Cumilla Airport"))
            {
                labelAirways.Text = "Bangladesh Biman";
                labelRoute.Text = "Chittagong To Cumilla";
                labelTime.Text = "7 am";
                labelTaka.Text = "3500 BDT";

            }

            if (cbFromAirport.Text.Contains("Chittagong Airport") && cbToAirport.Text.Contains("Dhaka Airport"))
            {
                labelAirways.Text = "US-Bangla Airways";
                labelRoute.Text = "Chittagong To Dhaka";
                labelTime.Text = "10 am";
                labelTaka.Text = "6500 BDT";

            }

            if (cbFromAirport.Text.Contains("Cumilla Airport") && cbToAirport.Text.Contains("Dhaka Airport"))
            {
                labelAirways.Text = "AIUB Airways";
                labelRoute.Text = "Cumilla To Dhaka";
                labelTime.Text = "9 am";
                labelTaka.Text = "3500 BDT";

            }
            if (cbFromAirport.Text.Contains("Cumilla Airport") && cbToAirport.Text.Contains("Chittagong Airport"))
            {
                labelAirways.Text = "Palestine Airways";
                labelRoute.Text = "Cumilla To Chittagong";
                labelTime.Text = "9 pm";
                labelTaka.Text = "3000 BDT";

            }
            if (cbFromAirport.Text.Contains("Dhaka Airport") && cbToAirport.Text.Contains("Cumilla Airport"))
            {
                labelAirways.Text = "New Airways";
                labelRoute.Text = "Dhaka To Cumilla";
                labelTime.Text = "9 am";
                labelTaka.Text = "3500 BDT";

            }
            if (cbFromAirport.Text.Contains("Dhaka Airport") && cbToAirport.Text.Contains("Chittagong Airport"))
            {
                labelAirways.Text = "US-Bangla Airways";
                labelRoute.Text = "Dhaka To Chittagong";
                labelTime.Text = "10 pm";
                labelTaka.Text = "6500 BDT";

            }


            /*
            Chittagong Airport
            Cumilla Airport
            Dhaka Airport
              try
            {
                flowLayoutPanel1.Controls.Clear();

                if (string.IsNullOrEmpty(cbFromAirport.Text) == true)
                {

                    return;
                }
                if (string.IsNullOrEmpty(cbToAirport.Text) == true)
                {
                    return;
                }

            //MessageBox.Show(cbFromAirport+"");


                string query1 = "select * from airport_table where airport_name = '"+cbFromAirport.Text+"'";
                string error1;

           

                DataTable dt = DataAccess.GetData(query1, out error1);

                string s = dt.Rows[0]["airport_id"].ToString();

                int departure_airport_id = Int32.Parse(s);

                MessageBox.Show(departure_airport_id+"");

                string query2 = "select * from airport_table where airport_name = '"+cbToAirport.Text+"'";
                string error2;


                DataTable dt1 = DataAccess.GetData(query2, out error2);

                string s1 = dt1.Rows[0]["airport_id"].ToString();
                int arrival_airport_id = Int32.Parse(s1);



                string query = "select * from flight_table inner join airport_table on(airport_id = "+departure_airport_id+" ) and( airport_id = "+ arrival_airport_id + ")";
                string error;


                DataTable dt2 = DataAccess.GetData(query, out error);


            
                sub_Flight = new sub_Flight[dt2.Rows.Count];

                //index = new int[sub_Flight.Length];

                if (sub_Flight.Length == 0)
                {
                    panel.Visible = false;
                    flowLayoutPanel1.Controls.Clear();
                }

                dateTimePicker11 = dateTimePicker1.Value.ToShortDateString();

                //MessageBox.Show(dateTimePicker11);

                for (int i = 0; i < sub_Flight.Length; i++)
                {
                    try
                    {
                        sub_Flight[i] = new sub_Flight();
                        //sub_Flight[i].airlineName = "defghgjh";
                        sub_Flight[i].airlineName = dt.Rows[i][1].ToString();

                        flowLayoutPanel1.Controls.Add(sub_Flight[i]);
                        panel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("adsfgbhn");

            }*/


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelCTGtoDhaka_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
