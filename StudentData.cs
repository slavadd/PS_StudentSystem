using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentData
    {
        public static List<Student> TestStudents
        {
            get
            {
                AddStudentInList();
                return _testStudent;
            }
            set { }
        }

        private static List<Student> _testStudent = new List<Student>();

        //  if (!IsThereStudent("121219001"))

        static private void AddStudentInList()
        {
            if (!_testStudent.Any())
            {
                _testStudent.Add(AddStudent1());
                _testStudent.Add(AddStudent2());
                _testStudent.Add(AddStudent3());
            }
        }


        private static Student AddStudent1()
        {
            Student student = new Student();
            student.name = "Petar";
            student.surname = "Dimitrov";
            student.lastName = "Georgiev";
            student.specialty = "KSI";
            student.faculty = "FKST";
            student.educationalLevel = "Bachelor";
            student.status = "Certified";
            student.facultyNumber = "121219001";
            student.course = 3;
            student.stream = 1;
            student.group = 29;
            student.receiveScholarship= true;
            student.receiveScholarship2 = false;
            student.genderMale = true;
            student.genderFemale = false;
            student.genderOther = false;

            return student;
        }


        private static Student AddStudent2()
        {
            Student student = new Student();
            student.name = "Georgi";
            student.surname = "Shopov";
            student.lastName = "Todorov";
            student.specialty = "KSI";
            student.faculty = "FKST";
            student.educationalLevel = "Bachelor";
            student.status = "Редовен";
            student.facultyNumber = "121219002";
            student.course = 3;
            student.stream = 1;
            student.group = 30;
            student.receiveScholarship = false; ;
            student.receiveScholarship2 = true;
            student.genderMale = true;
            student.genderFemale = false;
            student.genderOther = false;

            return student;
        }

        private static Student AddStudent3()
        {
            Student student = new Student();
            student.name = "Nina";
            student.surname = "Petkova";
            student.lastName = "Zdravkova";
            student.specialty = "KSI";
            student.faculty = "FKST";
            student.educationalLevel = "Bachelor";
            student.status = "Редовен";
            student.facultyNumber = "121219003";
            student.course = 3;
            student.stream = 1;
            student.group = 31;
            student.receiveScholarship = false; ;
            student.receiveScholarship2 = true;
            student.genderMale = false;
            student.genderFemale = true;
            student.genderOther = false;

            return student;
        }

        public List<Student> GetTestStudents()
        {
            return TestStudents;
        }




        public  bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> quertyStudents = context.Students;
            int? countStudents = quertyStudents.Count();

            if (quertyStudents == null)
            {
                return true;
            }
            else { return false; }


        }

       // User user1 = new User();
       // StudentInfoContext context = new StudentInfoContext();

        public  void CopyTestStudents()
        {
             StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
            if (TestStudentsIfEmpty())
            {
                CopyTestStudents();
            }

        }

       /* public void CopyTestUsers()
        {
            using (StudentInfoDatabase db = new StudentInfoDatabase())
            {
                User u = new User();
                user1 = db.Users.Where(s => s.name == u.Username).FirstOrDefault();

                foreach (User users in db.User)
                {
                    context.Users.Add(users);
                }

                //UserContext context = new UserContext();
                StudentData studentdata = new StudentData();
                /*foreach (User user in UserData.TestUsers)
                {
                    context.Users.Add(user);
                }*/
         //       context.SaveChanges();
        //    }
     //   } 






        public Student IsThereStudent()
        {
            User user1 = new User();
            StudentInfoContext context = new StudentInfoContext();

            Student result = (from st in context.Students where st.facultyNumber == user1.FacultyNumber select st).First();


            return result;
        }

        /* public bool IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();

            Student? result = context.Students.SingleOrDefault(s => s.FacultyNumber == facNum);
            return result != null;
        }*/



    }
}
