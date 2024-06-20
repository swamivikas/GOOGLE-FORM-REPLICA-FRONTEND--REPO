Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission) = New List(Of Submission)

    Private Async Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        submissions = Await GetSubmissionsFromBackend()
        If submissions.Count > 0 Then
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub ShowSubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Async Function GetSubmissionsFromBackend() As Task(Of List(Of Submission))
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/submissions")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim data As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                Return data
            Else
                MessageBox.Show("Failed to fetch submissions.")
                Return New List(Of Submission)()
            End If
        End Using
    End Function


    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Using client As New HttpClient()
                Dim url As String = $"http://localhost:3000/submissions/{currentIndex}" ' Adjust URL to match your Node.js API endpoint
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)

                If response.IsSuccessStatusCode Then
                    ' Remove the deleted submission from the local list
                    submissions.RemoveAt(currentIndex)

                    ' Adjust currentIndex if necessary
                    If currentIndex >= submissions.Count Then
                        currentIndex = submissions.Count - 1
                    End If

                    ' Show the current submission after deletion
                    ShowSubmission(currentIndex)
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            End Using
        End If
    End Sub

    Private Sub EnableEditingMode()
        txtName.ReadOnly = False
        txtEmail.ReadOnly = False
        txtPhone.ReadOnly = False
        txtGithubLink.ReadOnly = False
        txtStopwatchTime.ReadOnly = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            ' Enable editing mode (allow user to modify fields)
            EnableEditingMode()

            ' Optionally, disable other navigation or editing buttons while editing
            btnPrevious.Enabled = False
            btnNext.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = True ' Enable save button for saving changes
        End If
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            ' Gather updated data from UI
            Dim name As String = txtName.Text
            Dim email As String = txtEmail.Text
            Dim phone As String = txtPhone.Text
            Dim githubLink As String = txtGithubLink.Text
            Dim stopwatchTime As String = txtStopwatchTime.Text

            ' Create a new Submission object with the updated data
            Dim updatedSubmission As Submission = New Submission(name, email, phone, githubLink, stopwatchTime)

            Using client As New HttpClient()
                Dim url As String = $"http://localhost:3000/submissions/{currentIndex}" ' Adjust URL to match your Node.js API endpoint
                Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
                Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

                If response.IsSuccessStatusCode Then
                    ' Update the local submissions list
                    submissions(currentIndex) = updatedSubmission

                    MessageBox.Show("Submission updated successfully.")
                    ShowSubmission(currentIndex)

                    ' Disable editing mode after saving
                    DisableEditingMode()

                    ' Optionally, re-enable navigation and delete buttons
                    btnPrevious.Enabled = True
                    btnNext.Enabled = True
                    btnDelete.Enabled = True
                    btnSave.Enabled = False
                Else
                    MessageBox.Show("Failed to update submission.")
                End If
            End Using
        End If
    End Sub


    Private Sub DisableEditingMode()
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True
        txtGithubLink.ReadOnly = True
        txtStopwatchTime.ReadOnly = True
    End Sub




End Class
