namespace Practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            secondfunction();



        }

        public static void firstfunction() {
            int c = 0;
            Console.WriteLine("select first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void secondfunction() {
            Console.WriteLine("select first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a ^ b; // we use property of xor, which means that a ^ a ^ b = b . with that we can swap effectively without using extra memory usage 
            b = a ^ b;  
            a = a ^ b;



            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
