using System;

namespace Facturación
{
    class Program
    {
        static void Main(string[] args)
        {
            string Articulo;
            double Costo=0,Utilidad=0, Impuesto=0;
            Console.Write("Ingrese el nombre: ");
            Articulo = Console.ReadLine();
            Console.Write("Ingrese el costo: ");
            Costo = double.Parse(Console.ReadLine());
            Utilidad = (Costo * 150) / 100;
            Impuesto = (Costo * 21) / 100;
            Console.WriteLine("Articulo: " + Articulo);
            Console.WriteLine("Utilidad: $" + Utilidad);
            Console.WriteLine("Impuesto: $" + Impuesto);
           Console.WriteLine("Precio Venta: $" + (Utilidad + Impuesto));
        }
    }
}
