using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(GetMinValue(numbers));
            Console.WriteLine(GetMaxValue(numbers));
            double average = GetAverage(numbers);
            Console.WriteLine("{0:f2}",average);
            Console.WriteLine(GetSum(numbers));
            Console.WriteLine(GetProduct(numbers));
        }

        static int GetMinValue(List<int> list)
        {
            int min = list.Min();
            return min;
        }
        static int GetMaxValue(List<int> list)
        {
            int max = list.Max();
            return max;
        }
        static double GetAverage(List<int> list)
        {
            double average = GetSum(list) / (1.0 * list.Count) ;
            average = Math.Round(average, 2);
            return average;
        }
        static int GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        static long GetProduct(List<int> list)
        {
            long product = 1L;
            for (int i = 0; i < list.Count; i++)
            {
                product *= list[i];
            }
            return product;
        }
    }
}
