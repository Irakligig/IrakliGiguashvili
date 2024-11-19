using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal class Vehicle
    {
        public string Company_name { get; set; }
        public string Model_name { get; set; }
        public int Wheels { get; set; }
        public int Horsepower { get; set; }
        public string VIN { get; set; }
        public double Weight { get; set; }

        public Vehicle(string companyname, string modelname, int wheels, int horsepower, string vin, double weight)
        {
            Company_name = companyname;
            Model_name = modelname;
            Wheels = wheels;
            Horsepower = horsepower;
            VIN = vin;
            Weight = weight;

        }
        public virtual void driving()
        {
            Console.WriteLine("Vehicle is driving");
        }
        public static void CompareByWeight(Vehicle first , Vehicle second)
        {
            if (first.Weight > second.Weight)
            {
                Console.WriteLine("first car is heavier");
            }
            else if (first.Weight < second.Weight)
            {
                Console.WriteLine("second car is heavier");
            }
            else
            {
                Console.WriteLine("they have same weigth");
            }
        }
        public virtual void Honk()
        {
            Console.WriteLine("Vehicle honk");
        }
        public bool HasHighHorsepower()
        {
            return Horsepower > 300;
        }
    }
}
