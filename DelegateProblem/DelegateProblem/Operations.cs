using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProblem
{
    internal class Operations
    {
        public static void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum of two no. is: " + sum);
        }
        public static void Multiplication(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine("Multiplication of two no. is: " + mul);
        }
    }
}
