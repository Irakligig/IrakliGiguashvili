namespace practicalthreades
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the starting number of the range:");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter the ending number of the range:");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter the number of threads:");
            //int threadCount = int.Parse(Console.ReadLine());

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //List<int> primes = FindPrimesMultiThreaded(start, end, threadCount);

            //stopwatch.Stop();

            //Console.WriteLine("Prime numbers:");
            //Console.WriteLine(string.Join(", ", primes));

            //Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        static List<int> FindPrimesMultiThreaded(int start, int end, int threadCount)
        {
            List<int> primes = new List<int>();
            object lockObj = new object();

            int range = (end - start + 1) / threadCount;
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                int threadStart = start + i * range;
                int threadEnd = (i == threadCount - 1) ? end : threadStart + range - 1;

                threads[i] = new Thread(() =>
                {
                    List<int> threadPrimes = FindPrimes(threadStart, threadEnd);
                    lock (lockObj)
                    {
                        primes.AddRange(threadPrimes);
                    }
                });

                threads[i].Start();
            }

            
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            primes.Sort(); 
            return primes;
        }

        static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = Math.Max(start, 2); i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

}
