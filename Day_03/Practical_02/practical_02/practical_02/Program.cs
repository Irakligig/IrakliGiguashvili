namespace practical_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (x + y <= z || x + z <= y || y + z <= x) {
                case true:
                    Console.WriteLine("This shouldn't be a triangle");
                    break;
                
                default:

                    Console.WriteLine("This should be a triangle !");
                    break;                        
            
            }

        }
    }
}
