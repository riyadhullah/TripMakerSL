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
    public partial class ManageHotels : MetroFramework.Forms.MetroForm
    {
        public ManageHotels()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome obj = new AdminHome();
            obj.Show();
        }

        private void ManageHotels_Load(object sender, EventArgs e)
        {
            load();

            var query = "select * from destination_table";
            string error;

            var dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }


            if (dt == null)
            {
                return;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbDestination.Items.Add(dt.Rows[i]["destination_loc"].ToString());
            }
        }

        private void load()
        {
            string query = "select * from hotel_table";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            dgvManageHotels.AutoGenerateColumns = false;
            dgvManageHotels.DataSource = dt;
            dgvManageHotels.Refresh();
            dgvManageHotels.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
            newData();
        }

        private void newData()
        {
            txtId.Text = "";
            txtHotelName.Text = "";
            txtDestination.Text = "";
            dgvManageHotels.Refresh();
            dgvManageHotels.ClearSelection();
        }

        private void dgvManageHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvManageHotels.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loadDetails(id);
            }
        }

        private void loadDetails(string id)
        {
            var query = "select * from hotel_table where hotel_id = " + id + "";
            string error;

            var dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            txtId.Text = dt.Rows[0]["hotel_id"].ToString();
            txtDestination.Text = dt.Rows[0]["destination_id"].ToString();
            txtHotelName.Text = dt.Rows[0]["hotel_name"].ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            load();
            newData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select a row");
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string query = "delete from hotel_table where hotel_id = " + txtId.Text;
            string error = "";

            DataAccess.ExecuteData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            this.load();
            this.newData();
            MessageBox.Show("Deleted");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hotel_id = txtId.Text;
            string hotel_name = txtHotelName.Text;
            string destination_id = txtDestination.Text;

            if (string.IsNullOrEmpty(hotel_id))
            {
                string query = "insert into hotel_table values ('"+hotel_name+" ', "+destination_id+" )";
                string error = "";

                DataAccess.ExecuteData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Inviled");
                    return;
                }

                newData();
                load();
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                string query = @"update hotel_table set hotel_name = '"+hotel_name+ "', destination_id = "+ destination_id + " where hotel_id = "+hotel_id+"";
                string error = "";

                DataAccess.ExecuteData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Inviled");
                    return;
                }

                newData();
                load();
                MessageBox.Show("Successfully updated");

            }
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string destination_loc = cmbDestination.SelectedItem.ToString();
            var query = "select destination_Id from destination_table where destination_loc = '"+ destination_loc + "'";
            string error;

            var dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            txtDestination.Text = dt.Rows[0][0].ToString();
        }

    }



}
