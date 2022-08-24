using System;

namespace StaticExericse
{
    class Program
    {
        static void Main(string[] args)
        {
           var Celsius = TempConverter.FahrenheitToCelsius(75);
            Console.WriteLine($"its currently {Celsius} degrees in Celsius");

            var Fahrenheit = TempConverter.CelsiusToFahrenheit(34);
            Console.WriteLine($"its currently {Fahrenheit} degrees in Fahrenheit");
        }
     
        
    }
}

