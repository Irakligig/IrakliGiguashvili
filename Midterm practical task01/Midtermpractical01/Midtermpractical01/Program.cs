namespace Midtermpractical01
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static public void ShowPairs(int number , int[] array)
        {
            int i = 0;
            int j = array.Length - 1;
            while (i <= j)
            {
                if (array[i] + array[j] < number)
                {
                    i++;
                }
                else if (array[i] + array[j] > number)
                {
                    j++;
                }
                else
                {
                    Console.WriteLine($"{array[i]} and {array[j]}");
                }
                i++;
                j--;
            }
        }

    }
}
