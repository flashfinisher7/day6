using System;

namespace perfectnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int number;

            Console.WriteLine("enter number");

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)

            {

                if (number % i == 0)

                    sum = sum + i;



            }

            if (sum == number)

            {

                Console.WriteLine("the number is perfect number" + number);



            }

            else

            {

                Console.WriteLine("the number is not perfect number" + number);

            }
        }
    }
}
