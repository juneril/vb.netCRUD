<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserPhoto
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
        Me.pic_display = New System.Windows.Forms.PictureBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.dlg_openfile = New System.Windows.Forms.OpenFileDialog()
        Me.u_id = New System.Windows.Forms.Label()
        CType(Me.pic_display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_display
        '
        Me.pic_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_display.Location = New System.Drawing.Point(12, 12)
        Me.pic_display.Name = "pic_display"
        Me.pic_display.Size = New System.Drawing.Size(260, 201)
        Me.pic_display.TabIndex = 0
        Me.pic_display.TabStop = False
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(12, 219)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(119, 31)
        Me.btn_browse.TabIndex = 1
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(135, 219)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(135, 31)
        Me.savebtn.TabIndex = 2
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'dlg_openfile
        '
        Me.dlg_openfile.FileName = "OpenFileDialog1"
        '
        'u_id
        '
        Me.u_id.AutoSize = True
        Me.u_id.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.u_id.Location = New System.Drawing.Point(84, 258)
        Me.u_id.Name = "u_id"
        Me.u_id.Size = New System.Drawing.Size(0, 13)
        Me.u_id.TabIndex = 3
        Me.u_id.Visible = False
        '
        'frmUserPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.u_id)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.pic_display)
        Me.Name = "frmUserPhoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserPhoto"
        CType(Me.pic_display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_display As System.Windows.Forms.PictureBox
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents dlg_openfile As System.Windows.Forms.OpenFileDialog
    Public WithEvents u_id As System.Windows.Forms.Label
End Class
