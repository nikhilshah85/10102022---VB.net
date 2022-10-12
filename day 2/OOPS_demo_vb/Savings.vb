Public Class Savings
    Inherits Accounts


    'this class object, savings class object will now have all the properties and methods from Parent
    ' additionally can have its own properties and methods as well

    Private v_intrestRate As Integer
    Public Property IntrestRate() As Integer
        Get
            Return v_intrestRate
        End Get
        Set(ByVal value As Integer)
            v_intrestRate = value
        End Set
    End Property
End Class
