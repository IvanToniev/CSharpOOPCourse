using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string someString = "1234";
            sb.Append(someString);
           
            Console.WriteLine( sb.ToString().Substring(1,3));
        }
    }
}
