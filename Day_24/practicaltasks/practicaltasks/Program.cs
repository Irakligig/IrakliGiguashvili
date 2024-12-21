namespace practicaltasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 5 შეკვეთის შესრულება ასინქრონულად
            var tasks = new Task[5];

            for (int i = 0; i < 5; i++)
            {
                var orderId = i + 1;
                tasks[i] = ProcessOrder(orderId);
            }

            // აქ ყველას ელოდება
            await Task.WhenAll(tasks);
        }

        
        static async Task ProcessOrder(int orderId)
        {
            var order = new Order { OrderId = orderId.ToString(), OrderStatus = "Processing" };
            Console.WriteLine($"order {order.OrderId} is being processed.");

            try
            {
                
                var paymentTask = ValidatePayment(order.OrderId);
                var inventoryTask = CheckInventory(order.OrderId);

                
                await Task.WhenAll(paymentTask, inventoryTask);

                // თუ ორივე შესრულა , დაიწყე შეკვეთის მზადება
                if (paymentTask.Result && inventoryTask.Result)
                {
                    
                    await PrepareShipment(order.OrderId);
                    order.OrderStatus = "Shipped";
                    Console.WriteLine($"Order {order.OrderId}: {order.OrderStatus}");
                }
                else
                {
                    // If either fails, mark as failed
                    order.OrderStatus = "Failed";
                    Console.WriteLine($"Order {order.OrderId}: {order.OrderStatus}");
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                Console.WriteLine($"Order {order.OrderId} failed due to: {ex.Message}");
            }
        }

        
        static async Task<bool> ValidatePayment(string orderId)
        {
            Console.WriteLine($"Order {orderId}: Validating payment...");
            await Task.Delay(new Random().Next(1000, 2000));
            Console.WriteLine($"Order {orderId}: Payment validated.");
            return true;
        }

        
        static async Task<bool> CheckInventory(string orderId)
        {
            Console.WriteLine($"Order {orderId}: Checking inventory...");
            await Task.Delay(new Random().Next(1500, 2500));
            Console.WriteLine($"Order {orderId}: Inventory checked.");
            return true; 
        }

        
        static async Task PrepareShipment(string orderId)
        {
            Console.WriteLine($"Order {orderId}: Preparing shipment...");
            await Task.Delay(new Random().Next(2000, 3000)); 
            Console.WriteLine($"Order {orderId}: Shipment prepared.");
        }
    }
    class Order
    {
        public string OrderId { get; set; }
        public string OrderStatus { get; set; }
    }
}
