using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_CS3Concepts
{
    /// <summary>
    ///     Anonymous Types
    /// </summary>
    internal class Demo02
    {
        public static void RunThis()
        {
            // ----- Type is known during Compile Time
            //       Because the Type is declared by the Developer

            // Object Declaration, Instantion, Initialization
            Employee emp = new Employee() { Id = 1, Name = "First Employee" };
            Console.WriteLine("Type : {0}", emp.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp.Id, emp.Name);
            Console.WriteLine();

            // Object Declaration, Instantion, Initialization
            Employee empX = new Employee() { Name = "First Employee", Id = 100};
            Console.WriteLine("expX Type : {0}", empX.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", empX.Id, empX.Name);
            Console.WriteLine();

            // Type Inference
            var emp2 = new Employee() { Id = 2, Name = "Second Employee" };
            Console.WriteLine("Type : {0}", emp2.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp2.Id, emp2.Name);
            Console.WriteLine();

            // ----- ANONYMOUS Type is known during Compile Time
            //       Because the Type is INFERRED DURING INITIALIZATION
            //       And injected into the Assembly by the Language Compiler
            // 1. Anonymous Types are defined by the Language Compiler during Compile Time
            // 2. All Properties are READONLY
            // 3. All Properties are POSITIONAL. Change in position, changes definition.
            // 4. All Properties are identified by the Name.  Change in Name, changes definition.


            // Anonymous Type - inferred DURING INSTANTIATION.
            var emp3 = new { Id = 3, Name = "Third Employee" };
            // emp3.Id++;
            Console.WriteLine("Type : {0}", emp3.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp3.Id, emp3.Name);
            Console.WriteLine();

            var emp4 = new { Id = 4, Name = "Fourth Employee" };
            Console.WriteLine("Type : {0}", emp4.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp4.Id, emp4.Name);
            Console.WriteLine();

            var emp5 = new { Name = "Fifth Employee", Id = 5 };
            Console.WriteLine("Type : {0}", emp5.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp5.Id, emp5.Name);
            Console.WriteLine();

            var emp6 = new { ObjId = 4, Name = "Fourth Employee" };
            Console.WriteLine("Type : {0}", emp6.GetType());
            Console.WriteLine("ID: {0}, Name: {1}", emp6.ObjId, emp6.Name);
            Console.WriteLine();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
    }
}
