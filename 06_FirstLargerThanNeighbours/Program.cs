using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(GetFirstLargerThanNeighboursIndex(array));
        }
        static int GetFirstLargerThanNeighboursIndex(int[] array)
        {
            int index = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
