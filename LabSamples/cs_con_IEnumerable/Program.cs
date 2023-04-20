namespace cs_con_IEnumerable
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

            Console.WriteLine("----- Using IEnumerable interface");

            //objCompany.GetEnumerator().Reset();
            //while(objCompany.GetEnumerator().MoveNext())
            //{
            //    Employee? emp = objCompany.GetEnumerator().Current as Employee;
            //}

            foreach(Employee emp in objCompany)
            {
                Console.WriteLine($"{emp.Id} {emp.Name}");
            }

        }
    }
}