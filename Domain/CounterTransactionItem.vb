Imports DCS.ProjectBase.Core
Imports DCS.PlaycardBase.Core.GeneralDomain

Public Class CounterTransactionItem
    Private _counterType As DCS.PlaycardBase.Core.GeneralDomain.CounterType
    Private _amount As Decimal
    Public Property Amount() As Decimal
        Get
            Return _amount
        End Get
        Set(ByVal value As Decimal)
            _amount = value
        End Set
    End Property
    Public Property CounterType() As DCS.PlaycardBase.Core.GeneralDomain.CounterType
        Get
            Return _counterType
        End Get
        Set(ByVal value As DCS.PlaycardBase.Core.GeneralDomain.CounterType)
            _counterType = value
        End Set
    End Property
End Class
