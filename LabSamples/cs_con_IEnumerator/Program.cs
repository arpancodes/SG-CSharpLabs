namespace cs_con_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company() { CompanyName = "Microsoft" };

            objCompany.AddEmployee(new Employee() { Id = 10, Name = "First Employee" });
            objCompany.AddEmployee(new Employee() { Id = 20, Name = "Second Employee" });
            objCompany.AddEmployee(new Employee() { Id = 30, Name = "Third Employee" });
            objCompany.AddEmployee(new Employee() { Id = 40, Name = "Fourth Employee" });
            objCompany.AddEmployee(new Employee() { Id = 50, Name = "Fifth Employee" });

            objCompany.DisplayEmployees();
            Console.WriteLine();

            Console.WriteLine("----- Using IEnumerator interface");

            // objCompany.Reset();
            while (objCompany.MoveNext())
            {
                Employee? emp = objCompany.Current as Employee;
                Console.WriteLine($"{emp?.Id} {emp?.Name}");
            }
        }
    }
}