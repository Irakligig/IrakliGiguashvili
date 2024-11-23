using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practical3
{
    internal class Clock
    {
        private int hours;

        private int minutes;

        private int seconds;

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(value > 23 || value < 0)
                {
                    Console.WriteLine("invalid input");
                }
                else
                {
                    hours = value;
                }
            }
        }

        public int Minutes
        {
            get 
            {
                return minutes;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    Console.WriteLine("invalid input");
                }
                else
                {
                    minutes = value;
                }
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    Console.WriteLine("invalid input");
                }
                else
                {
                    seconds = value;
                }
            }
        }


        public void PlusHour() 
        {
            if (hours == 23)
            {
                hours = 00;
            }
            else
            {
                hours++;
            }
        }

        public void PlusMinute()
        {
            if (minutes == 59)
            {
                PlusHour();
                minutes = 00;
            }
            else
            {
                minutes++;
            }
        }

        public void PlusSecond()
        {
            if (seconds == 59)
            {
                PlusMinute();
                seconds = 00;
            }
            else
            {
                seconds++;
            }
        }

        public void MinusHour()
        {
            if(hours == 00)
            {
                hours = 23;  
            }
            else
            {
                hours--;
            }
        }

        public void MinusMinute()
        {
            if(minutes == 00)
            {
                minutes = 59;
            }
            else
            {
                minutes--;
            }
        } 

        public void MinusSecond()
        {
            if (seconds == 00)
            {
                seconds = 59;
            }
            else
            {
                seconds--;
            }
        }

        public void GetCurrentTime()
        {
            string time = $"{hours:D2} : {minutes:D2} : {seconds:D2}";
            Console.Write(time);
        }
    }
}
