Public Class NegativeAgeException
    Inherits ApplicationException
    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim input As String = TextBox1.Text
            Dim age As Integer = Integer.Parse(input)

            ' Check if age is negative
            If age < 0 Then
                Throw New NegativeAgeException("Age cannot be negative.")
            End If

            MessageBox.Show("Your age is: " & age.ToString())

        Catch ex As FormatException
            MessageBox.Show("Please enter a valid number for age.")

        Catch ex As NegativeAgeException
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
