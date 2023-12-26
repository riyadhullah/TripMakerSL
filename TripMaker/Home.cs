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
    public partial class Home : UserControl
    {

        private static Home instance;

        public static Home Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Home();
                }
                return instance;
            }
        }
        public static Home setInstance
        {
            set
            {
                instance = value;
            }

        }

        public Home()
        {
            InitializeComponent();
        }
    }
}
