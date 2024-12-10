namespace practicaleventdelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureAlert temperatureAlert = new TemperatureAlert();
            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();

            temperatureMonitor.TemperatureChanged += temperatureAlert.CriticalTemperatureMessage;
            List<int> temps = new List<int>();

            bool SaidExit = false;
            while (!SaidExit)
            {
                Console.WriteLine("Enter input");
                string input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    SaidExit = true;
                    continue;
                }

                if (int.TryParse(input , out int correctinput))
                {
                    temps.Add(correctinput);
                    temperatureMonitor.CheckTemperature(correctinput);
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
    }
}
