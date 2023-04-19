using System;

namespace cs_con_HelloWorld
{
    internal class Program
    {
        /// <summary>
        ///     The main method of the program
        /// </summary>
        /// <seealso cref="Program.GetName" />
        /// <seealso cref="Program.DisplayName(string?)"/>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string? name = GetName();

            DisplayName(name);

            Console.WriteLine();
            Console.WriteLine("name = {2}, a = {0}, b = {1}, ", 10, 20, "Microsoft");
            Console.WriteLine("name = {2, 20}, a = {0}, b = {1}", 10, 20, "Microsoft");
            Console.WriteLine("name = {2, -20}, a = {0}, b = {1}", 10, 20, "Microsoft");

            Console.WriteLine("name = {0,-15}, amount = {1,12:C}", "Ram", 2024.47);
            Console.WriteLine("name = {0,-15}, amount = {1,12:C}", "Mohan", 2.70);
            Console.WriteLine("name = {0,-15}, amount = {1,12:C}", "Hema", 5);

            System.DateTime dt = System.DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToString("dd-MMM-yyyy hh:mm:ss tt"));
            Console.WriteLine("{0:dd-MMM-yyyy}", dt);       // internally calls string.Format()
            // Console.WriteLine( string.Format("{0:dd-MMM-yyyy}", dt) );       
            Console.WriteLine($"{dt:dd-MMM-yyyy}");

            string output = string.Format("{0:dd-MMM-yyyy}", dt);
            Console.WriteLine(output);
            output = $"{dt:dd-MMM-yyyy}";
            Console.WriteLine(output);


            Console.WriteLine("age = {0}", GetAge());
        }

        /// <summary>
        ///     Displays the name of the user with a greeting
        /// </summary>
        /// <param name="name">Name of the user</param>
        /// <example>
        ///     DisplayName("Microsoft");
        /// </example>
        private static void DisplayName(string? name)
        {
            System.Console.WriteLine("Hi " + name + "!");
            System.Console.WriteLine("Hi {0}!", name);
            System.Console.WriteLine($"Hi {name}!");   // string interpolation - C# 5.0
            // Console.WriteLine($"Hi {name != null ? name.ToUpper() : ""}!");
            Console.WriteLine($"Hi {name?.ToUpper()}!");        // null-colasce operator
        }

        /// <summary>
        ///     Get the name of the User
        /// </summary>
        /// <returns>the name of the user provided by the console</returns>
        private static string? GetName()
        {
            Console.Write("Please enter your name: ");
            string? name = Console.ReadLine();

            DisplayName(name);

            return name;
        }

        private static int GetAge()
        {
            int age = 0;            // default value to the age is assumed "0" 
            Console.WriteLine("Enter your age:");
            string? ageString = Console.ReadLine();
            // if (ageString != null && ageString != "") { }
            if(! string.IsNullOrEmpty(ageString) )          // if (ageString != null)
            {
                age = int.Parse(ageString);
            }

            Console.WriteLine("Enter your age again:");
            int.TryParse(Console.ReadLine(), out age);

            return age;
        }
    }
}