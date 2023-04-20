Imports System.IO

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim totss As Integer = CInt(txtprices.Text) * CInt(txtqtyss.Text)

        If Not File.Exists(filepath) Then
            CreateFile(filepath)
        End If

        Dim data As String = txtids.Text + "," + txtnamess.Text + "," + txtqtyss.Text + "," + txtprices.Text + "," + totss.ToString("C2")
        data = txtids.Text + "=" + data
        UpdateFile(filepath, data)

        txttots.Text = totss.ToString("C2")

        GridFile(dgrid1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim id As String = InputBox("Enter The Product Id", "Product Id")
        Deletefile(filepath, id)
        GridFile(dgrid1)
    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnread.Click
        GridFile(dgrid1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If Not File.Exists(filepath) Then
            CreateFile(filepath)
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim id As String = InputBox("Enter The Product Id", "Product Id")
        SearchFile(filepath, id, dgrid1)
    End Sub

    Private Sub txtclear_Click(sender As Object, e As EventArgs) Handles txtclear.Click
        txtids.Clear()
        txtnamess.Clear()
        txtqtyss.Clear()
        txtprices.Clear()
        txttots.Clear()

    End Sub
End Class
