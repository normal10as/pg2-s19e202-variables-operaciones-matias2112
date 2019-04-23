Imports System

Module TablasBooleanas
    Sub Main()
        Dim expression1, expression2 As Boolean
        Dim result1, result2, result3, result4, result5 As Boolean

        Console.WriteLine("0=Falso, 1=Verdadero: ")
        Console.Write("AND ingrese el valor de verdad de exp1: ")
        expression1 = Console.ReadLine()
        Console.Write("AND ingrese el valor de verdad de exp2: ")
        expression2 = Console.ReadLine()
        Console.WriteLine()

        result1 = expression1 And expression2
        result2 = expression1 Xor expression2
        result3 = expression1 Or expression2
        result4 = Not expression1
        result5 = Not expression2

        Console.WriteLine("Resultado And: " & result1)
        Console.WriteLine("Resultado Xor: " & result2)
        Console.WriteLine("Resultado Or: " & result3)
        Console.WriteLine("Resultado not exp1: " & result4)
        Console.WriteLine("Resultado not exp2: " & result5)

    End Sub
End Module
