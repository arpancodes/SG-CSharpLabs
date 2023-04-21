using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AnonymousMethod
{
    delegate int ComputeHandler(int a, int b);

    internal class Calculator
    {
        public int Compute(int a, int b, ComputeHandler? handler)
        {
            int result;

            Console.WriteLine("--- Encapsulated Logic");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");

            Console.WriteLine("4. The Process/Activity");
            result = handler?.Invoke(a, b) ?? -1;
                
            Console.WriteLine("5. Audit Logging");

            return result;

        }
    }
}
