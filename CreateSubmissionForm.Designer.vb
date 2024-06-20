<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnToggleStopwatch = New Button()
        txtStopwatchTime = New TextBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(362, 77)
        txtName.Name = "txtName"
        txtName.Size = New Size(332, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(362, 147)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(332, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(362, 218)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(332, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(362, 290)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(332, 31)
        txtGithubLink.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(128, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 4
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(128, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 5
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(128, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 6
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(128, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 25)
        Label4.TabIndex = 7
        Label4.Text = "Git Hub Link For Task 2"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(118, 362)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(403, 34)
        btnToggleStopwatch.TabIndex = 8
        btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.ButtonShadow
        txtStopwatchTime.Location = New Point(614, 362)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(332, 31)
        txtStopwatchTime.TabIndex = 9
        txtStopwatchTime.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnSubmit.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(128, 465)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(748, 34)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1257, 711)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatchTime)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "vikas Swami, Slodely AI task 2 - CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
End Class
