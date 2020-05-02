using System;

namespace CotizaciónTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ancho, Lado, CostoM2;
            Console.Write("Ingrese el ancho: ");
            Ancho =double.Parse(Console.ReadLine());
            Console.Write("Ingrese la longitud: ");
            Lado = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el costo por m2: ");
            CostoM2 = double.Parse(Console.ReadLine());

            Console.WriteLine("El costo del terreno es de $: " + (Ancho * Lado) * CostoM2);
        }
    }
}
