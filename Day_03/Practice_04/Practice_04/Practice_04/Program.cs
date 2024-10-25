namespace Practice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year: ");
            int date = Convert.ToInt32(Console.ReadLine());
            switch (date % 12) {
                case 0:
                    Console.WriteLine($"{date} was Monkey year");
                    break;
                case 1:
                    Console.WriteLine($"{date} was Rooster year");
                    break;
                case 2:
                    Console.WriteLine($"{date} was Dog year");
                    break;
                case 3:
                    Console.WriteLine($"{date} was Pig year");
                    break;
                case 4:
                    Console.WriteLine($"{date} was Rat year");
                    break;
                case 5:
                    Console.WriteLine($"{date} was Ox year");
                    break;
                case 6:
                    Console.WriteLine($"{date} was Tiger year");
                    break;
                case 7:
                    Console.WriteLine($"{date} was Hare year");
                    break;
                case 8:
                    Console.WriteLine($"{date} was Dragon year");
                    break;
                case 9:
                    Console.WriteLine($"{date} was Snake year");
                    break;
                case 10:
                    Console.WriteLine($"{date} was Horse year");
                    break;
                case 11:
                    Console.WriteLine($"{date} was Sheep year");
                    break;
            }
        }
    }
}
