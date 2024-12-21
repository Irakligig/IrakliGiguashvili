using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaldelegates
{
    public static class ConsolidatedLogging
    {
        public static void LoggingOnConsole(string text)
        {
            Console.WriteLine(text);
        }
        public static void LoggingOnTxt(string text)
        {
            string path = "log.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(text);
            }
            Console.WriteLine("text written to file successfully");
        }
    }
}
