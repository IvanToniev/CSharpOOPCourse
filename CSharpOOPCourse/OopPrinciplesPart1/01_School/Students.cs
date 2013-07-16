using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Students:People
    {
        
        private int classNumber;
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public Students(string name, int number)
            :base(name)
        {
            this.ClassNumber = number;
        }
    }
}
