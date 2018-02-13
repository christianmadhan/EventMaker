using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    class DateTimeConverter
    {
        public DateTimeConverter() { }

        public static DateTime DatetimeAndDateConverter(DateTimeOffset date, TimeSpan time)
        {
            return  new DateTime(date.Year, date.Month, date.Day, time.Hours,time.Minutes,time.Seconds);
        }
    }
}
