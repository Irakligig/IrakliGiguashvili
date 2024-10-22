namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isleapyear(year));
        }
        public static bool isleapyear(int year) {
            return (year % 4 == 0) && ((year % 10 != 0) || (year % 400 == 0));
        }
    }
}
