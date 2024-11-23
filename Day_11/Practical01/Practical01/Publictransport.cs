using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal class Publictransport : Vehicle, IsPublicTransport
    {
        public Publictransport(string companyname, string modelname, int wheels, int horsepower, string vin, double weight , string routenumber , int capacity) : base(companyname, modelname, wheels, horsepower, vin, weight)
        {
            RouteNumber = routenumber;
            Capacity = capacity;
        }

        public string RouteNumber { get; private set; }

        public int Capacity { get; private set; }

        public void EndRoute()
        {
            Console.WriteLine("endroute");
        }

        public void StartRoute()
        {
            Console.WriteLine("startroute");
        }
        public override string ToString()
        {
            return $"name : {Company_name} , modelname : {Model_name} , wheels : {Wheels} , horsepower : {Horsepower} , vin : {VIN} , weigth : {Weight} , routenumber : {RouteNumber} , capacity : {Capacity}";

        }
    }
}
