using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers:");
            double x;
            List<double> list = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                x = double.Parse(Console.ReadLine());
                list.Add(x);
            }
            Console.WriteLine("Max is:{0}", list.Max());
            Console.ReadKey();
        }
    }
}
