'Elliot Heiner
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/heinelli/MultiplicationTable.git

Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()

        Dim tableDimensions As Integer
        Dim iterationCount As Integer
        Dim wholeNumber As Boolean

        Do While wholeNumber = False
            Try
                Console.WriteLine("Please type a whole number.")
                tableDimensions = CInt(Console.ReadLine())
                wholeNumber = True
            Catch
                wholeNumber = False
            End Try
        Loop

        Console.WriteLine("Enjoy your " & tableDimensions & " X " & tableDimensions &
                                  " multiplication table")
        For i = 1 To tableDimensions
            iterationCount = i
            Console.Write(RowCount(iterationCount, tableDimensions))
            Console.WriteLine()
        Next

        Console.Read()
    End Sub

    Function RowCount(ByVal tableDimensions As Integer, ByVal iterationCount As Integer) As String

        Dim stringConversion As String

        For i = 1 To iterationCount
            stringConversion = CStr(i * tableDimensions)
            Console.Write(stringConversion.PadLeft(6))
        Next
        Return Nothing

    End Function

End Module
