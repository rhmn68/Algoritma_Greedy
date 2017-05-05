Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nilai As String = TextBox1.Text
        Dim nilai1 As Integer = Mid(nilai, 1, 1)
        Dim nilai2 As Integer = Mid(nilai, 3, 1)
        Dim nilai3 As Integer = Mid(nilai, 5, 1)
        Dim tukar As Integer = CStr(TextBox2.Text)
        Dim hasil As String
        hasil = ""
        While tukar > 0
            If (tukar - nilai3) > 0 Then
                tukar = tukar - nilai3
                hasil = hasil & CStr(nilai3)
                If (tukar + nilai3) > nilai3 Then
                    hasil = hasil & "+"
                End If
            ElseIf (tukar - nilai2) > 0 Then
                tukar = tukar - nilai2
                hasil = hasil & CStr(nilai2)
                If (tukar + nilai2) > nilai2 Then
                    hasil = hasil & "+"
                End If
            ElseIf (tukar - nilai1) >= 0 Then
                tukar = tukar - nilai1
                hasil = hasil & CStr(nilai1)
                If (tukar + nilai1) > nilai1 Then
                    hasil = hasil & "+"
                End If
            End If
        End While
        TextBox3.Text = hasil
    End Sub
End Class

