using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ConvertDigitToWord(number[number.Length - 1]));
        }

        static string ConvertDigitToWord(char digit)
        {
            string word = "";
            if (digit == '0')
            {
                word = "zero";
            }
            else if (digit == '1')
            {
                word = "one";
            }
            else if (digit == '2')
            {
                word = "two";
            }
            else if (digit == '3')
            {
                word = "three";
            }
            else if (digit == '4')
            {
                word = "four";
            }
            else if (digit == '5')
            {
                word = "five";
            }
            else if (digit == '6')
            {
                word = "six";
            }
            else if (digit == '7')
            {
                word = "seven";
            }
            else if (digit == '8')
            {
                word = "eight";
            }
            else if (digit == '9')
            {
                word = "nine";
            }

            return word;
        }
    }
}
