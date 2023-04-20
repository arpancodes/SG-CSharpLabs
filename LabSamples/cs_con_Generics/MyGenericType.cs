using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generics
{
    class MyGenericType<T>
    {
        public T? Value { get; set; }

        public void Display()
        {
            // Console.WriteLine($"{this.Value}");                  // Version 4
            // Console.WriteLine("{0}", this.Value);                // Version 3
            // Console.WriteLine(string.Format("{0}", this.Value)); // Version 2
            Console.WriteLine("{0}", this.Value?.ToString());       // Version 1
            Console.WriteLine();
        }
    }
}
