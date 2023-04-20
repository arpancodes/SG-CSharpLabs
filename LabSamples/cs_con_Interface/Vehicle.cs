using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal abstract class Vehicle
    {
        // public abstract string RegistrationNumber { get; }

        private string _registrationNumber;
        public string RegistrationNumber
        {
            get
            {
                return _registrationNumber;
            }
            protected set
            {
                _registrationNumber = value;
            }
        }

        abstract public void Drive();
    }
}
