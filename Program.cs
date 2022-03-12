using System;

namespace PrimeFactorization
{
    internal class Program
    {
        public void PrimeFactor(int num)
        {
           
            int i;
            for(i=2;i>1;i++)
            {
                while(num%i==0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
            }
            Console.WriteLine(num);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Factor ");
            Program check = new Program();
            check.PrimeFactor(5);
        }
    }
}
