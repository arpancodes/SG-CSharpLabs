using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfaceConcepts.Demo04
{
    interface IDemo
    {
        void m();
    }

    interface IAnotherDemo : IDemo          // IAnotherDemo "extends" IDemo
    {
        void m();
        void n();
    }

    class Demo : IAnotherDemo               // Demo "implements" IAnotherDemo
    {
        // Implicit implementation of the IAnotherDemo.m() and IDemo.m()
        public void m() { }

        // Implicit Implementation of the IAnotherDemo.n()
        public void n() { }
    }

    class Demo2 : IAnotherDemo
    {
        // Explicit implementation of the IDemo.m() and IDemo.m()
        void IDemo.m() 
        {
            Console.WriteLine("Explicit implementation of IDemo.m() called");
        }

        // Explicit implementation of the IAnotherDemo.m() and IDemo.m()
        void IAnotherDemo.m() 
        {
            Console.WriteLine("Explicit implementation of IAnotherDemo.m() called");
        }

        public void m()
        {
            Console.WriteLine("Demo2's implementation of m() called");
        }

        // Implicit Implementation of the IAnotherDemo.n()
        public void n() 
        {
            Console.WriteLine("IMPLICIT implementation of IAnotherDemo.n() called");
        }

    }

}
