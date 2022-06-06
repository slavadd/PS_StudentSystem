using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            Student student = new Student();
            if (user.FacultyNumber == null)
            {
                Console.WriteLine("Faculty number is not entered in the user data.");
            }

            if (!user.FacultyNumber.Equals(student.facultyNumber))
            {
                Console.WriteLine("Student with this faculty number was not found.");

            }

            return student;
        }



    }
}
