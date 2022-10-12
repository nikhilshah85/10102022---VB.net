Module Module1

    Sub Main()


#Region "Greetings"
        'decalre varaible
        'Dim guestName As String
        'Console.WriteLine("Please Enter Your Name : ")
        'guestName = Console.ReadLine()
        'Console.WriteLine("Hello and Welcome to VB .Net Development World " + guestName)
#End Region

#Region "Calculation"
        'Dim firstNumber As Integer
        'Dim secondNumber As Integer

        'Dim addResult As Integer
        'Dim subResult As Integer
        'Dim mulResult As Integer
        'Dim divResult As Integer

        'Console.WriteLine("Enter First Number")
        'firstNumber = Convert.ToInt32(Console.ReadLine())

        'Console.WriteLine("Enter Second Number")
        'secondNumber = Convert.ToInt32(Console.ReadLine())

        'addResult = firstNumber + secondNumber
        'subResult = firstNumber - secondNumber
        'mulResult = firstNumber * secondNumber
        'divResult = firstNumber / secondNumber

        'Console.WriteLine("Addition : " & addResult)
        'Console.WriteLine("Subtraction : " & subResult)
        'Console.WriteLine("Multiplication : " & mulResult)
        'Console.WriteLine("Division : " & divResult)

        'Console.ReadLine()
#End Region

#Region "If Condition"
        'Dim number As Integer
        'Console.WriteLine("Enter a number : ")
        'number = Console.ReadLine()

        'If number < 0 Then
        '    Console.WriteLine("This is a Negative number")

        'ElseIf number > 100 Then
        '    Console.WriteLine("This more than 100, we expected a number between 0 and 100")
        'Else
        '    Console.WriteLine("Thank you, this is a good number")
        'End If
#End Region

#Region "CTC Calculation"
        Console.WriteLine("!! ~~~~~~~~~~~~  Welcome to CTC Calculation APP ~~~~~~~~~~~~~~ !!")
        Console.WriteLine("Please enter monthly basic salary ")

        Dim basic As Integer
        Dim city As String
        Dim cityAllowance As Integer
        Dim pf As Integer = 1200
        Dim dearnessAllowance As Integer = 1500
        Dim transportAllowance As Integer = 1000
        Dim foodCoupns As Integer = 1000
        Dim ctc As Integer

        basic = Console.ReadLine()

        Console.WriteLine("Enter Work City location ")
        city = Console.ReadLine()

        If city = "Mumbai" Then
            cityAllowance = 600
        ElseIf city = "Chennai" Then
            cityAllowance = 800
        ElseIf city = "Bangalore" Then
            cityAllowance = 1200
        End If
        ctc = (basic + cityAllowance + pf + dearnessAllowance + transportAllowance + foodCoupns)
        ctc = ctc * 12
        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("Basic Salary       : " & (basic * 12))
        Console.WriteLine("City Allowance     : " & cityAllowance * 12)
        Console.WriteLine("Provident Funds    : " & pf * 12)
        Console.WriteLine("Dearness Allowance : " & dearnessAllowance * 12)
        Console.WriteLine("Transport Allowance: " & transportAllowance * 12)
        Console.WriteLine("Food Coupns        : " & foodCoupns * 12)
        Console.WriteLine("Cost To Company    : " & ctc)










#End Region



    End Sub

End Module
