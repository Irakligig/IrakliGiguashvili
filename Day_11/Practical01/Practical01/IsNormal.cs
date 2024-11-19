using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal interface IsNormal
    {
        int Pastowners { get; }
        int VehicleAge { get; }

        void Start();
        void Stop();

    }
}
