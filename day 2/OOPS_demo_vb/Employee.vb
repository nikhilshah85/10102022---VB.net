Public Class Employee



    Private v_empNo As Integer
    Public Property EmployeeNumber() As Integer
        Get
            Return v_empNo
        End Get
        Set(ByVal value As Integer)
            v_empNo = value
        End Set
    End Property

    Private v_empName As String
    Public Property EmployeeName() As String
        Get
            Return v_empName
        End Get
        Set(ByVal value As String)
            v_empName = value
        End Set
    End Property

    Private v_empDesigantion As String
    Public Property EmployeeDesignation() As String
        Get
            Return v_empDesigantion
        End Get
        Set(ByVal value As String)
            v_empDesigantion = value
        End Set
    End Property


    Private v_empSalary As Double
    Public Property EmployeeSalary() As Double
        Get
            Return v_empSalary
        End Get
        Set(ByVal value As Double)
            v_empSalary = value
        End Set
    End Property

    Private v_empAvaialbleLeave As Integer
    Public Property EmployeeAvailableLeaves() As Integer
        Get
            Return v_empAvaialbleLeave
        End Get
        Set(ByVal value As Integer)
            v_empAvaialbleLeave = value
        End Set
    End Property

    Function Bonus(percentage As Integer) As Integer
        Dim bonusResult As Integer = EmployeeSalary * percentage / 100
        Return bonusResult
    End Function

    Function ApplyLeave(days As Integer) As Integer
        EmployeeAvailableLeaves = EmployeeAvailableLeaves - days
        Return EmployeeAvailableLeaves
    End Function

End Class








