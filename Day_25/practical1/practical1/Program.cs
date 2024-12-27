namespace practical1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const int TaskCount = 10;
            var cancellationTokenSources = new List<CancellationTokenSource>();
            var tasks = new List<Task>();

            // Start 10 tasks
            for (int i = 1; i <= TaskCount; i++)
            {
                var cts = new CancellationTokenSource();
                cancellationTokenSources.Add(cts);
                int taskNumber = i;
                tasks.Add(Task.Run(() => WriteToFile(taskNumber, cts.Token)));
            }

            // Listen for "x" input to terminate
            Console.WriteLine("Type 'x' and press Enter to stop the application.");
            while (true)
            {
                if (Console.ReadLine()?.ToLower() == "x")
                {
                    foreach (var cts in cancellationTokenSources)
                    {
                        cts.Cancel();
                    }
                    break;
                }
            }

            // Wait for all tasks to finish
            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks have been stopped.");
        }

        static async Task WriteToFile(int taskNumber, CancellationToken cancellationToken)
        {
            string fileName = $"{taskNumber}.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append: true))
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        await writer.WriteLineAsync($"Task{taskNumber} - {DateTime.Now}");
                        await writer.FlushAsync(); // Ensure immediate writing to file
                        await Task.Delay(taskNumber * 100, cancellationToken);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"Task {taskNumber} stopped.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Task {taskNumber}: {ex.Message}");
            }
        }
    }
}
