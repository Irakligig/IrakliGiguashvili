namespace Practical_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(x,2));
        }
    }
}
