using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearAndFlipCoin
{
    internal class Class1
    {
        public void LeapYear()
        {
            int year;
            Console.Write(" Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine(year + " Is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
        }
    }
}
