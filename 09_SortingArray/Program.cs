using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ",SortArray(input)));
        }

        static int MaxElement(List<int> list, int startIndex) // Get the biggest element in a int array, starting from a certain index
        {
            int numberOfElements = list.Count - startIndex;
            int[] partOfArray = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                partOfArray[i] = list[startIndex];
                startIndex++;
            }

            int maxElement = partOfArray.Max();
            return maxElement;
        }

        static int[] SortArray(int[] array, string sortingType = "ascending") // Sort a given array
        {
            int[] sortedArray = new int[array.Length];
            List<int> arrayCopy = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy.Add(array[i]);
            }

            if (sortingType == "ascending")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    sortedArray[i] = MaxElement(arrayCopy, 0);
                    arrayCopy.Remove(MaxElement(arrayCopy, 0));
                }
            }
            else if (sortingType == "descending")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sortedArray[i] = MaxElement(arrayCopy, 0);
                    arrayCopy.Remove(MaxElement(arrayCopy, 0));
                }
            }

            return sortedArray;
        }
    }
}
