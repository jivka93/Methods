using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(SumOfArrays(array1,array2));
        }

        static string SumOfArrays(int[] array1, int[] array2)
        {
            int length = Math.Max(array1.Length,array2.Length);
            int[] array1copy = new int[length];
            int[] array2copy = new int[length];

            int i1 = 0;
            int i2 = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                if (i1 < array1.Length)
                {
                    array1copy[i] = array1[i1];
                    i1++;
                }
                else
                {
                    array1copy[i] = 0;
                }


                if (i2 < array2.Length)
                {
                    array2copy[i] = array2[i2];
                    i2++;
                }
                else
                {
                    array2copy[i] = 0;
                }
            }

            int[] suma = new int[length];
            int iterator = 0;
            int remaining = 0;
            for (int i = length - 1; i >= 0 ; i--)
            {
                int digit1 = array1copy[i];
                int digit2 = array2copy[i];
                int sum = digit1 + digit2 + remaining;
                if (sum > 9)
                {
                    remaining = sum / 10;
                    sum = sum % 10;

                }
                else
                {
                    remaining = 0;
                }
                suma[iterator] = sum;
                iterator++;
            }

            string result = string.Join(" ", suma);
            return result;
        }
    }
}
