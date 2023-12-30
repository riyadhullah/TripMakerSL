
namespace TripMaker
{
    partial class BookingInfo
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
            this.btnBusInfo = new System.Windows.Forms.Button();
            this.btnFlightInfo = new System.Windows.Forms.Button();
            this.btnHotelInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSelectOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBusInfo
            // 
            this.btnBusInfo.FlatAppearance.BorderSize = 0;
            this.btnBusInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusInfo.ForeColor = System.Drawing.Color.Black;
            this.btnBusInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusInfo.Location = new System.Drawing.Point(76, 20);
            this.btnBusInfo.Name = "btnBusInfo";
            this.btnBusInfo.Size = new System.Drawing.Size(236, 60);
            this.btnBusInfo.TabIndex = 4;
            this.btnBusInfo.Text = "Bus booking Info";
            this.btnBusInfo.UseVisualStyleBackColor = true;
            this.btnBusInfo.Click += new System.EventHandler(this.btnBusInfo_Click);
            // 
            // btnFlightInfo
            // 
            this.btnFlightInfo.FlatAppearance.BorderSize = 0;
            this.btnFlightInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightInfo.ForeColor = System.Drawing.Color.Black;
            this.btnFlightInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightInfo.Location = new System.Drawing.Point(348, 20);
            this.btnFlightInfo.Name = "btnFlightInfo";
            this.btnFlightInfo.Size = new System.Drawing.Size(236, 60);
            this.btnFlightInfo.TabIndex = 5;
            this.btnFlightInfo.Text = "Flight booking Info";
            this.btnFlightInfo.UseVisualStyleBackColor = true;
            this.btnFlightInfo.Click += new System.EventHandler(this.btnFlightInfo_Click);
            // 
            // btnHotelInfo
            // 
            this.btnHotelInfo.FlatAppearance.BorderSize = 0;
            this.btnHotelInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelInfo.ForeColor = System.Drawing.Color.Black;
            this.btnHotelInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelInfo.Location = new System.Drawing.Point(620, 20);
            this.btnHotelInfo.Name = "btnHotelInfo";
            this.btnHotelInfo.Size = new System.Drawing.Size(236, 60);
            this.btnHotelInfo.TabIndex = 6;
            this.btnHotelInfo.Text = "Hotel booking Info";
            this.btnHotelInfo.UseVisualStyleBackColor = true;
            this.btnHotelInfo.Click += new System.EventHandler(this.btnHotelInfo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(935, 535);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Visible = false;
            // 
            // lblSelectOne
            // 
            this.lblSelectOne.AutoSize = true;
            this.lblSelectOne.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOne.ForeColor = System.Drawing.Color.Red;
            this.lblSelectOne.Location = new System.Drawing.Point(391, 90);
            this.lblSelectOne.Name = "lblSelectOne";
            this.lblSelectOne.Size = new System.Drawing.Size(166, 34);
            this.lblSelectOne.TabIndex = 8;
            this.lblSelectOne.Text = "Select One";
            // 
            // BookingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectOne);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnHotelInfo);
            this.Controls.Add(this.btnFlightInfo);
            this.Controls.Add(this.btnBusInfo);
            this.Name = "BookingInfo";
            this.Size = new System.Drawing.Size(935, 662);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusInfo;
        private System.Windows.Forms.Button btnFlightInfo;
        private System.Windows.Forms.Button btnHotelInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSelectOne;
    }
}
