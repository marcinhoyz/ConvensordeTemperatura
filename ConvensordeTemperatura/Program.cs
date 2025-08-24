using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvensordeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit, kelvin;
            Console.WriteLine("Infrome em qual temperatura você está: ");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.WriteLine("3 - Kelvin");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a temperatura: ");
            float temperatura = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            float celsiusParaFahrenheit, celsiusParaKelvin;
            float fahrenheitParaCelsius, fahrenheitParaKelvin;
            float kelvinParaCelsius, kelvinParaFahrenheit;
            if (opcao == 1)
            {
                celsiusParaFahrenheit = (temperatura * 9 / 5) + 32;
                celsiusParaKelvin = temperatura + 273.15f;
                Console.WriteLine("Temperatura em Fahrenheit: " + celsiusParaFahrenheit);
                Console.WriteLine("Temperatura em Kelvin: " + celsiusParaKelvin);
            }
            else if (opcao == 2)
            {
                fahrenheitParaCelsius = (temperatura - 32) * 5 / 9;
                fahrenheitParaKelvin = (temperatura - 32) * 5 / 9 + 273.15f;
                Console.WriteLine("Temperatura em Celsius: " + fahrenheitParaCelsius);
                Console.WriteLine("Temperatura em Kelvin: " + fahrenheitParaKelvin);
            }
            else if (opcao == 3)
            {
                kelvinParaCelsius = temperatura - 273.15f;
                kelvinParaFahrenheit = (temperatura - 273.15f) * 9 / 5 + 32;
                Console.WriteLine("Temperatura em Celsius: " + kelvinParaCelsius);
                Console.WriteLine("Temperatura em Fahrenheit: " + kelvinParaFahrenheit);
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

        }
    }
}
