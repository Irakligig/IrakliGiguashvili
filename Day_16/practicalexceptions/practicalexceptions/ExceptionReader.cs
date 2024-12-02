using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalexceptions
{
    internal static class ExceptionReader
    {
        public static string GetLastInnerExMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                return GetLastInnerExMessage (ex.InnerException);
            }
            return ex.Message;
        }

        public static string GetAllInnerExMessageTogether(Exception ex)
        {
            string acc = "";
            int i = 0;
            while(ex is not null)
            {
                acc += $"exception {i} is {ex.Message}";
                ex = ex.InnerException;
                i++;
            }
            return acc;
        }
    }
}
