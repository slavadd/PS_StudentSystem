using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        public String name { get; set; }
        public String surname { get; set; }
        public String lastName { get; set; }
        public String specialty { get; set; }
        public String faculty { get; set; }
        public String educationalLevel { get; set; }
        public String status { get; set; }
        public String facultyNumber { get; set; }
        public int course { get; set; }
        public int stream { get; set; }
        public int group { get; set; }

        public bool receiveScholarship { get; set; }

        public bool receiveScholarship2 { get; set; }

        public bool genderFemale { get; set; }

        public bool genderMale { get; set; }

        public bool genderOther { get; set; }



        public byte[] Photo { get; set; }

        public int StudentId { get; set; }

        public override string ToString() { return this.name; }
    }
}
