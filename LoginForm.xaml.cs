using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;
using StudentInfoSystem;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
          //  DataContext = new LoginVM(this);

        }







        



 //       public static void PrintErrorMsg(string s)
 //       {
 //           MessageBox.Show(" !!! " + s + " !!! ");
 //       }

      

 //       private void EnterButton_Click(object sender, RoutedEventArgs e)
 //       {
 /*           LoginValidation loginValidation = new LoginValidation(txtBoxName.Text, txtBoxPass.Text, PrintErrorMsg);

            User newUser = null;
            bool registered = loginValidation.ValidateUserInput(ref newUser);

            if (registered)
            {
                int userRole = (int)LoginValidation.currentUserRole;

                switch (userRole)
                {
                    case 1:
                        //Console.WriteLine("User: Student");
                        Console.WriteLine(LoginValidation.currentUserRole);
                        break;
                }


                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();

                // StudentData studentData = new StudentData();

                // showInfo(studentData.GetTestStudents().First());

            }
            else
            {
                MessageBox.Show("Login was unsuccessful");
                return;
            }

            */
//        }

    }
}