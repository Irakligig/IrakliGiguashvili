namespace practicalthreads2
{
    using System;
    using System.Threading;

    class Program
    {
        private static int seconds = 0;
        private static bool isRunning = true;
        private static readonly object lockObj = new object();

        static void Main(string[] args)
        {
            // Thread for the timer
            Thread timerThread = new Thread(Timer);
            timerThread.Start();

            // Thread for user input
            Thread inputThread = new Thread(UserInput);
            inputThread.Start();

            // Wait for the threads to finish before exiting
            timerThread.Join();
            inputThread.Join();
        }

        static void Timer()
        {
            while (isRunning)
            {
                lock (lockObj)
                {
                    Console.Clear();
                    Console.WriteLine($"Elapsed time: {seconds} seconds");
                }
                Thread.Sleep(1000);

                lock (lockObj)
                {
                    seconds++;
                }
            }
        }

        static void UserInput()
        {
            while (isRunning)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.R)
                {
                    lock (lockObj)
                    {
                        seconds = 0;
                    }
                }
                else if (key == ConsoleKey.Q)
                {
                    isRunning = false;
                }
            }
        }
    }

}
