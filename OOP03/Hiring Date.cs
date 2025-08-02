using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Hiring_Date
    {
        public int day;
        public int month; 
        public int year { get; set; }

        public Hiring_Date(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            year = _year;
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value < 1 || value > 31)
                    Console.WriteLine("Day must be between 1 and 31");
                day = value;
            }
        }

        public int Month
        {
            get {return month; }
            set
            {
                if (value < 1 || value > 12)
                    Console.WriteLine("Month must be between 1 and 12");
                month = value;
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{year}";
        }
    }
}
