using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalstreams
{
    internal abstract class GeographicEntity
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public GeographicEntity(string name , double area , int population) 
        {
            Name = name;
            Area = area;
            Population = population;
        }
        public GeographicEntity(string name) 
        {
            Name = name;
        }


        
    }
}
