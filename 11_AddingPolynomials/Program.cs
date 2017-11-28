using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", SumPolynomials(array1, array2)));
        }

        static int[] SumPolynomials(int[] array1, int[] array2)
        {
            int[] sum = new int[array1.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = array1[i] + array2[i];
            }
            return sum;
        }
    }
}
