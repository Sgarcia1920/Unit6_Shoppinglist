Public Class Product


    Private _nameProduct As String
    Public Property NameProduct As String
        Get
            Return _nameProduct
        End Get
        Set(ByVal value As String)
            _nameProduct = value
        End Set
    End Property
    Private _price As Decimal
    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value
        End Set
    End Property

    Public Sub New()
        _nameProduct = ""
        _Price = 0
    End Sub
    Public Sub New(ByVal nameproduct As String, ByVal price As Decimal)
        _nameProduct = nameproduct
        _price = price
    End Sub

    Public Overrides Function ToString() As String
        Return _nameProduct & " - " & _price
    End Function


End Class
