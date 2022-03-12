using System;

namespace TwoNumberSwapping
{
    internal class Program
    {
        public void Swapping()
        {
            int num1;
            int num2;
            Console.WriteLine(" After Swapping ");
            Console.Write("num1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            temp = num1;
            num1 = num2;
             num2=temp;
            Console.WriteLine("Before Swapping ");
            Console.WriteLine("num1 = "+num1);
            Console.WriteLine("num2 = "+num2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping The Number");
            Program swapp = new Program();
            swapp.Swapping();
        }
    }
}
