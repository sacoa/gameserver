Imports DCS.ProjectBase.Core
Imports Iesi.Collections.Generic

Public Class CounterTransaction
    Inherits DomainObject(Of Long)

    Private _cardNumber As Long
    Private _items As ISet(Of CounterTransactionItem) = New HashedSet(Of CounterTransactionItem)

    Public Property Items() As ISet(Of CounterTransactionItem)
        Get
            Return _items
        End Get
        Set(ByVal value As ISet(Of CounterTransactionItem))
            _items = value
        End Set
    End Property
    Public Property CardNumber() As Long
        Get
            Return _cardNumber
        End Get
        Set(ByVal value As Long)
            _cardNumber = value
        End Set
    End Property
    Public Overrides Function GetHashCode() As Integer
        Throw New NotImplementedException()
    End Function
End Class
