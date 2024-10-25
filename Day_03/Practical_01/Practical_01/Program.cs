namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input % 2) {
                case 0:
                    Console.WriteLine($"Entered number {input}  is even");
                    break;
                default:
                    Console.WriteLine($"Entered number {input} is odd");
                    break;                              
            }
        }
    }
}
