using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Events
{
    delegate int ComputeHandler(int x, int y);

    delegate void OnErrorHandler(string message);

    delegate void OnCustomErrorHandler(CalculatorErrorArg e);

    internal class Calculator
    {
        public event OnErrorHandler? OnError;            // events are always declared as DATAFIELD
        public event OnCustomErrorHandler? OnCustomErrorHandler;

        public int Compute(int x, int y, ComputeHandler? objD)
        {
            int result = -1;

            Console.WriteLine("--- Encapsulated Logic");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");

            Console.WriteLine("4. The Process/Activity");
            try
            {
                result = objD?.Invoke(x, y) ?? 0;
            }
            catch(System.Exception exp)
            {
                if (this.OnError != null)        // check if the event is subscribed
                {
                    this.OnError(exp.Message);             // raise the event
                }

                if(this.OnCustomErrorHandler != null)
                {
                    CalculatorErrorArg e = new CalculatorErrorArg();
                    e.ErrorMessage = exp.Message;

                    // e.Data = new Dictionary<string, int>();
                    // e.Data.Add("x", x);
                    // e.Data.Add("y", y);

                    e.Data = new Dictionary<string, int>
                    {
                        { "x", x },
                        { "y", y }
                    };
                    this.OnCustomErrorHandler(e);
                }
            }

            Console.WriteLine("5. Audit Logging");

            return result;
        }

    }
}
