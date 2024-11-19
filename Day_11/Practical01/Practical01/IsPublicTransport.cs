using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal interface IsPublicTransport
    {
        string RouteNumber { get; }
        int Capacity { get; }

        void StartRoute();
        void EndRoute();
    }
}
