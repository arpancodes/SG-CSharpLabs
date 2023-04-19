using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    public class Company
    {
        public string? CompanyName { get; set; }
        private int _counter;
        private System.Collections.Generic.List<Employee> _theEmployees;

        public Company()
        {
            _counter = 0;
            _theEmployees = new List<Employee>();
        }

        // INDEXER
        public Employee? this[int id]
        {
            get
            {
                Employee? empFound = null;

                for (int i = 0; i < _theEmployees.Count; i++)
                {
                    if (_theEmployees[i].Id == id)
                    {
                        empFound = _theEmployees[i];
                    }
                }
                return empFound;
            }
        }

        // INDEXER
        public Employee? this[string name]
        {
            get
            {
                Employee? empFound = null;

                for (int i = 0; i < _theEmployees.Count; i++)
                {
                    if (_theEmployees[i].EmployeeName == name)
                    {
                        empFound = _theEmployees[i];
                    }
                }
                return empFound;
            }
        }

        public Employee? GetEmployee(int id)
        {
            Employee? empFound = null;

            for(int i = 0; i < _theEmployees.Count; i++ )
            {
                if (_theEmployees[i].Id == id)
                {
                    empFound = _theEmployees[i];
                }
            }
            return empFound;
        }


        public void AddEmployee(string employeeName)
        {
            Employee newemployee = new Employee()
            {
                Id = ++_counter,
                EmployeeName = employeeName
            };
            _theEmployees.Add(newemployee);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"Employees of {this.CompanyName}");
            for(int i = 0; i < _theEmployees.Count; i++)
            {
                Employee emp = _theEmployees[i];
                Console.WriteLine($"{emp.Id} {emp.EmployeeName}");
            }
        }
    }
}
