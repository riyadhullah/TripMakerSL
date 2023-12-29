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
    public partial class Bus : UserControl
    {
        private Busbooking[] operetor;
        private int[] index;
        private  string dateTimePicker;
        private static Bus instance;

        public  string DateTimePicker
        {
            get
            { 
                return dateTimePicker; 
            }
           
        }
        
        public static Bus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bus();
                }
                return instance;
            }
        }

        public static Bus setInstance
        {
            set
            {
                instance = value;
            }
        }

        public Bus()
        {
            InitializeComponent();
        }
        
        private void Bus_Load(object sender, EventArgs e)
        {
            string query = "select * from bus_station_table";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbstart.Items.Add(dt.Rows[i]["station_name"].ToString());
                cmbto.Items.Add(dt.Rows[i]["station_name"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "select * from bus_table  where departure_station_id = (select station_id from bus_station_table  where station_name = '"+cmbstart.Text+"')  and  arrival_station_id = (select station_id from bus_station_table  where station_name = '"+cmbto.Text+"')";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
           
            operetor = new Busbooking[dt.Rows.Count];
            index = new int[operetor.Length];
            if (operetor.Length == 0)
            {
                panel.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }

            dateTimePicker = dtbjourney.Value.ToShortDateString();
            Busconfirmbook.Instance.DateTimePicker = this.dateTimePicker;

            for (int i = 0; i < operetor.Length; i++)
            {
                try
                {
                    operetor[i] = new Busbooking();
                    operetor[i].busname = dt.Rows[i]["bus_company"].ToString();
                    operetor[i].Start = cmbstart.Text;
                    operetor[i].Ending = cmbto.Text;
                    operetor[i].DepTime = dt.Rows[i]["departure_time"].ToString();
                    operetor[i].ArrTime = dt.Rows[i]["arrival_time"].ToString();
                    operetor[i].Price = dt.Rows[i]["price"].ToString();
                    operetor[i].Btype = dt.Rows[i]["bus_type"].ToString();

                    flowLayoutPanel1.Controls.Add(operetor[i]);
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
