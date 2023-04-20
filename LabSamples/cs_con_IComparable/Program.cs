using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace cs_con_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];

            employees[0] = new Employee();
            employees[0].Id = 1;
            employees[0].Name = "First Employee";
            employees[0].Salary = 2000;

            employees[1] = new Employee() { Id = 4, Name = "Fourth Employee", Salary = 1500 };
            employees[2] = new Employee() { Id = 2, Name = "Second Employee", Salary = (decimal)5000.75 };
            employees[3] = new Employee() { Id = 5, Name = "Fifth Employee", Salary = 75 };
            employees[4] = new Employee() { Id = 3, Name = "Third Employee", Salary = 8000.95M };

            DisplayEmployes(employees);

            Array.Sort(employees);

            Console.WriteLine("--- After Sorting");
            DisplayEmployes(employees);
        }

        static void DisplayEmployes(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("{0} {1, -20} {2, 12:C}",
                    employees[i].Id, employees[i].Name, employees[i].Salary);
            }
            Console.WriteLine();
        }
    }
}