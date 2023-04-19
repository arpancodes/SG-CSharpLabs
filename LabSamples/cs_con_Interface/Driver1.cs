using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    /// <summary>
    ///     Version #1: Overloaded Version
    /// </summary>
    internal class Driver1
    {
        
        public void Drive(Car objCar)
        {
            Console.WriteLine("Driver is driving");
            objCar.DriveCar();
        }

        public void Drive(Scooter objScooter)
        {
            Console.WriteLine("Driver is driving");
            objScooter.DriveScooter();
        }

    }
}
