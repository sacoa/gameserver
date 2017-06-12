Imports DCS.ProjectBase.Core
Public Class Play
    Inherits GameTransaction

    Private _gamePrice As Decimal
    Private _productSelected As GameProduct
    Public Property ProductSelected() As GameProduct
        Get
            Return _productSelected
        End Get
        Set(ByVal value As GameProduct)
            _productSelected = value
        End Set
    End Property
    Public Property GamePrice() As Decimal
        Get
            Return _gamePrice
        End Get
        Set(ByVal value As Decimal)
            _gamePrice = value
        End Set
    End Property


End Class
