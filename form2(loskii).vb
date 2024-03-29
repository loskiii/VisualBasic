Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private WithEvents nameLabel As Label
    Private WithEvents nameTextBox As TextBox
    Private WithEvents fontFamilyGaramond As RadioButton
    Private WithEvents fontFamilyMagneto As RadioButton
    Private WithEvents fontFamilyTahoma As RadioButton
    Private WithEvents fontStyleItalic As RadioButton
    Private WithEvents fontStyleBold As RadioButton
    Private WithEvents fontStyleBoldItalic As RadioButton
    Private WithEvents fontColorRed As RadioButton
    Private WithEvents fontColorBlue As RadioButton
    Private WithEvents fontColorGreen As RadioButton
    Private WithEvents displayImageCheckbox As CheckBox
    Private WithEvents addButton As Button
    Private WithEvents exitButton As Button

    Public Sub New()
        Me.Text = "Form with Text Field and Toggles"
        Me.Size = New Size(400, 400)

        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        nameLabel = New Label()
        nameLabel.Text = "Name:"
        nameLabel.Location = New Point(20, 20)
        nameLabel.AutoSize = True

        nameTextBox = New TextBox()
        nameTextBox.Location = New Point(100, 20)
        nameTextBox.Size = New Size(200, 20)

        fontFamilyGaramond = New RadioButton()
        fontFamilyGaramond.Text = "Garamond"
        fontFamilyGaramond.Location = New Point(20, 50)

        fontFamilyMagneto = New RadioButton()
        fontFamilyMagneto.Text = "Magneto"
        fontFamilyMagneto.Location = New Point(120, 50)

        fontFamilyTahoma = New RadioButton()
        fontFamilyTahoma.Text = "Tahoma"
        fontFamilyTahoma.Location = New Point(220, 50)

        fontStyleItalic = New RadioButton()
        fontStyleItalic.Text = "Italic"
        fontStyleItalic.Location = New Point(20, 80)

        fontStyleBold = New RadioButton()
        fontStyleBold.Text = "Bold"
        fontStyleBold.Location = New Point(120, 80)

        fontStyleBoldItalic = New RadioButton()
        fontStyleBoldItalic.Text = "Bold Italic"
        fontStyleBoldItalic.Location = New Point(220, 80)

        fontColorRed = New RadioButton()
        fontColorRed.Text = "Red"
        fontColorRed.Location = New Point(20, 110)

        fontColorBlue = New RadioButton()
        fontColorBlue.Text = "Blue"
        fontColorBlue.Location = New Point(120, 110)

        fontColorGreen = New RadioButton()
        fontColorGreen.Text = "Green"
        fontColorGreen.Location = New Point(220, 110)

        displayImageCheckbox = New CheckBox()
        displayImageCheckbox.Text = "Display Image"
        displayImageCheckbox.Location = New Point(20, 140)

        addButton = New Button()
        addButton.Text = "Load Image"
        addButton.Location = New Point(150, 140)

        exitButton = New Button()
        exitButton.Text = "Exit"
        exitButton.Location = New Point(280, 140)

        AddHandler addButton.Click, AddressOf AddImageButton_Click
        AddHandler exitButton.Click, AddressOf ExitButton_Click

        AddHandler fontFamilyGaramond.CheckedChanged, AddressOf FontFamily_CheckedChanged
        AddHandler fontFamilyMagneto.CheckedChanged, AddressOf FontFamily_CheckedChanged
        AddHandler fontFamilyTahoma.CheckedChanged, AddressOf FontFamily_CheckedChanged

        AddHandler fontStyleItalic.CheckedChanged, AddressOf FontStyle_CheckedChanged
        AddHandler fontStyleBold.CheckedChanged, AddressOf FontStyle_CheckedChanged
        AddHandler fontStyleBoldItalic.CheckedChanged, AddressOf FontStyle_CheckedChanged

        AddHandler fontColorRed.CheckedChanged, AddressOf FontColor_CheckedChanged
        AddHandler fontColorBlue.CheckedChanged, AddressOf FontColor_CheckedChanged
        AddHandler fontColorGreen.CheckedChanged, AddressOf FontColor_CheckedChanged

        Me.Controls.Add(nameLabel)
        Me.Controls.Add(nameTextBox)
        Me.Controls.Add(fontFamilyGaramond)
        Me.Controls.Add(fontFamilyMagneto)
        Me.Controls.Add(fontFamilyTahoma)
        Me.Controls.Add(fontStyleItalic)
        Me.Controls.Add(fontStyleBold)
        Me.Controls.Add(fontStyleBoldItalic)
        Me.Controls.Add(fontColorRed)
        Me.Controls.Add(fontColorBlue)
        Me.Controls.Add(fontColorGreen)
        Me.Controls.Add(displayImageCheckbox)
        Me.Controls.Add(addButton)
        Me.Controls.Add(exitButton)
    End Sub

    Private Sub AddImageButton_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image File"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            Dim pictureBox As New PictureBox()
            pictureBox.ImageLocation = imagePath
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Size = New Size(200, 200)
            pictureBox.Location = New Point(100, 200)
            Me.Controls.Add(pictureBox)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub FontFamily_CheckedChanged(sender As Object, e As EventArgs)
        If fontFamilyGaramond.Checked Then
            nameTextBox.Font = New Font("Garamond", nameTextBox.Font.Size, nameTextBox.Font.Style)
        ElseIf fontFamilyMagneto.Checked Then
            nameTextBox.Font = New Font("Magneto", nameTextBox.Font.Size, nameTextBox.Font.Style)
        ElseIf fontFamilyTahoma.Checked Then
            nameTextBox.Font = New Font("Tahoma", nameTextBox.Font.Size, nameTextBox.Font.Style)
        End If
    End Sub

    Private Sub FontStyle_CheckedChanged(sender As Object, e As EventArgs)
        If fontStyleItalic.Checked Then
            nameTextBox.Font = New Font(nameTextBox.Font.FontFamily, nameTextBox.Font.Size, FontStyle.Italic)
        ElseIf fontStyleBold.Checked Then
            nameTextBox.Font = New Font(nameTextBox.Font.FontFamily, nameTextBox.Font.Size, FontStyle.Bold)
        ElseIf fontStyleBoldItalic.Checked Then
            nameTextBox.Font = New Font(nameTextBox.Font.FontFamily, nameTextBox.Font.Size, FontStyle.Bold Or FontStyle.Italic)
        End If
    End Sub

    Private Sub FontColor_CheckedChanged(sender As Object, e As EventArgs)
        If fontColorRed.Checked Then
            nameTextBox.ForeColor = Color.Red
        ElseIf fontColorBlue.Checked Then
            nameTextBox.ForeColor = Color.Blue
        ElseIf fontColorGreen.Checked Then
            nameTextBox.ForeColor = Color.Green
        End If
    End Sub

    Public Shared Sub Main()
        Application.Run(New Form1())
    End Sub

End Class
