using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CountElementAppearance(numbers,searchedNumber));
        }
        static int CountElementAppearance(int[] array, int element)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
