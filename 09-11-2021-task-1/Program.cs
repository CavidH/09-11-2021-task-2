using System;
using _09_11_2021_task_1.Models;

namespace _09_11_2021_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            TempKelvin n = new TempKelvin(45);
            TempCelsius f = n;
            Console.WriteLine(f.Celsius);
            TempCelsius selsi = new TempCelsius(45);
            TempFahrenheit fahrenheit = selsi;
            TempFahrenheit fahrenheit1 = new TempFahrenheit(32);
            TempCelsius selsi1 = fahrenheit1;
            Console.WriteLine(fahrenheit.Fahrenheit);
            **/
            TempCelsius selsi = new TempCelsius(45);
            TempKelvin tempKelvin = selsi;
            Console.WriteLine(tempKelvin.Kelvin);



        }
    }
}
