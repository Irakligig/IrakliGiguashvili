namespace practicalstreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Geography now has started");
            Console.WriteLine("Choose one option: 1.Search Country 2.Search City ");

            int option = int.Parse(Console.ReadLine());           
            string path = "C:\\Users\\darkb\\Downloads\\Cities.txt";

            List<City> cities = Utils.TxtToCollectionCity(path);
            List<Country> countries = Utils.TxtToCollectionCountry(path);
            Console.WriteLine(1);
            if (option == 1)
            {
                
                Console.WriteLine("Enter County: ");
                string country = Console.ReadLine();
                Country x = countries.FirstOrDefault(c => c.Name == country);
                Console.WriteLine(x.toString());
            }
            else if (option == 2) 
            {
                Console.WriteLine("Enter Country");
                string city = Console.ReadLine();
                City y = cities.FirstOrDefault(c => c.Name.Equals(city, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine(y.ToString());            
                
            }




        }
    }
}
