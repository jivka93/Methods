using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10_N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(number));
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger result = 1;

            if (number == 0)
            {
                result = 1;
            }
            else
            {
                int[] array = new int[number];
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
            }

            return result;
        }
    }
}
