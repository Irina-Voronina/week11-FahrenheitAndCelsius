using System;

namespace FahrenheitAndCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Celsius Fahrenheit Converter");
            Console.WriteLine();

            CelsiusFahrenheitConverter();
            Celsius();
            Fahrenheit();
            Sentiment();

        }

        public static void CelsiusFahrenheitConverter()
        {

            Console.Write("Enter [1] Celsius to Fahrenheit / Enter [2] Fahrenheit to Celsius: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("What is the temperature in Celsius? : ");
                Celsius();
            }
            else if (choice == 2)
            {
                Console.Write("What is the temperature in Fahrenheit? : ");
                Fahrenheit();
            }
            else
            {
                Console.WriteLine("Incorrect choice.");
                CelsiusFahrenheitConverter();
            }

        }
        public static void Celsius()
        {
            int inputCelsius = Convert.ToInt32(Console.ReadLine());
            double result1 = (inputCelsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is : {result1} F");
            
            Sentiment();
            //CelsiusFahrenheitConverter();
        }

        public static void Fahrenheit()
        {
            int inputFahrenheit = Convert.ToInt32(Console.ReadLine());
            double result2 = (inputFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"The temperature in Celsius is : {result2} C");
            
            Sentiment();
            //CelsiusFahrenheitConverter();
        }

        public static void Sentiment()
        {
            Console.WriteLine();
            Console.WriteLine("Have a nice day!");
            
        }

    }

}

