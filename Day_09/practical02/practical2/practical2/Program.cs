namespace practical2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle samkutxedi = new Triangle();
            Console.Write("Enter side 1: ");
            samkutxedi.A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 2: ");
            samkutxedi.B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 3: ");
            samkutxedi.C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perimeter of the triangle is: ");
            samkutxedi.Perimeter();
            Console.WriteLine("Area of the triangle is: ");
            samkutxedi.Area();

        }
    }
}