Module Module1

    Sub Main()

#Region "Accounts Obj"

        'Dim accObj1 As New Accounts() 'this is create a new object 
        'accObj1.AccountNumber = 101
        'accObj1.AccountName = "Nikhil"
        'accObj1.AccountBalance = 5000
        'accObj1.AccountIsActive = True

        'Console.WriteLine("Account Number : " & accObj1.AccountNumber)
        'Console.WriteLine("Account Name : " & accObj1.AccountName)
        'Console.WriteLine("Account Balance : " & accObj1.AccountBalance)
        'Console.WriteLine("Account Is Active : " & accObj1.AccountIsActive)


        'Console.WriteLine("Enter Choice")
        'Console.WriteLine("1. Widraw")
        'Console.WriteLine("2. Deposit")
        'Dim choice As Integer = Console.ReadLine()

        'If choice = 1 Then
        '    accObj1.Widraw(700)
        'Else
        '    accObj1.Deposit(700)
        'End If
        'Console.WriteLine("Balance after transaction : " & accObj1.AccountBalance)
#End Region


        Dim savObj As New Savings()

        savObj.AccountBalance = 6000

        Console.WriteLine("Available balance : " & savObj.AccountBalance)

        savObj.Widraw(1800)
        Console.WriteLine("Available balance : " & savObj.AccountBalance)


        savObj.IntrestRate = 8
    End Sub

End Module
