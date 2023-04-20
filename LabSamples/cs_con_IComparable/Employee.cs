using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Employee : System.IComparable
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public int CompareTo(object? obj)
        {
            return Id.CompareTo((obj as Employee)?.Id);
        }

        /***************************
        // RETURNS:
        //     Less than zero – This instance precedes obj in the sort order.
        //     Zero – This instance occurs in the same position in the sort order as obj.
        //     Greater than zero – This instance follows obj in the sort order.
        public int CompareTo(object? obj)
        {
            Employee? objOther = obj as Employee;
            // return objOther?.Id.CompareTo(this.Id) ?? 0;         // descending order on ID
            return this.Id.CompareTo(objOther?.Id);                 // ascending order on ID
        }
        *****************************/
    }
}
