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
        private static Hotel instance;
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

            int x = dt.Rows.Count;
            string s = "d";

            for (int i = 0; i < x; i++)
            {
                cmbDestination.Items.Add(dt.Rows[i]["destination_loc"].ToString());
            }

        }
    }
}
