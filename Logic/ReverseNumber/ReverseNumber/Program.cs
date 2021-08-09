using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Reverse(number);
        }

        //Reversing the given number
        public static void Reverse(int number)
        {
            int a = number;
            int rev = 0;
            while (number != 0) // while (number>0)
            {
                rev = rev * 10 + (number % 10);
                number /= 10;
            }
            Console.WriteLine("The reverse of a number " + a + " is : " + rev); ;
        }
    }
    
}
