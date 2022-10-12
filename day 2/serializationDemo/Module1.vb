Imports System.IO
Imports System.Xml.Serialization

Module Module1

    Sub Main()

        Dim continueProcess As Boolean = True

        While continueProcess



            Console.WriteLine(" ~~~~~~~~~~ Welcome to Banking System ~~~~~~~~~~` ")
        Console.WriteLine("1. Create a New Account")
        Console.WriteLine("2. View Account Details")
        Console.WriteLine("3. Widraw")
        Console.WriteLine("4. Deposit")
        Console.WriteLine("5. Transfer")
        Console.WriteLine("6. Exit")

        Dim choice As Integer = Console.ReadLine()

            If choice = 1 Then
#Region "Serialization"
                'Step 1: Create a new object and assign the properties
                Dim accObj As New Accounts()
                Console.WriteLine("Enter Account Number")
                accObj.AccNo = Console.ReadLine()
                Console.WriteLine("Enter Account Name")
                accObj.AccName = Console.ReadLine()
                Console.WriteLine("Enter Account Balance")
                accObj.AccBalance = Console.ReadLine()
                Console.WriteLine("Enter Account Is Active")
                accObj.AccIsActive = Console.ReadLine()

                'step 2: we need a new file object, as we want to save the object to file
                Dim myFile As New FileStream(accObj.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                'step 3 : create a new object of XMLSerializer
                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, accObj)
                myFile.Close()

                Console.WriteLine("Object Serialized - saved to disk")
#End Region
            ElseIf choice = 2 Then
#Region "Deserialization"

                'filestream object with read

                Console.WriteLine("Enter Your Account No")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)


                'XML Serializer object
                Dim getAccount As New XmlSerializer(GetType(Accounts))

                'use Deserialize method of xmlserializer

                Dim acc As Accounts 'this is not a new account - we did not use New keyword

                acc = getAccount.Deserialize(file)

                Console.WriteLine("Account Number : " & acc.AccNo)
                Console.WriteLine("Account Name : " & acc.AccName)
                Console.WriteLine("Account Balance : " & acc.AccBalance)
                Console.WriteLine("Account Is Active : " & acc.AccIsActive)

                file.Close()



#End Region
            ElseIf choice = 3 Then
#Region "Widraw Amount"
                Console.WriteLine("Enter Your Account No")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)



                Dim getAccount As New XmlSerializer(GetType(Accounts))
                Dim acc As Accounts
                acc = getAccount.Deserialize(file)
                file.Close()
                Console.WriteLine("Enter Amount To Widraw")
                Dim amount As Integer = Console.ReadLine()

                acc.Widraw(amount)
                Console.WriteLine("Widraw Successful - Balance : " & acc.AccBalance)

                Dim myFile As New FileStream(acc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                'step 3 : create a new object of XMLSerializer
                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, acc)
                myFile.Close()
#End Region
            ElseIf choice = 4 Then
#Region "Deposit Amount"
                Console.WriteLine("Enter Your Account No")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)



                Dim getAccount As New XmlSerializer(GetType(Accounts))
                Dim acc As Accounts
                acc = getAccount.Deserialize(file)
                file.Close()
                Console.WriteLine("Enter Amount To Deposit")
                Dim amount As Integer = Console.ReadLine()

                acc.Deposit(amount)
                Console.WriteLine("Deposit Successful - Balance : " & acc.AccBalance)

                Dim myFile As New FileStream(acc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                'step 3 : create a new object of XMLSerializer
                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, acc)
                myFile.Close()
#End Region
            ElseIf choice = 5 Then
            ElseIf choice = 6 Then
                continueProcess = False
                Console.WriteLine("Thank you for Banking with us")


            End If
            Console.WriteLine("          ")
            Console.WriteLine("          ")
            Console.WriteLine("          ")

            Console.WriteLine("Press Enter to continue")
            Console.ReadLine()
            Console.Clear()
        End While




    End Sub

End Module



