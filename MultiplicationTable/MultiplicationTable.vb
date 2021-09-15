'Elliot Heiner
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/heinelli/MultiplicationTable.git

Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()

        Dim columnCount As Integer

        Console.WriteLine("Please type a whole number.")
        columnCount = CInt(Console.ReadLine())
        Console.WriteLine("Enjoy your " & columnCount & " X " & columnCount &
                          " multiplication table")
        For i = 1 To columnCount
            Console.Write(i & "     ")
        Next
        Console.WriteLine()
        For i = 1 To columnCount
            Console.Write(2 * i & "     ")
        Next

        Console.Read()
    End Sub

End Module
