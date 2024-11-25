using System.Runtime.InteropServices;

namespace DataStructureImplementations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static  void GenericSwap<T>(T elem1 , T elem2 , T[] arr)
        {
            int indexofelem1 = Array.IndexOf(arr, elem1);
            int indexofelem2 = Array.IndexOf(arr, elem2);
            if (indexofelem1 == -1 || indexofelem2 == -1)
            {
                Console.WriteLine("incorrect input");
            }
            else
            {
                arr[indexofelem1] = elem2;
                arr[indexofelem2] = elem1;
            }
        }

        public static T GenericMaxFinder<T>(T[] arr ) where T : IComparable<T>
        {
            T maxvalue = arr[0];
            for (int i = 1; i < arr.Length;i++)
            {
                if (maxvalue.CompareTo(arr[i]) == -1)
                {
                    maxvalue = arr[i];
                }
            }
            return maxvalue;
        }
    }
}
