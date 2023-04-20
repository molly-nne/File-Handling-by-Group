Imports System.IO

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Not SelectItem() Then
            Return
        End If

        If IsEmptyInputs({txtids, txtnamess, txtprices, txtqtyss}) Then
            Return
        End If
        If Not IsValidNumbers({txtprices, txtqtyss}) Then
            Return
        End If

        txttots.Text = (CDec(txtprices.Text) * CDec(txtqtyss.Text)).ToString("f2")

        Dim datas As String() = GetInputs({txtids, txtnamess, txtprices, txtqtyss, txttots})
        If datas Is Nothing Then
            Return
        End If

        Dim item As String = txtids.Text + "=" + ConcatStrings(datas)

        Updateitems(item, currentItemId)
        dgrid1.Rows.RemoveAt(itemPos)
        dgrid1.Rows.Insert(itemPos)
        GridFile(dgrid1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim id As String = InputBox("Enter The Product Id", "Product Id")
        Deleteitems(filepath, id)
        GridFile(dgrid1)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnread.Click
        GridFile(dgrid1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If IsEmptyInputs({txtids, txtnamess, txtprices, txtqtyss}) Then
            Return
        End If
        If Not IsValidNumbers({txtprices, txtqtyss}) Then
            Return
        End If

        txttots.Text = (CDec(txtprices.Text) * CDec(txtqtyss.Text)).ToString("f2")

        Dim datas As String() = GetInputs({txtids, txtnamess, txtprices, txtqtyss, txttots})
        If datas Is Nothing Then
            Return
        End If

        Dim item As String = txtids.Text + "=" + ConcatStrings(datas)
        CreateItem(item + vbCrLf)
        GridFile(dgrid1)
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

    Public Function SelectItem() As Boolean
        Dim id As String
        If dgrid1.SelectedRows.Count > 0 Then
            id = dgrid1.SelectedRows(0).Cells(0).Value
        Else
            id = InputBox("Enter Item ID", "Get Item")
            If String.IsNullOrEmpty(id) Then
                Return 0
            End If

        End If

        itemPos = IndexFromGrid(dgrid1, id)
        If itemPos < 0 Then
            MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
            Return 0
        End If
        currentItemId = id
        SelectedItem = ReadItem(currentItemId)
        Return 1
    End Function
End Class
