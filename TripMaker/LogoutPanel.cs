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
            LoginAndSignupPanel.Instance.BringToFront();
            
            string error;
            string query = "delete from tmp_table";

            DataAccess.ExecuteData(query, out error);

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile.Instance.BringToFront();
        }
    }
}
