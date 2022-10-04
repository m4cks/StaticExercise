using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    internal static class TempConverter
    {
        // 9/5 x + 32
        public static double CelsiusToFahrenheit(int f)
        {
            return ((f * 9 / 5) + 32);
        }

        public static double FahrenheitToCelsius(int c)
        {
            return ((c - 32) * 5 / 9);
        }
    }
}
