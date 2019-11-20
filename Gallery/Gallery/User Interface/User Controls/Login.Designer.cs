namespace Gallery.User_Interface.User_Controls
{
    partial class Login
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.B_Close = new System.Windows.Forms.Button();
            this.roundedButton1 = new Gallery.Controls.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.B_Close);
            this.panel4.Controls.Add(this.roundedButton1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TB_Password);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.TB_UserName);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Location = new System.Drawing.Point(588, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 370);
            this.panel4.TabIndex = 24;
            // 
            // B_Close
            // 
            this.B_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Close.BackColor = System.Drawing.Color.Transparent;
            this.B_Close.BackgroundImage = global::Gallery.Properties.Resources.Close;
            this.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Location = new System.Drawing.Point(340, 3);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(25, 25);
            this.B_Close.TabIndex = 16;
            this.B_Close.UseVisualStyleBackColor = false;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(181)))), ((int)(((byte)(85)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(181)))), ((int)(((byte)(85)))));
            this.roundedButton1.BorderDownColor = System.Drawing.Color.Empty;
            this.roundedButton1.BorderDownWidth = 0F;
            this.roundedButton1.BorderOverColor = System.Drawing.Color.Empty;
            this.roundedButton1.BorderOverWidth = 0F;
            this.roundedButton1.BorderRadius = 50;
            this.roundedButton1.BorderWidth = 1F;
            this.roundedButton1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(91, 315);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(191, 31);
            this.roundedButton1.TabIndex = 15;
            this.roundedButton1.Text = "Login";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RB_Login_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome";
            // 
            // TB_Password
            // 
            this.TB_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.ForeColor = System.Drawing.Color.DimGray;
            this.TB_Password.Location = new System.Drawing.Point(38, 245);
            this.TB_Password.Multiline = true;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(300, 30);
            this.TB_Password.TabIndex = 2;
            this.TB_Password.Text = "Password";
            this.TB_Password.Enter += new System.EventHandler(this.TB_Password_Enter);
            this.TB_Password.Leave += new System.EventHandler(this.TB_Password_Leave);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Location = new System.Drawing.Point(38, 248);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 30);
            this.panel8.TabIndex = 13;
            // 
            // TB_UserName
            // 
            this.TB_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.ForeColor = System.Drawing.Color.DimGray;
            this.TB_UserName.Location = new System.Drawing.Point(38, 197);
            this.TB_UserName.Multiline = true;
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(300, 30);
            this.TB_UserName.TabIndex = 1;
            this.TB_UserName.Text = "User Name";
            this.TB_UserName.Enter += new System.EventHandler(this.TB_UserName_Enter);
            this.TB_UserName.Leave += new System.EventHandler(this.TB_UserName_Leave);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackgroundImage = global::Gallery.Properties.Resources.ION_LOGO;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(150, 72);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 84);
            this.panel9.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Location = new System.Drawing.Point(38, 200);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 30);
            this.panel10.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.DarkGray;
            this.panel11.Location = new System.Drawing.Point(592, 142);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(370, 370);
            this.panel11.TabIndex = 25;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel11);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1550, 650);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button B_Close;
        public Controls.RoundedButton roundedButton1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_Password;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox TB_UserName;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.Panel panel11;
    }
}
