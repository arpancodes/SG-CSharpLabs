using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfaceConcepts.Demo03
{
    interface IDemo
    {
        void m();
    }

    interface IAnotherDemo : IDemo          // IAnotherDemo "extends" IDemo
    {
        void n();
    }

    class Demo : IAnotherDemo               // Demo "implements" IAnotherDemo
    {
        public void m() { }

        public void n() { }
    }

}
