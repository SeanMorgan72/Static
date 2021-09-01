using System;
namespace Static
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double temp)
        {
            return Math.Round((temp - 32.00) * 5 /9);
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return Math.Round ((temp *9) / 5 + 32.00);
        }

    }
}
