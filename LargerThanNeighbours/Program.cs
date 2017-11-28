using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(LargerThanNeighbours(array));

        }
        static int LargerThanNeighbours(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
