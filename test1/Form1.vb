Public Class Form1
    Dim numbers(4) As Integer
    Dim numberInputCount As Integer = 0
    Dim allIndex As Integer = 0
    Private Sub EnterNumber_Click(sender As Object, e As EventArgs) Handles EnterNumber.Click
        If numberInputCount <= 4 Then
            numbers(numberInputCount) = Number1.Value
            numberInputCount += 1
        Else
            MsgBox("Hard Limit is 5")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each num As Integer In numbers
            NumberList.Items.Add(numbers(allIndex))
            allIndex += 1
        Next
    End Sub
End Class
