using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    /// <summary>
    ///     Version #2: Inheritance 
    /// </summary>
    internal class Driver2
    {
        
        public void Drive(Vehicle objVehicle)
        {
            Console.WriteLine("Driver is driving");
            objVehicle.Drive();
        }

    }
}
