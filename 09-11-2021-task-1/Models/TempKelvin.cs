using System;
using System.Collections.Generic;
using System.Text;
using Temperature;

namespace _09_11_2021_task_1.Models
{
    class TempKelvin
    {

        public double Kelvin { get; set; }
        public TempKelvin(double kelvin)
        {
            Kelvin = kelvin;
        }

        public static implicit operator TempFahrenheit(TempKelvin tempKelvin)
        {
            return new TempFahrenheit(ConvertTemp.KelvinToFahrenheit(tempKelvin.Kelvin));
        }
        public static implicit operator TempCelsius(TempKelvin tempKelvin)
        {
            return new TempCelsius(ConvertTemp.KelvinToCelsius(tempKelvin.Kelvin));
        }
        public static implicit operator TempKelvin(TempFahrenheit tempFahrenheit)
        {
            return new TempKelvin(ConvertTemp.FahrenheitToKelvin(tempFahrenheit.Fahrenheit));
        }
        public static implicit operator TempKelvin(TempCelsius tempCelsius)
        {
            return new TempKelvin(ConvertTemp.CelsiusToKelvin(tempCelsius.Celsius));
        }
    }
}
