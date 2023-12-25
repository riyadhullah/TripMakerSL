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
        public static Flight Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Flight();
                }
                return instance;
            }
        }

        public Flight()
        {
            InitializeComponent();
        }
    }
}
