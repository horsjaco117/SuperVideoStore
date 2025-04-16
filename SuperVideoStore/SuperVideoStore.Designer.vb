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
        EmailTextBox = New TextBox()
        PhoneTextBox = New TextBox()
        ZipTextBox = New TextBox()
        StateTextBox = New TextBox()
        CityTextBox = New TextBox()
        LastNameTextBox = New TextBox()
        CustomerIDLabel = New Label()
        CustomerIDTextBox = New TextBox()
        EmailLabel = New Label()
        PhoneNumberLabel = New Label()
        ZipLabel = New Label()
        StateLabel = New Label()
        CityLabel = New Label()
        LastNameLabel = New Label()
        FirstNameLabel = New Label()
        FirstNameTextBox = New TextBox()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        ExitButton = New Button()
        UpdateButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(EmailTextBox)
        GroupBox1.Controls.Add(PhoneTextBox)
        GroupBox1.Controls.Add(ZipTextBox)
        GroupBox1.Controls.Add(StateTextBox)
        GroupBox1.Controls.Add(CityTextBox)
        GroupBox1.Controls.Add(LastNameTextBox)
        GroupBox1.Controls.Add(CustomerIDLabel)
        GroupBox1.Controls.Add(CustomerIDTextBox)
        GroupBox1.Controls.Add(EmailLabel)
        GroupBox1.Controls.Add(PhoneNumberLabel)
        GroupBox1.Controls.Add(ZipLabel)
        GroupBox1.Controls.Add(StateLabel)
        GroupBox1.Controls.Add(CityLabel)
        GroupBox1.Controls.Add(LastNameLabel)
        GroupBox1.Controls.Add(FirstNameLabel)
        GroupBox1.Controls.Add(FirstNameTextBox)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(725, 461)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(380, 67)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(150, 31)
        EmailTextBox.TabIndex = 26
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(25, 414)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(150, 31)
        PhoneTextBox.TabIndex = 25
        ' 
        ' ZipTextBox
        ' 
        ZipTextBox.Location = New Point(25, 340)
        ZipTextBox.Name = "ZipTextBox"
        ZipTextBox.Size = New Size(150, 31)
        ZipTextBox.TabIndex = 24
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(12, 266)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(150, 31)
        StateTextBox.TabIndex = 23
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(12, 195)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(150, 31)
        CityTextBox.TabIndex = 22
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(25, 129)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(116, 31)
        LastNameTextBox.TabIndex = 21
        ' 
        ' CustomerIDLabel
        ' 
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New Point(380, 101)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New Size(112, 25)
        CustomerIDLabel.TabIndex = 20
        CustomerIDLabel.Text = "Customer ID"
        ' 
        ' CustomerIDTextBox
        ' 
        CustomerIDTextBox.Location = New Point(380, 129)
        CustomerIDTextBox.Name = "CustomerIDTextBox"
        CustomerIDTextBox.Size = New Size(150, 31)
        CustomerIDTextBox.TabIndex = 19
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
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New Point(25, 375)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(132, 25)
        PhoneNumberLabel.TabIndex = 17
        PhoneNumberLabel.Text = "Phone Number"
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
        ' StateLabel
        ' 
        StateLabel.AutoSize = True
        StateLabel.Location = New Point(25, 238)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New Size(51, 25)
        StateLabel.TabIndex = 15
        StateLabel.Text = "State"
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
        ' LastNameLabel
        ' 
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New Point(25, 101)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New Size(95, 25)
        LastNameLabel.TabIndex = 13
        LastNameLabel.Text = "Last Name"
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
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(25, 61)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(150, 31)
        FirstNameTextBox.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(796, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(442, 411)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(63, 130)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(146, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(52, 59)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(146, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(953, 650)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(112, 34)
        ExitButton.TabIndex = 2
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(796, 650)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(112, 34)
        UpdateButton.TabIndex = 3
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' SuperVideoStore
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 779)
        Controls.Add(UpdateButton)
        Controls.Add(ExitButton)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "SuperVideoStore"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button

End Class
