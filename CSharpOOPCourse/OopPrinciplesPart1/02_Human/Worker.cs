using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Human
{
    class Worker:Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        
        public Worker(string firstname,string lastname,int salary,int workhours) 
            :base(firstname,lastname)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workhours;
        }

        public Worker(string firstName, string lastName, int salary)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
        }

        public Worker(int salary)
            :this(null,null,salary)
        {
            this.WeekSalary = salary;
        }


        public double MoneyPerHour(int weekSalary, int hoursPerDay)
        {
            return (weekSalary / 7) / hoursPerDay;
        }

    }
}
