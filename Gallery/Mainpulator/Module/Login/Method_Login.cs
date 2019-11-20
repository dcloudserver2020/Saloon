using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using Mainpulator.Module.Common;

namespace Mainpulator.Module.Login
{
    public class Method_Login
    {
        public void LoginValidation()
        {
            if (Class_Login.LoginInfo.UserName == "User Name")
            {
                Class_Common.MessageBox.Colour = "Red";
                Class_Common.MessageBox.Title = "Data Validation";
                Class_Common.MessageBox.Description = "Please enter the User Name";
                Class_Common.Execute.E_Method = "MessageBox";
            }
            else if (Class_Login.LoginInfo.Password == "Password")
            {
                Class_Common.MessageBox.Colour = "Red";
                Class_Common.MessageBox.Title = "Data Validation";
                Class_Common.MessageBox.Description = "Please enter the Password";
                Class_Common.Execute.E_Method = "MessageBox";
            }
            else
            {
                PrincipalContext pc = new PrincipalContext(ContextType.Domain, Environment.UserDomainName, Class_Login.LoginInfo.UserName, Class_Login.LoginInfo.Password);

                bool isCredentialValid = pc.ValidateCredentials(Class_Login.LoginInfo.UserName, Class_Login.LoginInfo.Password);

                if (!isCredentialValid)
                {
                    Class_Common.MessageBox.Colour = "Red";
                    Class_Common.MessageBox.Title = "Data Validation";
                    Class_Common.MessageBox.Description = "Invalid Login";
                    Class_Common.Execute.E_Method = "MessageBox";
                }
                else
                {
                    Class_Common.Execute.E_Method = "LoginSucessfull";
                }

            }
        }
    }
}
