using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHallo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine() ;
            Console.WriteLine(GetGreeting(name));
        }

        static string GetGreeting(string name)
        {
            string greeting = "Hello, " + name + "!";
            return greeting;
        }
    }
}
