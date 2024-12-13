namespace practicallinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<string>();
            var orders = new List<string>();

            using (var reader = new System.IO.StreamReader("customers.txt"))
            {
                while (!reader.EndOfStream)
                {
                    customers.Add(reader.ReadLine());
                }
            }

            using (var reader = new System.IO.StreamReader("orders.txt"))
            {
                while (!reader.EndOfStream)
                {
                    orders.Add(reader.ReadLine());
                }
            }

            // Parse customers data
            var customersData = customers.Skip(1)
                .Select(line => line.Split('|'))
                .ToDictionary(parts => int.Parse(parts[0]), parts => parts[1]);

            // Parse orders data
            var ordersData = orders.Skip(1)
                .Select(line => {
                    var parts = line.Split('|');
                    return new
                    {
                        OrderID = int.Parse(parts[0]),
                        Date = parts[1],
                        Product = parts[2],
                        Price = decimal.Parse(parts[3]),
                        CustomerID = int.Parse(parts[4])
                    };
                }).ToList();

            // 1
            var orderCounts = ordersData.GroupBy(order => order.CustomerID)
                .Select(group => new { CustomerID = group.Key, OrderCount = group.Count() });

            // 2
            var totalPrices = ordersData.GroupBy(order => order.CustomerID)
                .Select(group => new { CustomerID = group.Key, SumAmount = group.Sum(order => order.Price) });

            // 3
            var minPrices = ordersData.GroupBy(order => order.CustomerID)
                .Select(group => new { CustomerID = group.Key, MinAmount = group.Min(order => order.Price) });

            // 4
            var multipleOrders = orderCounts.Where(client => client.OrderCount > 1);

            // 5
            var highAverageOrders = ordersData.GroupBy(order => order.CustomerID)
                .Select(group => new
                {
                    CustomerID = group.Key,
                    AvgAmount = group.Average(order => order.Price)
                })
                .Where(client => client.AvgAmount > 10);

            
            var results = new List<string>();

            results.Add("Number of orders for each client:");
            foreach (var result in orderCounts)
                results.Add($"CustomerID: {result.CustomerID}, OrderCount: {result.OrderCount}");

            results.Add("\nTotal price of orders for each client:");
            foreach (var result in totalPrices)
                results.Add($"CustomerID: {result.CustomerID}, SumAmount: {result.SumAmount}");

            results.Add("\nMinimum order price for each client:");
            foreach (var result in minPrices)
                results.Add($"CustomerID: {result.CustomerID}, MinAmount: {result.MinAmount}");

            results.Add("\nClients with more than one order:");
            foreach (var result in multipleOrders)
                results.Add($"CustomerID: {result.CustomerID}, OrderCount: {result.OrderCount}");

            results.Add("\nClients with average order price more than 10:");
            foreach (var result in highAverageOrders)
                results.Add($"CustomerID: {result.CustomerID}, AvgAmount: {result.AvgAmount}");

            // Save to file
            System.IO.File.WriteAllLines("results.txt", results);

            Console.WriteLine("Results have been written to results.txt.");

        }
    }
}
