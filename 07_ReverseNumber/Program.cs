using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseInput(input));
        }
        static string ReverseInput(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            string reversed = sb.ToString();

            return reversed;
        }
    }
}
