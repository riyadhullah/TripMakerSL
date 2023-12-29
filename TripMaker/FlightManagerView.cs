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
    public partial class FlightManagerView : MetroFramework.Forms.MetroForm
    {
        public FlightManagerView()
        {
            InitializeComponent();
        }

        private void FlightManagerView_Load(object sender, EventArgs e)
        {
            this.loadEventTypes();
        }
        private void loadEventTypes()
        {
            string query = "select * from flight_table";
            string error;

            DataTable dt1 = DataAccess.GetData(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView.DataSource = dt1;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Refresh();
            dataGridView.ClearSelection();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flightidTB.Text = "";
            airlineTB.Text = "";
            arrivalAirportidTB.Text = "";
            departureAirportidTB.Text = "";
            departTB.Text = "";
            arriveTB.Text = "";
            dateTB.Text = "";
            this.loadEventTypes();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.loadDetails(id);

            }
        }
        private void loadDetails(string id)
        {
            var query = "select * from flight_table where flight_id=" + id;
            string error;
            var dt = DataAccess.GetData(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            flightidTB.Text = dt.Rows[0]["flight_id"].ToString();
            airlineTB.Text = dt.Rows[0]["airline"].ToString();
            arrivalAirportidTB.Text = dt.Rows[0]["arrival_airport_id"].ToString();
            departureAirportidTB.Text = dt.Rows[0]["departure_airport_id"].ToString(); ;
            departTB.Text = dt.Rows[0]["departure_airport_id"].ToString();
            arriveTB.Text = dt.Rows[0]["arrival_airport_id"].ToString();
            priceTB.Text = dt.Rows[0]["price"].ToString();
            dateTB.Text = dt.Rows[0]["date"].ToString();

        }
        private void newData()
        {
            flightidTB.Text = "";
            airlineTB.Text = "";
            arrivalAirportidTB.Text = "";
            departureAirportidTB.Text = "";
            departTB.Text = "";
            arriveTB.Text = "";
            priceTB.Text = "";
            dateTB.Text = "";

            dataGridView.ClearSelection();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            newData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightidTB.Text))
            {
                MessageBox.Show("Please select a row first");
                return;
            }
            var result=MessageBox.Show("Are you sure?","Configeration",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var query = "delete from flight_table where flight_id="+flightidTB.Text+"";
                string error;
                DataAccess.ExecuteData(query, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                this.loadEventTypes();
                MessageBox.Show("Deleted!");

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string fid=flightidTB.Text;
            string airline=airlineTB.Text;
            string airportid=arrivalAirportidTB.Text;
            string depAirportid = departureAirportidTB.Text;
            string depart=departTB.Text;
            string arrive=arriveTB.Text;
            string price = priceTB.Text;
            string date = dateTB.Text;

            if (string.IsNullOrEmpty(depart) || string.IsNullOrEmpty(arrive) || string.IsNullOrEmpty(price) ||
                string.IsNullOrEmpty(airportid) || string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill blank text-boxes");
            }

            if (string.IsNullOrEmpty(fid))
            {
                string query = "insert into flight_table(airline, departure_airport_id, arrival_airport_id, departure_datetime, arrival_datetime, price, date) values ('"+airline+"', " + depAirportid + ", "+airportid+", '"+ depart + "', '"+arrive+"', "+price+ ",'" + date + "') ";
                
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.loadEventTypes();
                MessageBox.Show("Updated");
            }
            else
            {
                string query = "update flight_table set airline = '"+airline+ "', departure_airport_id = " + depAirportid + "," +
                    " arrival_airport_id = "+airportid+", departure_datetime = '"+ depart + "', arrival_datetime = '"+arrive+"', " +
                    "price = "+price+ ", date= '" + date + "' where flight_id = " + fid + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.loadEventTypes();
                MessageBox.Show("Updated");
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
