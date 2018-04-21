using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedMath1963;

namespace DLLTest1963
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Please enter a number: ");
            input = int.Parse(Console.ReadLine());
            Console.Write(Calculator.Factorial(input));
            Console.ReadKey();
        }
    }
}

