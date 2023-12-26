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
    public partial class LogoutPanel : UserControl
    {
        private static LogoutPanel instance;

        public static LogoutPanel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogoutPanel();
                }
                return instance;
            }
        }

        public LogoutPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //LoginAndSignupPanel.Instance.BringToFront();

            //Form1 form1 = new Form1();
            //form1.red_panel_changed(true, false, false, false, false, false, false);
            //form1.panel.Controls.Add(Home.Instance);
            //Home.Instance.Dock = DockStyle.Fill;
            //Home.Instance.BringToFront();

            //Form1.

            //Bus.setInstance = null;
            //Login.setInstance = null;
            //Home.setInstance = null;
            //Flight.setInstance = null;
            //Signup.setInstance = null;


            //Form1 form1 = new Form1();

            //form1.load();
            
            string error;
            string query = "delete from tmp_table";

            DataAccess.ExecuteData(query, out error);

        }
    }
}
