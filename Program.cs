using System;

namespace CheckVowel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter an ALPHABET");
            string input=Console.ReadLine();
            string alphabet = Convert.ToString(input.ToUpper()); //(input.ToLower()); we can use
            //  we can use this also --> char alphabet = Convert.ToChar(input.ToUpper());
            switch(alphabet)
            {
                case "A":
                    Console.WriteLine(" it is vowel");
                    break;
                case "E":
                    Console.WriteLine("it is vowel");
                    break;
                case "I":
                    Console.WriteLine(" it is vowel");
                    break;
                case "O":
                    Console.WriteLine(" it is vowel");
                    break;
                case "U":
                    Console.WriteLine("it is vowel");
                    break;
                default:
                    Console.WriteLine(" it is Not a vowel");
                    break;
            }
        }
    }
}
