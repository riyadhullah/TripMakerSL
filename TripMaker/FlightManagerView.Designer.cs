
namespace TripMaker
{
    partial class FlightManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView = new MetroFramework.Controls.MetroGrid();
            this.DGVflight_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVdeparture_airport_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVarrival_airport_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVairline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVdeparture_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVarrival_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.newBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dateTB = new MetroFramework.Controls.MetroDateTime();
            this.dateLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.departureAirportidTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.arrivalAirportidTB = new MetroFramework.Controls.MetroTextBox();
            this.departTB = new MetroFramework.Controls.MetroTextBox();
            this.arriveTB = new MetroFramework.Controls.MetroTextBox();
            this.priceTB = new MetroFramework.Controls.MetroTextBox();
            this.airlineTB = new MetroFramework.Controls.MetroTextBox();
            this.flightidTB = new MetroFramework.Controls.MetroTextBox();
            this.arrivalTimeLbl = new MetroFramework.Controls.MetroLabel();
            this.depTimeLbl = new MetroFramework.Controls.MetroLabel();
            this.priceLbl = new MetroFramework.Controls.MetroLabel();
            this.airportidLbl = new MetroFramework.Controls.MetroLabel();
            this.AirlineLbl = new MetroFramework.Controls.MetroLabel();
            this.flightidLbl = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 720);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroPanel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(353, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(804, 714);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.dataGridView);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 53);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(798, 658);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVflight_id,
            this.DGVdeparture_airport_id,
            this.DGVarrival_airport_id,
            this.DGVairline,
            this.Date,
            this.DGVdeparture_datetime,
            this.DGVarrival_datetime,
            this.DGVprice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(796, 656);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // DGVflight_id
            // 
            this.DGVflight_id.DataPropertyName = "flight_id";
            this.DGVflight_id.FillWeight = 40F;
            this.DGVflight_id.HeaderText = "Flight ID";
            this.DGVflight_id.MinimumWidth = 6;
            this.DGVflight_id.Name = "DGVflight_id";
            this.DGVflight_id.ReadOnly = true;
            this.DGVflight_id.Width = 40;
            // 
            // DGVdeparture_airport_id
            // 
            this.DGVdeparture_airport_id.DataPropertyName = "departure_airport_id";
            this.DGVdeparture_airport_id.FillWeight = 50F;
            this.DGVdeparture_airport_id.HeaderText = "Departure Airport ID";
            this.DGVdeparture_airport_id.MinimumWidth = 6;
            this.DGVdeparture_airport_id.Name = "DGVdeparture_airport_id";
            this.DGVdeparture_airport_id.ReadOnly = true;
            this.DGVdeparture_airport_id.Width = 70;
            // 
            // DGVarrival_airport_id
            // 
            this.DGVarrival_airport_id.DataPropertyName = "arrival_airport_id";
            this.DGVarrival_airport_id.FillWeight = 50F;
            this.DGVarrival_airport_id.HeaderText = "Arrival Airport ID";
            this.DGVarrival_airport_id.MinimumWidth = 6;
            this.DGVarrival_airport_id.Name = "DGVarrival_airport_id";
            this.DGVarrival_airport_id.ReadOnly = true;
            this.DGVarrival_airport_id.Width = 70;
            // 
            // DGVairline
            // 
            this.DGVairline.DataPropertyName = "airline";
            this.DGVairline.FillWeight = 150F;
            this.DGVairline.HeaderText = "Airline";
            this.DGVairline.MinimumWidth = 6;
            this.DGVairline.Name = "DGVairline";
            this.DGVairline.ReadOnly = true;
            this.DGVairline.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 60;
            // 
            // DGVdeparture_datetime
            // 
            this.DGVdeparture_datetime.DataPropertyName = "departure_datetime";
            this.DGVdeparture_datetime.HeaderText = "Departure Time";
            this.DGVdeparture_datetime.MinimumWidth = 6;
            this.DGVdeparture_datetime.Name = "DGVdeparture_datetime";
            this.DGVdeparture_datetime.ReadOnly = true;
            this.DGVdeparture_datetime.Width = 60;
            // 
            // DGVarrival_datetime
            // 
            this.DGVarrival_datetime.DataPropertyName = "arrival_datetime";
            this.DGVarrival_datetime.HeaderText = "Arrival Time";
            this.DGVarrival_datetime.MinimumWidth = 6;
            this.DGVarrival_datetime.Name = "DGVarrival_datetime";
            this.DGVarrival_datetime.ReadOnly = true;
            this.DGVarrival_datetime.Width = 60;
            // 
            // DGVprice
            // 
            this.DGVprice.DataPropertyName = "price";
            this.DGVprice.HeaderText = "Price";
            this.DGVprice.MinimumWidth = 6;
            this.DGVprice.Name = "DGVprice";
            this.DGVprice.ReadOnly = true;
            this.DGVprice.Width = 60;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.btnBack);
            this.metroPanel3.Controls.Add(this.newBtn);
            this.metroPanel3.Controls.Add(this.deleteBtn);
            this.metroPanel3.Controls.Add(this.refreshBtn);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(798, 44);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(23, 4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New";
            this.newBtn.UseSelectable = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(144, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(265, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 714);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.dateTB);
            this.metroPanel2.Controls.Add(this.dateLbl);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.departureAirportidTB);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.arrivalAirportidTB);
            this.metroPanel2.Controls.Add(this.departTB);
            this.metroPanel2.Controls.Add(this.arriveTB);
            this.metroPanel2.Controls.Add(this.priceTB);
            this.metroPanel2.Controls.Add(this.airlineTB);
            this.metroPanel2.Controls.Add(this.flightidTB);
            this.metroPanel2.Controls.Add(this.arrivalTimeLbl);
            this.metroPanel2.Controls.Add(this.depTimeLbl);
            this.metroPanel2.Controls.Add(this.priceLbl);
            this.metroPanel2.Controls.Add(this.airportidLbl);
            this.metroPanel2.Controls.Add(this.AirlineLbl);
            this.metroPanel2.Controls.Add(this.flightidLbl);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 53);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(338, 658);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dateTB
            // 
            this.dateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTB.Location = new System.Drawing.Point(121, 465);
            this.dateTB.MaxDate = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            this.dateTB.MinDate = new System.DateTime(2023, 12, 29, 16, 8, 1, 0);
            this.dateTB.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(212, 30);
            this.dateTB.TabIndex = 20;
            this.dateTB.Value = new System.DateTime(2023, 12, 29, 16, 8, 1, 0);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.dateLbl.Location = new System.Drawing.Point(49, 465);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(46, 20);
            this.dateLbl.TabIndex = 18;
            this.dateLbl.Text = "Date:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(17, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Arrival";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(12, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Airport ID:";
            // 
            // departureAirportidTB
            // 
            // 
            // 
            // 
            this.departureAirportidTB.CustomButton.Image = null;
            this.departureAirportidTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.departureAirportidTB.CustomButton.Name = "";
            this.departureAirportidTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.departureAirportidTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.departureAirportidTB.CustomButton.TabIndex = 1;
            this.departureAirportidTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.departureAirportidTB.CustomButton.UseSelectable = true;
            this.departureAirportidTB.CustomButton.Visible = false;
            this.departureAirportidTB.Lines = new string[0];
            this.departureAirportidTB.Location = new System.Drawing.Point(121, 142);
            this.departureAirportidTB.MaxLength = 32767;
            this.departureAirportidTB.Name = "departureAirportidTB";
            this.departureAirportidTB.PasswordChar = '\0';
            this.departureAirportidTB.PromptText = "****";
            this.departureAirportidTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.departureAirportidTB.SelectedText = "";
            this.departureAirportidTB.SelectionLength = 0;
            this.departureAirportidTB.SelectionStart = 0;
            this.departureAirportidTB.ShortcutsEnabled = true;
            this.departureAirportidTB.Size = new System.Drawing.Size(212, 30);
            this.departureAirportidTB.TabIndex = 15;
            this.departureAirportidTB.UseSelectable = true;
            this.departureAirportidTB.WaterMark = "****";
            this.departureAirportidTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.departureAirportidTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.departureAirportidTB.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(12, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Departure";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // arrivalAirportidTB
            // 
            // 
            // 
            // 
            this.arrivalAirportidTB.CustomButton.Image = null;
            this.arrivalAirportidTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.arrivalAirportidTB.CustomButton.Name = "";
            this.arrivalAirportidTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.arrivalAirportidTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arrivalAirportidTB.CustomButton.TabIndex = 1;
            this.arrivalAirportidTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arrivalAirportidTB.CustomButton.UseSelectable = true;
            this.arrivalAirportidTB.CustomButton.Visible = false;
            this.arrivalAirportidTB.Lines = new string[0];
            this.arrivalAirportidTB.Location = new System.Drawing.Point(121, 205);
            this.arrivalAirportidTB.MaxLength = 32767;
            this.arrivalAirportidTB.Name = "arrivalAirportidTB";
            this.arrivalAirportidTB.PasswordChar = '\0';
            this.arrivalAirportidTB.PromptText = "****";
            this.arrivalAirportidTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arrivalAirportidTB.SelectedText = "";
            this.arrivalAirportidTB.SelectionLength = 0;
            this.arrivalAirportidTB.SelectionStart = 0;
            this.arrivalAirportidTB.ShortcutsEnabled = true;
            this.arrivalAirportidTB.Size = new System.Drawing.Size(212, 30);
            this.arrivalAirportidTB.TabIndex = 13;
            this.arrivalAirportidTB.UseSelectable = true;
            this.arrivalAirportidTB.WaterMark = "****";
            this.arrivalAirportidTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arrivalAirportidTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // departTB
            // 
            // 
            // 
            // 
            this.departTB.CustomButton.Image = null;
            this.departTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.departTB.CustomButton.Name = "";
            this.departTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.departTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.departTB.CustomButton.TabIndex = 1;
            this.departTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.departTB.CustomButton.UseSelectable = true;
            this.departTB.CustomButton.Visible = false;
            this.departTB.Lines = new string[0];
            this.departTB.Location = new System.Drawing.Point(121, 270);
            this.departTB.MaxLength = 32767;
            this.departTB.Name = "departTB";
            this.departTB.PasswordChar = '\0';
            this.departTB.PromptText = "Enter Time";
            this.departTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.departTB.SelectedText = "";
            this.departTB.SelectionLength = 0;
            this.departTB.SelectionStart = 0;
            this.departTB.ShortcutsEnabled = true;
            this.departTB.Size = new System.Drawing.Size(212, 30);
            this.departTB.TabIndex = 12;
            this.departTB.UseSelectable = true;
            this.departTB.WaterMark = "Enter Time";
            this.departTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.departTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // arriveTB
            // 
            // 
            // 
            // 
            this.arriveTB.CustomButton.Image = null;
            this.arriveTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.arriveTB.CustomButton.Name = "";
            this.arriveTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.arriveTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arriveTB.CustomButton.TabIndex = 1;
            this.arriveTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arriveTB.CustomButton.UseSelectable = true;
            this.arriveTB.CustomButton.Visible = false;
            this.arriveTB.Lines = new string[0];
            this.arriveTB.Location = new System.Drawing.Point(121, 337);
            this.arriveTB.MaxLength = 32767;
            this.arriveTB.Name = "arriveTB";
            this.arriveTB.PasswordChar = '\0';
            this.arriveTB.PromptText = "Enter Time";
            this.arriveTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arriveTB.SelectedText = "";
            this.arriveTB.SelectionLength = 0;
            this.arriveTB.SelectionStart = 0;
            this.arriveTB.ShortcutsEnabled = true;
            this.arriveTB.Size = new System.Drawing.Size(212, 30);
            this.arriveTB.TabIndex = 11;
            this.arriveTB.UseSelectable = true;
            this.arriveTB.WaterMark = "Enter Time";
            this.arriveTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arriveTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // priceTB
            // 
            // 
            // 
            // 
            this.priceTB.CustomButton.Image = null;
            this.priceTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.priceTB.CustomButton.Name = "";
            this.priceTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.priceTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceTB.CustomButton.TabIndex = 1;
            this.priceTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceTB.CustomButton.UseSelectable = true;
            this.priceTB.CustomButton.Visible = false;
            this.priceTB.Lines = new string[0];
            this.priceTB.Location = new System.Drawing.Point(121, 403);
            this.priceTB.MaxLength = 32767;
            this.priceTB.Name = "priceTB";
            this.priceTB.PasswordChar = '\0';
            this.priceTB.PromptText = "$$$";
            this.priceTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTB.SelectedText = "";
            this.priceTB.SelectionLength = 0;
            this.priceTB.SelectionStart = 0;
            this.priceTB.ShortcutsEnabled = true;
            this.priceTB.Size = new System.Drawing.Size(212, 30);
            this.priceTB.TabIndex = 10;
            this.priceTB.UseSelectable = true;
            this.priceTB.WaterMark = "$$$";
            this.priceTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // airlineTB
            // 
            // 
            // 
            // 
            this.airlineTB.CustomButton.Image = null;
            this.airlineTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.airlineTB.CustomButton.Name = "";
            this.airlineTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.airlineTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.airlineTB.CustomButton.TabIndex = 1;
            this.airlineTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.airlineTB.CustomButton.UseSelectable = true;
            this.airlineTB.CustomButton.Visible = false;
            this.airlineTB.Lines = new string[0];
            this.airlineTB.Location = new System.Drawing.Point(121, 78);
            this.airlineTB.MaxLength = 32767;
            this.airlineTB.Name = "airlineTB";
            this.airlineTB.PasswordChar = '\0';
            this.airlineTB.PromptText = "XYZ Airways";
            this.airlineTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.airlineTB.SelectedText = "";
            this.airlineTB.SelectionLength = 0;
            this.airlineTB.SelectionStart = 0;
            this.airlineTB.ShortcutsEnabled = true;
            this.airlineTB.Size = new System.Drawing.Size(212, 30);
            this.airlineTB.TabIndex = 9;
            this.airlineTB.UseSelectable = true;
            this.airlineTB.WaterMark = "XYZ Airways";
            this.airlineTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.airlineTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flightidTB
            // 
            // 
            // 
            // 
            this.flightidTB.CustomButton.Image = null;
            this.flightidTB.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.flightidTB.CustomButton.Name = "";
            this.flightidTB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.flightidTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.flightidTB.CustomButton.TabIndex = 1;
            this.flightidTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.flightidTB.CustomButton.UseSelectable = true;
            this.flightidTB.CustomButton.Visible = false;
            this.flightidTB.Lines = new string[0];
            this.flightidTB.Location = new System.Drawing.Point(121, 14);
            this.flightidTB.MaxLength = 32767;
            this.flightidTB.Name = "flightidTB";
            this.flightidTB.PasswordChar = '\0';
            this.flightidTB.PromptText = "Auto Generation";
            this.flightidTB.ReadOnly = true;
            this.flightidTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.flightidTB.SelectedText = "";
            this.flightidTB.SelectionLength = 0;
            this.flightidTB.SelectionStart = 0;
            this.flightidTB.ShortcutsEnabled = true;
            this.flightidTB.Size = new System.Drawing.Size(212, 30);
            this.flightidTB.TabIndex = 8;
            this.flightidTB.UseSelectable = true;
            this.flightidTB.WaterMark = "Auto Generation";
            this.flightidTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.flightidTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // arrivalTimeLbl
            // 
            this.arrivalTimeLbl.AutoSize = true;
            this.arrivalTimeLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.arrivalTimeLbl.Location = new System.Drawing.Point(22, 337);
            this.arrivalTimeLbl.Name = "arrivalTimeLbl";
            this.arrivalTimeLbl.Size = new System.Drawing.Size(74, 20);
            this.arrivalTimeLbl.TabIndex = 7;
            this.arrivalTimeLbl.Text = "Arrive at:";
            // 
            // depTimeLbl
            // 
            this.depTimeLbl.AutoSize = true;
            this.depTimeLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.depTimeLbl.Location = new System.Drawing.Point(17, 270);
            this.depTimeLbl.Name = "depTimeLbl";
            this.depTimeLbl.Size = new System.Drawing.Size(79, 20);
            this.depTimeLbl.TabIndex = 6;
            this.depTimeLbl.Text = "Depart at:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.priceLbl.Location = new System.Drawing.Point(49, 403);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(47, 20);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Price:";
            // 
            // airportidLbl
            // 
            this.airportidLbl.AutoSize = true;
            this.airportidLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.airportidLbl.Location = new System.Drawing.Point(17, 215);
            this.airportidLbl.Name = "airportidLbl";
            this.airportidLbl.Size = new System.Drawing.Size(84, 20);
            this.airportidLbl.TabIndex = 4;
            this.airportidLbl.Text = "Airport ID:";
            // 
            // AirlineLbl
            // 
            this.AirlineLbl.AutoSize = true;
            this.AirlineLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AirlineLbl.Location = new System.Drawing.Point(37, 78);
            this.AirlineLbl.Name = "AirlineLbl";
            this.AirlineLbl.Size = new System.Drawing.Size(59, 20);
            this.AirlineLbl.TabIndex = 3;
            this.AirlineLbl.Text = "Airline:";
            // 
            // flightidLbl
            // 
            this.flightidLbl.AutoSize = true;
            this.flightidLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.flightidLbl.Location = new System.Drawing.Point(23, 14);
            this.flightidLbl.Name = "flightidLbl";
            this.flightidLbl.Size = new System.Drawing.Size(73, 20);
            this.flightidLbl.TabIndex = 2;
            this.flightidLbl.Text = "Flight ID:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.saveBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(338, 44);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Location = new System.Drawing.Point(721, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FlightManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlightManagerView";
            this.Text = "Flight Manager View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightManagerView_FormClosing);
            this.Load += new System.EventHandler(this.FlightManagerView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton newBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroGrid dataGridView;
        private MetroFramework.Controls.MetroLabel flightidLbl;
        private MetroFramework.Controls.MetroTextBox arrivalAirportidTB;
        private MetroFramework.Controls.MetroTextBox departTB;
        private MetroFramework.Controls.MetroTextBox arriveTB;
        private MetroFramework.Controls.MetroTextBox priceTB;
        private MetroFramework.Controls.MetroTextBox airlineTB;
        private MetroFramework.Controls.MetroTextBox flightidTB;
        private MetroFramework.Controls.MetroLabel arrivalTimeLbl;
        private MetroFramework.Controls.MetroLabel depTimeLbl;
        private MetroFramework.Controls.MetroLabel priceLbl;
        private MetroFramework.Controls.MetroLabel airportidLbl;
        private MetroFramework.Controls.MetroLabel AirlineLbl;
        private MetroFramework.Controls.MetroTextBox departureAirportidTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel dateLbl;
        private MetroFramework.Controls.MetroDateTime dateTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVflight_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVdeparture_airport_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVarrival_airport_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVairline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVdeparture_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVarrival_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVprice;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}