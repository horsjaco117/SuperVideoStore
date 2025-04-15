<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuperVideoStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        FirstNameTextBox = New TextBox()
        Me.LastNameTextBox = New TextBox()
        Me.CityTextBox = New TextBox()
        Me.StateTextBox = New TextBox()
        Me.ZipTextBox = New TextBox()
        Me.PhoneNumberTextBox = New TextBox()
        Me.EmailAddressTextBox = New TextBox()
        FirstNameLabel = New Label()
        LastNameLabel = New Label()
        CityLabel = New Label()
        StateLabel = New Label()
        ZipLabel = New Label()
        PhoneNumberLabel = New Label()
        EmailLabel = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(EmailLabel)
        GroupBox1.Controls.Add(PhoneNumberLabel)
        GroupBox1.Controls.Add(ZipLabel)
        GroupBox1.Controls.Add(StateLabel)
        GroupBox1.Controls.Add(CityLabel)
        GroupBox1.Controls.Add(LastNameLabel)
        GroupBox1.Controls.Add(FirstNameLabel)
        GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        GroupBox1.Controls.Add(Me.ZipTextBox)
        GroupBox1.Controls.Add(Me.StateTextBox)
        GroupBox1.Controls.Add(Me.CityTextBox)
        GroupBox1.Controls.Add(Me.LastNameTextBox)
        GroupBox1.Controls.Add(FirstNameTextBox)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(725, 461)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(25, 61)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(150, 31)
        FirstNameTextBox.TabIndex = 0
        ' 
        ' LastNameTextBox
        ' 
        Me.LastNameTextBox.Location = New Point(25, 129)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New Size(150, 31)
        Me.LastNameTextBox.TabIndex = 1
        ' 
        ' CityTextBox
        ' 
        Me.CityTextBox.Location = New Point(25, 195)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New Size(150, 31)
        Me.CityTextBox.TabIndex = 2
        ' 
        ' StateTextBox
        ' 
        Me.StateTextBox.Location = New Point(25, 266)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New Size(150, 31)
        Me.StateTextBox.TabIndex = 3
        ' 
        ' ZipTextBox
        ' 
        Me.ZipTextBox.Location = New Point(25, 340)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New Size(150, 31)
        Me.ZipTextBox.TabIndex = 4
        ' 
        ' PhoneNumberTextBox
        ' 
        Me.PhoneNumberTextBox.Location = New Point(25, 403)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New Size(150, 31)
        Me.PhoneNumberTextBox.TabIndex = 5
        ' 
        ' EmailAddressTextBox
        ' 
        Me.EmailAddressTextBox.Location = New Point(380, 61)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New Size(150, 31)
        Me.EmailAddressTextBox.TabIndex = 6
        ' 
        ' FirstNameLabel
        ' 
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New Point(25, 33)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New Size(97, 25)
        FirstNameLabel.TabIndex = 12
        FirstNameLabel.Text = "First Name"
        ' 
        ' LastNameLabel
        ' 
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New Point(25, 101)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New Size(95, 25)
        LastNameLabel.TabIndex = 13
        LastNameLabel.Text = "Last Name"
        ' 
        ' CityLabel
        ' 
        CityLabel.AutoSize = True
        CityLabel.Location = New Point(25, 167)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New Size(42, 25)
        CityLabel.TabIndex = 14
        CityLabel.Text = "City"
        ' 
        ' StateLabel
        ' 
        StateLabel.AutoSize = True
        StateLabel.Location = New Point(25, 238)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New Size(51, 25)
        StateLabel.TabIndex = 15
        StateLabel.Text = "State"
        ' 
        ' ZipLabel
        ' 
        ZipLabel.AutoSize = True
        ZipLabel.Location = New Point(25, 312)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New Size(37, 25)
        ZipLabel.TabIndex = 16
        ZipLabel.Text = "Zip"
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New Point(25, 375)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(132, 25)
        PhoneNumberLabel.TabIndex = 17
        PhoneNumberLabel.Text = "Phone Number"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(380, 33)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(124, 25)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email Address"
        ' 
        ' SuperVideoStore
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 779)
        Controls.Add(GroupBox1)
        Name = "SuperVideoStore"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FirstNameTextBox As TextBox

End Class
