using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrItems=int.Parse(Console.ReadLine());
            int[] givenArr=new int[arrItems];
            for (int i = 0; i < givenArr.Length; i++)
            {
                givenArr[i] = int.Parse(Console.ReadLine());
            }

            var divisibleLINQ =
                from number in givenArr
                where number % 21 == 0
                select number;

            foreach (var number in divisibleLINQ)
            {
                Console.WriteLine(number);
            }

            var divisibleLambda = givenArr.Where(x => x % 21 == 0);
            foreach (var num in divisibleLambda)
            {
                Console.WriteLine(num);
            }
        }
    }
}
