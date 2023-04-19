namespace cs_con_BoxingUnboxing
{
    /// <remarks>
    ///     IS operator             Type-Check Operator
    ///     AS operator             Type-Cast Opertor (ONLY FOR REFERENCE TYPES)
    /// </remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = 500L;
            char c = 'a';
            string s = "hello world";

            long y = i;             // implicit typecasting
            int x = (int)l;         // explicit typecasting

            Display(i);
            Display(l);

            // A objA = new B();
            object oInt = i;                // Boxing  (implicit typecasting)
            object oLong = l;
            object oChar = c;

            int z;
            z = i;
            z = (int)oInt;                  // UnBoxing (explicit typecasting - can throw exception)

            int? z2 = (int?)oInt;            // UnBoxing (will not throw an exception
                                             //           if oInt is not an INTEGER)
            z = z2 ?? default;

            // ---- (version 1)
            // object oString = s;             // boxing 
            // Display(oString);

            // ---- (version 2)
            Display(s);                        // boxing 
        }

        static void Display(object o)
        {
            Console.WriteLine($"Received: {o}, Type : {o.GetType()}");
            if(o.GetType() == typeof(int))
            {
                // o = o + 1;           ---> o = (int)o + 1; // Correct
                // o++;                 ---> o = (int)o + 1; // Correct
                // o += 1;              ---> o = (int)o + 1; // Correct

                int x = (int)o;             // unboxing
                x++;
                Console.WriteLine("Received an Integer with the value of {0}", x);
            }
            else if( o is int )                  // if(o.GetType() == typeof(long))
            {
                long x = (long)o;
                Console.WriteLine("Received a Long with the value of {0}", x);
            }
            // (o.GetType() == typeof(string))
            // o.GetType().Equals( typeof(int) )
            else if (o is string)
            {
                // string x = (string)o;
                string? x = o as string;         // Safe Unboxing  (will not throw an exception
                                                 //                if o is not a STRING)
                Console.WriteLine("Received a String with the value of {0}", x);
            }
            Console.WriteLine();
        }

        //static void Display(int i)
        //{
        //    Console.WriteLine($"integer: {i}");
        //}

        //static void Display(long l)
        //{
        //    Console.WriteLine($"long: {l}");
        //}
    }
}