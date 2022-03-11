using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearAndFlipCoin
{
    public class Class1
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
        public void FlipCoin()
        {
            int heads = 0;
            int tails = 0;
            int coin;
            Console.WriteLine("Enter the number : ");
            coin = Convert.ToInt32(Console.ReadLine());
            while (coin > 0)
            {
                Random random = new Random();
                int randomCheck = random.Next(2);
                if (randomCheck == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                coin--;
            }
            Console.WriteLine("Head = " + heads);
            Console.WriteLine("Tails= " + tails);
        }
    }
}
