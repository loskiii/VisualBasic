Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private WithEvents btnLoadObjectDemo As Button
    Private WithEvents btnExit As Button

    Public Sub New()
        Me.Text = "Welcoming Form"
        Me.Size = New Size(300, 200)
        Me.BackColor = Color.Red

        btnLoadObjectDemo = New Button()
        btnLoadObjectDemo.Text = "Load Object"
        btnLoadObjectDemo.Name = "btnLoadObjectDemo"
        btnLoadObjectDemo.Size = New Size(100, 30)
        btnLoadObjectDemo.Location = New Point(50, 50)
        Me.Controls.Add(btnLoadObjectDemo)

        btnExit = New Button()
        btnExit.Text = "Exit"
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(100, 30)
        btnExit.Location = New Point(170, 50)
        Me.Controls.Add(btnExit)

        AddHandler btnLoadObjectDemo.Click, AddressOf btnLoadObjectDemo_Click
        AddHandler btnExit.Click, AddressOf btnExit_Click
    End Sub

    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs)
        Dim objectDemoForm As New ObjectDemoForm()
        objectDemoForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Shared Sub Main()
        Application.Run(New MainForm())
    End Sub
End Class

Public Class ObjectDemoForm
    Inherits Form

    Public Sub New()
        Me.Text = "Object Demonstrations"
        Me.Size = New Size(300, 200)
    End Sub
End Class
