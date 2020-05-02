using System;

namespace EquivalenciasPies
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pies, Yarda, Pulgada, Centimetro, Metro;
            Console.Write("Ingrese una medida en pies: ");
            Pies = double.Parse(Console.ReadLine());
            Pulgada = Pies * 12;
            Yarda = Pies / 3;
            Centimetro = Pulgada * 2.54;
            Metro = Centimetro / 100;
            Console.WriteLine(Yarda + " yardas");
            Console.WriteLine(Pulgada + " pulgadas");
            Console.WriteLine(Centimetro + " cm");
            Console.WriteLine(Metro + " m");
        }
    }
}
