using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Frog:Animal
    {
       public Frog(int age,string name,string sex)
            : base(age, name, sex)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

       public string ProduceSound()
       {
           return "quak quak";
       }
        
    }
}
