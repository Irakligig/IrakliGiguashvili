namespace Practice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day_of_birth_of_birth of birth: ");
            int day_of_birth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter you month_of_birth_of_birth of birth: ");
            String month_of_birth = (Console.ReadLine());
            if (month_of_birth == "march" && day_of_birth >= 21 || month_of_birth == "april" && day_of_birth <= 19) Console.WriteLine($"{day_of_birth} {month_of_birth} is Aries") ;
            if (month_of_birth == "april" && day_of_birth >= 20 || month_of_birth == "may" && day_of_birth <= 20) Console.WriteLine($"{day_of_birth} {month_of_birth} is Taurus") ;
            if (month_of_birth == "may" && day_of_birth >= 21 || month_of_birth == "june" && day_of_birth <= 20) Console.WriteLine($"{day_of_birth} {month_of_birth} is Gemini") ;
            if (month_of_birth == "june" && day_of_birth >= 21 || month_of_birth == "july" && day_of_birth <= 22) Console.WriteLine($"{day_of_birth} {month_of_birth} is Cancer") ;
            if (month_of_birth == "july" && day_of_birth >= 23 || month_of_birth == "august" && day_of_birth <= 22) Console.WriteLine($"{day_of_birth} {month_of_birth} is Leo") ;
            if (month_of_birth == "august" && day_of_birth >= 23 || month_of_birth == "september" && day_of_birth <= 22) Console.WriteLine($"{day_of_birth} {month_of_birth} is Virgo") ;
            if (month_of_birth == "september" && day_of_birth >= 23 || month_of_birth == "october" && day_of_birth <= 22) Console.WriteLine($"{day_of_birth} {month_of_birth} is Libra") ;
            if (month_of_birth == "october" && day_of_birth >= 23 || month_of_birth == "november" && day_of_birth <= 21) Console.WriteLine($"{day_of_birth} {month_of_birth} is Scorpio") ;
            if (month_of_birth == "november" && day_of_birth >= 22 || month_of_birth == "december" && day_of_birth <= 21) Console.WriteLine($"{day_of_birth} {month_of_birth} is Sagittarius") ;
            if (month_of_birth == "december" && day_of_birth >= 22 || month_of_birth == "january" && day_of_birth <= 19) Console.WriteLine($"{day_of_birth} {month_of_birth} is Capricorn") ;
            if (month_of_birth == "january" && day_of_birth >= 20 || month_of_birth == "february" && day_of_birth <= 18) Console.WriteLine($"{day_of_birth} {month_of_birth} is Aquarius") ;
            if (month_of_birth == "february" && day_of_birth >= 19 || month_of_birth == "march" && day_of_birth <= 20) Console.WriteLine($"{day_of_birth} {month_of_birth} is Pisces");

        }
    }
}
