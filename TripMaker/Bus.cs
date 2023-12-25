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

        
    }
}
