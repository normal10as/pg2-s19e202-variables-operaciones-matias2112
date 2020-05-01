Imports System

Module EquivalenciasHoras
    Sub Main(args As String())
        Dim Hora, Minutos, Segundos, Dias As Single
        Console.Write("Ingrese las horas: ")
        Hora = Console.ReadLine
        Minutos = Hora * 60
        Segundos = Minutos * 60
        Dias = Hora / 24

        Console.WriteLine("Dias: " & Dias)
        Console.WriteLine("Minutos: " & Minutos)
        Console.WriteLine("Segundos: " & Segundos)

    End Sub
End Module
