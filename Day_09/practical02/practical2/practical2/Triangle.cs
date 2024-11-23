using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical2
{
    internal class Triangle
    {
        public int A { get; set; }

        public int B { get; set; }

        private int c;  


        public int C
        {
            get { return c; }
            set 
            {
                if (value >= A + B || A >= value + B || B >= A + value)
                {
                    Console.WriteLine("It is not valid triangle");
                }
                else 
                { 
                    c = value;
                }
            
            }
        }

        public void Area()
        {
            double s = (A + B + c) / 2;

            Console.WriteLine( Math.Sqrt(s * (s - A) * (s - B) * (s - c)));
        }

        public void Perimeter()
        {
            Console.WriteLine(A + B + C);
        }
    }
}
