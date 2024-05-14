Imports System.Collections

Public Class Form1
    Dim usernames As New ArrayList()
    Dim passwords As New ArrayList()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = TextBox3.Text Then
            ' Passwords match, add username and password to the ArrayLists
            usernames.Add(TextBox1.Text)
            passwords.Add(TextBox2.Text)
            MessageBox.Show("User registered successfully!")

            ' Show Form2 and pass the ArrayLists
            Dim form2Instance As New Form2(usernames, passwords)
            form2Instance.Show()
            Me.Hide()

        Else
            ' Passwords don't match, display an error message
            MessageBox.Show("Passwords do not match. Please try again.")
        End If
    End Sub

    ' Function to retrieve usernames ArrayList
    Public Function GetUsernames() As ArrayList
        Return usernames
    End Function

    ' Function to retrieve passwords ArrayList
    Public Function GetPasswords() As ArrayList
        Return passwords
    End Function
End Class
