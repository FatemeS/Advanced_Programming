using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nPlease choose 1 or 2:\n\n1-Enter 10 numbers the Max will be shown.\n2-With this you will receive date today.\n0-Exit\n***You can press any key to return menu\n");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter 10 numbers:");
                        Class.Baseclass.H Max1 = new Class.Baseclass.H();
                        Console.WriteLine("Max number is:{0}", Max1.MaxNum());
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Class.Baseclass.H year = new Class.Baseclass.H();
                        Class.Baseclass.H month = new Class.Baseclass.H();
                        Class.Baseclass.H day = new Class.Baseclass.H();

                        Console.WriteLine("{0}/{1}/{2}", year.Year(), month.Month(), day.Day());
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.Clear();
                        Environment.Exit(2);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter 1 or 2");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
