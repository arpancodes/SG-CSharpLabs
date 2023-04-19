namespace cs_con_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company() {  CompanyName = "Microsoft" };

            objCompany.AddEmployee("First Employee");
            objCompany.AddEmployee("Second Employee");
            objCompany.AddEmployee("Third Employee");
            objCompany.AddEmployee("Fourth Employee");
            objCompany.AddEmployee("Fifth Employee");

            objCompany.DisplayEmployees();

            //int[] arr = new int[4];
            //Console.WriteLine(arr[2]);
            Console.WriteLine();

            Employee? empSearch;

            // empSearch = objCompany._theEmployees[2];
            // objCompany._theEmployees[2] = new Employee

            empSearch = objCompany.GetEmployee(2);
            if(empSearch == null)
            {
                Console.WriteLine("Employee with ID == 2 NOT found!");
            }
            else
            {
                Console.WriteLine("Employee with ID == 2 found!");
            }
            
            empSearch = objCompany[2];
            if (empSearch == null)
            {
                Console.WriteLine("Employee with ID == 2 NOT found!");
            }
            else
            {
                Console.WriteLine("Employee with ID == 2 found!");
            }

            empSearch = objCompany["Fourth Employee"];
            if (empSearch == null)
            {
                Console.WriteLine("Fourth Employee NOT found!");
            }
            else
            {
                Console.WriteLine("Fourth Employee found!");
            }


            Console.WriteLine($"ID: {objCompany[2]?.Id} Name: {objCompany[2]?.EmployeeName}");

        }
    }
}