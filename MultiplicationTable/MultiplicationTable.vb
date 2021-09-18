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
        Dim newString As String
        Dim columnString As String
        Dim lineTwo As String

        newString = CStr(columnCount)

        Console.WriteLine("Please type a whole number.")
        columnCount = CInt(Console.ReadLine())
        Console.WriteLine("Enjoy your " & columnCount & " X " & columnCount &
                          " multiplication table")
        For i = 1 To columnCount
            Console.Write(RowCount(columnCount))
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

    Function RowCount(ByVal columnCount2 As Integer) As Integer
        For i = 1 To columnCount2
            Console.Write(columnCount2)
        Next
    End Function

End Module
