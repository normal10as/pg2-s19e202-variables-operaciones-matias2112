Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Byte
        Dim Cuadratica As Single
        a = 1
        b = 5
        c = 2
        Cuadratica = (Math.Pow(b, 2) - (4 * a * c)) / (2 * a)
        Console.WriteLine("La cuadratica es: " & Cuadratica)
    End Sub
End Module
