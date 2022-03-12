using System;

namespace QuotientAndRemiander
{
    internal class Program
    {
        
        public void QuotientAndRemiander()
        {
            int num1;
            int num2;
            int quotient;
            int remainder;
            Console.WriteLine("enter num1 =");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 =");
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine("Quotient = "+quotient);
            Console.WriteLine("Remainder= "+remainder);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quotient And Remainder");
            Program check = new Program();
            check.QuotientAndRemiander();
        }
    }
}
