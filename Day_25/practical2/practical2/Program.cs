using System.Diagnostics;

namespace practical2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static async Task Main(string[] args)
            {
                var cars = new List<ElectricCar>{
            new ElectricCar("Model S", 2020, 20),
            new ElectricCar("Model X", 2021, 50),
            new ElectricCar("Model 3", 2022, 10),
            new ElectricCar("Model Y", 2023, 30)
                };

                Console.WriteLine("Starting to charge all cars...");

                var stopwatch = Stopwatch.StartNew();
                await ChargeAllCarsAsync(cars);
                stopwatch.Stop();

                Console.WriteLine($"All cars are fully charged. Total time: {stopwatch.Elapsed.TotalSeconds:F2} seconds.");
            }

            static async Task ChargeAllCarsAsync(IEnumerable<ElectricCar> cars)
            {
                var tasks = new List<Task>();
                var cancellationTokenSource = new CancellationTokenSource();

                foreach (var batch in cars.Batch(200)) // Limit charging to 200 cars per batch
                {
                    foreach (var car in batch)
                    {
                        tasks.Add(car.ChargeAsync(cancellationTokenSource.Token));
                    }

                    // Wait for all cars in the current batch to charge
                    await Task.WhenAll(tasks);
                    tasks.Clear();
                }

                cancellationTokenSource.Cancel();
            }
        }
    }
}
