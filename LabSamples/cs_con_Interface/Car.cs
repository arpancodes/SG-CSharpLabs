using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal class Car : Vehicle, IAutomobile
    {
        public Car(string regNo)
        {
            base.RegistrationNumber = regNo;
        }

        public override void Drive()
        {
            Console.WriteLine("Car is being driven");
        }

        public void DriveCar()
        {
            Console.WriteLine("Car is being driven");
        }
    }
}
