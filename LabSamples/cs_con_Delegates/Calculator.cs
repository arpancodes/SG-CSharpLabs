using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Delegates
{
    // STEP 1: Define the method signature
    delegate int ComputeHandler(int a, int b);

    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("--- Encapsulated Logic");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");
            Console.WriteLine("4. The Process/Activity");
            Console.WriteLine("5. Audit Logging");

            return a + b;
        }

        // STEP 2: Define the method to receive an object of the Delegate
        /// <summary>
        ///     Performs the computation
        /// </summary>
        /// <param name="a">the first number</param>
        /// <param name="b">the second number</param>
        /// <param name="objD">the delegate object</param>
        /// <returns></returns>
        public int Compute(int a, int b, ComputeHandler? objD )
        {
            int result = -1;

            Console.WriteLine("--- Encapsulated Logic");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");
            
            Console.WriteLine("4. The Process/Activity");

            // STEP 3: Check if the DELEGATE is "SUBSCRIBED"
            if (objD != null)
            {
                // STEP 4: Invoke the call to the method pointed to by delegate
                result = objD(a, b);
                //  SAME AS ABOVE: result = objD.Invoke(a, b);
            }

            result = objD?.Invoke(a, b) ?? -1;          // STEP 3 & 4

            Console.WriteLine("5. Audit Logging");
            
            return result;
        }
    }

    
}
