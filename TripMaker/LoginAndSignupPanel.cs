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
            Form1.Instance.red_panel_changed(false, false, false, false, false, false, false);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form1.Instance.red_panel_changed(false, false, false, false, false, false, false);
            Signup.Instance.BringToFront();
        }
    }
}
