using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalstreams
{
    internal class Country : GeographicEntity
    {
        public List<City> Cities { get; set; }

        public Country(string name, List<City> cities)
            : base(name)
        {
            Cities = cities;
            Area = TotalArea(Cities);
            Population = TotalPop(Cities);
        }
        public double TotalArea(List<City> Cities)
        {
            double area = 0;
            foreach (City city in Cities)
            {
                area += city.Area;
            }
            return area;
        }

        public int TotalPop(List<City> Cities)
        {
            int pop = 0;
            foreach (City city in Cities)
            {
                pop += city.Population;
            }
            return pop;
        }
        public void toString()
        {
            string x = $"name : {Name} , Area : {Area} , Population : {Population} , Cities : {Cities}";
            Console.WriteLine(x);
            foreach (City city in Cities) 
            {
                Console.WriteLine(city.ToString());
            }
        }
    }
}
