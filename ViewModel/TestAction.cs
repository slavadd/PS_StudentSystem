using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem.ViewModel
{
    internal class TestAction : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string st_name;
        private string st_pass;

        public string St_name
        {
            get { return st_name; }
            set
            {
                st_name = value;
                RaisePropertyChangedEvent("St_name");
            }
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public string St_pass
        {
            get { return st_pass; }
            set
            {
                st_pass = value;
                //RaisePropertyChangedEvent("SomeText");
            }
        }

        public ICommand getData
        {
            get { return new TestDelegateCommand(GetStudentData); }
        }


        private void GetStudentData()
        {

            User user = null;
            string un = st_name;
            string pw = st_pass;

            void errorFunc(String str)
            {
                Console.WriteLine("EXCEPTION: " + str);
            }

            LoginValidation lv = new LoginValidation(un, pw, errorFunc);

            if (lv.ValidateUserInput(ref user))
            {
                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.STUDENT:
                        MainWindow mw = new MainWindow();
                        mw.Show();

                       // mw.getStudentData();
                      //  mw.hideFields();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
// else
// {
//     MessageBox.Show("User is not registered", "Error registration");
// }




/*      private void GetStudentData()
       {

           User newUser = null;
           string userName = username;
           string passWord = password;


           void errorAction(String error)
           {
               MessageBox.Show(error, "Error logging!");
           }

           LoginValidation loginValidation = new LoginValidation(userName, passWord, errorAction);
           bool registered = loginValidation.ValidateUserInput(ref newUser);

           MainWindow mainWindow = new MainWindow();

           if (loginValidation.ValidateUserInput(ref newUser))
           {


               switch (LoginValidation.currentUserRole)
               {
                   case UserRoles.STUDENT:

                       mainWindow.Show();

                       break;

                   case UserRoles.ADMIN:
                       mainWindow.Show();

                       break;
                   default:
                       return;
               }
           }
       }
 */