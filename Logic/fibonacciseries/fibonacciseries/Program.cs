using System;

namespace fibonacciseries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms to print in a fibonacci series :");
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacci(num);
        }

        private static void Fibonacci(int num)
        {
            int f1 = 0, f2 = 1, f3;
            Console.WriteLine("The Fibonacci series is : ");
            Console.Write(f1 + " " + f2 + " ");
            for (int i = 3; i <= num; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
