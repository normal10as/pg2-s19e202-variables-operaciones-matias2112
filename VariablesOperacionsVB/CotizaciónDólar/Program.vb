Imports System

Module Program
    Sub Main(args As String())
        Dim Dolar As Single
        Console.Write("1 dolar = 65.93 pesos" & vbCrLf & "Ingrese la cantidad de Dólares: ")
        Dolar = Console.ReadLine
        Console.WriteLine("Cantidad de pesos: $" & Dolar * 65.93)
    End Sub
End Module
