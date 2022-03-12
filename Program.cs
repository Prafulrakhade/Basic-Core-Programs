using System;

namespace PowerOf2
{
    internal class Program
    {
         public void PowerOf2()
        {
            int result = 1;
            int a=2;
            int b;
            //Console.WriteLine("enter a ");
            //a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=b;i++)
            {
                result = result * a;
            }
            Console.WriteLine("power of 2  upto num 3 = " + result);
        }
        static void Main(string[] args)
        {
            Program check = new Program();
            check.PowerOf2();
            
        }
    }
}
