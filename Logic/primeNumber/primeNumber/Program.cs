using System;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            Console.WriteLine("Enter the number to check prime number or not : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("it is  a prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }

        }
    }
}
