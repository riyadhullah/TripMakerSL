
namespace TripMaker
{
    partial class Flight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.labelAirways = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.labelTaka = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelCUtoCTG = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFromAirport = new System.Windows.Forms.ComboBox();
            this.cbToAirport = new System.Windows.Forms.ComboBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCUtoCTG.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "To";
            // 
            // labelAirways
            // 
            this.labelAirways.AutoSize = true;
            this.labelAirways.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirways.Location = new System.Drawing.Point(12, 17);
            this.labelAirways.Name = "labelAirways";
            this.labelAirways.Size = new System.Drawing.Size(0, 23);
            this.labelAirways.TabIndex = 0;
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoute.Location = new System.Drawing.Point(149, 56);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(0, 21);
            this.labelRoute.TabIndex = 1;
            this.labelRoute.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelTaka
            // 
            this.labelTaka.AutoSize = true;
            this.labelTaka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaka.ForeColor = System.Drawing.Color.Red;
            this.labelTaka.Location = new System.Drawing.Point(503, 88);
            this.labelTaka.Name = "labelTaka";
            this.labelTaka.Size = new System.Drawing.Size(0, 23);
            this.labelTaka.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 88);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 23);
            this.labelTime.TabIndex = 4;
            // 
            // panelCUtoCTG
            // 
            this.panelCUtoCTG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCUtoCTG.Controls.Add(this.labelTime);
            this.panelCUtoCTG.Controls.Add(this.labelTaka);
            this.panelCUtoCTG.Controls.Add(this.labelAirways);
            this.panelCUtoCTG.Controls.Add(this.labelRoute);
            this.panelCUtoCTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCUtoCTG.Location = new System.Drawing.Point(150, 385);
            this.panelCUtoCTG.Name = "panelCUtoCTG";
            this.panelCUtoCTG.Size = new System.Drawing.Size(629, 120);
            this.panelCUtoCTG.TabIndex = 30;
            this.panelCUtoCTG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCTGtoDhaka_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Available Flights";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(11, 220);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(932, 48);
            this.panel.TabIndex = 27;
            this.panel.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(769, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 33);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 131);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 27);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Flight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose Airports";
            // 
            // cbFromAirport
            // 
            this.cbFromAirport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFromAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFromAirport.FormattingEnabled = true;
            this.cbFromAirport.Items.AddRange(new object[] {
            "Chittagong Airport",
            "Cumilla Airport",
            "Dhaka Airport"});
            this.cbFromAirport.Location = new System.Drawing.Point(109, 133);
            this.cbFromAirport.Name = "cbFromAirport";
            this.cbFromAirport.Size = new System.Drawing.Size(187, 25);
            this.cbFromAirport.Sorted = true;
            this.cbFromAirport.TabIndex = 16;
            // 
            // cbToAirport
            // 
            this.cbToAirport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbToAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToAirport.FormattingEnabled = true;
            this.cbToAirport.Items.AddRange(new object[] {
            "Dhaka Airport",
            "Cumilla Airport",
            "Chittagong Airport"});
            this.cbToAirport.Location = new System.Drawing.Point(369, 133);
            this.cbToAirport.Name = "cbToAirport";
            this.cbToAirport.Size = new System.Drawing.Size(187, 25);
            this.cbToAirport.TabIndex = 17;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(612, 87);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(54, 23);
            this.DateLbl.TabIndex = 23;
            this.DateLbl.Text = "Date";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCUtoCTG);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbToAirport);
            this.Controls.Add(this.cbFromAirport);
            this.Controls.Add(this.label3);
            this.Name = "Flight";
            this.Size = new System.Drawing.Size(935, 662);
            this.Load += new System.EventHandler(this.Flight_Load);
            this.panelCUtoCTG.ResumeLayout(false);
            this.panelCUtoCTG.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAirways;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Label labelTaka;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelCUtoCTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFromAirport;
        private System.Windows.Forms.ComboBox cbToAirport;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Button button1;
    }
}
