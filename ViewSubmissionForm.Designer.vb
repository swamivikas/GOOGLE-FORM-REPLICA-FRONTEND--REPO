<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForm
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
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ButtonShadow
        txtName.Location = New Point(405, 58)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(472, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonShadow
        txtEmail.Location = New Point(405, 127)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(472, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ButtonShadow
        txtPhone.Location = New Point(405, 199)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(472, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.ButtonShadow
        txtGithubLink.Location = New Point(405, 267)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(472, 31)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.ButtonShadow
        txtStopwatchTime.Location = New Point(405, 339)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(472, 31)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.Text = "00:00:00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(140, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(145, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 6
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(145, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 7
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(145, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 25)
        Label4.TabIndex = 8
        Label4.Text = "Git Hub Link For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(140, 342)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 25)
        Label5.TabIndex = 9
        Label5.Text = "Stopwatch Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(29, 505)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(348, 34)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnNext.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(826, 505)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(357, 34)
        btnNext.TabIndex = 11
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(531, 505)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(164, 34)
        btnDelete.TabIndex = 12
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Fuchsia
        btnEdit.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(182, 433)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(436, 34)
        btnEdit.TabIndex = 13
        btnEdit.Text = "EDIT(PLEASE CLICK ON SAVE AFTER EDITING)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Cyan
        btnSave.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(796, 433)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(297, 34)
        btnSave.TabIndex = 14
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1254, 640)
        Controls.Add(btnSave)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "ViewSubmissionForm"
        Text = "vikas Swami, Slodely AI task 2 - ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
End Class
