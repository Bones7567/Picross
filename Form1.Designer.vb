<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MariosPicross
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
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.pnlTopNums = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlBoard
        '
        Me.pnlBoard.Location = New System.Drawing.Point(233, 171)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(445, 445)
        Me.pnlBoard.TabIndex = 0
        '
        'pnlTopNums
        '
        Me.pnlTopNums.Location = New System.Drawing.Point(233, 15)
        Me.pnlTopNums.Name = "pnlTopNums"
        Me.pnlTopNums.Size = New System.Drawing.Size(445, 150)
        Me.pnlTopNums.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(78, 171)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(150, 445)
        Me.Panel3.TabIndex = 2
        '
        'MariosPicross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 633)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlTopNums)
        Me.Controls.Add(Me.pnlBoard)
        Me.Name = "MariosPicross"
        Me.Text = "Mario's Picross Deluxe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBoard As Panel
    Friend WithEvents pnlTopNums As Panel
    Friend WithEvents Panel3 As Panel
End Class
