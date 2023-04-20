using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerator
{
    internal class Company
        : System.Collections.IEnumerator
    {
        private List<Employee> employees = new List<Employee>();
        public string CompanyName { get; set; } = string.Empty;

        public Company()
        {
            this._currentPosition = -1;
        }


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

        #region System.Collections.IEnumerator members

        private int _currentPosition;

        public object Current
        {
            get
            {
                return employees[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (_currentPosition < employees.Count - 1)
            {
                _currentPosition++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentPosition = -1;    
        }

        #endregion

    }
}
