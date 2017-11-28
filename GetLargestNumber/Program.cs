using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = (Console.ReadLine()).Split(' ').Select(int.Parse).ToArray();

            int maxNum = int.MinValue;
            for (int i = 1; i < numbers.Length; i++)
            {
                int number1 = numbers[i];
                int number2 = numbers[i - 1];
                if (maxNum < GetMax(number1,number2))
                {
                    maxNum = GetMax(number1, number2);
                }
            }
            Console.WriteLine(maxNum);
        }

        static int GetMax(int number1, int number2)
        {
            int max = int.MinValue;
            if (number1 > number2)
            {
                max = number1;
            }
            else
            {
                max = number2;
            }
            return max;
        }
    }
}
