Imports System.ComponentModel
Imports System.IO
Module Module1
    Dim ids As Integer
    Dim names As String
    Dim qty As Integer
    Dim pricy As Integer

    Public filepath As String = CurDir() + "\PRODUCT.txt"

    Public Sub CreateFile(filepath As String)
        File.Create(filepath).Dispose()
    End Sub

    Public Sub UpdateFile(filepath As String, text As String)
        If Not String.IsNullOrEmpty(text) Then
            Dim data As String() = Readfile(filepath)
            For i As Integer = 0 To data.Length - 1
                Dim line As String = data(i)
                If line.Contains(text.Split("=")(0) + "=") Then
                    MsgBox("Product Already Existed!")
                    Return
                End If
            Next
            File.AppendAllText(filepath, text + vbCrLf)

        End If
    End Sub
    Public Sub Deletefile(filepath As String, id As String)
        If String.IsNullOrEmpty(id) Then
            Return
        End If
        Dim data As String() = Readfile(filepath)
        For i As Integer = 0 To data.Length - 1
            Dim line As String = data(i)
            If line.Contains(id + "=") Then
                data(i) = " "
            End If
        Next
        File.WriteAllLines(filepath, data)
    End Sub


    Public Function Readfile(filepath As String) As String()
        Return File.ReadAllLines(filepath)
    End Function

    Public Sub GridFile(ByRef grid As DataGridView)
        Dim data As String() = Readfile(filepath)
            grid.Rows.Clear()
        For i As Integer = grid.RowCount To data.Length - 1
            If String.IsNullOrEmpty(data(i).Trim) Then
                Continue For
            End If
            Dim line As String = data(i).Split("=")(1)

            Dim array As String() = line.Split(",")
            grid.Rows.Add(array)
        Next
    End Sub

    Public Sub SearchFile(filepath As String, id As String, ByRef grid As DataGridView)
        If String.IsNullOrEmpty(id) Then
            Return
        End If
        Dim data As String() = Readfile(filepath)

        For i As Integer = 0 To data.Length - 1
            Dim line As String = data(i)
            If line.Contains(id + "=") Then
                grid.Rows.Clear()
                grid.Rows.Add(line.Split("=")(1).Split(","))
            End If
        Next

    End Sub
End Module
