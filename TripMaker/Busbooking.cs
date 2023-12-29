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
    public partial class Busbooking : UserControl
    {
        
        private static Busbooking instance;
        public static Busbooking Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Busbooking();
                }
                return instance;
            }
        }

        public static Busbooking setInstance
        {
            set
            {
                instance = value;
            }
        }
        public Busbooking()
        {
            InitializeComponent();
        }
        private string Busname, start, ending, depTime, arrTime, price,btype;
         public string busname
        {
            get
            {
                return Busname;
            }
            set
            {
                Busname = value;
                Lblname.Text = value;
            }
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Busconfirmbook busConfirmBookInstance = Busconfirmbook.Instance;
            busConfirmBookInstance.Busname = this.busname;
            busConfirmBookInstance.Start = this.Start;
            busConfirmBookInstance.Ending = this.Ending;
            busConfirmBookInstance.DepTime = this.DepTime;
            busConfirmBookInstance.ArrTime = this.ArrTime;
            busConfirmBookInstance.Price = this.Price;
            busConfirmBookInstance.Btype= this.Btype;
          //  HotelRoom.HotelNamee = this.lblName.Text;
            Busconfirmbook.Instance.busconfirmbook_Load();
            
            Busconfirmbook.Instance.BringToFront();



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
        public  string Btype
        {
            get
            {
                return btype;
            }
            set
            {
                btype = value;
                lbltype.Text = value;
            }
        }
        
    }
}
