
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
            this.pnlPackages = new System.Windows.Forms.Panel();
            this.pnlFlight = new System.Windows.Forms.Panel();
            this.btnWallet = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.pnlBus = new System.Windows.Forms.Panel();
            this.btnFlight = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.signup = new TripMaker.Signup();
            this.flight1 = new TripMaker.Flight();
            this.bus1 = new TripMaker.Bus();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.login = new TripMaker.Login();
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
            this.panel1.Controls.Add(this.pnlPackages);
            this.panel1.Controls.Add(this.pnlFlight);
            this.panel1.Controls.Add(this.btnWallet);
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.btnPackages);
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
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Red;
            this.pnlAbout.Location = new System.Drawing.Point(1, 618);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(19, 60);
            this.pnlAbout.TabIndex = 9;
            this.pnlAbout.Visible = false;
            // 
            // pnlWallet
            // 
            this.pnlWallet.BackColor = System.Drawing.Color.Red;
            this.pnlWallet.Location = new System.Drawing.Point(1, 538);
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
            this.btnAbout.Location = new System.Drawing.Point(20, 618);
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
            this.pnlHotel.Location = new System.Drawing.Point(1, 378);
            this.pnlHotel.Name = "pnlHotel";
            this.pnlHotel.Size = new System.Drawing.Size(19, 60);
            this.pnlHotel.TabIndex = 4;
            this.pnlHotel.Visible = false;
            // 
            // pnlPackages
            // 
            this.pnlPackages.BackColor = System.Drawing.Color.Red;
            this.pnlPackages.Location = new System.Drawing.Point(1, 458);
            this.pnlPackages.Name = "pnlPackages";
            this.pnlPackages.Size = new System.Drawing.Size(19, 60);
            this.pnlPackages.TabIndex = 7;
            this.pnlPackages.Visible = false;
            // 
            // pnlFlight
            // 
            this.pnlFlight.BackColor = System.Drawing.Color.Red;
            this.pnlFlight.Location = new System.Drawing.Point(1, 298);
            this.pnlFlight.Name = "pnlFlight";
            this.pnlFlight.Size = new System.Drawing.Size(19, 60);
            this.pnlFlight.TabIndex = 4;
            this.pnlFlight.Visible = false;
            // 
            // btnWallet
            // 
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.Image = ((System.Drawing.Image)(resources.GetObject("btnWallet.Image")));
            this.btnWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.Location = new System.Drawing.Point(20, 538);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(236, 60);
            this.btnWallet.TabIndex = 8;
            this.btnWallet.Text = "Wallet";
            this.btnWallet.UseVisualStyleBackColor = true;
            this.btnWallet.Click += new System.EventHandler(this.btn_function);
            // 
            // btnHotel
            // 
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnHotel.Image")));
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.Location = new System.Drawing.Point(20, 378);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(236, 60);
            this.btnHotel.TabIndex = 5;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btn_function);
            // 
            // btnPackages
            // 
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.White;
            this.btnPackages.Image = ((System.Drawing.Image)(resources.GetObject("btnPackages.Image")));
            this.btnPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackages.Location = new System.Drawing.Point(20, 458);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(236, 60);
            this.btnPackages.TabIndex = 9;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btn_function);
            // 
            // pnlBus
            // 
            this.pnlBus.BackColor = System.Drawing.Color.Red;
            this.pnlBus.Location = new System.Drawing.Point(1, 218);
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
            this.btnFlight.Location = new System.Drawing.Point(20, 298);
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
            this.pnlHome.Location = new System.Drawing.Point(1, 138);
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
            this.btnBus.Location = new System.Drawing.Point(20, 218);
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
            this.btnHome.Location = new System.Drawing.Point(20, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(236, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btn_function);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signup.Location = new System.Drawing.Point(271, 138);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(935, 662);
            this.signup.TabIndex = 5;
            this.signup.Visible = false;
            // 
            // flight1
            // 
            this.flight1.Location = new System.Drawing.Point(268, 138);
            this.flight1.Name = "flight1";
            this.flight1.Size = new System.Drawing.Size(935, 662);
            this.flight1.TabIndex = 4;
            this.flight1.Visible = false;
            // 
            // bus1
            // 
            this.bus1.Location = new System.Drawing.Point(268, 138);
            this.bus1.Name = "bus1";
            this.bus1.Size = new System.Drawing.Size(935, 662);
            this.bus1.TabIndex = 3;
            this.bus1.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(975, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btn_function);
            // 
            // btnSignup
            // 
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignup.Location = new System.Drawing.Point(1084, 19);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(87, 45);
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btn_function);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(268, 138);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(935, 662);
            this.login.TabIndex = 8;
            this.login.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.login);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.flight1);
            this.Controls.Add(this.bus1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlWallet;
        private System.Windows.Forms.Panel pnlHotel;
        private System.Windows.Forms.Panel pnlPackages;
        private System.Windows.Forms.Panel pnlFlight;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Panel pnlBus;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Button btnAbout;
        private Bus bus1;
        private Flight flight1;
        private Signup signup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private Login login;
    }
}

