using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerator
{
    internal class Employee : System.IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        #region System.IComparable members

        public int CompareTo(object? obj)
        {
            return this.Name?.CompareTo((obj as Employee)?.Name) ?? 0;
        }

        #endregion

    }
}
