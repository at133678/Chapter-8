Public Class listFriends
    Private lstNames As New List(Of String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstNames.Add(txtNames.Text)
        txtNames.Clear()
        txtNames.Focus()

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim strName As String
        lstFriend.Items.Clear()

        For Each strName In lstNames
            lstFriend.Items.Add(strName)
        Next

    End Sub
End Class
