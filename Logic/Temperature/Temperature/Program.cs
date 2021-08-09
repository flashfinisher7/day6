using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in degrees : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To convert Temperature Choose an option \n 1.Celsius to Fahrenheit \n 2.Fahrenheit to Celsius");
            Console.WriteLine("Choose an option 1 or 2 : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    double fahrenheit = (double)temperature * (9 / 5.0) + 32;
                    Console.WriteLine("The temperature " + temperature + " celsius is converted to " + fahrenheit + " fahrenheit");
                    break;
                case 2:
                    double celsius = (double)(temperature - 32) * (5 / 9.0);
                    Console.WriteLine("The temperature " + temperature + " fahrenheit is converted to " + celsius + " celsius");
                    break;
            }
        }
    }
    
}
