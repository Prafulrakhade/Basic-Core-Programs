using System;

namespace HarmonicNumber
{
    internal class Program
    {
        public void  Harmonic()
        {
            double result = 0;
            int num;
            Console.Write("Enter the number :");
            num=Convert.ToInt32( Console.ReadLine());
            for(double i=1;i<=num;i++)
            {
                result = result + 1/i;
            }
            Console.WriteLine( "Harmonic number of " +num +" is "+result);
        }
        static void Main(string[] args)
        {
            Program check = new Program();
            check.Harmonic();

        }
    }
}
