using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerable
{
    internal class Company
        : System.Collections.IEnumerable
    {
        private List<Employee> employees = new List<Employee>();
        public string CompanyName { get; set; } = string.Empty;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("--- Employees of {0}", this.CompanyName);
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].Id} {employees[i].Name}");
            }
        }

        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            //for(int i = 0; i < employees.Count;i++)
            //{
            //    yield return employees[i];
            //}
            
            foreach(Employee emp in employees)
            {
                yield return emp;
            }
        }

        #endregion
    }
}
