using System;

namespace GradosFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float Celsius, Fahrenheit;
            Console.Write("Ingrese los grados Celsius: ");
            Celsius = float.Parse(Console.ReadLine());
            Fahrenheit = (Celsius * (9 / 5)) + 32;
            Console.WriteLine(Fahrenheit + "°F");
        }
    }
}
