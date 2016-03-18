Module Module1

    Sub Main()

        'Console.WriteLine("Please type something and press enter")
        'Dim userValue As String
        'userValue = Console.ReadLine()
        'Console.WriteLine("You typed " & userValue)
        'Console.ReadLine()

        Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3? ")
        Dim userValue As String = Console.ReadLine()
        If userValue = "1" Then
            Console.Write("You are now a billionnaire!")
            Console.ReadLine()
        ElseIf userValue = "2" Then
            Console.Write("You won a yacht!")
            Console.ReadLine()
        ElseIf userValue = "3" Then
            Console.Write("You ain't won shit....")
            Console.ReadLine()
        Else
            Console.Write("You dumbass. Can't you type?")
            Console.ReadLine()

        End If


    End Sub

End Module
