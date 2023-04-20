Imports System.ComponentModel
Imports System.IO
Module Module1

    Public itemPos As Integer
    Public currentItemId As String
    Public SelectedItem As String

    Public filepath As String = CurDir() + "\PRODUCT.txt"

    Public Sub CreateFile(filepath As String)
        File.Create(filepath).Dispose()
    End Sub

    Public Sub CreateItem(item As String)
        If Not String.IsNullOrEmpty(item) Then
            File.AppendAllText(filepath, item)
        End If
    End Sub
    Public Sub Updateitems(text As String, id As Integer)


        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(Readitems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas(i) = text
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(filepath, new_datas)

                Return
            End If
            i += 1
        End While
    End Sub
    Public Sub Deleteitems(filepath As String, id As String)
        If String.IsNullOrEmpty(id) Then
            Return
        End If
        Dim data As String() = Readitems()
        For i As Integer = 0 To data.Length - 1
            Dim line As String = data(i)
            If line.Contains(id + "=") Then
                data(i) = " "
            End If
        Next
        File.WriteAllLines(filepath, data)
    End Sub


    Public Function Readitems() As String()
        Return File.ReadAllLines(filepath)
    End Function

    Public Function ReadItem(id As String) As String
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return ""
        End If

        Dim datas As String() = Readitems()
        Dim i As Integer = 0
        Dim item As String = ""

        While i < datas.Length
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then
                item = datas(i).Split("=")(1)
                Return item
            End If
            i += 1
        End While
        Return item
    End Function

    Public Sub GridFile(ByRef grid As DataGridView)
        Dim datas As String() = Readitems()
        If Not datas.Length - grid.RowCount = 1 Then
            grid.Rows.Clear()
        End If
        For row As Integer = grid.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            grid.Rows.Add(item)
        Next
    End Sub

    Public Function IndexFromGrid(grid As DataGridView, id As Integer) As Integer
        Dim i = 0
        While i < grid.Rows.Count
            If grid.Rows(i).Cells(0).Value = id Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Sub SearchFile(filepath As String, id As String, ByRef grid As DataGridView)
        If String.IsNullOrEmpty(id) Then
            Return
        End If
        Dim data As String() = Readitems()

        For i As Integer = 0 To data.Length - 1
            Dim line As String = data(i)
            If line.Contains(id + "=") Then
                grid.Rows.Clear()
                grid.Rows.Add(line.Split("=")(1).Split(","))
            End If
        Next

    End Sub

    Public Function ConcatStrings(str As String()) As String
        Dim result As String = ""
        For Each s In str
            result += s + ","
        Next
        Return result.Remove(result.Length - 1)
    End Function

    Public Function GetInputs(ByRef inputs As TextBox()) As String()
        Dim datas As New ArrayList

        For Each t In inputs
            datas.Add(t.Text)
        Next
        Return datas.ToArray(GetType(String))
    End Function

    Public Function IsEmptyInputs(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If String.IsNullOrEmpty(t.Text) Then
                Dim msg As String = "Found missing value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Please fill all the fields")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsValidNumbers(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If Not IsNumeric(t.Text) Then
                Dim msg As String = "Found invalid value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Invalid Value")
                t.Focus()
                Return False
            End If
        Next
        Return True
    End Function
End Module
