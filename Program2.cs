using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum DayEnum : int { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        enum MonthEnum : int { Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            // Monday is day #1.
            DayEnum someDay = DayEnum.Wed;
            int dayNumber = (int)someDay;
            Console.WriteLine("{0} is day # {1}.", someDay, dayNumber);

            // Mar is the 3rd month in the year!
            MonthEnum someMonth = MonthEnum.Mar;
            int monthNumber = (int)someMonth;
            Console.WriteLine("{0} is the {1}rd month in the year!", someMonth, monthNumber);

            // Monday: 1 Friday: 5
            int weekDayStart = (int)DayEnum.Mon;
            int weekDayEnd = (int)DayEnum.Fri;
            Console.WriteLine("Monday: {0}", weekDayStart);
            Console.WriteLine("Friday: {0}", weekDayEnd);

            // getname
            string day = Enum.GetName(typeof(DayEnum), 3);
            Console.WriteLine(day);
            // string days = Enum.GetNames(typeof(DayEnum));
            // Console.WriteLine(string.Join(" ", days));

            // Switch

            switch (someDay)
            {
                case DayEnum.Sun:
                    Console.WriteLine("Sunday!");
                    break;
                case DayEnum.Mon:
                    Console.WriteLine("Monday:(");
                    break;
                case DayEnum.Tue:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Unknown day");
                    break;
            }
        }
    }
}
