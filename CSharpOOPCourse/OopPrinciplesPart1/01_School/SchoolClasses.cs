using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class SchoolClasses
    {
        private string textIdent = "";
        private List<Teachers> teachers = new List<Teachers>();
        private List<Students> students = new List<Students>();
        public List<Students> Students
        {
            get
            {
                return this.students;
            }
        }

        

        public List<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string TextIdent
        {
            get
            {
                return this.textIdent;
            }
            set
            {
                this.textIdent = value;
            }
        }

    }
}
