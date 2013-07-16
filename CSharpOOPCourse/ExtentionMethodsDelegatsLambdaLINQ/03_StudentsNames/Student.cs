using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_05_Students
{
    public class Student 
    {
        private string firstName;
        private string lastName;
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public Student(string firstName,string lastName,int age) 
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
        }

    }
}
