using System.Collections;
using System.Transactions;

namespace practical_1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string test1 = "({([])}";
            //Console.WriteLine(IsBalanced(test1));
            //double[] arr = {1.4,3.4,7.4 };
            //double min, max, average;
            //OutFunction(arr, out min ,out  max , out average);
            //(double min, double max, double average) tuple = TupleFunction(arr);
            List<Book> listofbooks = new List<Book>();
            listofbooks.Add(new Book("author1","book1",1995));
            listofbooks.Add(new Book("author2", "book2", 1990));
            listofbooks.Add(new Book("author3", "book3", 1970));
            listofbooks.Add(new Book("author4", "book4", 2015));
            listofbooks.Add(new Book("author5", "book5", 1700));
            foreach (Book book in listofbooks)
            {
                Console.WriteLine(book);
            }
            listofbooks.Sort();
            foreach (Book book in listofbooks)
            {
                Console.WriteLine(book);
            }
        }

    
    public static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length;i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[') 
                {
                    stack.Push(input[i]);
                }

                if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    if (stack.Count == 0) 
                    {
                        return false;
                    }

                    char lastelem = stack.Pop();
                    if (!ReturnsTrue(lastelem, input[i]))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public static bool ReturnsTrue(char one , char two)
        {
            if (one == '(' && two == ')' || one == '{' && two == '}' || one == '[' && two == ']') return true;
            else return false;
        }


        

        public static double CalculateDistance((double x, double y, double z) point1 , (double x, double y, double z) point2)
        {
            return Math.Sqrt(Math.Pow((point1.x - point2.x),2) + Math.Pow((point1.y - point2.y), 2) + Math.Pow((point1.z - point2.z), 2));
        }

        public static void OutFunction(double[] arr , out double min , out double max , out double average)
        {
            min = arr.Min();
            max = arr.Max();
            average = arr.Average();
            Console.WriteLine("finished");
        }

        public static (double min , double max , double average) TupleFunction(double[] arr)
        {
            return (arr.Min(), arr.Max(), arr.Average());
        }


    }
}
