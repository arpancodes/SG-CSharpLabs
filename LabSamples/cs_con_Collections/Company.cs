using System.Collections;

namespace cs_con_Collections.Demo
{
    class Company
    {
        public string CompanyName { get; set; } = string.Empty;
       
        private ArrayList? theEmployees { get; set; }

        public void AddEmployee(Employee emp)
        {
            if (theEmployees == null)
            {
                theEmployees = new ArrayList();
            }
            theEmployees.Add(emp);
        }

        public void DisplayEmployees()
        {
            for(int i = 0; i < theEmployees.Count; i++)
            {
                Employee? emp = theEmployees[i] as Employee;
                if(emp != null)
                {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.EmployeeName, emp.Age);
                }
            }
        }
    }
}

