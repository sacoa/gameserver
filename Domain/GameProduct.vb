Imports DCS.ProjectBase.Core

Public Class GameProduct
    Inherits DomainObject(Of Long)

    Private _name As String
    Private _gameInfo As DCS.PlaycardBase.Core.GameDomain.GameInfo
    Private _defaultPrice As Decimal
    Private _currentPrice As Decimal
    Private _playsQuantity As Integer
    Private _isDefault As Boolean
    Public Property IsDefault() As Boolean
        Get
            Return _isDefault
        End Get
        Set(ByVal value As Boolean)
            _isDefault = value
        End Set
    End Property
    Public Property PlaysQuantity() As Short
        Get
            Return _playsQuantity
        End Get
        Set(ByVal value As Short)
            _playsQuantity = value
        End Set
    End Property
    Public Property NewProperty() As Decimal
        Get
            Return _currentPrice
        End Get
        Set(ByVal value As Decimal)
            _currentPrice = value
        End Set
    End Property

    Public Property DefaultPrice() As Decimal
        Get
            Return _defaultPrice
        End Get
        Set(ByVal value As Decimal)
            _defaultPrice = value
        End Set
    End Property
    Public Property GameInfo() As DCS.PlaycardBase.Core.GameDomain.GameInfo
        Get
            Return _gameInfo
        End Get
        Set(ByVal value As DCS.PlaycardBase.Core.GameDomain.GameInfo)
            _gameInfo = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Overrides Function GetHashCode() As Integer
        Throw New NotImplementedException()
    End Function
End Class
