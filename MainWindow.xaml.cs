using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;



namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //INotifyPropertyChanged

        private Student _student;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> StudStatusChoices { get; set; }



        public MainWindow()
        {
           

            InitializeComponent();
            FillStudStatusChoices();
            this.DataContext = this;
            AddSelectedDates();
           

            // TestMode testMode = new TestMode();
            // testMode.Show();
            //this.Hide();

            // StudentData studentData = new StudentData();

            // showInfo(studentData.GetTestStudents().First());
        }


        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr
 FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }

        }


        private void AddSelectedDates()
        {
            calendar1.SelectedDates.Add(new DateTime(2022, 5, 22));
            calendar1.SelectedDates.Add(new DateTime(2022, 5, 16));
            calendar1.SelectedDates.Add(new DateTime(2022, 5, 09));

        }
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearText();
        }

        private void getStudentButton_Click(object sender, RoutedEventArgs e)
        {
            StudentData studentData = new StudentData();

          //  showInfo(studentData.GetTestStudents().First());
            showInfo(studentData.GetTestStudents().Last());
        }

        private void enableButton_Click(object sender, RoutedEventArgs e)
        {
            //foreach (UIElement box in StudentGrid.Children)
             //   box.IsEnabled = true;

            txtBoxName.IsEnabled = true;
            txtBoxSurName.IsEnabled = true;
            txtBoxFamilyName.IsEnabled = true;
            txtBoxSpecialty.IsEnabled = true;
            txtBoxFaculty.IsEnabled = true;
            txtBoxStatus.IsEnabled = true;
            txtBoxFNum.IsEnabled = true;
            txtBoxEduLevel.IsEnabled = true;
            txtBoxCourse.IsEnabled = true;
            txtBoxStream.IsEnabled = true;
            txtBoxGroup.IsEnabled = true;
            cbScholarship.IsEnabled = true;
            cbScholarship2.IsEnabled = true;
            rbMale.IsEnabled = true;
            rbFemale.IsEnabled = true;
            rbOther.IsEnabled = true;   
            calendar1.IsEnabled = true;
            userImage.IsEnabled = true;

            clearButton.IsEnabled = true;
            getStudentButton.IsEnabled = true;
            disableButton.IsEnabled = true;
            enableButton.IsEnabled = true; 
            enterMode.IsEnabled = true;
            exitMode.IsEnabled = true; 



        }

        private void disableButton_Click(object sender, RoutedEventArgs e)
        {
            txtBoxName.IsEnabled = false;
            txtBoxSurName.IsEnabled = false;
            txtBoxFamilyName.IsEnabled = false;
            txtBoxSpecialty.IsEnabled = false;
            txtBoxFaculty.IsEnabled = false;
            txtBoxStatus.IsEnabled = false;
            txtBoxFNum.IsEnabled = false;
            txtBoxEduLevel.IsEnabled = false;
            txtBoxCourse.IsEnabled = false;
            txtBoxStream.IsEnabled = false;
            txtBoxGroup.IsEnabled = false;
            cbScholarship.IsEnabled = false;
            cbScholarship2.IsEnabled = false;
            rbMale.IsEnabled = false;
            rbFemale.IsEnabled = false;
            rbOther.IsEnabled = false;
            calendar1.IsEnabled = false;
            userImage.IsEnabled = false;

            clearButton.IsEnabled = false;
            getStudentButton.IsEnabled = false;
            disableButton.IsEnabled = false;
            enableButton.IsEnabled = true;
            enterMode.IsEnabled = false;
            exitMode.IsEnabled = false;


            /*   foreach (UIElement box in StudentGrid.Children)
                {

                        if (box is TextBox)
                        {
                            box.IsEnabled = false;
                        }

                        /*
                        if (box.Name.Equals(enableButton.Name))
                            box.IsEnabled = true;
                        else
                            box.IsEnabled = false;
                        */

            // } 


        }

        private void ClearText()
        {
            txtBoxName.Text = String.Empty;
            txtBoxSurName.Text = String.Empty;
            txtBoxFamilyName.Text = String.Empty;
            txtBoxSpecialty.Text = String.Empty;
            txtBoxFaculty.Text = String.Empty; ;
            txtBoxStatus.SelectedItem = String.Empty;
            // txtBoxStatus.ItemsSource = student.status;
            // txtBoxStatus.Text = student.status;
            txtBoxFNum.Text = String.Empty;
            txtBoxEduLevel.Text = String.Empty;
            txtBoxCourse.Text = String.Empty;
            txtBoxStream.Text = String.Empty;
            txtBoxGroup.Text = String.Empty;
            cbScholarship.IsChecked = false;
            cbScholarship2.IsChecked = false;
            // cbScholarship.IsChecked = student.Checked;
            rbMale.IsChecked = false;
            rbFemale.IsChecked = false;
            rbOther.IsChecked = false;
        


        /*
        foreach (UIElement control in StudentGrid.Children)
        {
            if (control is TextBox)
            {
                (control as TextBox).Clear();
            }
        }
        */


        /*
        foreach (UIElement box in StudentGrid.Children)
        {

                if (box.GetType() == typeof(TextBox))
                {
                    ((TextBox)box).Text = String.Empty;
                }
                else if (box.GetType() == typeof(RadioButton))
                {
                    box.IsEnabled = false;
                }
                else if (box.GetType() == typeof(CheckBox))
                {
                    box.IsEnabled = false;
                }
                else
                {

                }  

        }
        */

        /* 

        foreach (Control box in StudentGrid.Children)
        {
            if (box.GetType() == typeof(TextBox))
                ((TextBox)box).Text = String.Empty;
        }
        */
    }

        private void showInfo(Student student)
        {
            txtBoxName.Text = student.name;
            txtBoxSurName.Text = student.surname;
            txtBoxFamilyName.Text = student.lastName;
            txtBoxSpecialty.Text = student.specialty;
            txtBoxFaculty.Text = student.faculty;
            txtBoxStatus.SelectedItem = student.status;
           // txtBoxStatus.ItemsSource = student.status;
           // txtBoxStatus.Text = student.status;
            txtBoxFNum.Text = student.facultyNumber;
            txtBoxEduLevel.Text = student.educationalLevel;
            txtBoxCourse.Text = student.course.ToString();
            txtBoxStream.Text = student.stream.ToString();
            txtBoxGroup.Text = student.group.ToString();
            cbScholarship.IsChecked = student.receiveScholarship;
            cbScholarship2.IsChecked = student.receiveScholarship2;
            // cbScholarship.IsChecked = student.Checked;
            rbMale.IsChecked = student.genderMale;
            rbFemale.IsChecked = student.genderFemale; 
            rbOther.IsChecked = student.genderOther;
        }


        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                userImage.Source = new BitmapImage(fileUri);
            }
        }



        private void enterMode_Click(object sender, RoutedEventArgs e)
        {
           /* foreach (UIElement box in StudentGrid.Children)
            {
                box.Visibility = Visibility.Visible;
            }
           */

            StudentData studentData = new StudentData();

            showInfo(studentData.GetTestStudents().First());

            txtBoxName.Visibility = Visibility.Visible;
            txtBoxSurName.Visibility = Visibility.Visible;
            txtBoxFamilyName.Visibility = Visibility.Visible;
            txtBoxSpecialty.Visibility = Visibility.Visible;
            txtBoxFaculty.Visibility = Visibility.Visible;
            txtBoxStatus.Visibility = Visibility.Visible;
            txtBoxFNum.Visibility = Visibility.Visible;
            txtBoxEduLevel.Visibility = Visibility.Visible;
            txtBoxCourse.Visibility = Visibility.Visible;
            txtBoxStream.Visibility = Visibility.Visible;
            txtBoxGroup.Visibility = Visibility.Visible;
            cbScholarship.Visibility = Visibility.Visible;
            cbScholarship2.Visibility = Visibility.Visible;
            rbMale.Visibility = Visibility.Visible;
            rbFemale.Visibility = Visibility.Visible;
            rbOther.Visibility = Visibility.Visible;
            calendar1.Visibility = Visibility.Visible;
            userImage.Visibility = Visibility.Visible;

            loadFromFile.Visibility = Visibility.Visible;
            testStudentsEmpty.Visibility = Visibility.Visible; 
            

            clearButton.Visibility = Visibility.Visible;
            getStudentButton.Visibility = Visibility.Visible;
            disableButton.Visibility = Visibility.Visible;
            enableButton.Visibility = Visibility.Visible;
            enterMode.Visibility = Visibility.Visible;
            exitMode.Visibility = Visibility.Visible;

        }

        private void exitMode_Click(object sender, RoutedEventArgs e)
        {
            txtBoxName.Visibility = Visibility.Hidden;
            txtBoxSurName.Visibility = Visibility.Hidden;
            txtBoxFamilyName.Visibility = Visibility.Hidden;
            txtBoxSpecialty.Visibility = Visibility.Hidden;
            txtBoxFaculty.Visibility = Visibility.Hidden;
            txtBoxStatus.Visibility = Visibility.Hidden;
            txtBoxFNum.Visibility = Visibility.Hidden;
            txtBoxEduLevel.Visibility = Visibility.Hidden;
            txtBoxCourse.Visibility = Visibility.Hidden;
            txtBoxStream.Visibility = Visibility.Hidden;
            txtBoxGroup.Visibility = Visibility.Hidden;
            cbScholarship.Visibility = Visibility.Hidden;
            cbScholarship2.Visibility = Visibility.Hidden;
            rbMale.Visibility = Visibility.Hidden;
            rbFemale.Visibility = Visibility.Hidden;
            rbOther.Visibility = Visibility.Hidden;
            calendar1.Visibility = Visibility.Hidden;
            userImage.Visibility = Visibility.Hidden;

            loadFromFile.Visibility = Visibility.Hidden;
            testStudentsEmpty.Visibility = Visibility.Hidden;


            clearButton.Visibility = Visibility.Hidden;
            getStudentButton.Visibility = Visibility.Hidden;
            disableButton.Visibility = Visibility.Hidden;
            enableButton.Visibility = Visibility.Hidden;
            
            enterMode.Visibility = Visibility.Visible;
            exitMode.Visibility = Visibility.Hidden;


            /* foreach (UIElement box in StudentGrid.Children)
             {

                 box.Visibility = Visibility.Visible;
             } */


            /*
            foreach (Control box in StudentGrid.Children)
            {
                if (box.Name.Equals(exitMode.Name))
                {
                    box.Visibility = Visibility.Visible;
                }
                else
                {
                    box.Visibility = Visibility.Hidden;
                }


            }
            */
        }

        private void ifStudentsEmpty_Click(object sender, RoutedEventArgs e)
        {
            StudentData cntx = new StudentData();
            
            cntx.TestStudentsIfEmpty();
            // MessageBox.Show(cntx.ToString());
            if (cntx.TestStudentsIfEmpty())
            {
                MessageBox.Show("Empty Students!");
            }
            else
            {
                MessageBox.Show("Not empty");
            }
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Сигурни ли сте,че искате да затворите прозореца ?", "Изход", MessageBoxButton.YesNo);
            Console.WriteLine(result);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}


//ifStudentsEmpty_Click



//showNamesButton.Click -= this.showNamesButton_Click;
// showNamesButton.Click += new EventHandler(showOtherInfoButton_Click);
