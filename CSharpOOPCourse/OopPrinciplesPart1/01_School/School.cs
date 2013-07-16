using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class School
    {
        private int numOfClasses=1;
        private readonly List<SchoolClasses> classes=new List<SchoolClasses>();

        public List<SchoolClasses> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public int NumOfClasses
        {
            get
            {
                return this.numOfClasses;
            }
            set
            {
                this.numOfClasses = value;
            }
        }
    }
}
