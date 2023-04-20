namespace cs_con_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            int x = 10;
            int y = 20;
            int result = objCalc.Add(x, y);
            Console.WriteLine($"Sum of {x} and {y} = {result}");
            Console.WriteLine();

            result = Program.Subtract(x, y);
            Console.WriteLine($"Difference between {y} and {x} = {result}");
            Console.WriteLine();

            result = objCalc.Compute(x, y, Program.Subtract);
            Console.WriteLine($"Difference between {y} and {x} = {result} computed through DELEGATE");
            Console.WriteLine();

            result = objCalc.Compute(x, y, null);
            Console.WriteLine("Result of a NULL call to delegate: {0}", result);
        }

        static private int Subtract(int x, int y)
        {
            Console.WriteLine($"--- Subtract called with {x} and {y}");
            return y - x;
        }
    }
}