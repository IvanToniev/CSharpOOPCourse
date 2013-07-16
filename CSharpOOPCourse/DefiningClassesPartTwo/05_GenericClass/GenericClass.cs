using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericClass
{
    class GenericList<T>
    {
        

        private T[] elementsList;
        private int usedPositions;

        public GenericList(int capacity)
        {
            elementsList=new T[capacity];
            usedPositions = 0;
        }

        public GenericList()
            :this(10)
        { }

        public void AddElement(T newElem)
        {
            if (this.usedPositions >= elementsList.Length)
            {
                throw new InvalidOperationException("List is full.");
            }
            else
            {
                this.elementsList[this.usedPositions] = newElem;
                this.usedPositions++;
            }
        }

        public void AutoGrow()
        {
            T[] doubleElements = new T[2 * elementsList.Length];
            for (int i = 0; i < elementsList.Length; i++)
            {
                doubleElements[i] = elementsList[i];
            }
            elementsList = doubleElements;
        }

        public void RemoveElement(T indexOfElemToRemove) 
        {
            int index = Array.IndexOf(elementsList, indexOfElemToRemove);
            T[] tempArr=new T[elementsList.Length];
            Array.Copy(tempArr, index + 1, elementsList, index, elementsList.Length - 1 - index);
            usedPositions--;
        }

        public int FindByValue(T element)
        {
            int myIndex = Array.IndexOf(elementsList, element);
            return myIndex; 
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = elementsList.Min();
            return min;
        }

        public T Max<T>() where T:IComparable<T>,IComparable 
        {
            dynamic max = elementsList.Max();
            return max;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < usedPositions; i++)
            {
                result.Append(elementsList[i] + " ");
            }
            return result.ToString();
        }
    }
}
