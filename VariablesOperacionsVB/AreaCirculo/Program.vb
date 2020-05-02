Imports System

Module Program
    Sub Main(args As String())
        Dim Radio, Area As Single
        Console.Write("Ingrese el radio: ")
        Radio = Console.ReadLine
        Area = Math.PI * (Math.Pow(Radio, 2))
        Console.WriteLine("El area es: " & Area)

    End Sub
End Module
