Module Module1

    Sub Main()

        'Console.WriteLine("Please type something and press enter")
        'Dim userValue As String
        'userValue = Console.ReadLine()
        'Console.WriteLine("You typed " & userValue)
        'Console.ReadLine()

        Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3? ")
        Dim userValue As String = Console.ReadLine()

        Dim message As String = ""

        If userValue = "1" Then
            message = "You are now a billionnaire!"
        ElseIf userValue = "2" Then
            message = "You won a yacht!"
        ElseIf userValue = "3" Then
            message = "You ain't won shit...."
        Else
            message = "You dumbass. Can't you type?"


        End If
        Console.WriteLine(message)


    End Sub

End Module
