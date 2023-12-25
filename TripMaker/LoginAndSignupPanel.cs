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
    public partial class LoginAndSignupPanel : UserControl
    {
        private static LoginAndSignupPanel instance;

        public static LoginAndSignupPanel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginAndSignupPanel();
                }
                return instance;
            }
        }

        public LoginAndSignupPanel()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.Instance.BringToFront();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            Signup.Instance.BringToFront();
        }
    }
}
