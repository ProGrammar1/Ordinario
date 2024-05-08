Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Public Class loginfrm
    Public Property DataToPass As String

    Private Sub loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PasswordChar property to '*' for masking
        Userpass.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles titlebar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub loginfrm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click
        If Not String.IsNullOrEmpty(textuser.Text) And Not String.IsNullOrEmpty(Userpass.Text) Then
            Dim user As String = textuser.Text
            Dim pass As String = Userpass.Text

            If user.Equals("superadmin") And pass.Equals("superadmin123") Then

                Dim loginfrm As New loginfrm()
                loginfrm.DataToPass = "Super Admin"
                Dim Form1 As New Form1
                Form1.UserData = "Super Admin"
                Form1.Show()

                Me.Hide()

                ' Show the second form
            Else
                Dim query As String = "SELECT user_level FROM users WHERE username = '" & user & "'  AND password ='" & EncryptPassword(pass) & "'"

                Try
                    readQuery(query)
                    With cmdRead
                        If .HasRows Then

                            While .Read
                                Form1.UserData = .GetValue(0)
                            End While

                        Else
                            MsgBox("User Does not exits", MsgBoxStyle.Exclamation)
                            Return
                        End If
                    End With
                    Form1.Show()
                    Me.Hide()
                Catch ex As Exception

                End Try
            End If
        Else
            MsgBox("Please fill up required fields")

        End If


    End Sub

    Private Function EncryptPassword(password As String) As String
        Using md5Hash As MD5 = MD5.Create()
            ' Convert the input string to a byte array and compute the hash
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Create a new StringBuilder to collect the bytes
            Dim sBuilder As New StringBuilder()

            ' Loop through each byte of the hashed data and format each one as a hexadecimal string
            For i As Integer = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next

            ' Return the hexadecimal string
            Return sBuilder.ToString()
        End Using
    End Function

    Private Sub showhide_CheckedChanged(sender As Object, e As EventArgs) Handles showhide.CheckedChanged
        If showhide.Checked Then
            Userpass.PasswordChar = ""
        Else
            Userpass.PasswordChar = "*"
        End If
    End Sub
End Class