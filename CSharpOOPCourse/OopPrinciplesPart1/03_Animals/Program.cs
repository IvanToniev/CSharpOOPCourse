using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Program
    {
        public static double AverageAge(Animal[] animalArray)
        {
            double animalAge = 0;
            foreach (var animal in animalArray)
            {
                animalAge += animal.Age;
            }

            return animalAge / animalArray.Length;
        }

        static void Main(string[] args)
        {
            Cat[] cats = new Cat[3]{new Cat(3,"petkancho","female"),new Cat(4,"dragancho","male"),new Cat(6,"ez","female")};
            Dog[] dogs = new Dog[2]{new Dog(7,"sharko","male"),new Dog(8,"beliq zub","male")};
            Frog[] frogs = new Frog[2]{new Frog(1,"greg","male"),new Frog(1,"peci","male")};

            Console.WriteLine(AverageAge(cats));
        }
    }
}
