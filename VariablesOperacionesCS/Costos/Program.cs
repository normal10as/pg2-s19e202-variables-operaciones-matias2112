using System;
namespace Costos
{
    class Program
    {
        static void Main(string[] args)
        {
            string DescArticulo;
            
            double Costo=0, UnidadesProducidas=0;
            Console.Write("Ingrese la descripción: ");
            DescArticulo=Console.ReadLine();

            Console.Write("Ingrese las Unidades producidas: ");
            UnidadesProducidas =double.Parse(Console.ReadLine());
            
            Costo = (UnidadesProducidas * 3.5) + 10700;

            Console.WriteLine("Descripcion: " + DescArticulo);
            Console.WriteLine("Unidades Producidas: " + UnidadesProducidas);
            Console.WriteLine("Costo: " + Costo);

            
        }
    }
}
