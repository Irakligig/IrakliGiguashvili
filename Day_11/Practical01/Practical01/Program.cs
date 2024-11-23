namespace Practical01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Armored cars like tanks ,btr etc.");
            Console.WriteLine("2. public transport like bus , van");
            Console.WriteLine("3. Normal transport like suv, sedan , motorcycle" );
            Console.Write("Choose vehicle type: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter everything to create an object");
                    //string companyname, string modelname, int wheels, int horsepower, string vin, double weight , string armortyp
                    Console.Write("enter companyname: ");
                    string companyname = Console.ReadLine();
                    Console.Write("enter modelname");
                    string modelname = Console.ReadLine();
                    Console.Write("enter wheels: ");
                    int wheels = int.Parse(Console.ReadLine()); 
                    Console.Write("enter horsepower: ");
                    int horsepower = int.Parse(Console.ReadLine());
                    Console.Write("enter vin: ");
                    string vin = Console.ReadLine();
                    Console.Write("enter weight: ");
                    double weight = (double) int.Parse(Console.ReadLine());    
                    Console.Write("enter armortype: ");
                    string armortyp = Console.ReadLine();
                    Vehicle armoredvehicle = new ArmoredCar(companyname , modelname, wheels, horsepower , vin, weight, armortyp);

                    Console.WriteLine($"your car is {armoredvehicle.ToString()}");

                    break;
                case 2:
                    Console.WriteLine("enter everything to create an object");
                    //string companyname, string modelname, int wheels, int horsepower, string vin, double weight , string routenumber , int capacity
                    Console.Write("enter companyname: ");
                    companyname = Console.ReadLine();
                    Console.Write("enter modelname: ");
                    modelname = Console.ReadLine();
                    Console.Write("enter wheels: ");
                    wheels = int.Parse(Console.ReadLine());
                    Console.Write("enter horsepower: ");
                    horsepower = int.Parse(Console.ReadLine());
                    Console.Write("enter vin: ");
                    vin = Console.ReadLine();
                    Console.Write("enter weight: ");
                    weight = (double)int.Parse(Console.ReadLine());
                    Console.Write("enter routenumber: ");
                    string routenumber = Console.ReadLine();
                    Console.Write("enter capacity: ");
                    int capacity = int.Parse(Console.ReadLine());
                    Vehicle publictransport = new Publictransport(companyname, modelname, wheels, horsepower, vin, weight, routenumber , capacity);

                    Console.WriteLine($"your car is {publictransport.ToString()}");
                    break;
                case 3:
                    Console.WriteLine("enter everything to create an object");
                    // string companyname, string modelname, int wheels, int horsepower, string vin, double weight, int pastowners, int vehicleage
                    Console.Write("enter companyname: ");
                    companyname = Console.ReadLine();
                    Console.Write("enter modelname: ");
                    modelname = Console.ReadLine();
                    Console.Write("enter wheels: ");
                    wheels = int.Parse(Console.ReadLine());
                    Console.Write("enter horsepower: ");
                    horsepower = int.Parse(Console.ReadLine());
                    Console.Write("enter vin: ");
                    vin = Console.ReadLine();
                    Console.Write("enter weight: ");
                    weight = (double)int.Parse(Console.ReadLine());
                    Console.Write("enter amount of past owners: ");
                    int pastowners = int.Parse(Console.ReadLine());
                    Console.Write("enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Vehicle normal = new Normal(companyname, modelname, wheels, horsepower, vin, weight, pastowners , age);

                    Console.WriteLine($"your car is {normal.ToString()}");
                    break;
            }
            
            

        }
    }
}
