using static System.Net.Mime.MediaTypeNames;

namespace practical_1_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Practical01 (int x)
        {
            if (x <= 0) 
            {
                return;
            }
            Practical01(x - 1);
            Console.Write(x + " ");
        }
        static int Practical02 (int x)
        {
            if (x == 1) 
            { 
                return 1;
            }
            else
            {
                return x + Practical02(x - 1);
            }
        }
        static int Practical03 (int x)
        {
            if (x / 10 <= 0 )
            {
                return 1;
            }
            else
            {
                return 1 + Practical03(x / 10);
            }
        }
        static int Pow(int x , int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            else
            {
                return x * Pow(x, degree - 1);
            }
        }
        static bool IsPalindrome(string word)
        {
            return IsPalindromeHelper(word, 0, word.Length - 1);
        }
        static bool IsPalindromeHelper(string text, int left, int right)
        {
            if (left >= right)
                return true; 

            if (text[left] != text[right])
                return false; 

            return IsPalindromeHelper(text, left + 1, right - 1);
        }
    }
}
