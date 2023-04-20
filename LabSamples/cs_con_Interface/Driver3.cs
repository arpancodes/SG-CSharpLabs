using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal class Driver3
    {
        public void Drive(IAutomobile objVehicle)
        {
            Console.WriteLine("Driver is driving");
            objVehicle.Drive();
            Console.WriteLine("Registration Number: {0}", objVehicle.RegistrationNumber);
        }

    }
}
