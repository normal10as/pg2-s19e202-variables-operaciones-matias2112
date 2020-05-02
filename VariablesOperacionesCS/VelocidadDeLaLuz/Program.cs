using System;

namespace VelocidadDeLaLuz
{
    class Program
    {
        static void Main(string[] args)
        {
            double Segundos;
        int Kilometros  = 300000;
            Console.Write("Ingrese los segundos: ");
            Segundos = double.Parse(Console.ReadLine());
            Console.WriteLine("La distancia que recorre es de: " + Kilometros * Segundos + "km");
        }
    }
}
