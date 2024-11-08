namespace practical3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock saati = new Clock();
            Console.Write("Enter hours : ");
            saati.Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes : ");
            saati.Minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds : ");
            saati.Seconds = Convert.ToInt32(Console.ReadLine());
            saati.PlusSecond();
            saati.PlusSecond();
            saati.PlusSecond();
            saati.PlusSecond();
            saati.GetCurrentTime();
        }
    }
}
