
namespace TripMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.pnlWallet = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlHotel = new System.Windows.Forms.Panel();
            this.pnlFlight = new System.Windows.Forms.Panel();
            this.btnBookingInfo = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.pnlBus = new System.Windows.Forms.Panel();
            this.btnFlight = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Location = new System.Drawing.Point(35, 19);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(202, 45);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "TripMaker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pnlAbout);
            this.panel1.Controls.Add(this.pnlWallet);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.pnlHotel);
            this.panel1.Controls.Add(this.pnlFlight);
            this.panel1.Controls.Add(this.btnBookingInfo);
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.pnlBus);
            this.panel1.Controls.Add(this.btnFlight);
            this.panel1.Controls.Add(this.pnlHome);
            this.panel1.Controls.Add(this.btnBus);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 800);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Red;
            this.pnlAbout.Location = new System.Drawing.Point(1, 558);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(19, 60);
            this.pnlAbout.TabIndex = 9;
            this.pnlAbout.Visible = false;
            // 
            // pnlWallet
            // 
            this.pnlWallet.BackColor = System.Drawing.Color.Red;
            this.pnlWallet.Location = new System.Drawing.Point(1, 480);
            this.pnlWallet.Name = "pnlWallet";
            this.pnlWallet.Size = new System.Drawing.Size(19, 60);
            this.pnlWallet.TabIndex = 6;
            this.pnlWallet.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(20, 558);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(236, 60);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btn_function);
            // 
            // pnlHotel
            // 
            this.pnlHotel.BackColor = System.Drawing.Color.Red;
            this.pnlHotel.Location = new System.Drawing.Point(1, 402);
            this.pnlHotel.Name = "pnlHotel";
            this.pnlHotel.Size = new System.Drawing.Size(19, 60);
            this.pnlHotel.TabIndex = 4;
            this.pnlHotel.Visible = false;
            // 
            // pnlFlight
            // 
            this.pnlFlight.BackColor = System.Drawing.Color.Red;
            this.pnlFlight.Location = new System.Drawing.Point(1, 324);
            this.pnlFlight.Name = "pnlFlight";
            this.pnlFlight.Size = new System.Drawing.Size(19, 60);
            this.pnlFlight.TabIndex = 4;
            this.pnlFlight.Visible = false;
            // 
            // btnBookingInfo
            // 
            this.btnBookingInfo.FlatAppearance.BorderSize = 0;
            this.btnBookingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingInfo.ForeColor = System.Drawing.Color.White;
            this.btnBookingInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingInfo.Image")));
            this.btnBookingInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingInfo.Location = new System.Drawing.Point(20, 480);
            this.btnBookingInfo.Name = "btnBookingInfo";
            this.btnBookingInfo.Size = new System.Drawing.Size(236, 60);
            this.btnBookingInfo.TabIndex = 8;
            this.btnBookingInfo.Text = "Booking Info";
            this.btnBookingInfo.UseVisualStyleBackColor = true;
            this.btnBookingInfo.Click += new System.EventHandler(this.btn_function);
            // 
            // btnHotel
            // 
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnHotel.Image")));
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.Location = new System.Drawing.Point(20, 402);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(236, 60);
            this.btnHotel.TabIndex = 5;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btn_function);
            // 
            // pnlBus
            // 
            this.pnlBus.BackColor = System.Drawing.Color.Red;
            this.pnlBus.Location = new System.Drawing.Point(1, 246);
            this.pnlBus.Name = "pnlBus";
            this.pnlBus.Size = new System.Drawing.Size(19, 60);
            this.pnlBus.TabIndex = 4;
            this.pnlBus.Visible = false;
            // 
            // btnFlight
            // 
            this.btnFlight.FlatAppearance.BorderSize = 0;
            this.btnFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlight.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlight.ForeColor = System.Drawing.Color.White;
            this.btnFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnFlight.Image")));
            this.btnFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlight.Location = new System.Drawing.Point(20, 324);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(236, 60);
            this.btnFlight.TabIndex = 5;
            this.btnFlight.Text = "Flight";
            this.btnFlight.UseVisualStyleBackColor = true;
            this.btnFlight.Click += new System.EventHandler(this.btn_function);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Red;
            this.pnlHome.Location = new System.Drawing.Point(1, 168);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(19, 60);
            this.pnlHome.TabIndex = 3;
            // 
            // btnBus
            // 
            this.btnBus.FlatAppearance.BorderSize = 0;
            this.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBus.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBus.Image = ((System.Drawing.Image)(resources.GetObject("btnBus.Image")));
            this.btnBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBus.Location = new System.Drawing.Point(20, 246);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(236, 60);
            this.btnBus.TabIndex = 5;
            this.btnBus.Text = "Bus";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btn_function);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(20, 168);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(236, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btn_function);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(265, 138);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(935, 662);
            this.panel.TabIndex = 8;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Gray;
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(265, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(935, 139);
            this.panelUp.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlWallet;
        private System.Windows.Forms.Panel pnlHotel;
        private System.Windows.Forms.Panel pnlFlight;
        private System.Windows.Forms.Button btnBookingInfo;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Panel pnlBus;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Button btnAbout;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel;
        protected System.Windows.Forms.Panel panelUp;
    }
}

