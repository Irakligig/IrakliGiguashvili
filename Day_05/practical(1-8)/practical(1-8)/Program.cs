using System.ComponentModel.Design;
using System.Numerics;

namespace practical_1_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practical08JachedArray();
        }
        static void Practical01() {
            Console.Write("Enter array size:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            for (int i = 0; i < x; i++) {
                Console.Write($"Enter number for index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());                        
            }
            foreach (var elem in array) {
                Console.WriteLine(elem);            
            }
        }
        static void Practical02() {
            Console.Write("Enter array size:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            int j = 0;
            for (int i = x-1; i >= 0; i--)
            {
                Console.Write($"Enter number for index {j}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                j++;
            }
            foreach (var elem in array)
            {
                Console.WriteLine(elem);
            }
        }
        static void Practical03() {
            Console.Write("Enter array size:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"Enter number for index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());            
            }
            foreach (var elem in array) {
                sum += elem;            
            }
            Console.WriteLine(sum);
        }
        static void Practical04() {
            Console.Write("Enter array size:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var elem in array)
            {
                product *= elem;
            }
            Console.WriteLine(product);
        }
        static void Practical05()
        {
            Console.Write("Enter array size:  ");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            bool exists = false;
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"Enter number for index {i}:  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < array.Length;i++) {
                exists = false;
                for (int j = 0; j < array.Length;j++) {
                    if (i == j) continue;
                    else if (array[i] == array[j]) { exists = true; break; }
                    else { continue;}

                }
                if (!exists) { Console.Write(array[i] + " "); }
            }
        }
        static void Practical06() {
            Console.Write("Enter n number of rows");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n number of columns");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Enter number for index {i} , {j}");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }                
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " , ");
                }
                Console.WriteLine("");
            }
        }
        static void Practical07() {
            Console.Write("Enter n number of rows");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n number of columns");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill first matrix");
            int[,] matrix1 = new int[x, y];
            int[,] matrix2 = new int[x, y];
            int[,] matrix3 = new int[x, y];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write($"Enter number for index {i} , {j}");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Fill second matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++) {
                for (int j = 0; j < matrix2.GetLength(1); j++) {
                    Console.Write($"Enter number for index {i} , {j}");
                    matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write(matrix3[i,j] + ",  ");
                }
                Console.WriteLine("");
            }
        }
        static void Practical08()
        {
            int[,] matrix1 =  {{0,1,1,1,1,1,1,1},
                              {0,0,1,1,1,1,1,1},
                              {0,0,0,1,1,1,1,1},
                              {0,0,0,0,1,1,1,1},
                              {0,0,0,0,0,1,1,1},
                              {0,0,0,0,0,0,1,1},
                              {0,0,0,0,0,0,0,1},
                              {0,0,0,0,0,0,0,0}};
            int[,] matrix2 = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
            int k = matrix1.GetLength(0) - 1;
            for (int i = 0;i < matrix2.GetLength(0);i++) {
                for (int j = 0; j < matrix2.GetLength(1); j++) // k = 6,i = 1,j = 0
                {
                    matrix2[k, j] = matrix1[i, j];   
                }
                k--;
            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static void Practical08JachedArray() {
            int[][] jaggedarray = {new int[] {0,1,1,1,1,1,1,1},
                               new int[] {0,0,1,1,1,1,1,1},
                              new int[]{0,0,0,1,1,1,1,1},
                              new int[]{0,0,0,0,1,1,1,1},
                              new int[]{0,0,0,0,0,1,1,1},
                              new int[]{0,0,0,0,0,0,1,1},
                              new int[]{0,0,0,0,0,0,0,1},
                              new int[]{0,0,0,0,0,0,0,0} } ;
            int[][] jaggedarray2 = new int[jaggedarray.Length][];
            for (int i = 0; i < jaggedarray.Length; i++) {
                jaggedarray2[i] = new int[jaggedarray[i].Length];
            }
            int k = jaggedarray.Length - 1;
            for (int i = 0;i < jaggedarray2.Length ;i++) { // 7 , 1,0
                for (int j = 0;j < jaggedarray2[i].Length;j++) {
                    jaggedarray2[k][j] = jaggedarray[i][j]; 
                }
                k--;
            }
            for (int i = 0; i < jaggedarray2.Length; i++)
            {
                for (int j = 0; j < jaggedarray2[i].Length; j++)
                {
                    Console.Write(jaggedarray2[i][j]);
                }
                Console.WriteLine("");
            }


        }
    }
}
