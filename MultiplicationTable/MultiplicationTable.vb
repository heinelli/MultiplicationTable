'Elliot Heiner
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/heinelli/MultiplicationTable.git

Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()

        Dim columnMultiplier As Integer

        Console.WriteLine("Please type a whole number.")
        columnMultiplier = CInt(Console.ReadLine())
        For i = 1 To columnMultiplier
            Console.WriteLine(i)
        Next
        Console.Read()
    End Sub

End Module
