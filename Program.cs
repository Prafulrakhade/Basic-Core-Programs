using System;

namespace OddEven
{
    internal class Program
    {
        int num;
        public void OddEven()
        {
            Console.Write("enter the number :");
             num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("check number is even or odd");

            Program obj = new Program();
            obj.OddEven();
        }
    }
}
