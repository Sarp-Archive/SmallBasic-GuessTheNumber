Module GuessModule
    Dim num, t, g As Primitive
    Sub Main()
        num = Microsoft.SmallBasic.Library.Math.GetRandomNumber(100)
        t = 0
        TextWindow.Write("Enter a number between 1 and 100: ")

loop:
        g = TextWindow.ReadNumber()
        t = t + 1

        If g > num Then
            TextWindow.Write("Your guess is high. Try again: ")
            Goto loop

        ElseIf g < num Then
            TextWindow.Write("Your guess is low. Try again: ")
            Goto loop

        Else
            TextWindow.WriteLine("")
            TextWindow.WriteLine("You found number and tried " + t + " times.")
            TextWindow.WriteLine("Press ENTER to exit..")
            TextWindow.Read()

        End If

        Program.End()
    End Sub
End Module
