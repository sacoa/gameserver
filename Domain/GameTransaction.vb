
Imports DCS.ProjectBase.Core
Imports DCS.PlaycardBase.Core.GameDomain

Public Class GameTransaction
    Inherits DomainObject(Of Long)
    Public Enum GameServerTransactionTypes
        Play = 1
        Collect = 2
        Payout = 3
    End Enum
    Private _game As Game
    Private _transactionType As GameServerTransactionTypes
    Private _transactionReference As Long

    Public Property TransactionReference() As Long
        Get
            Return _transactionReference
        End Get
        Set(ByVal value As Long)
            _transactionReference = value
        End Set
    End Property

    Public Property TransactionType() As GameServerTransactionTypes
        Get
            Return _transactionType
        End Get
        Set(ByVal value As GameServerTransactionTypes)
            _transactionType = value
        End Set
    End Property

    Public Property Game() As Game
        Get
            Return _game
        End Get
        Set(ByVal value As Game)
            _game = value
        End Set
    End Property

    Private _transactionDate As Date
    Public Property TransactionDate() As Date
        Get
            Return _transactionDate
        End Get
        Set(ByVal value As Date)
            _transactionDate = value
        End Set
    End Property

    Public Overrides Function GetHashCode() As Integer

    End Function

End Class
