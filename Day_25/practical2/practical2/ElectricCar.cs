using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical2
{
    internal class ElectricCar
    {
        public int BatteryLevel { get; private set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public ElectricCar(string model, int year, int initialBatteryLevel = 0)
        {
            Model = model;
            Year = year;
            BatteryLevel = initialBatteryLevel;
        }

        public async Task ChargeAsync(CancellationToken cancellationToken)
        {
            while (BatteryLevel < 100 && !cancellationToken.IsCancellationRequested)
            {
                BatteryLevel = Math.Min(BatteryLevel + 5, 100);
                await Task.Delay(10000, cancellationToken); // Wait for 10 seconds
            }
        }
    }
}
