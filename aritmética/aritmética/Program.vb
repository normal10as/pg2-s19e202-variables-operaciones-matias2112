Imports System

Module aritmética
    Sub Main()

        Dim n1, n2 As Integer
        Dim m3, m4 As Long
        Dim rs, rr, rm, rd As Long

        n1 = 12
        n2 = 13
        m3 = -2.5
        m4 = 3.5

        rs = n1 + n2 + m3 + m4
        rr = n1 - n2 - m3 - m4
        rm = n1 * n2 * m3 * m4
        rd = n1 / n2 / m3 / m4

        Console.WriteLine(rs)
        Console.WriteLine(rr)
        Console.WriteLine(rm)
        Console.WriteLine(rd)

    End Sub
