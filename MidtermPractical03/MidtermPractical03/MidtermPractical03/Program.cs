namespace MidtermPractical03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] x = CreateTable();
            Console.WriteLine("its first players turn");
            Console.WriteLine("insert X or O ");
            char x = Console.ReadLine();
            Console.WriteLine("insert row");
            int row = Convert.ToInt32(Console);
            Console.WriteLine("insert column");
            int column = Convert.ToInt32(Console);





        }
        static char[,] CreateTable()
        {
            Console.Write("Enter rows: ");
            int x = Convert.ToInt32(Console.ReadLine());
            char[,] table = new char[x, x];
            for(int i = 0; i < table.GetLength();
            return table;
        }
        static bool CheckIfhorizontalWin(char[,] table)
        {
            bool haswon = true;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                char firstelem = table[i, 0];
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (firstelem == table[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        haswon = false;
                        break;
                    }
                }
                if (haswon)
                {
                    return true;
                }
            }
            return false;
        }
        static bool CheckIfverticalWin(char[,] table)
        {
            bool haswon = true;
            for (int i = 0; i < table.GetLength(1); i++)
            {
                char firstelem = table[0, i];
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    if (firstelem == table[j, i])
                    {
                        continue;
                    }
                    else
                    {
                        haswon = false;
                        break;
                    }
                }
                if (haswon)
                {
                    return true;
                }
            }
            return false;
        }
        static bool checkdiagonal(char[,] table)
        {
            char firstelem = table[0, 0];
            int i = 1;
            int j = 1;
            while (i <= table.GetLength(0) && j <= table.GetLength(1))
            {
                if (table[i,j] == firstelem)
                {
                    continue;
                }
                else{
                    return false;
                }
            }
            return true;

        }
        static void Insert(char[,] table , char x , int row , int column)
        {
            if (row > table.GetLength(0) || row < 0)
            {
                Console.WriteLine("invalid input");
            }
            if(column > table.GetLength(0) || column < 0)
            {
                Console.WriteLine("invalid input");
            }
            if (table[row, column] == ' ')
            {
                table[row, column] = x;
            }
            else 
            {
                Console.WriteLine("there is somethinh in square");
            }
        }
    }
}
