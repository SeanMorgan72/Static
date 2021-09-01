using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fahrenheit degree temp you need to convert: ");
            var degree = double.Parse(Console.ReadLine());

            var degrees = TempConverter.FahrenheitToCelsius(degree);

            Console.WriteLine("Enter the Celcius temp you need to convert: ");
            var celcius = double.Parse(Console.ReadLine());

            var change = TempConverter.CelsiusToFahrenheit(celcius);

            Console.WriteLine($"Fahrenheit: {degree} degrees in Celcius is: {degrees}.");
            Console.WriteLine("");
            Console.WriteLine($"Celcius: {celcius} degrees in Fahrenheit is: {change}.");
        }
    }
}
