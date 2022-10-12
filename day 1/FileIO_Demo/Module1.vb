Imports System.IO

Module Module1

    Sub Main()




        Dim doMore As Boolean = True

        While doMore
            Console.WriteLine("Enter a Choice")
            Console.WriteLine("1. Write a new File")
            Console.WriteLine("2. Read From a File")
            Console.WriteLine("3. Exit")

            Dim choice As Integer = Console.ReadLine()
            If choice = 1 Then
#Region "Write to file"
                Dim guestName As String
                Console.WriteLine("Please Enter Your Name")
                guestName = Console.ReadLine()


                Dim myFIle As New FileStream(guestName & ".txt", FileMode.Create, FileAccess.Write)
                Dim writer As New StreamWriter(myFIle)

                writer.WriteLine("Hello My name is " & guestName)
                Console.WriteLine("You are from Which city")
                Dim city As String = Console.ReadLine()
                writer.WriteLine("I am from " & city)

                Console.WriteLine("What do you work as")
                Dim work As String = Console.ReadLine()
                writer.WriteLine("I am a " & work)

                Console.WriteLine("What do you love ")
                Dim love As String = Console.ReadLine()
                writer.WriteLine("I Love " & love)

                Console.WriteLine("What do you work as ")
                Dim workas As String = Console.ReadLine()
                writer.WriteLine("I work as " & workas)


                writer.WriteLine("I know many languages")


                writer.Close()
                myFIle.Close()

                Console.WriteLine("Content written to file")
#End Region
            ElseIf choice = 2 Then
#Region "Read From File"
                Console.WriteLine("Please enter a name to open the file")
                Dim user As String = Console.ReadLine()

                Dim myFile As New FileStream(user & ".txt", FileMode.Open, FileAccess.Read)
                Dim reader As New StreamReader(myFile)

                Console.WriteLine(reader.ReadToEnd())

                reader.Close()
                myFile.Close()
                Console.ReadLine()
#End Region
            Else
                Console.WriteLine("Thank You")
                doMore = False

            End If
            Console.Clear()
        End While
    End Sub

End Module
