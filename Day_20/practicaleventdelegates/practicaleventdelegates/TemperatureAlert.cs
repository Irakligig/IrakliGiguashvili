using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaleventdelegates
{
    internal class TemperatureAlert
    {
        public void CriticalTemperatureMessage(object x,int y)
        {
            Console.WriteLine($"Alert! Critical temperature detected: {y} Celsius");
        }
    }
}
