using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaldelegates
{
    public static class Mathoperations
    {
        public static decimal Mult(decimal x , decimal y)
        {
            return x * y;
        }

        public static decimal Div(decimal x, decimal y)
        {
            try
            {
                return x / y;
            } 
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Subs(decimal x, decimal y)
        {
            return x - y;
        }
    }
}
