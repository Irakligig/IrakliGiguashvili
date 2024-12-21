using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalReflection
{
    internal class Calculator
    {
        public double Add(double x , double y)
        {
            
            return x + y;
        }
        
        public double Substract(double x , double y)
        {
            return x - y;
        }

        public double Mult(double x , double y)
        {
            return x * y;
        }

        public double Div(double x , double y)
        {
            if (y == 0)
            {
                throw new Exception("You cant devidfe by zero");
            }
            return (x / y);
        }
    }
}
