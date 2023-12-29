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
    public partial class Busconfirmbook : UserControl
    {
      
        private static Busconfirmbook instance;
        public static Busconfirmbook Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Busconfirmbook();
                }
                return instance;
            }
        }

        public static Busconfirmbook setInstance
        {
            set
            {
                instance = value;
            }
        }
        public Busconfirmbook()
        {
            InitializeComponent();
        }
        private string dateTimePicker,busname,start,ending,type,depTime,arrTime,price;
        public string Busname
        {
            get
            {
                return busname;
            }
            set
            {
                busname = value;
                Lblname.Text = value;
            }
        }
        public string Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
                lblstart.Text = value;
            }
        }

        

        public string Ending
        {
            get
            {
                return ending;
            }
            set
            {
                ending = value;
                lblEnding.Text = value;
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
                lbldepT.Text = value;
            }
        }
        public string ArrTime
        {
            get
            {
                return arrTime;
            }
            set
            {
                arrTime = value;
                lblarvT.Text = value;
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
                lblprice.Text = value;
            }
        }
        public string Btype
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                lbltype.Text = value;
            }
        }


        public  string DateTimePicker
        {
            get
            {
                return dateTimePicker;
            }
            set
            {
                dateTimePicker = value;
                lblDate.Text = value;
            }
        }
        public void busconfirmbook_Load()
        {
           
        }
        int count = 0;
        private void btnBook_Click(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked==true)
            {
                count++;
                MessageBox.Show(count+"");
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            Bus.Instance.BringToFront();
            count = 0;
            checkBox1.Checked = false;
        }
    }

}
