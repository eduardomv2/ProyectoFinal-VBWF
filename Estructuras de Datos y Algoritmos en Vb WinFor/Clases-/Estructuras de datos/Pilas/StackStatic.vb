Public Class StackStatic(Of T)
    Private Elements As T()
    Public Ability As Integer
    Private Contain As Integer

    Public Sub New(ability As Integer)
        Me.Ability = ability
        Me.Elements = New T(ability - 1) {}
        Me.Contain = 0
    End Sub

    Public Sub New()
        Me.Ability = 0
        Me.Elements = New T(0) {}
        Me.Contain = 0
    End Sub

    Public Sub Push(element As T)
        If Count < Ability Then
            Elements(Contain) = element
            Contain += 1
        Else
            MessageBox.Show("Static Stack Full!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function Pop() As T
        If Contain > 0 Then
            Contain -= 1
            Dim elemento As T = Elements(Contain)
            Elements(Contain) = Nothing ' Restablecer el valor a su valor predeterminado
            Return elemento
        Else
            MessageBox.Show("Void Static Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing ' Valor predeterminado para el tipo T (por ejemplo, null para referencias)
        End If
    End Function

    Public Function Peek() As T
        If Contain > 0 Then
            MessageBox.Show($"Peek Static Stack: {Elements(Contain - 1)}", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Elements(Contain - 1)
        Else
            MessageBox.Show("Void Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing ' Valor predeterminado para el tipo T
        End If
    End Function

    Public Function Show(stack As StackStatic(Of T)) As String
        Dim Message As String = ""
        If stack.Count = 0 Then
            Return Message
        End If

        While stack.Count > 0
            Message += stack.Pop().ToString()
        End While

        Return Message
    End Function

    Public ReadOnly Property Count As Integer
        Get
            Return Contain
        End Get
    End Property

    Public Function ToString2() As String()
        Dim r As String() = New String(Me.Count - 1) {}
        For i As Integer = 0 To Count - 1
            r(i) += Elements(i).ToString()
        Next
        Return r
    End Function

End Class
