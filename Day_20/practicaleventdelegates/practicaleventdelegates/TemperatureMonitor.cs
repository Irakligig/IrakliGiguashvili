using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace practicaleventdelegates
{
    internal class TemperatureMonitor
    {
        //public delegate idk
        public event EventHandler<int> TemperatureChanged;

        public void CheckTemperature(int temp)
        {
            if (temp > 40 || temp < 0)
            {
                OnTemperatureChanged(temp);
            }
        }

        protected virtual void OnTemperatureChanged(int temp)
        {
            if (TemperatureChanged != null)
            {
                TemperatureChanged.Invoke(this,temp);
            }
        }

    }
}
