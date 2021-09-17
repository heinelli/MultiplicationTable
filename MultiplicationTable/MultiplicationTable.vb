'Elliot Heiner
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/heinelli/MultiplicationTable.git

Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()

        Dim columnCount As Integer = 10
        Dim newString As String
        Dim columnString As String
        Dim lineTwo As String

        newString = CStr(columnCount)
        Console.WriteLine(newString.PadLeft(20))

        Console.WriteLine("Please type a whole number.")
        columnCount = CInt(Console.ReadLine())
        Console.WriteLine("Enjoy your " & columnCount & " X " & columnCount &
                          " multiplication table")
        For i = 1 To columnCount
            columnString = CStr(i)
            Console.Write(columnString.PadLeft(5))

        Next
        Console.WriteLine()
        For i = 1 To columnCount
            lineTwo = CStr(i * 2)
            Console.Write(lineTwo.PadLeft(5))
        Next

        Console.Read()
    End Sub

End Module
