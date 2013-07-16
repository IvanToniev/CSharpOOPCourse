using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Disciplines
    {
        private string name="";
        private int numOfLecturers=0;
        private int numOfExc=0;
        public int NumOfExc
        {
            get
            {
                return this.numOfExc;
            }
            set
            {
                this.numOfExc = value;
            }
        }

        public int NumOfLecturers
        {
            get
            {
                return this.numOfLecturers;
            }
            set
            {
                this.numOfLecturers = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Disciplines(string name,int lectNum,int excNum)
        {
            this.name = Name;
            this.NumOfLecturers = lectNum;
            this.NumOfExc = excNum;
        }

    }
}
