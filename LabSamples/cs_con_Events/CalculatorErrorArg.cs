using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Events
{
    class CalculatorErrorArg : System.EventArgs
    {
        public string? ErrorMessage { get; set; }

        public System.Collections.Generic.Dictionary<string, int>? Data { get; set; }
    }

}
