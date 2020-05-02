using System;

namespace Cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=5, c=2;
            double Cuadratica;

            Cuadratica = (Math.Pow(b, 2) - (4 * a * c)) / (2 * a);

            Console.WriteLine("La cuadratica es: " + Cuadratica);
        }
    }
}
