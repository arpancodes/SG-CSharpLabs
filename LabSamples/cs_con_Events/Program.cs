namespace cs_con_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;

            //result = objCalc.Compute(5, 20, (new Program()).Add);
            //Console.WriteLine("Result from Add: {0}", result);
            //Console.WriteLine();

            //result = objCalc.Compute(5, 20, Program.Subtract);
            //Console.WriteLine("Result from Subtract: {0}", result);
            //Console.WriteLine();

            result = objCalc.Compute(10, 0, Program.Divide);
            Console.WriteLine("Result from Divide: {0}", result);
            Console.WriteLine();

            objCalc.OnError += Program.m;       // Subscribe to the event handler
            objCalc.OnCustomErrorHandler += ObjCalc_OnCustomErrorHandler;
            result = objCalc.Compute(10, 0, Program.Divide);
            Console.WriteLine("Result from Divide: {0}", result);
            Console.WriteLine();
        }

        private static void ObjCalc_OnCustomErrorHandler(CalculatorErrorArg e)
        {
            Console.WriteLine($"CUSTOM ERROR ENCOUNTERED: {e.ErrorMessage}");

            if (e.Data != null)
            {
                foreach (KeyValuePair<string, int> item in e.Data)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }

                foreach (var item in e.Data)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
        }

        static private void m(string message)
        {
            Console.WriteLine($"ERROR OCCURRED: {message}");
        }

        static private int Divide(int x, int y)
        {
            Console.WriteLine("---- Divide() was called");
            return x / y;
        }

        private int Add(int x, int y)
        {
            Console.WriteLine("--- Add() was called");
            return x + y;
        }

        static private int Subtract(int x, int y)
        {
            Console.WriteLine("--- Subtract() was called");
            return y - x;
        }
    }
}