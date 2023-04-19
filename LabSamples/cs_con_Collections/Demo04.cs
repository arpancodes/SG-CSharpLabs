using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace cs_con_Collections
//{
//    namespace Demo
//    {
//        class Demo04
//        {

//        }
//    }
//}

// Sub-Namespace
namespace cs_con_Collections.Demo
{

    class Demo04
    {
        public static void RunThis()
        {

            Company objCompany = new Company();         // Declaration, Instantiation
            objCompany.CompanyName = "Microsoft";       // Initialization

            Employee objEmp1 = new Employee();          // Declaration, Instantiation
            objEmp1.Id = 1;                             // Initialization
            objEmp1.EmployeeName = "First Employee";    // Initialization
            objEmp1.Age = 30;                           // Initialization

            // Declaration, Instantiation, OBJECT INITIALIZATION
            Employee objEmp2 = new Employee()
            {
                Id = 2,
                EmployeeName = "Second Employee",
                Age = 50
            };

            // COLLECTION INTIALIZATION
            int[] arr = new int[4] { 1, 2, 3, 4 };


            objCompany.AddEmployee(objEmp1);
            objCompany.AddEmployee(objEmp2);
            objCompany.AddEmployee(
                new Employee()
                {
                    Id = 3, 
                    EmployeeName = "Third Employee",
                    Age = 27
                });
            objCompany.AddEmployee(new Employee() { Id = 4, EmployeeName = "Fourth Guy", Age = 19 });

            objCompany.DisplayEmployees();
        }
    }
}

