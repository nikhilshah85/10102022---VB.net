Imports System.Data
Imports System.Data.SqlClient
Module Module1

    Sub Main()


        Dim continueOperations As Boolean = True

        While continueOperations




            Dim con As New SqlConnection("server=WIN8\NIKHILINSTANCE;database=bankingDB_VB;integrated security=true")
        Dim cmd_checkLogin As New SqlCommand("select count(*) from loginInfo where userName=@uName and password=@pwd", con)

        Console.WriteLine("Enter User Name")
        Dim userName As String = Console.ReadLine()

        Console.WriteLine("Enter Password")
        Dim password As String = Console.ReadLine()

        cmd_checkLogin.Parameters.AddWithValue("@uName", userName)
        cmd_checkLogin.Parameters.AddWithValue("@pwd", password)

        con.Open()

        Dim result As Integer = cmd_checkLogin.ExecuteScalar()
        If result = 1 Then

            Console.Clear()
            Console.WriteLine(" Welcome " & userName)
            Console.WriteLine("1. Check Account Details")
            Console.WriteLine("2. Create New Account")
            Console.WriteLine("3. Delete Account")
            Console.WriteLine("4. Update Account")
            Console.WriteLine("5. Summary")
            Console.WriteLine("6. Exit")

            Dim choice As Integer = Console.ReadLine()

            If choice = 1 Then
#Region "Reader - Execute Reader"


                Dim cmd_readAccount As New SqlCommand("select * from accounts where accNo =@accNo", con)

                Console.WriteLine("Enter Account No")
                Dim accNo As Integer = Console.ReadLine()
                cmd_readAccount.Parameters.AddWithValue("@accNo", accNo)

                con.Open()

                Dim read As SqlDataReader = cmd_readAccount.ExecuteReader()

                If read.Read() Then


                    Console.WriteLine("Account Number    : " & read(0))
                    Console.WriteLine("Account Name      : " & read(1))
                    Console.WriteLine("Account Type      : " & read(2))
                    Console.WriteLine("Account Balance   : " & read(3))
                    Console.WriteLine("Account Is Active : " & read(4))

                Else

                    Console.WriteLine("Invalid Account Number")
                End If
                con.Close()


#End Region
            ElseIf choice = 2 Then
#Region "Create New Account"


                Console.WriteLine("Enter Account Number")
                Dim accNo As Integer = Console.ReadLine()

                Console.WriteLine("Enter Account Name")
                Dim accName As String = Console.ReadLine()

                Console.WriteLine("Enter Account Type")
                Dim accType As String = Console.ReadLine()

                Console.WriteLine("Enter Account Balance")
                Dim accBalance As Double = Console.ReadLine()

                Console.WriteLine("Enter Account Is Active")
                Dim accIsActive As Boolean = Console.ReadLine()

                Dim cmd_insert As New SqlCommand("insert into Accounts values(@accNo,@accName,@accType,@accBalance,@accIsActive)", con)
                cmd_insert.Parameters.AddWithValue("@accNo", accNo)
                cmd_insert.Parameters.AddWithValue("@accName", accName)
                cmd_insert.Parameters.AddWithValue("@accType", accType)
                cmd_insert.Parameters.AddWithValue("@accBalance", accBalance)
                cmd_insert.Parameters.AddWithValue("@accIsActive", accIsActive)
                con.Open()
                cmd_insert.ExecuteNonQuery()
                con.Close()
                Console.WriteLine("Account Created Successfully")
#End Region
            ElseIf choice = 3 Then
#Region "Delete Account"


                Dim cmd_delete As New SqlCommand("delete from accounts where accNo = @accNo", con)

                Console.WriteLine("Enter Account No to delete")
                Dim accNo As Integer = Console.ReadLine()

                cmd_delete.Parameters.AddWithValue("@accNo", accNo)

                con.Open()

                result = cmd_delete.ExecuteNonQuery()

                If result = 1 Then
                    Console.WriteLine("Account Delete Successully")
                Else
                    Console.WriteLine("Invalid Account Number")
                End If

                con.Close()


#End Region
            ElseIf choice = 4 Then
                Console.WriteLine("Feature coming soon")
            ElseIf choice = 5 Then
#Region "Summary"


                Dim cmd_count As New SqlCommand("select count(*) from accounts", con)
                Dim cmd_sumBalance As New SqlCommand("select sum(accBalance) from accounts", con)
                Dim cmd_minBalance As New SqlCommand("select min(accBalance) from accounts", con)
                Dim cmd_maxBalance As New SqlCommand("select max(accBalance) from accounts", con)
                Dim cmd_avgBalance As New SqlCommand("select avg(accBalance) from accounts", con)

                con.Open()

                Dim totalAccounts As Integer = cmd_count.ExecuteScalar()
                Dim totalBalance As Integer = cmd_sumBalance.ExecuteScalar()
                Dim minBalance As Integer = cmd_minBalance.ExecuteScalar()
                Dim maxBalance As Integer = cmd_maxBalance.ExecuteScalar()
                Dim avgBalance As Integer = cmd_avgBalance.ExecuteScalar()


                con.Close()

                Console.WriteLine("Total Accounts  :" & totalAccounts)
                Console.WriteLine("Total Balance   : " & totalBalance)
                Console.WriteLine("Minimum Balance : " & minBalance)
                Console.WriteLine("Maximum Balance : " & maxBalance)
                Console.WriteLine("Average Balance :" & avgBalance)

#End Region
            Else
                Console.Clear()
                Console.WriteLine("Thank you for banking")



            End If
        Else
            Console.WriteLine("Invalid Credential")

        End If

            con.Close()
        End While

    End Sub

End Module
