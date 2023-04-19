using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Inheritance
{
    internal class ContractEmployee 
        : Employee
    {
        public ContractEmployee(int id, string name)
            : base(id)
        {
            base.EmployeeName = name;            // SAME AS: EmployeeName = name;
            this.ContractName = string.Empty;    // SAME AS: ContractName = string.Empty;
            Console.WriteLine("Derived Object instantiated successfully!");
        }

        new public String? EmployeeName
        {
            get
            {
                return base.EmployeeName.ToUpper();
            }
            set
            {
                if(value?.Length > 5)
                {
                    base.EmployeeName = value;
                }
            }
        }

        public string ContractName { get; set; }

        public decimal ContractPrice {
            get; 
            set;
        }
    }
}
