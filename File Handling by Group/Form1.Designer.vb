<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnread = New System.Windows.Forms.Button()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtprices = New System.Windows.Forms.TextBox()
        Me.txtqtyss = New System.Windows.Forms.TextBox()
        Me.txtnamess = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtids = New System.Windows.Forms.TextBox()
        Me.dgrid1 = New System.Windows.Forms.DataGridView()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txttots = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtclear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupBox1.Controls.Add(Me.txtclear)
        Me.GroupBox1.Controls.Add(Me.txttots)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.btnread)
        Me.GroupBox1.Controls.Add(Me.btncreate)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.txtprices)
        Me.GroupBox1.Controls.Add(Me.txtqtyss)
        Me.GroupBox1.Controls.Add(Me.txtnamess)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtids)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 477)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnread
        '
        Me.btnread.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnread.Location = New System.Drawing.Point(181, 322)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(132, 38)
        Me.btnread.TabIndex = 13
        Me.btnread.Text = "READ"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btncreate.Location = New System.Drawing.Point(23, 322)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(132, 38)
        Me.btncreate.TabIndex = 12
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btndel.Location = New System.Drawing.Point(24, 392)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(132, 38)
        Me.btndel.TabIndex = 10
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.Location = New System.Drawing.Point(349, 322)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(132, 38)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtprices
        '
        Me.txtprices.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtprices.Location = New System.Drawing.Point(285, 186)
        Me.txtprices.Name = "txtprices"
        Me.txtprices.Size = New System.Drawing.Size(168, 30)
        Me.txtprices.TabIndex = 9
        '
        'txtqtyss
        '
        Me.txtqtyss.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtqtyss.Location = New System.Drawing.Point(285, 138)
        Me.txtqtyss.Name = "txtqtyss"
        Me.txtqtyss.Size = New System.Drawing.Size(168, 30)
        Me.txtqtyss.TabIndex = 8
        '
        'txtnamess
        '
        Me.txtnamess.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnamess.Location = New System.Drawing.Point(285, 82)
        Me.txtnamess.Name = "txtnamess"
        Me.txtnamess.Size = New System.Drawing.Size(168, 30)
        Me.txtnamess.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(20, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NAME:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(20, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PRODUCT PRICE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(161, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 22)
        Me.Label4.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(20, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCT QUANTITY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT ID:"
        '
        'txtids
        '
        Me.txtids.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtids.Location = New System.Drawing.Point(285, 30)
        Me.txtids.Name = "txtids"
        Me.txtids.Size = New System.Drawing.Size(168, 30)
        Me.txtids.TabIndex = 0
        '
        'dgrid1
        '
        Me.dgrid1.AllowUserToAddRows = False
        Me.dgrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrid1.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.prices, Me.totals, Me.Column3})
        Me.dgrid1.Location = New System.Drawing.Point(578, 50)
        Me.dgrid1.Name = "dgrid1"
        Me.dgrid1.RowHeadersWidth = 51
        Me.dgrid1.RowTemplate.Height = 24
        Me.dgrid1.Size = New System.Drawing.Size(644, 477)
        Me.dgrid1.TabIndex = 1
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(181, 392)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(132, 38)
        Me.btnsearch.TabIndex = 14
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'prices
        '
        Me.prices.HeaderText = "QUANTITY"
        Me.prices.MinimumWidth = 6
        Me.prices.Name = "prices"
        '
        'totals
        '
        Me.totals.HeaderText = "PRICE"
        Me.totals.MinimumWidth = 6
        Me.totals.Name = "totals"
        '
        'Column3
        '
        Me.Column3.HeaderText = "TOTAL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'txttots
        '
        Me.txttots.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttots.Location = New System.Drawing.Point(285, 234)
        Me.txttots.Name = "txttots"
        Me.txttots.Size = New System.Drawing.Size(168, 30)
        Me.txttots.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(20, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL:"
        '
        'txtclear
        '
        Me.txtclear.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtclear.Location = New System.Drawing.Point(349, 392)
        Me.txtclear.Name = "txtclear"
        Me.txtclear.Size = New System.Drawing.Size(132, 38)
        Me.txtclear.TabIndex = 17
        Me.txtclear.Text = "CLEAR"
        Me.txtclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1264, 539)
        Me.Controls.Add(Me.dgrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndel As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtprices As TextBox
    Friend WithEvents txtqtyss As TextBox
    Friend WithEvents txtnamess As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtids As TextBox
    Friend WithEvents dgrid1 As DataGridView
    Friend WithEvents btnread As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents txttots As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents prices As DataGridViewTextBoxColumn
    Friend WithEvents totals As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtclear As Button
End Class
