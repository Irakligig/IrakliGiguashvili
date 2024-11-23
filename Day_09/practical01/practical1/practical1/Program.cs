using System.Runtime.CompilerServices;
using System.Transactions;

namespace practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating Cat object");

            Cat cat = new Cat();
            Console.Write("Enter name: ");
            cat.Name = Console.ReadLine();

            Console.Write("Enter breed: ");
            cat.Breed = Console.ReadLine();

            Console.Write("Enter age:");
            cat.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter if it is male");
            cat.IsMale = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Cat object created");
            Console.WriteLine("Enter food weight in grams: ");
            cat.eating(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter meowing count");
            int i = Convert.ToInt32(Console.ReadLine());
            while(i > 0)
            {
                cat.mewing();
                i--;
            }
        }
    }
}
