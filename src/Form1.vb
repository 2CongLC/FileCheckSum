Imports System
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then


            If CheckBox1.Checked = True Then

                If ComboBox1.SelectedIndex = 0 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.MD5Hash(OpenFileDialog1.FileName).Replace("-", "").ToLower Else TextBox1.Text = FileExtension.MD5Hash(OpenFileDialog1.FileName).Replace("-", "")
                ElseIf ComboBox1.SelectedIndex = 1 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha1Hash(OpenFileDialog1.FileName).Replace("-", "").ToLower Else TextBox1.Text = FileExtension.Sha1Hash(OpenFileDialog1.FileName).Replace("-", "")
                ElseIf ComboBox1.SelectedIndex = 2 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha256Hash(OpenFileDialog1.FileName).Replace("-", "").ToLower Else TextBox1.Text = FileExtension.Sha256Hash(OpenFileDialog1.FileName).Replace("-", "")
                ElseIf ComboBox1.SelectedIndex = 3 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha384Hash(OpenFileDialog1.FileName).Replace("-", "").ToLower Else TextBox1.Text = FileExtension.Sha384Hash(OpenFileDialog1.FileName).Replace("-", "")
                ElseIf ComboBox1.SelectedIndex = 4 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha512Hash(OpenFileDialog1.FileName).Replace("-", "").ToLower Else TextBox1.Text = FileExtension.Sha512Hash(OpenFileDialog1.FileName).Replace("-", "")
                End If

            Else

                If ComboBox1.SelectedIndex = 0 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.MD5Hash(OpenFileDialog1.FileName).ToLower Else TextBox1.Text = FileExtension.MD5Hash(OpenFileDialog1.FileName)
                ElseIf ComboBox1.SelectedIndex = 1 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha1Hash(OpenFileDialog1.FileName).ToLower Else TextBox1.Text = FileExtension.Sha1Hash(OpenFileDialog1.FileName)
                ElseIf ComboBox1.SelectedIndex = 2 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha256Hash(OpenFileDialog1.FileName).ToLower Else TextBox1.Text = FileExtension.Sha256Hash(OpenFileDialog1.FileName)
                ElseIf ComboBox1.SelectedIndex = 3 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha384Hash(OpenFileDialog1.FileName).ToLower Else TextBox1.Text = FileExtension.Sha384Hash(OpenFileDialog1.FileName)
                ElseIf ComboBox1.SelectedIndex = 4 Then
                    If CheckBox2.Checked = True Then TextBox1.Text = FileExtension.Sha512Hash(OpenFileDialog1.FileName).ToLower Else TextBox1.Text = FileExtension.Sha512Hash(OpenFileDialog1.FileName)
                End If

            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBox2.Text) Then
            If TextBox2.Text.Equals(TextBox1.Text) = True Then
                PictureBox1.Image = ImageList1.Images(0)
                TextBox3.Text = "Trùng khớp mã Hash !"
                '  MessageBox.Show("Trùng khớp mã Hash !")
            Else
                PictureBox1.Image = ImageList1.Images(1)
                TextBox3.Text = "Không trùng khớp mã Hash !"
                '  MessageBox.Show("Không trùng khớp mã Hash !")
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://2conglc-vn.blogspot.com/2020/04/visual-basic-filechecksum.html")

    End Sub
End Class
