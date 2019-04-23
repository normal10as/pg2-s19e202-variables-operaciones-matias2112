Imports System

Module variables_tipos
    Sub Main()

        Dim Nombre As String = "Matias Estigarribia"
        Dim Documento As Integer = 36407654
        Dim Nacimiento As String = "Posadas, Misiones, Republica Argentina"
        Dim FNacimiento As String = "1/12/1994"
        Dim Altura As Decimal = 72.2
        Dim Argentino As Boolean = True
        Dim Temperatura As Decimal = 42.5
        Dim NombreCalle As String = "Herrera 4240"
        Dim AlturaCalle As String = "4240 rosa"
        Dim Distancia As Integer = 2000
        Dim ProfundidadMar As Decimal = 5000.5
        Dim Chabitantes As Integer = 355531
        Dim PesoProducto As Decimal = 5.5
        Dim MontoArticulo As Decimal = 22.99

        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Numero de Documento: " & Documento)
        Console.WriteLine("Lugar de nacimiento: " & Nacimiento)
        Console.WriteLine("Fecha de nacimiento: " & FNacimiento)
        Console.WriteLine("Altura corporal: " & Altura)
        If Argentino = True Then
            Console.WriteLine("Es Argentino: " & Argentino)
        Else
            Console.WriteLine("No es Argentino ")
        End If
        Console.WriteLine("Temperatura: " & Temperatura)
        Console.WriteLine("Nombre Calle: " & NombreCalle)
        Console.WriteLine("Altura Calle: " & AlturaCalle)
        Console.WriteLine("Distancia en kms entre dos ciudades cualquiera: " & Distancia & " " & "Km")
        Console.WriteLine("Profundidad del mar en metros: " & ProfundidadMar & " " & "m2")
        Console.WriteLine("Cantidad de habitantes del territorio nacional: " & PesoProducto)
        Console.WriteLine("Peso de un producto de un supermercado en kilogramo: " & Chabitantes)
        Console.WriteLine("Monto de un artículo de un supermercado: " & MontoArticulo)

    End Sub
End Module
