Imports System

Module Program
    Sub Main(args As String())

        Dim Nombre As String
        Dim Apellido As String
        Dim Fnacimiento

        Console.Write("Ingrese Nombre:  ")
        Nombre = Console.ReadLine()

        Console.Write("Ingrese Apellido:   ")
        Apellido = Console.ReadLine()

        Console.Write("Ingrese Fecha de nacimiento:   ")
        Console.WriteLine("Apellido: " & Apellido & "  " & "Nombre: " & Nombre & "  " & "Nacio el: " & Fnacimiento)

    End Sub
End Module
