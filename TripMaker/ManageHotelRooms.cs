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
    public partial class ManageHotelRooms : MetroFramework.Forms.MetroForm
    {
        public ManageHotelRooms()
        {
            InitializeComponent();
        }

        private void ManageHotelRooms_Load(object sender, EventArgs e)
        {
            load();

            var query = "select * from hotel_table";
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
                cmbHotel.Items.Add(dt.Rows[i]["hotel_name"].ToString());
            }
        }

        private void load()
        {
            string query = "select * from hotel_room_table";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            dgvManageHotelRooms.AutoGenerateColumns = false;
            dgvManageHotelRooms.DataSource = dt;
            dgvManageHotelRooms.Refresh();
            dgvManageHotelRooms.ClearSelection();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
            newData();
        }

        private void dgvManageHotelRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvManageHotelRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loadDetails(id);
            }
        }

        private void loadDetails(string id)
        {
            var query = "select * from hotel_room_table where room_id = "+id+"";
            string error;

            var dt = DataAccess.GetData(query, out error);

            if(!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            txtId.Text = dt.Rows[0]["room_id"].ToString();
            txtPrice.Text = dt.Rows[0]["price_per_night"].ToString();
            txtRoomType.Text = dt.Rows[0]["room_type"].ToString();
            txtGuest.Text = dt.Rows[0]["guest_per_room"].ToString();
            txtHotelid.Text = dt.Rows[0]["hotel_id"].ToString();

            if (dt.Rows[0]["breakfast_include"].ToString().Contains("Yes"))
            {
                rbBreakfastYes.Select();
            }
            else
            {
                rbBreakfastNo.Select();
            }

            if (dt.Rows[0]["lunch_include"].ToString().Contains("Yes"))
            {
                rbLunchYes.Select();
            }
            else
            {
                rbLunchNo.Select();
            }

            if (dt.Rows[0]["dinner_include"].ToString().Contains("Yes"))
            {
                rbDinnerYes.Select();
            }
            else
            {
                rbDinnerNo.Select();
            }

        }

        private void newData()
        {
            txtId.Text = "";
            txtPrice.Text = "";
            txtRoomType.Text = "";
            txtGuest.Text = "";
            txtHotelid.Text = "";
            rbLunchYes.Checked = false;
            rbLunchNo.Checked = false;
            rbBreakfastYes.Checked = false;
            rbBreakfastNo.Checked = false;
            rbDinnerYes.Checked = false;
            rbDinnerNo.Checked = false;
            dgvManageHotelRooms.Refresh();
            dgvManageHotelRooms.ClearSelection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newData();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select a row");
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.Yes)
            {
                string query = "delete from hotel_room_table where room_id = "+txtId.Text;
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string room_id = txtId.Text;
            string price = txtPrice.Text;
            string room_type = txtRoomType.Text;
            string guest = txtGuest.Text;
            string hotel_id = txtHotelid.Text;
            string breakfast = "";
            string lunch = "";
            string dinner = "";


            if (rbBreakfastYes.Checked)
            {
                breakfast = "Yes";
            }
            else if(rbBreakfastNo.Checked)
            {
                breakfast = "No";
            }

            if (rbLunchYes.Checked)
            {
                lunch = "Yes";
            }
            else if(rbLunchNo.Checked)
            {
                lunch = "No";
            }

            if (rbDinnerYes.Checked)
            {
                dinner = "Yes";
            }
            else if (rbDinnerNo.Checked)
            {
                dinner = "No";
            }


            if(string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Invalid price");
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(room_type))
            {
                MessageBox.Show("Invalid room type");
                txtRoomType.Focus();
                return;
            }
            if (string.IsNullOrEmpty(guest))
            {
                MessageBox.Show("Invalid guest");
                txtGuest.Focus();
                return;
            }
            if (string.IsNullOrEmpty(hotel_id))
            {
                MessageBox.Show("Invalid hotel id");
                txtHotelid.Focus();
                return;
            }
            if (string.IsNullOrEmpty(breakfast))
            {
                MessageBox.Show("Invalid breakfast");
                return;
            }
            if (string.IsNullOrEmpty(lunch))
            {
                MessageBox.Show("Invalid lunch");
                return;
            }
            if (string.IsNullOrEmpty(dinner))
            {
                MessageBox.Show("Invalid dinner");
                return;
            }


            if (string.IsNullOrEmpty(room_id))
            {
                string query = "insert into hotel_room_table values (" + price + ",'" + breakfast + "','" + lunch + "','" + dinner + "', '" + room_type + "', " + guest + ", " + hotel_id + ")";
                string error = "";

                DataAccess.ExecuteData(query, out error);

                if(!string.IsNullOrEmpty(error))
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
                string query = @"update hotel_room_table set price_per_night = "+price+", breakfast_include = '"+breakfast+"', lunch_include = '"+lunch+"', dinner_include = '"+dinner+"', room_type = '"+room_type+"', guest_per_room = "+guest+", hotel_id = "+hotel_id+" where room_id = "+room_id+"";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome obj = new AdminHome();
            obj.Show();
        }

        private void ManageHotelRooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AdminHome obj = new AdminHome();
            obj.Show();
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hotel = cmbHotel.SelectedItem.ToString();
            var query = "select hotel_id from hotel_table where hotel_name = '" + hotel + "'";
            string error;

            var dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            txtHotelid.Text = dt.Rows[0][0].ToString();
        }
    }
}
