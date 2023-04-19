using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Inheritance
{
    internal class Employee
    {
        private int _counter;                        // DataField

        private int _EmployeeId;                    // Backing DataField
        public int EmployeeId                       // Property
        {
            get
            {
                return _EmployeeId;
            }
            private set                             // ACCESS MODIFIER to the PROPERTY ACCESSOR
            {
                {
                    // 1. 2. 3. 4. 5.
                    if (value > 0)
                    {
                        _EmployeeId = value;
                    }
                }
            }
        }

        //private string _EmployeeName;
        //public string EmployeeName
        //{
        //    get
        //    {
        //        return _EmployeeName;
        //    }
        //    set
        //    {
        //        _EmployeeName = value;
        //    }
        //}
        public string EmployeeName { get; set; } = string.Empty;     // Auto-Implemented Property

        public Employee(int id)
        {
            this.EmployeeId = id;           // SET ACCESSOR is called

            // <--- achieved by setting the Initialization Value in the Auto-Implemented Property
            // this.EmployeeName = string.Empty;  

            Console.WriteLine("base object instantiated sucessfully");

        }
    }
}
