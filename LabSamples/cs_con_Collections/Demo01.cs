using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Collections
{
    /// <summary>
    ///     Demo of Array
    /// </summary>
    internal class Demo01
    {
        public void RunThis()
        {
            // 1 Dimension - Array of Rank 1

            int[] arr;                  // declaration
            arr = new int[5];           // instantiation
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            int[] arr2 = new int[5];
            arr2[0] = 100;
            arr2[1] = 200;
            arr2[2] = 300;
            arr2[3] = 400;
            arr2[4] = 500;
            Console.WriteLine(arr2.Length);

            int[] arr3 = new int[5] { 1000, 2000, 3000, 4000, 5000 };


            int[,] arr2d = new int[2, 3]
                { 
                    { 1, 2, 3 },
                    { 4, 5, 6}
                };
        }
    }
}
