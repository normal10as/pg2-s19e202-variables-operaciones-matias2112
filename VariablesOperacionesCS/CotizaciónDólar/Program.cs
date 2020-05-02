using System;

namespace CotizaciónDólar
{
    class Program
    {
        static void Main(string[] args)
        {
            float Dolar;
            Console.Write("1 dolar = 65.93 pesos-----Ingrese la cantidad de Dólares: ");
            Dolar = float.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de pesos: $" + Dolar * 65.93);
        }
    }
}
