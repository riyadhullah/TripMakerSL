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
    public partial class Sub_HotelBookingInfo : UserControl
    {
        public Sub_HotelBookingInfo()
        {
            InitializeComponent();
        }

        private string breakfast;
        private string lunch;
        private string dinner;
        private string hotelName;
        private string roomName;
        private string guest;
        private string totalPrice;
        private string checkin;
        private string checkout;
        private string bookingId;
        private string nightStay;


        public string Breakfast
        {
            get
            {
                return breakfast;
            }
            set
            {
                breakfast = value;
                lblBreakfast.Text = value;
            }
        }

        //[Category("Custom pops")]
        public string Lunch
        {
            get
            {
                return lunch;
            }
            set
            {
                lunch = value;
                lblLunch.Text = value;
            }
        }

        public string Dinner
        {
            get
            {
                return dinner;
            }
            set
            {
                dinner = value;
                lblDinner.Text = value;
            }
        }

        public string HotelName
        {
            get
            {
                return hotelName;
            }
            set
            {
                hotelName = value;
                lblName.Text = value;
            }
        }

        public string RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                roomName = value;
                lblRoomName.Text = value;
            }
        }

        public string Guest
        {
            get
            {
                return guest;
            }
            set
            {
                guest = value;
                lblGuest.Text = value;
            }
        }

        public string TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                lblTotalPrice.Text = value;
            }
        }

        public string Checkin
        {
            get
            {
                return checkin;
            }
            set
            {
                checkin = value;
                lblCheckin.Text = value;
            }
        }

        public string Checkout
        {
            get
            {
                return checkout;
            }
            set
            {
                checkout = value;
                lblCheckout.Text = value;
            }
        }
        
        public string BookingId
        {
            get
            {
                return bookingId;
            }
            set
            {
                bookingId = value;
                lblBookingId.Text = value;
            }
        }

        public string NightStay
        {
            get
            {
                return nightStay;
            }
            set
            {
                nightStay = value;
                lblNightsStay.Text = value;
            }
        }

    }
}
