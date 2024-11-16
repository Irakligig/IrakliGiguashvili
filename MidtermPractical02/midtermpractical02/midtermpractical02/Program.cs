namespace midtermpractical02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Noelement(int[] arr)
        {
            int interval = FindMedianInterval(arr);
            int i = 0;
            int j = 1;
            
            // თუ ინტერვალი უფრო დიდია , ვიდრე საშუალო ინტერვალი
            while (i <= j)
            {
                if (arr[i+1] - arr[i] == arr[j] - arr[j - 1])
                {
                    i++;
                    j--;
                }
                if(arr[i] - arr[i + 1] < arr[j] - arr[j - 1])
                {
                    return arr[i] + arr[j] - arr[j-1]; 
                }
                if (arr[i] - arr[i + 1] > arr[j] - arr[j - 1])
                {
                    return arr[j] - (arr[i + 1] - arr[i]); 
                }
            }
            /* [1,3,4,5] რადგან  1სა და 3ს შორის სხვაობა უფრო დიდია , ესეიგი იქარი ეს ელემენტი
             * და მაგას ვიპოვით 1ს რომ დავუმატოთ ის ინტერვალი , რომელიც ამ არრეის შესაბამისია
             * 
             */
            return -1;
        }
        public static int FindMedianInterval(int[] arr)
        {
            int sum = 0;
            int intervalcount = arr.Length - 1;
            int i = 0;
            int j = 0;
            while (j == arr.Length - 1)
            {
                sum += arr[j] - arr[i];
            }
            return sum / intervalcount;

        }
    }
}
