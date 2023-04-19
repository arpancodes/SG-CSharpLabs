using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal class Scooter : IAutomobile
    {
        public void DriveScooter()
        {
            Console.WriteLine("Scooter is being driven");
        }

        public void Drive()
        {
            Console.WriteLine("Scooter is being driven");
        }
    }
}
