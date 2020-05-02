Imports System

Module VelocidadDeLaLuz
    Sub Main(args As String())
        Dim Segundos As Single
        Dim Kilometros As UInteger = 300000
        Console.Write("Ingrese los segundos: ")
        Segundos = Console.ReadLine
        Console.WriteLine("La distancia que recorre es de: " & Kilometros * Segundos & "km")
    End Sub
End Module
