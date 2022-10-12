Public Class Accounts



    Private v_accNo As Integer
    Public Property AccNo() As Integer
        Get
            Return v_accNo
        End Get
        Set(ByVal value As Integer)
            v_accNo = value
        End Set
    End Property

    Private v_accName As String
    Public Property AccName() As String
        Get
            Return v_accName
        End Get
        Set(ByVal value As String)
            v_accName = value
        End Set
    End Property
    Private v_accBalance As Double
    Public Property AccBalance() As Double
        Get
            Return v_accBalance
        End Get
        Set(ByVal value As Double)
            v_accBalance = value
        End Set
    End Property
    Private v_accIsActive As Boolean
    Public Property AccIsActive() As Boolean
        Get
            Return v_accIsActive
        End Get
        Set(ByVal value As Boolean)
            v_accIsActive = value
        End Set
    End Property

    Function Widraw(amount As Integer) As Integer
        AccBalance = AccBalance - amount
        Return AccBalance
    End Function

    Function Deposit(amount As Integer) As Integer
        AccBalance = AccBalance + amount
        Return AccBalance
    End Function
End Class
