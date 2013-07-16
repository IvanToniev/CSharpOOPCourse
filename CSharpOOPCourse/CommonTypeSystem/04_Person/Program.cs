using _04.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = 
        {
            new Person("Pesho", 25),
            new Person("Gosho"),
            new Person("Sasho", 18 ),
            new Person("Vasko")
        };

            foreach (var person in people)
            {
                Console.WriteLine("Person Information:");
                Console.WriteLine("------------------");
                Console.WriteLine(person);
            }
        }
    }
}
