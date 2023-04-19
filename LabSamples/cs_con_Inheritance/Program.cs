namespace cs_con_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(10);
            Console.WriteLine($"emp: ID: {emp.EmployeeId}, Name: {emp.EmployeeName}");
            Console.WriteLine();

            // emp.EmployeeId = 50;
            emp.EmployeeName = "My Base Employee Object";
            Console.WriteLine($"emp: ID: {emp.EmployeeId}, Name: {emp.EmployeeName}");
            Console.WriteLine();

            ContractEmployee contractEmployee = new ContractEmployee(20, "My Contractor");
            Console.WriteLine($"contract emp: ID: {contractEmployee.EmployeeId}, Name: {contractEmployee.EmployeeName}");
            Console.WriteLine();

            contractEmployee.EmployeeName = contractEmployee.EmployeeName.ToUpper();
            Console.WriteLine($"contract emp: ID: {contractEmployee.EmployeeId}, Name: {contractEmployee.EmployeeName}");
            Console.WriteLine();
        }
    }
}