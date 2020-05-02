Imports System

Module Facturacion
    Sub Main(args As String())
        Dim Articulo As String
        Dim Utilidad, Impuesto As Byte
        Dim Costo As Single

        Console.Write("Ingrese el nombre: ")
        Articulo = Console.ReadLine
        Console.Write("Ingrese el costo: ")
        Costo = Console.ReadLine
        Utilidad = (Costo * 150) / 100
        Impuesto = (Costo * 21) / 100
        Console.WriteLine("Articulo: " & Articulo)
        Console.WriteLine("Utilidad: $" & Utilidad)
        Console.WriteLine("Impuesto: $" & Impuesto)
        Console.WriteLine("Precio Venta: $" & Utilidad + Impuesto)



    End Sub
End Module
