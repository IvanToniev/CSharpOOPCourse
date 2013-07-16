using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IEnumerableExtensions
{
    public static class IEnumerableExt
    {
        public static T Sum<T>(this IEnumerable<T> input) where T:IComparable
        {
            dynamic sum = 0;
            foreach (var item in input)
            {
                sum += input;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in input)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic min=int.MaxValue; // to be sure , there is a smaller number. 
            foreach (var item in input)
            {
                if (min>item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic max = int.MinValue;
            foreach (var item in input)
            {
                if (max<item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {         
            int itemsCount = 0;
            dynamic sum=0;

            foreach (var item in input)
	        {
	        	 sum+=item;
                 itemsCount++;
	        }
            
            return sum/itemsCount;
        }
        
    }
}
