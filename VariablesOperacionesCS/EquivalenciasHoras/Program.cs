using System;

namespace EquivalenciasHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double Hora, Minutos, Segundos, Dias ;
            Console.Write("Ingrese las horas: ");
            Hora = double.Parse(Console.ReadLine());
            Minutos = Hora * 60;
            Segundos = Minutos * 60;
            Dias = Hora / 24;

            Console.WriteLine("Dias: " + Dias);
            Console.WriteLine("Minutos: " + Minutos);
            Console.WriteLine("Segundos: "+ Segundos);
        }
    }
}
