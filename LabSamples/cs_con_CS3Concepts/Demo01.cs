using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_CS3Concepts
{
    internal class Demo01
    {
        // Demo of Type Inference
        public static void RunThis()
        {
            int i = 10;
            Console.WriteLine("int i => {0} : {1}", i.GetType(), i);

            string s = "10";
            Console.WriteLine("string s => {0} : {1}", s.GetType(), s);


            object o1 = i;
            Console.WriteLine("object o1 => {0} : {1}", o1.GetType(), o1);      // System.Int32
            o1 = s;
            Console.WriteLine("object o1 => {0} : {1}", o1.GetType(), o1);      // 


            // object o2 = s;
            // Console.WriteLine("object o2 => {0} : {1}", o2.GetType(), o2);


            // Type Inference
            var v1 = i;
            // v1 = s;          // compiler error

            object x;
            // var v2;     // expects an initialization

        }

    }
}
