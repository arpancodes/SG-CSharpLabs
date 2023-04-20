using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfaceConcepts.Demo02
{
    class Demo
    {
        public virtual void m() { }
    }

    class AnotherDemo : Demo          // AnotherDemo "inherits" Demo
    {
        public virtual void n() { }
    }

    class RunThis : AnotherDemo        // RunThis "inherits" from AnotherDemo
    {
        public override void m() { }        // Demo.m()
        public override void n() { }        // AnotherDemo.m();
    }

}
