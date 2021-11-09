 
using Temperature;

namespace _09_11_2021_task_1.Models
{
    class TempCelsius
    {
        public double Celsius { get; set; }
        public TempCelsius(double celsius)
        {
            Celsius = celsius;
        }
        public static implicit operator TempFahrenheit(TempCelsius tempCelsius)
        {
            return new TempFahrenheit(ConvertTemp.CelsiusToFahrenheit(tempCelsius.Celsius));
        }

        public static implicit operator TempCelsius(TempFahrenheit tempFahrenheit)
        {
            return new TempCelsius(ConvertTemp.FahrenheitToCelsius(tempFahrenheit.Fahrenheit));
        }

       
    }

}
