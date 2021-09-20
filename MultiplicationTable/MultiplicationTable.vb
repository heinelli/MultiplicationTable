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

        'Prompt user input and prevent string input.
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
        'Number of rows is dictated by input. Function dictates length of rows.
        For i = 1 To tableDimensions
            iterationCount = i
            'Console.Write(RowCount(iterationCount, tableDimensions))
            RowCount(iterationCount, tableDimensions)
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

    Sub RowCount(ByVal iterationCount As Integer, ByVal tableDimensions As Integer)
        Dim stringConversion As String

        'For loop within the function allows multiple integers in one row.
        For i = 1 To tableDimensions
            stringConversion = CStr(i * iterationCount)
            Console.Write(stringConversion.PadLeft(6))
        Next
        'Return Nothing - Sub does not return anything - TJR
    End Sub

End Module
