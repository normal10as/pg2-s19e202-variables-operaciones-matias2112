Imports System

Module CotizacionTerreno
    Sub Main(args As String())
        Dim Ancho, Lado, CostoM2 As Single
        Console.Write("Ingrese el ancho: ")
        Ancho = Console.ReadLine
        Console.Write("Ingrese la longitud: ")
        Lado = Console.ReadLine
        Console.Write("Ingrese el costo por m2: ")
        CostoM2 = Console.ReadLine

        Console.WriteLine("El costo del terreno es de $: " & (Ancho * Lado) * CostoM2)

    End Sub
End Module
