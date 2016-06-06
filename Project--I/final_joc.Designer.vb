<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class final_joc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(final_joc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pctboxSad = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctboxHappy = New System.Windows.Forms.PictureBox()
        Me.lblRecor = New System.Windows.Forms.Label()
        CType(Me.pctboxSad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctboxHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ">GAME OVER<"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scorul tau este: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "0 "
        '
        'pctboxSad
        '
        Me.pctboxSad.Image = CType(resources.GetObject("pctboxSad.Image"), System.Drawing.Image)
        Me.pctboxSad.Location = New System.Drawing.Point(368, 103)
        Me.pctboxSad.Name = "pctboxSad"
        Me.pctboxSad.Size = New System.Drawing.Size(209, 186)
        Me.pctboxSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctboxSad.TabIndex = 3
        Me.pctboxSad.TabStop = False
        Me.pctboxSad.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'pctboxHappy
        '
        Me.pctboxHappy.Image = CType(resources.GetObject("pctboxHappy.Image"), System.Drawing.Image)
        Me.pctboxHappy.Location = New System.Drawing.Point(368, 103)
        Me.pctboxHappy.Name = "pctboxHappy"
        Me.pctboxHappy.Size = New System.Drawing.Size(209, 186)
        Me.pctboxHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctboxHappy.TabIndex = 4
        Me.pctboxHappy.TabStop = False
        Me.pctboxHappy.Visible = False
        '
        'lblRecor
        '
        Me.lblRecor.AutoSize = True
        Me.lblRecor.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecor.Location = New System.Drawing.Point(166, 103)
        Me.lblRecor.Name = "lblRecor"
        Me.lblRecor.Size = New System.Drawing.Size(196, 46)
        Me.lblRecor.TabIndex = 5
        Me.lblRecor.Text = "RECORD"
        Me.lblRecor.Visible = False
        '
        'final_joc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 379)
        Me.Controls.Add(Me.lblRecor)
        Me.Controls.Add(Me.pctboxHappy)
        Me.Controls.Add(Me.pctboxSad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "final_joc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "final_joc"
        CType(Me.pctboxSad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctboxHappy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pctboxSad As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctboxHappy As System.Windows.Forms.PictureBox
    Friend WithEvents lblRecor As System.Windows.Forms.Label
End Class
