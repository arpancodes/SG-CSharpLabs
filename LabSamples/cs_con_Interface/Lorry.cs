using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal class Lorry : Vehicle
    {
        override public void Drive()
        {
            Console.WriteLine("Lorry is being driven");
        }
    }
}
