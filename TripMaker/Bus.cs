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
        private static Bus instance;
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
            string query = "select * from city_table";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbstart.Items.Add(dt.Rows[i]["city-name"].ToString());
                cmbto.Items.Add(dt.Rows[i]["city-name"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
