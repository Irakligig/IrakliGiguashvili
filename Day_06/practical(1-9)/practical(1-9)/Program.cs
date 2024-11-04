using System.Transactions;

namespace practical_1_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practical07_3(Practical07_2(Practical07_1(),Practical07_1()));
        }
        static int Practical01(int[] array , int index) 
        {
            if (index >= array.Length - 1)
            {
                Console.WriteLine("invalid parameter");
                return -1;
            }
            int k = index;
            for (int i = 0; i < array.Length; i++) 
            {
                if (k == 0) return array[i];
                else
                {
                    k--;
                }
            }
            return -1;
        }
        static int Practical02(int[] array,int index) 
        {
            if (index >= array.Length - 1)
            {
                Console.WriteLine("invalid parameter");
                return -1;
            }
            int k = index;
            for (int i = 0; i < array.Length - 1; i++)  
            {
                if (k == 0)
                {
                    int sum = 0;
                    while (array[i] > 0)
                    {
                        sum += array[i] % 10;
                        array[i] /= 10;
                    }
                    return sum;
                }
                else
                {
                    k--;
                }
            }
            return -1;
        }
        static int[] Practical03_1() //  ამას ვიყენებთ სხვა ამოცანებშიც
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++) 
            {
                Console.Write($"Enter integer for index {i}:  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        static void Practical03_2(int[] array)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i = 0;i < array.Length;i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    
                }
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        static float Practical04(int[] array)
        {
            int sum = 0;
            foreach (var elem in array)
            {
                sum += elem;
            }
            return (float) sum / array.Length;
        }
        // func1 = int[] , index -> if exist (fact(int[index])) else error
 
        static int Factorial(int x)
        {
            if (x == 0) return 1;
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Practical05(int[] array,int number)
        {
            bool exists = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    Console.WriteLine(Factorial(array[i]));
                    exists = true;
                    break;
                }
            }
            if(!exists)
            {
                Console.WriteLine($"Number {number} was not found in the given array");
            }
        }
        static char[] Practical06_1()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter integer for index {i}:  ");
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            return array;
        }
        static int Practical06_2(char[] array , char x)
        {
            int amount = 0;
            foreach (char c in array)
            {
                if(c == x) amount++;
            }
            return amount;
        }
        static void Practical06_3(int x,char y)
        {
            Console.WriteLine($"{y} shegvxvda {x} - jer");
        }
        static int[,] Practical07_1()
        {
            Console.Write("Enter count of rows:  ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter count of columns:  ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] twodarray = new int[rows, columns];
            for(int i = 0;i < twodarray.GetLength(0); i++)
            {
                for(int j = 0;j < twodarray.GetLength(1); j++)
                {
                    Console.Write($"Enter integer for index {i},{j}");
                    twodarray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return twodarray;
        }
        static int[,] Practical07_2(int[,] array1 , int[,] array2)
        {
            int[,] summedarray = new int[array1.GetLength(0), array1.GetLength(1)];
            for (int i = 0; i < summedarray.GetLength(0); i++)
            {
                for (int j = 0; j < summedarray.GetLength(1); j++)
                {
                    summedarray[i, j] = array1[i,j] + array2[i,j];
                }
            }
            return summedarray;
        }
        static void Practical07_3(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static int PositiveNumber()
        {
            Console.Write("Enter a positive number");
            int x = Convert.ToInt32(Console.ReadLine);
            while (x < 0) 
            {
                Console.Write("Enter a positive number");
                x = Convert.ToInt32(Console.ReadLine); 
            }
            return x;
        }
        static void Practical08(int x)
        {
            int num = x;
            string numberstr = x.ToString();
            int length = numberstr.Length;
            for (int i = 0; i < length; i++)
            {
                int k = x % 10;
                Console.Write($"{k} * {Math.Pow(10, i)} +");
                x /= 10;
            }
        }
        static int Practical09(params int[] arr)
        {
            int product = 1;
            foreach (int i in arr)
            {
                product *= i;
            }
            return product;
        }
        
    }
}
