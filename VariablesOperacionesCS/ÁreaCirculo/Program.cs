using System;

namespace ÁreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radio, Area;
            Console.Write("Ingrese el radio: ");
            Radio =double.Parse( Console.ReadLine());
            Area = Math.PI * (Math.Pow(Radio, 2));
            Console.WriteLine("El área es: " + Area);
        }
    }
}
