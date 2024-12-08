using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalstreams
{
    internal static class Utils
    {
        public static List<City> TxtToCollectionCity(string path)
        {
            var list = new List<City>();
            using (var reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] attributes = line.Split('|');

                    if (attributes.Length < 5)
                    {
                        // Skip this line or handle it as needed 
                        line = reader.ReadLine();
                        continue;
                    }

                    string name = attributes[0].Trim();

                    double area;
                    bool areacheck = double.TryParse(attributes[1], out area);//if true , gives value to 
                    area = areacheck ? area : 0.0; // if false , sets value to 0.0

                    int population;
                    bool populationcheck = int.TryParse(attributes[2], out population);
                    population = populationcheck ? population : 0;

                    bool iscapital;
                    bool iscapitalcheck = bool.TryParse(attributes[3], out iscapital);
                    iscapital = iscapitalcheck ? iscapital : false;

                    string countryname = attributes[4].Trim();

                    City city = new City(name , area , population , iscapital,countryname);
                    list.Add(city);
                    
                    line = reader.ReadLine();
                }
            }
            return list;
        }

        public static List<Country> TxtToCollectionCountry(string path)
        {
            
            Dictionary<string , List<City>> dict = new Dictionary<string , List<City>>();

            using (var reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] values = line.Split('|');
                    if (values.Length == 5)
                    {
                        string name = values[0].Trim();

                        double area;
                        bool isarea = double.TryParse(values[1], out area);
                        area = isarea ? area : 0.0;

                        int population;
                        bool populationcheck = int.TryParse(values[2], out population);
                        population = populationcheck ? population : 0;

                        bool iscapital;
                        bool iscapitalcheck = bool.TryParse(values[3], out iscapital);
                        iscapital = iscapitalcheck ? iscapital : false;

                        string countryname = values[4].Trim();

                        City city = new City(name, area, population, iscapital, countryname);

                        if (!dict.ContainsKey(countryname))
                        {
                            dict.Add(countryname, new List<City>());
                        }
                        dict[countryname].Add(city);
                        
                    }
                    line = reader.ReadLine();
                }
            }
            List<Country> country = new List<Country>();
            foreach (var entry in dict)
            {
                country.Add(new Country(entry.Key , entry.Value));
            }

            return country;
        }
    }
}
