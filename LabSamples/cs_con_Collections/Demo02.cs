using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Collections
{
    /// <summary>
    ///     Dynamically resizable Collection - ArrayList
    ///     NOTE: uses Boxing and UnBoxing
    /// </summary>
    internal class Demo02
    {
        public static void RunThis()
        {
            System.Collections.ArrayList alist = new System.Collections.ArrayList();

            alist.Add(10);                   // alist[0] = 10;
            alist.Add(20);                   // alist[1] = 20;       

            // alist[2] = 30, alist[3] = 40, alist[4] = 50
            alist.AddRange(new int[] { 30, 40, 50 });

            Console.WriteLine(alist.Count);

            int? x = (int?)alist[3];
            // if(x != null)
            // if( !(x is null) )
            if(x is not null)           
            {
                Console.WriteLine(x);
            }

            alist.Add("hello world");
            alist.Add(true);
        }
    }
}
