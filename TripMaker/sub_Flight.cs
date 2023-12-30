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
    public partial class sub_Flight : UserControl
    {
        public sub_Flight()
        {
            InitializeComponent();
        }

        private string airLineName;
        private string date;
        private string depTime;
        private string landTime; 
        private string price;

        public string airlineName
        {
            get
            {
                return airLineName;
            }
            set
            {
                airLineName = value;
                lblAirlineName.Text = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                lblDate.Text = value;
            }
        }

        public string DepTime
        {
            get
            {
                return depTime;
            }
            set
            {
                depTime = value;
                lblDepTime.Text = value;
            }
        }
        public string LandTime
        {
            get
            {
                return landTime;
            }
            set
            {
                landTime = value;
                lblLandTime.Text = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                lblPrice.Text = value;
            }
        }


    }
}
