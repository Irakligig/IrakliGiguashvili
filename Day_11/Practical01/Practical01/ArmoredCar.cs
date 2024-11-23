using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
    internal class ArmoredCar : Vehicle , IsArmor
    {
        public string ArmorType { get; set; }
        public ArmoredCar(string companyname, string modelname, int wheels, int horsepower, string vin, double weight , string armortype) : base(companyname, modelname, wheels, horsepower, vin, weight)
        {
            ArmorType = armortype;
        }

        public static void ShootButStatic(IsArmor x)
        {
            Console.WriteLine("Shoots , but statically");
        }

        public void Shoot()
        {
            Console.WriteLine("shoots normally");
        }
        public override void driving()
        {
            Console.WriteLine("Armored - vehicle is driving");
        }
        public virtual void honk()
        {
            Console.WriteLine("armored car honks");
        }
        public override string ToString()
        {
            return $"name : {Company_name} , modelname : {Model_name} , wheels : {Wheels} , horsepower : {Horsepower} , vin : {VIN} , weigth : {Weight} , armortype : {ArmorType}";
        }
    }
}
