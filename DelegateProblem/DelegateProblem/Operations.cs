using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProblem
{
    internal class Operations
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiply={0}", a * b);
        }

        public event EventHandler xyz;
        public void Action(string a)
        {
            if (xyz != null)
            {
                xyz(a);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Not Registered");
            }
        }
    }
}
