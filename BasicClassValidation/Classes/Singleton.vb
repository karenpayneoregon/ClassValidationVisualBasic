Public NotInheritable Class ApplicationData
    Private Sub New()
    End Sub

    Public Property AccountNumber() As String
    Private Shared ReadOnly Lazy As New Lazy(Of ApplicationData)(Function() New ApplicationData())
    Public Shared ReadOnly Property Instance() As ApplicationData
        Get
            Return Lazy.Value
        End Get
    End Property
End Class