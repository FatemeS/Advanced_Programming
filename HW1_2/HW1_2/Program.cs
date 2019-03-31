using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime dateTime = DateTime.Now;
            
            int year, month, day;
            year = persianCalendar.GetYear(dateTime);
            month = persianCalendar.GetMonth(dateTime);
            day = persianCalendar.GetDayOfMonth(dateTime);
            Console.WriteLine("year : {0}\nmonth : {1}\nday : {2}\n", year, month, day);
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
            Console.ReadKey();
        }
    }
}
