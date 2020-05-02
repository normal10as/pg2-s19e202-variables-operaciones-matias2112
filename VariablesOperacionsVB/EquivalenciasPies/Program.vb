Imports System

Module EquivalenciasPies
    Sub Main(args As String())
        Dim Pies, Yarda, Pulgada, Centimetro, Metro As Single
        Console.Write("Ingrese una medida en pies: ")
        Pies = Console.ReadLine
        Pulgada = Pies * 12
        Yarda = Pies / 3
        Centimetro = Pulgada * 2.54
        Metro = Centimetro / 100
        Console.WriteLine(Yarda & " yardas")
        Console.WriteLine(Pulgada & " pulgadas")
        Console.WriteLine(Centimetro & " cm")
        Console.WriteLine(Metro & " m")
    End Sub
End Module
