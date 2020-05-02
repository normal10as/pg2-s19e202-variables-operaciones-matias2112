Imports System

Module GradosFahrenheit
    Sub Main(args As String())
        Dim Celsius, Fahrenheit As Single
        Console.Write("Ingrese los grados Celsius: ")
        Celsius = Console.ReadLine
        Fahrenheit = (Celsius * (9 / 5)) + 32
        Console.WriteLine(Fahrenheit & "°F")
    End Sub
End Module
