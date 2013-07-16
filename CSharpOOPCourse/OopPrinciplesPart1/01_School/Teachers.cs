using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Teachers:People
    {
        private readonly List<Disciplines> disc=new List<Disciplines>();

        public List<Disciplines> Disc
        {
            get
            {
                return this.disc;
            }
        }

        

       

        public Teachers(string name) 
            :base(name)
        {
            
        }
    }
}
