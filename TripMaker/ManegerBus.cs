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
    public partial class ManegerBus : MetroFramework.Forms.MetroForm
    {
        public ManegerBus()
        {
            InitializeComponent();
        }
        private void loadgrid()
        {
            string error;
            try
            {
                string query = "select bus_id, bus_company,bus_station_table.station_name as 'departure_station',arrival_station.station_name as 'arrival_station',departure_time,arrival_time,bus_type,price from bus_table inner join bus_station_table on bus_table.departure_station_id=bus_station_table.station_id inner join bus_station_table AS arrival_station on bus_table.arrival_station_id=arrival_station.station_id";
                DataTable dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                metroGrid.DataSource = dt;
                metroGrid.Refresh();
                metroGrid.ClearSelection();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }


        private void ManegerBus_Load(object sender, EventArgs e)
        {
            this.loadgrid();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = metroGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(id);
            }
        }
        private void loaddetail(string id)
        {
            string error;
            try
            {
                var query = "select bus_id,bus_company,bus_station_table.station_name as 'departure_station',arrival_station.station_name as 'arrival_station',departure_time,arrival_time,bus_type,price from bus_table inner join bus_station_table on bus_table.departure_station_id=bus_station_table.station_id inner join bus_station_table AS arrival_station on bus_table.arrival_station_id=arrival_station.station_id where bus_id=" + id + "";

                var dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                txtid.Text = dt.Rows[0]["bus_id"].ToString();
                txtName.Text = dt.Rows[0]["bus_company"].ToString();
                txtds.Text = dt.Rows[0]["departure_station"].ToString();
                txtas.Text = dt.Rows[0]["arrival_station"].ToString();
                txtdt.Text = dt.Rows[0]["departure_time"].ToString();
                txtat.Text = dt.Rows[0]["arrival_time"].ToString();
                txtbt.Text = dt.Rows[0]["bus_type"].ToString();
                txtprice.Text = dt.Rows[0]["price"].ToString();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                if (string.IsNullOrEmpty(txtid.Text))
                {
                    MessageBox.Show("Please Select A Row");
                    return;
                }
                var msg = MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    var query = "delete bus_id, bus_company,bus_station_table.station_name as 'departure_station',arrival_station.station_name as 'arrival_station',departure_time,arrival_time,bus_type,price from bus_table inner join bus_station_table on bus_table.departure_station_id=bus_station_table.station_id inner join bus_station_table AS arrival_station on bus_table.arrival_station_id=arrival_station.station_id where bus_id=" + txtid.Text;
                    DataAccess.ExecuteData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    this.loadgrid();
                    this.newdata();
                    MessageBox.Show("Deleted");
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.loadgrid();
            this.newdata();
        }
        private void newdata()
        {
            txtid.Text = "";
            txtName.Text = "";
            txtds.Text = "";
            txtas.Text = "";
            txtdt.Text = "";
            txtat.Text = "";
            txtbt.Text = "";
            txtprice.Text = "";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string bname = txtName.Text;
            string Ds = txtds.Text;
            string ass= txtas.Text;
            string dt = txtdt.Text;
            string at = txtat.Text;
            string bt = txtbt.Text;
            string price = txtprice.Text;
            string error = "";
            try
            { 
                if (string.IsNullOrEmpty(id))
                {
                   // var query = "insert into ";

                    //var dtt = DataAccess.GetData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                   // txtid.Text = dtt.Rows[0]["Id"].ToString();
                    MessageBox.Show("Buss Details Added");
                }

            }

             catch(Exception ex)
            {

            }

        }
    }
}
