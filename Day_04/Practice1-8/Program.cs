namespace practical_1_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practical08();
        }
        static void Practical02() {
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = x; i > 0; i--) {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void Practical01() {
            int x = 10;
            int sum = 0;
            for (int i = x; i > 0; i--) { sum += i; }
            Console.WriteLine(sum);         
        }
        static void Practical03() {
            Console.Write("Enter a number :  ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++) Console.WriteLine($"{i} cubed is {Math.Pow(i,3)}");    
        }
        static void Practical04() {
            Console.Write("Enter a number :  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i++) {
                if (i % 2 == 1) { sum += i; }                                    
            }
            Console.WriteLine(sum);
        }
        static void Practical05() {
            Console.Write("Enter a number of rows of Floyd's triangle to be printed:  ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (j % 2 == 0) Console.Write("0  ");
                    else Console.Write("1  ");
                }
                Console.WriteLine("");
            }
        }
        static void Practical06() {
            Console.Write("Enter a number :  ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"divisors of {x} are : ");
            for (int i = 1; i < x; i++) {
                if (x % i == 0) { Console.Write($"  {i},"); }            
            }
        }
        static void Practical07() {
            Console.Write("Enter a number :  ");
            int x = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            Console.Write(first + "  ");
            Console.Write(second + "  ");
            for (int i = 0; i < x; i++) {
                int sum = first + second;
                Console.Write(sum + "  ");
                first = second;
                second = sum;
            }
        }
        static void Practical08() {
            Console.Write("Enter a number :  ");
            int x = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (x > 0) {
                if (x % 2 == 0) result = string.Concat("0", result);
                else result = string.Concat("1", result);
                x /= 2;
            }
            Console.Write(result);
        }
    }
}
