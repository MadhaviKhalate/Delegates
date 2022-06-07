using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProblem
{
    public delegate void EventHandler(String x);
    internal class EventExample
    {
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operations o = new Operations();
            o.Action("Event Calling");

            Console.WriteLine();
            o.xyz += new EventHandler(CatchEvent);
            o.Action("Event Called");
        }
    }
}
