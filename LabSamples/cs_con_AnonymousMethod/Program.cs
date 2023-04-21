namespace cs_con_AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            int x = 2;
            int y = 10;
            int z;

            // Single Cast Delegate (implicitly done by the developer)
            z = objCalc.Compute(x, y, Program.Add);
            Console.WriteLine($"{x} + {y} = {z}");
            Console.WriteLine();

            // Single Cast Delegate (explicitly done by the developer)
            ComputeHandler objD 
                = new ComputeHandler(Program.Add);      // explicitly instantiated
            z = objCalc.Compute(x, y, objD);
            Console.WriteLine($"{x} + {y} = {z}");
            Console.WriteLine();

            // ANONYMOUS METHOD
            ComputeHandler objD2 
                = delegate(int x, int y)
                {
                    Console.WriteLine("---- Anonymous Method was called!");
                    return y - x;
                };
            z = objCalc.Compute(x, y, objD2);
            Console.WriteLine($"Anonymous Method: {y} - {x} = {z}");
            Console.WriteLine();

            // ANONYMOUS METHOD - Version 2
            ComputeHandler objD3
                = (int x, int y) =>         // GOES TO OPERATOR (=>)
                {
                    Console.WriteLine("---- Anonymous Method was called!");
                    return x * y;
                };
            z = objCalc.Compute(x, y, objD3);
            Console.WriteLine($"Anonymous Method: {x} * {y} = {z}");
            Console.WriteLine();

            // ANONYMOUS METHOD - Version 3
            ComputeHandler objD4
                = (x, y) =>         // GOES TO OPERATOR (=>)
                {
                    return x * y;
                };
            z = objCalc.Compute(x, y, objD4);
            Console.WriteLine($"Anonymous Method: {x} * {y} = {z}");
            Console.WriteLine();

            // LAMBDA VERSION
            // ANONYMOUS METHOD - FINAL VERSION
            // ONLY IF: ONLY one line in the anonymous method's code  {...}
            ComputeHandler objD5
                = (x, y) => x * y;          // LAMBDA EXPRESSION

            z = objCalc.Compute(x, y, objD4);
            Console.WriteLine($"Anonymous Method: {x} * {y} = {z}");
            Console.WriteLine();


        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private int _ObjectID;
        public int ObjectID
        {
            get => _ObjectID;
            set => _ObjectID = value;
        }

        private static int Add( int x, int y)
        {
            Console.WriteLine("---- Add() was called!");
            return x + y;   
        }
    }
}