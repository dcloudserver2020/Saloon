namespace Gallery
{
    partial class Theme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theme));
            this.P_BackGround = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.P_MessageBox = new System.Windows.Forms.Panel();
            this.L_MessageBoxBody = new System.Windows.Forms.Label();
            this.L_MessageBoxTitle = new System.Windows.Forms.Label();
            this.MessageBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.P_TopLeft = new System.Windows.Forms.Panel();
            this.P_Left = new System.Windows.Forms.Panel();
            this.MB_R_Button17 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button16 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button15 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button14 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button13 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button12 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button11 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button10 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button9 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button8 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button7 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button6 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button5 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button4 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button3 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button2 = new MetroFramework.Controls.MetroButton();
            this.MB_R_Button1 = new MetroFramework.Controls.MetroButton();
            this.L_PoweredBy = new System.Windows.Forms.Label();
            this.L_Version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_Header = new System.Windows.Forms.Panel();
            this.B_Logout = new System.Windows.Forms.Button();
            this.B_ThemeChange = new System.Windows.Forms.Button();
            this.P_Logo = new System.Windows.Forms.Panel();
            this.P_Top = new System.Windows.Forms.Panel();
            this.Home = new Gallery.User_Interface.User_Controls.Home();
            this.login = new Gallery.User_Interface.User_Controls.Login();
            this.P_BackGround.SuspendLayout();
            this.panel1.SuspendLayout();
            this.P_MessageBox.SuspendLayout();
            this.P_Left.SuspendLayout();
            this.P_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_BackGround
            // 
            this.P_BackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_BackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_BackGround.Controls.Add(this.P_TopLeft);
            this.P_BackGround.Controls.Add(this.panel1);
            this.P_BackGround.Controls.Add(this.P_Left);
            this.P_BackGround.Controls.Add(this.P_Header);
            this.P_BackGround.Controls.Add(this.P_Top);
            this.P_BackGround.Controls.Add(this.panel2);
            this.P_BackGround.Controls.Add(this.P_MessageBox);
            this.P_BackGround.Location = new System.Drawing.Point(-1, -2);
            this.P_BackGround.Name = "P_BackGround";
            this.P_BackGround.Size = new System.Drawing.Size(1801, 804);
            this.P_BackGround.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(227, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 650);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(231, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 650);
            this.panel2.TabIndex = 8;
            // 
            // P_MessageBox
            // 
            this.P_MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(181)))), ((int)(((byte)(85)))));
            this.P_MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_MessageBox.Controls.Add(this.L_MessageBoxBody);
            this.P_MessageBox.Controls.Add(this.L_MessageBoxTitle);
            this.P_MessageBox.Location = new System.Drawing.Point(1546, 124);
            this.P_MessageBox.Name = "P_MessageBox";
            this.P_MessageBox.Size = new System.Drawing.Size(245, 75);
            this.P_MessageBox.TabIndex = 9;
            this.P_MessageBox.Visible = false;
            // 
            // L_MessageBoxBody
            // 
            this.L_MessageBoxBody.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MessageBoxBody.ForeColor = System.Drawing.Color.White;
            this.L_MessageBoxBody.Location = new System.Drawing.Point(29, 30);
            this.L_MessageBoxBody.Name = "L_MessageBoxBody";
            this.L_MessageBoxBody.Size = new System.Drawing.Size(205, 38);
            this.L_MessageBoxBody.TabIndex = 1;
            this.L_MessageBoxBody.Text = "Message Text :";
            // 
            // L_MessageBoxTitle
            // 
            this.L_MessageBoxTitle.AutoSize = true;
            this.L_MessageBoxTitle.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MessageBoxTitle.ForeColor = System.Drawing.Color.White;
            this.L_MessageBoxTitle.Location = new System.Drawing.Point(12, 8);
            this.L_MessageBoxTitle.Name = "L_MessageBoxTitle";
            this.L_MessageBoxTitle.Size = new System.Drawing.Size(116, 16);
            this.L_MessageBoxTitle.TabIndex = 0;
            this.L_MessageBoxTitle.Text = "Message Title :";
            // 
            // MessageBoxTimer
            // 
            this.MessageBoxTimer.Tick += new System.EventHandler(this.MessageBoxTimer_Tick);
            // 
            // P_TopLeft
            // 
            this.P_TopLeft.BackgroundImage = global::Gallery.Properties.Resources.BlueTopLeft;
            this.P_TopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_TopLeft.Location = new System.Drawing.Point(158, 2);
            this.P_TopLeft.Name = "P_TopLeft";
            this.P_TopLeft.Size = new System.Drawing.Size(82, 147);
            this.P_TopLeft.TabIndex = 3;
            // 
            // P_Left
            // 
            this.P_Left.BackgroundImage = global::Gallery.Properties.Resources.BlueLeft;
            this.P_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Left.Controls.Add(this.MB_R_Button17);
            this.P_Left.Controls.Add(this.MB_R_Button16);
            this.P_Left.Controls.Add(this.MB_R_Button15);
            this.P_Left.Controls.Add(this.MB_R_Button14);
            this.P_Left.Controls.Add(this.MB_R_Button13);
            this.P_Left.Controls.Add(this.MB_R_Button12);
            this.P_Left.Controls.Add(this.MB_R_Button11);
            this.P_Left.Controls.Add(this.MB_R_Button10);
            this.P_Left.Controls.Add(this.MB_R_Button9);
            this.P_Left.Controls.Add(this.MB_R_Button8);
            this.P_Left.Controls.Add(this.MB_R_Button7);
            this.P_Left.Controls.Add(this.MB_R_Button6);
            this.P_Left.Controls.Add(this.MB_R_Button5);
            this.P_Left.Controls.Add(this.MB_R_Button4);
            this.P_Left.Controls.Add(this.MB_R_Button3);
            this.P_Left.Controls.Add(this.MB_R_Button2);
            this.P_Left.Controls.Add(this.MB_R_Button1);
            this.P_Left.Controls.Add(this.L_PoweredBy);
            this.P_Left.Controls.Add(this.L_Version);
            this.P_Left.Controls.Add(this.label2);
            this.P_Left.Controls.Add(this.label1);
            this.P_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Left.Location = new System.Drawing.Point(0, 118);
            this.P_Left.Name = "P_Left";
            this.P_Left.Size = new System.Drawing.Size(200, 686);
            this.P_Left.TabIndex = 4;
            // 
            // MB_R_Button17
            // 
            this.MB_R_Button17.Location = new System.Drawing.Point(25, 588);
            this.MB_R_Button17.Name = "MB_R_Button17";
            this.MB_R_Button17.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button17.TabIndex = 33;
            this.MB_R_Button17.Text = "Button17";
            this.MB_R_Button17.Visible = false;
            // 
            // MB_R_Button16
            // 
            this.MB_R_Button16.Location = new System.Drawing.Point(25, 554);
            this.MB_R_Button16.Name = "MB_R_Button16";
            this.MB_R_Button16.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button16.TabIndex = 32;
            this.MB_R_Button16.Text = "Button16";
            this.MB_R_Button16.Visible = false;
            // 
            // MB_R_Button15
            // 
            this.MB_R_Button15.Location = new System.Drawing.Point(25, 520);
            this.MB_R_Button15.Name = "MB_R_Button15";
            this.MB_R_Button15.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button15.TabIndex = 31;
            this.MB_R_Button15.Text = "Button15";
            this.MB_R_Button15.Visible = false;
            // 
            // MB_R_Button14
            // 
            this.MB_R_Button14.Location = new System.Drawing.Point(25, 486);
            this.MB_R_Button14.Name = "MB_R_Button14";
            this.MB_R_Button14.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button14.TabIndex = 30;
            this.MB_R_Button14.Text = "Button14";
            this.MB_R_Button14.Visible = false;
            // 
            // MB_R_Button13
            // 
            this.MB_R_Button13.Location = new System.Drawing.Point(25, 452);
            this.MB_R_Button13.Name = "MB_R_Button13";
            this.MB_R_Button13.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button13.TabIndex = 29;
            this.MB_R_Button13.Text = "Button13";
            this.MB_R_Button13.Visible = false;
            // 
            // MB_R_Button12
            // 
            this.MB_R_Button12.Location = new System.Drawing.Point(25, 418);
            this.MB_R_Button12.Name = "MB_R_Button12";
            this.MB_R_Button12.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button12.TabIndex = 28;
            this.MB_R_Button12.Text = "Button12";
            this.MB_R_Button12.Visible = false;
            // 
            // MB_R_Button11
            // 
            this.MB_R_Button11.Location = new System.Drawing.Point(25, 384);
            this.MB_R_Button11.Name = "MB_R_Button11";
            this.MB_R_Button11.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button11.TabIndex = 27;
            this.MB_R_Button11.Text = "Button11";
            this.MB_R_Button11.Visible = false;
            // 
            // MB_R_Button10
            // 
            this.MB_R_Button10.Location = new System.Drawing.Point(25, 350);
            this.MB_R_Button10.Name = "MB_R_Button10";
            this.MB_R_Button10.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button10.TabIndex = 26;
            this.MB_R_Button10.Text = "Button10";
            this.MB_R_Button10.Visible = false;
            // 
            // MB_R_Button9
            // 
            this.MB_R_Button9.Location = new System.Drawing.Point(25, 316);
            this.MB_R_Button9.Name = "MB_R_Button9";
            this.MB_R_Button9.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button9.TabIndex = 25;
            this.MB_R_Button9.Text = "Button9";
            this.MB_R_Button9.Visible = false;
            // 
            // MB_R_Button8
            // 
            this.MB_R_Button8.Location = new System.Drawing.Point(25, 282);
            this.MB_R_Button8.Name = "MB_R_Button8";
            this.MB_R_Button8.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button8.TabIndex = 24;
            this.MB_R_Button8.Text = "Button8";
            this.MB_R_Button8.Visible = false;
            // 
            // MB_R_Button7
            // 
            this.MB_R_Button7.Location = new System.Drawing.Point(25, 248);
            this.MB_R_Button7.Name = "MB_R_Button7";
            this.MB_R_Button7.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button7.TabIndex = 23;
            this.MB_R_Button7.Text = "Button7";
            this.MB_R_Button7.Visible = false;
            // 
            // MB_R_Button6
            // 
            this.MB_R_Button6.Location = new System.Drawing.Point(25, 214);
            this.MB_R_Button6.Name = "MB_R_Button6";
            this.MB_R_Button6.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button6.TabIndex = 22;
            this.MB_R_Button6.Text = "Button6";
            this.MB_R_Button6.Visible = false;
            // 
            // MB_R_Button5
            // 
            this.MB_R_Button5.Location = new System.Drawing.Point(25, 180);
            this.MB_R_Button5.Name = "MB_R_Button5";
            this.MB_R_Button5.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button5.TabIndex = 21;
            this.MB_R_Button5.Text = "Button5";
            this.MB_R_Button5.Visible = false;
            // 
            // MB_R_Button4
            // 
            this.MB_R_Button4.Location = new System.Drawing.Point(25, 146);
            this.MB_R_Button4.Name = "MB_R_Button4";
            this.MB_R_Button4.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button4.TabIndex = 20;
            this.MB_R_Button4.Text = "Button4";
            this.MB_R_Button4.Visible = false;
            // 
            // MB_R_Button3
            // 
            this.MB_R_Button3.Location = new System.Drawing.Point(25, 112);
            this.MB_R_Button3.Name = "MB_R_Button3";
            this.MB_R_Button3.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button3.TabIndex = 19;
            this.MB_R_Button3.Text = "Button3";
            this.MB_R_Button3.Visible = false;
            // 
            // MB_R_Button2
            // 
            this.MB_R_Button2.Location = new System.Drawing.Point(25, 78);
            this.MB_R_Button2.Name = "MB_R_Button2";
            this.MB_R_Button2.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button2.TabIndex = 18;
            this.MB_R_Button2.Text = "Button2";
            this.MB_R_Button2.Visible = false;
            // 
            // MB_R_Button1
            // 
            this.MB_R_Button1.Location = new System.Drawing.Point(25, 44);
            this.MB_R_Button1.Name = "MB_R_Button1";
            this.MB_R_Button1.Size = new System.Drawing.Size(151, 28);
            this.MB_R_Button1.TabIndex = 17;
            this.MB_R_Button1.Text = "   Go Back   <---";
            this.MB_R_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MB_R_Button1.Visible = false;
            // 
            // L_PoweredBy
            // 
            this.L_PoweredBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_PoweredBy.AutoSize = true;
            this.L_PoweredBy.BackColor = System.Drawing.Color.Transparent;
            this.L_PoweredBy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PoweredBy.ForeColor = System.Drawing.Color.DarkGray;
            this.L_PoweredBy.Location = new System.Drawing.Point(109, 659);
            this.L_PoweredBy.Name = "L_PoweredBy";
            this.L_PoweredBy.Size = new System.Drawing.Size(32, 13);
            this.L_PoweredBy.TabIndex = 7;
            this.L_PoweredBy.Text = "DOT";
            // 
            // L_Version
            // 
            this.L_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Version.AutoSize = true;
            this.L_Version.BackColor = System.Drawing.Color.Transparent;
            this.L_Version.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Version.ForeColor = System.Drawing.Color.DarkGray;
            this.L_Version.Location = new System.Drawing.Point(81, 640);
            this.L_Version.Name = "L_Version";
            this.L_Version.Size = new System.Drawing.Size(25, 13);
            this.L_Version.TabIndex = 6;
            this.L_Version.Text = "1.0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(21, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Powered By :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(21, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Version :";
            // 
            // P_Header
            // 
            this.P_Header.BackgroundImage = global::Gallery.Properties.Resources.Header;
            this.P_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Header.Controls.Add(this.B_Logout);
            this.P_Header.Controls.Add(this.B_ThemeChange);
            this.P_Header.Controls.Add(this.P_Logo);
            this.P_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Header.Location = new System.Drawing.Point(0, 25);
            this.P_Header.Name = "P_Header";
            this.P_Header.Size = new System.Drawing.Size(1801, 93);
            this.P_Header.TabIndex = 1;
            // 
            // B_Logout
            // 
            this.B_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Logout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Logout.ForeColor = System.Drawing.Color.Black;
            this.B_Logout.Location = new System.Drawing.Point(1704, 25);
            this.B_Logout.Name = "B_Logout";
            this.B_Logout.Size = new System.Drawing.Size(75, 35);
            this.B_Logout.TabIndex = 6;
            this.B_Logout.Text = "Logout";
            this.B_Logout.UseVisualStyleBackColor = true;
            this.B_Logout.Visible = false;
            this.B_Logout.Click += new System.EventHandler(this.B_Logout_Click);
            // 
            // B_ThemeChange
            // 
            this.B_ThemeChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ThemeChange.BackColor = System.Drawing.Color.Transparent;
            this.B_ThemeChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_ThemeChange.BackgroundImage")));
            this.B_ThemeChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_ThemeChange.FlatAppearance.BorderSize = 0;
            this.B_ThemeChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_ThemeChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_ThemeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ThemeChange.Location = new System.Drawing.Point(1754, 66);
            this.B_ThemeChange.Name = "B_ThemeChange";
            this.B_ThemeChange.Size = new System.Drawing.Size(25, 25);
            this.B_ThemeChange.TabIndex = 5;
            this.B_ThemeChange.UseVisualStyleBackColor = false;
            this.B_ThemeChange.Click += new System.EventHandler(this.B_ThemeChange_Click);
            // 
            // P_Logo
            // 
            this.P_Logo.BackColor = System.Drawing.Color.Transparent;
            this.P_Logo.BackgroundImage = global::Gallery.Properties.Resources.ION_LOGO;
            this.P_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Logo.Location = new System.Drawing.Point(32, 3);
            this.P_Logo.Name = "P_Logo";
            this.P_Logo.Size = new System.Drawing.Size(82, 87);
            this.P_Logo.TabIndex = 4;
            // 
            // P_Top
            // 
            this.P_Top.BackgroundImage = global::Gallery.Properties.Resources.BlueTop;
            this.P_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Top.Location = new System.Drawing.Point(0, 0);
            this.P_Top.Name = "P_Top";
            this.P_Top.Size = new System.Drawing.Size(1801, 25);
            this.P_Top.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1548, 648);
            this.Home.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1548, 648);
            this.login.TabIndex = 0;
            this.login.TabStopChanged += new System.EventHandler(this.login_TabStopChanged);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 800);
            this.Controls.Add(this.P_BackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Theme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.P_BackGround.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.P_MessageBox.ResumeLayout(false);
            this.P_MessageBox.PerformLayout();
            this.P_Left.ResumeLayout(false);
            this.P_Left.PerformLayout();
            this.P_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_BackGround;
        private System.Windows.Forms.Panel P_TopLeft;
        private System.Windows.Forms.Panel P_Header;
        private System.Windows.Forms.Panel P_Top;
        private System.Windows.Forms.Panel P_Logo;
        private System.Windows.Forms.Panel P_Left;
        private System.Windows.Forms.Button B_ThemeChange;
        private System.Windows.Forms.Button B_Logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel P_MessageBox;
        private System.Windows.Forms.Label L_MessageBoxBody;
        private System.Windows.Forms.Label L_MessageBoxTitle;
        private System.Windows.Forms.Timer MessageBoxTimer;
        private User_Interface.User_Controls.Login login;
        private MetroFramework.Controls.MetroButton MB_R_Button17;
        private MetroFramework.Controls.MetroButton MB_R_Button16;
        private MetroFramework.Controls.MetroButton MB_R_Button15;
        private MetroFramework.Controls.MetroButton MB_R_Button14;
        private MetroFramework.Controls.MetroButton MB_R_Button13;
        private MetroFramework.Controls.MetroButton MB_R_Button12;
        private MetroFramework.Controls.MetroButton MB_R_Button11;
        private MetroFramework.Controls.MetroButton MB_R_Button10;
        private MetroFramework.Controls.MetroButton MB_R_Button9;
        private MetroFramework.Controls.MetroButton MB_R_Button8;
        private MetroFramework.Controls.MetroButton MB_R_Button7;
        private MetroFramework.Controls.MetroButton MB_R_Button6;
        private MetroFramework.Controls.MetroButton MB_R_Button5;
        private MetroFramework.Controls.MetroButton MB_R_Button4;
        private MetroFramework.Controls.MetroButton MB_R_Button3;
        private MetroFramework.Controls.MetroButton MB_R_Button2;
        private MetroFramework.Controls.MetroButton MB_R_Button1;
        private System.Windows.Forms.Label L_PoweredBy;
        private System.Windows.Forms.Label L_Version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private User_Interface.User_Controls.Home Home;
    }
}

