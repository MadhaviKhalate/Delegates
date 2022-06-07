using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProblem
{
    internal class ArrayDelegates
    {
        delegate void DelegateOp(int a, int b);
        public static void ImplementDelegate()
        {
            DelegateOp[] obj =
            {
                new DelegateOp(DelegateProblem.Operations.Add),
                new DelegateOp(DelegateProblem.Operations.Mul)
            };
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 9);
                obj[i](4, 7);
            }

        }
    }
}
