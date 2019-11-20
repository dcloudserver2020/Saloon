using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Mainpulator.Module.Login;
using Mainpulator.Module.Common;

namespace Gallery
{
    public partial class Theme : MetroForm
    {
        int ThemeColour = 2;

        public Theme()
        {
            InitializeComponent();
            InitializeContol();
        }

        #region Method

        public void InitializeContol()
        {
            login.Visible = true;
            login.BringToFront();
        }

        public void LoginSucessfull()
        {
            B_Logout.Visible = true;
            login.Visible = false;
            Class_Common.Execute.E_Method = null;
            Home.Visible = true;
            Home.BringToFront();
        }

        public void ThemeChange()
        {
            if (ThemeColour == 1)
            {
                P_TopLeft.BackgroundImage = global::Gallery.Properties.Resources.BlueTopLeft;
                P_Top.BackgroundImage = global::Gallery.Properties.Resources.BlueTop;
                P_Left.BackgroundImage = global::Gallery.Properties.Resources.BlueLeft;
                ThemeColour = 2;
            }
            else if (ThemeColour == 2)
            {
                P_TopLeft.BackgroundImage = global::Gallery.Properties.Resources.GreenTopLeft;
                P_Top.BackgroundImage = global::Gallery.Properties.Resources.GreenTop;
                P_Left.BackgroundImage = global::Gallery.Properties.Resources.GreenLeft;
                ThemeColour = 3;
            }
            else if (ThemeColour == 3)
            {
                P_TopLeft.BackgroundImage = global::Gallery.Properties.Resources.RedTopLeft;
                P_Top.BackgroundImage = global::Gallery.Properties.Resources.RedTop;
                P_Left.BackgroundImage = global::Gallery.Properties.Resources.RedLeft;
                ThemeColour = 1;
            }
        }

        public void MessageBox()
        {
            if (Class_Common.MessageBox.Colour == "Red")
            { System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95))))); }
            else if (Class_Common.MessageBox.Colour == "Green")
            { P_MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(206)))), ((int)(((byte)(121))))); }
            L_MessageBoxTitle.Text = Class_Common.MessageBox.Title;
            L_MessageBoxBody.Text = Class_Common.MessageBox.Description;
            P_MessageBox.Visible = true;
            P_MessageBox.BringToFront();
            MessageTimmer();
        }

        public void MessageTimmer()
        {
            MessageBoxTimer.Interval = (4000); // 4 Sec
            MessageBoxTimer.Tick += new EventHandler(MessageBoxTimer_Tick);
            MessageBoxTimer.Start();
        }

        #endregion

        #region TabStopChangeEvent

        private void login_TabStopChanged(object sender, EventArgs e)
        {
            if (Class_Common.Execute.E_Method == "MessageBox") { MessageBox(); }
            else if (Class_Common.Execute.E_Method == "LoginSucessfull") { LoginSucessfull(); }
        }

        #endregion

        #region Event

        private void B_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_ThemeChange_Click(object sender, EventArgs e)
        {
            ThemeChange();
        }

        private void MessageBoxTimer_Tick(object sender, EventArgs e)
        {
            P_MessageBox.Visible = false;
            P_MessageBox.SendToBack();
            MessageBoxTimer.Stop();
        }
        #endregion


    }
}
