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
        Dim tester1 As Integer
        Dim tester2 As Integer

        newString = CStr(columnCount)

        Console.WriteLine("Please type a whole number.")
        columnCount = CInt(Console.ReadLine())
        Console.WriteLine("Enjoy your " & columnCount & " X " & columnCount &
                          " multiplication table")
        For i = 1 To columnCount
            tester1 = i
            Console.Write(RowCount(tester1, columnCount))
            Console.WriteLine()

        Next
        Console.Read()
    End Sub

    Function RowCount(ByVal columnCount2 As Integer, ByVal columncount3 As Integer) As Integer
        Dim newString2 As String
        Dim turtle As Integer

        For i = 1 To columncount3
            turtle = i * columnCount2
            newString2 = CStr(turtle)
            Console.Write(newString2.PadLeft(10))
        Next
    End Function

End Module
