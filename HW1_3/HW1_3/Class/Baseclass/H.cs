using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HW1_3.Class.Baseclass
{
    class H
    {
        public string MaxNum()
        {
            double x;
            List<double> list = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                x = double.Parse(Console.ReadLine());
                list.Add(x);
            }
            String a = Convert.ToString(list.Max());
            return a;
        }

        public string Year()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime dateTime = DateTime.Now;
            string year;
            year = Convert.ToString(persianCalendar.GetYear(dateTime));
            return year;
        }

        public string Month()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime dateTime = DateTime.Now;
            string month;
            month = Convert.ToString(persianCalendar.GetMonth(dateTime));
            return month;
        }

        public string Day()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime dateTime = DateTime.Now;
            string day;
            day = Convert.ToString(persianCalendar.GetDayOfMonth(dateTime));
            return day;
        }
    }
}
