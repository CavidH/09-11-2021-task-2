using System;
using System.Collections.Generic;
using System.Text;

namespace Temperature
{
    public class ConvertTemp
    {
        /// <summary>
        /// Fahrenheit convert to  Celsius
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <returns>type  double  Celsius </returns>
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return(Fahrenheit - 32) * 5 / 9;
        }
        /// <summary>
        /// Celsius convert to   Fahrenheit
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <returns>type  double  Fahrenheit </returns>
        public static double CelsiusToFahrenheit( double Celsius )
        {
            return((Celsius * 9 / 5) + 32);
        }
        /// <summary>
        /// Fahrenheit convert to Kelvin
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <returns>type  double  Kelvin </returns>
        public static double FahrenheitToKelvin(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9+273.15;
        }
        /// <summary>
        /// Celsius convert to Kelvin
        /// </summary>
        /// <param name="Celsius"></param>
        /// <returns>type  double  Kelvin </returns>
        public static double CelsiusToKelvin(double Celsius)
        {
            return Celsius + 273.15;
        }
        /// <summary>
        ///  Kelvin convert to Celsius 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <returns>type  double  Kelvin </returns>
        public static double KelvinToCelsius(double Kelvin)
        {
            return Kelvin - 273.15;
        }
        /// <summary>
        ///  Kelvin convert to Fahrenheit 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <returns>type  double  Fahrenheit </returns>
        public static double KelvinToFahrenheit(double Kelvin)
        {
            return (Kelvin-273.15) * (9 / 5) + 32;
        }

    }
}
