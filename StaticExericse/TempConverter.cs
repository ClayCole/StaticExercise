using System;
namespace StaticExericse
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double fah)
        {
            var resultsF = (fah - 32) / 1.8;
            return Math.Round(resultsF,2);
        }

        public static double CelsiusToFahrenheit(double cel)
        {
            var resultsC = (cel * 1.8) + 32;
            return Math.Round(resultsC,2);
        }
    }

}

