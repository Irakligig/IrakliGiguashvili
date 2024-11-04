namespace practical_1_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string[] Practical01_1(string sentence)
        {
            string vowels = "";
            string consonant = "";
            foreach (char x in sentence)
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    vowels += x;
                }
                else
                {
                    consonant += x;
                }
            }
            string[] all = { vowels, consonant }; // ცოტა გაუგებარია პირობის შინაარსი ჩემთვის და მაგიტომ დავაბრუნე array-თ
            return all;
        }
        static void Practical01_2(string vowels, string consonant) // string[1] = vowels,string[2] = consonants
        {
            Console.Write(vowels.Length);
            Console.Write("Vowels: ");
            foreach (char x in vowels)
            {
                Console.Write(x + " ");
            }

            Console.Write($"Consonant count : {consonant.Length}");
            Console.Write("Consonant: ");
            foreach (char x in vowels)
            {
                Console.Write(x + " ");
            }
        }
        static void Practical02(string word)
        {
            char[] reversedstringarr = new char[word.Length];
            char[] normalstring = word.ToCharArray();
            int k = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                reversedstringarr[k] = normalstring[i];
                k--;
            }
            Console.WriteLine(new string(reversedstringarr));
        }
        static void Practical03(string word)
        {
            char[] wordtoarr = new char[word.Length];
            foreach (char x in word)
            {
                Console.Write($"{Char.ToUpper(x)}  ");
            }
        }
        static void Practical04(string sentence)
        {
            string[] x = sentence.Split(' ');
            Console.Write(x.Length);
        }
        static void Practical05(string sentence)
        {
            int Letters = 0, Numbers = 0, Others = 0;
            char[] chars = sentence.ToCharArray();
            foreach (char x in chars) 
            {
                if (Char.IsDigit(x))
                {
                    Numbers++;
                }
                else if (Char.IsLetter(x))
                {
                    Letters++;
                }
                else 
                {
                    Others++;
                }
            }
            Console.WriteLine($"{sentence} -> Letters: {Letters} , Numbers: {Numbers} , Others: {Others}");
        }
    } 
}
