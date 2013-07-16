using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Student
{
    class Student:IClonable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Course { get; set; }
        public int SSN { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }


        public Student(string firstName, string middleName, string lastName, string address, string phone, int course, int ssn, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.Mobile = phone;
            this.Course = course;
            this.SSN = ssn;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

         public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.AppendLine(this.FirstName);
            build.AppendLine(this.MiddleName);
            build.AppendLine(this.LastName);
            build.AppendLine(this.Address);
            build.AppendLine(this.Mobile.ToString());
            build.AppendLine(this.Course.ToString());
            build.AppendLine(this.SSN.ToString());
            build.AppendLine(this.Specialty.ToString());
            build.AppendLine(this.University.ToString());
            build.AppendLine(this.Faculty.ToString());

            return build.ToString();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }
        public Student Clone()
        {
            Student clone = new Student
                (
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Address,
                this.Mobile,
                this.Course,
                this.SSN,
                this.Specialty,
                this.University,
                this.Faculty
                );
            return clone;
        }

        Student IClonable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.LastName != student.LastName)
            {
                return (String.Compare(this.LastName, student.LastName));
            }
            if (this.FirstName != student.FirstName)
            {
                return (String.Compare(this.FirstName, student.FirstName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }    
    }
    
}
