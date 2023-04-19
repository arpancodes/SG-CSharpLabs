namespace cs_con_ClassVsStruct
{
    internal class Program
    {

        /// <remarks>
        ///     ValuesTypes 
        ///         1. Implicit instantiation
        ///         2. Default Constructor is ALWAYS ADDED ONLY BY THE LANGUAGE COMPILER
        ///     ReferenceTypes
        ///         1. Explicit Instantiation
        ///         2. Default Constructor is ALWAYS ADDED BY THE LANGUAGE COMPILER
        ///            ONLY WHEN DEVELOPER DOES NOT DEFINE ANY INSTANCE CONSTRUCTOR
        /// </remarks>
        static void Main(string[] args)
        {
            // Value Types

            int i;                  // Declaration & Instantiation (implicit)
            i = 10;                 // Initialization
            Console.WriteLine($"i = {i}");

            MyStruct objStruct;     // Declaration & Instantiation
            objStruct.Greeting = "hello world";
            Console.WriteLine($"objStruct = {objStruct}");
            Console.WriteLine($"Greeting = {objStruct.Greeting}");
            Console.WriteLine();

            // Reference Types

            MyClass objClass;               // Declaration
            objClass = new MyClass();       // Instantiation (explicit) using Default Constructor
            Console.WriteLine($"Greeting on Creating object = {objClass.Greeting}");
            Console.WriteLine();

            objClass.Greeting = "Another World";
            Console.WriteLine($"objClass = {objClass}");
            Console.WriteLine($"Greeting = {objClass.Greeting}");
            Console.WriteLine();

            // Instantiation (explicit) using Parameterized Constructor
            objClass = new MyClass("Different World");
            Console.WriteLine($"Greeting = {objClass.Greeting}, ID: {objClass.ID}");
            Console.WriteLine();
        }
    }
}