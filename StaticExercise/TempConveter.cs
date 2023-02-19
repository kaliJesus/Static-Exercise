using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConveter
    {
        public static double FahrenheitToCelsious(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5/9; 
        }
        public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9 / 5) + 32;
        }
        
    }
}
