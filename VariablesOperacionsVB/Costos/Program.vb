Imports System

Module Costos
    Sub Main(args As String())
        Dim DescArticulo As String
        Dim UnidadesProducidas As Byte
        Dim Costo As Single

        Console.Write("Ingrese la descripción: ")
        DescArticulo = Console.ReadLine
        Console.Write("Ingrese las Unidades producidas: ")
        UnidadesProducidas = Console.ReadLine
        Costo = (UnidadesProducidas * 3.5) + 10700

        Console.WriteLine("Descripciones: " & DescArticulo)
        Console.WriteLine("Unidades Producidas: " & UnidadesProducidas)
        Console.WriteLine("Costo: " & Costo)

    End Sub
End Module
