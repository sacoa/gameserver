Imports DCS.ProjectBase.Core

Public Class Payment
    Private _counterTransaction As CounterTransaction
    'Private _creditCardTransaction As DCS.
    Private _appliedPlaycardStatus As DCS.PlaycardBase.Core.CardDomain.PlaycardStatus
    Private _amountPaid As Decimal
    Public Property AmountPaid() As Decimal
        Get
            Return _amountPaid
        End Get
        Set(ByVal value As Decimal)
            _amountPaid = value
        End Set
    End Property
    Public Property AppliedPlaycardStatus() As DCS.PlaycardBase.Core.CardDomain.PlaycardStatus
        Get
            Return _appliedPlaycardStatus
        End Get
        Set(ByVal value As DCS.PlaycardBase.Core.CardDomain.PlaycardStatus)
            _appliedPlaycardStatus = value
        End Set
    End Property
    Public Property CounterTransaction() As CounterTransaction
        Get
            Return _counterTransaction
        End Get
        Set(ByVal value As CounterTransaction)
            _counterTransaction = value
        End Set
    End Property
End Class
