/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem
{
    class LoginVM
    {

        public LoginForm loginWindow;


        public LoginVM(LoginForm loginf)
        {
            loginWindow = loginf;
            LoginCommand= new LoginCommand(this);
            LoginParameters = new LoginParameters("", "");
     
        }

        public LoginParameters LoginParameters { get; private set; }


        public ICommand LoginCommand
        {
            get;
            private set;
        }


        static private void errorAction(String error)
        {
            MessageBox.Show(error, "Error logging!");
        }

        public void Login()
        {

            LoginValidation loginValidation = new LoginValidation(LoginParameters.Username, LoginParameters.Password, errorAction);

            User newUser = null;
            bool registered = loginValidation.ValidateUserInput(ref newUser);

          

            if (loginValidation.ValidateUserInput(ref newUser))
            {
                MainWindow mainWindow = new MainWindow();
                if (newUser.Role == UserRoles.STUDENT ||newUser.Role==UserRoles.ADMIN)
                {
                    var studentValidation = new StudentValidation();
                    
                    
                    
                    
                    
                    
                    mainWindow.Show();
                    loginWindow.Close();
                   
                }
               
                else
                {
                  
                    MessageBox.Show("Login was unsuccessful");
                    return;
                }
                
            }



        }
    }
}





// internal bool IsLoginEnabled()
//{
//     return !string.IsNullOrEmpty(LoginParameters.Username) && !string.IsNullOrEmpty(LoginParameters.Password);
// }

*/