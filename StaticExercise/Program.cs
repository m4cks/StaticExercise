using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"60 Fahrenheit is: {TempConverter.FahrenheitToCelsius(60)} Celsius");
            Console.WriteLine($"85 Fahrenheit is: {TempConverter.FahrenheitToCelsius(85)} Celsius");

            Console.WriteLine("================================================");

            Console.WriteLine($"18 Celsius is: {TempConverter.CelsiusToFahrenheit(18)} Fahrenheit");
            Console.WriteLine($"15 Celsius is: {TempConverter.CelsiusToFahrenheit(15)} Fahrenheit");
        }
    }
}
