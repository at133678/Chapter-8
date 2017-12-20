Public Class LotteryNumbers

    Private Sub GenerateNumbers_Click(sender As Object, e As EventArgs) Handles Generate.Click
        'Create an array to hold five lottery numbers.
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        'Create Random Object.
        Dim rand As New Random

        'Fill the arraywith random numbers.
        'Each number will be in the range 0-99.
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        'Display the array elements in the labels.
        lblOne.Text = intNumbers(0).ToString
        lblTwo.Text = intNumbers(1).ToString
        lblThree.Text = intNumbers(2).ToString
        lblFour.Text = intNumbers(3).ToString
        lblFive.Text = intNumbers(4).ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
