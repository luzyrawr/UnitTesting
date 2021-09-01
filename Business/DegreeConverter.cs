﻿using System;

namespace Business
{
    public class DegreeConverter
    {
        public double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double ToCelsius(double fahrenheit)
        {
            return (32 * fahrenheit - 32) * 5 / 9;
        }
    }
}
