Imports DCS.ProjectBase.Core

Public Class Paymode
    Inherits DomainObject(Of Short)
    Private _name As String
    Private _paymodeType As Byte
    Public Property PaymodeType() As Byte
        Get
            Return _paymodeType
        End Get
        Set(ByVal value As Byte)
            _paymodeType = value
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
