using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace practicalstreams
{
    internal class City : GeographicEntity
    {
        public bool IsCapital { get; set; }
        public string CountryName { get; set; }

        public City(string name , double area , int population , bool iscapital , string countryname) 
            : base(name,area,population)
        {
            IsCapital = iscapital;
            CountryName = countryname;
        }
        public override string ToString() 
        {
            return $"name : {Name} ,Area : {Area} , Population : {Population} , iscapital : {IsCapital}";
            
        }
    }
}
