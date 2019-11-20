using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mainpulator.Module.Login;
using Mainpulator.Module.Common;

namespace Gallery.User_Interface.User_Controls
{
    public partial class Login : UserControl
    {

        #region  Common Referance
        Method_Login Method_Login = new Method_Login();
        #endregion


        public Login()
        {
            InitializeComponent();
        }

        private void TB_UserName_Enter(object sender, EventArgs e)
        {
            if (TB_UserName.Text == "User Name") { TB_UserName.Text = null; }
        }

        private void TB_UserName_Leave(object sender, EventArgs e)
        {
            if (TB_UserName.TextLength == 0) { TB_UserName.Text = "User Name"; }
        }

        private void TB_Password_Leave(object sender, EventArgs e)
        {
            if (TB_Password.TextLength == 0) { TB_Password.Text = "Password"; TB_Password.PasswordChar = '\0'; }
        }

        private void TB_Password_Enter(object sender, EventArgs e)
        {
            if (TB_Password.Text == "Password") { TB_Password.Text = null; TB_Password.PasswordChar = '*'; }
        }

        private void RB_Login_MouseDown(object sender, MouseEventArgs e)
        {
            Class_Login.LoginInfo.UserName = TB_UserName.Text;
            Class_Login.LoginInfo.Password = TB_Password.Text;
            Method_Login.LoginValidation();
            TabStop = true;TabStop = false;            
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
