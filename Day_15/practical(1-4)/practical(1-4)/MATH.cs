using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace practical_1_4_
{
    public enum Status
    {
        PowMustBeaPositiveOrZero, Success,MustntBeEqual
    }

    static internal class MATH 
    { 
        static Status Status;
    
        public static double Pow(double number , int powerof , out Status status)
        {
            double result = 1;
            int absexponent = Math.Abs(powerof);

            for (int i = 0; i < absexponent; i++)
            {
                result *= number;
            }

            if (powerof < 0)
            {
                status = Status.PowMustBeaPositiveOrZero;
                result = 1 / result;
            }
            else
            {
                status = Status.Success;
            }
            return result;
        }

        public static double Min(double x , double y , out Status status)
        {
            if (x > y)
            {
                status = Status.Success;
                return y;
            }
            else if (x < y)
            {
                status = Status.Success;
                return x;
            }
            else
            {
                status = Status.MustntBeEqual;
                return -1.0;
            }
        }

        public static double Max(double x, double y, out Status status)
        {
            if (x > y)
            {
                status = Status.Success;
                return x;
            }
            else if (x < y)
            {
                status = Status.Success;
                return y;
            }
            else
            {
                status = Status.MustntBeEqual;
                return -1.0;
            }
        }


    }
}
