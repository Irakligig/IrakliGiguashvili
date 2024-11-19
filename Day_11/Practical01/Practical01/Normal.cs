using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal class Normal : Vehicle, IsNormal
    {
        public Normal(string companyname, string modelname, int wheels, int horsepower, string vin, double weight , int pastowners , int vehicleage) : base(companyname, modelname, wheels, horsepower, vin, weight)
        {
            Pastowners = pastowners;
            VehicleAge = vehicleage;
        }

        public int Pastowners { get; private set; }

        public int VehicleAge { get; private set; }

        

        public void Start()
        {
            Console.WriteLine("Normal vehicle started");
        }

        public void Stop()
        {
            Console.WriteLine("Normal vehicle stoped");
        }
        public override string ToString()
        {
            return $"name : {Company_name} , modelname : {Model_name} , wheels : {Wheels} , horsepower : {Horsepower} , vin : {VIN} , weigth : {Weight} , pastowners : {Pastowners} , vehicleage : {VehicleAge}";

        }
    }
}
