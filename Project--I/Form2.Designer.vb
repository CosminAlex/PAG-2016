<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("Trajan Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Gold
        Me.btnPlay.Location = New System.Drawing.Point(103, 51)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(80, 30)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnScore
        '
        Me.btnScore.BackColor = System.Drawing.Color.Black
        Me.btnScore.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScore.ForeColor = System.Drawing.Color.Gold
        Me.btnScore.Location = New System.Drawing.Point(103, 87)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(80, 30)
        Me.btnScore.TabIndex = 1
        Me.btnScore.Text = "Scor"
        Me.btnScore.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Black
        Me.btnInfo.Font = New System.Drawing.Font("Trajan Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.Gold
        Me.btnInfo.Location = New System.Drawing.Point(103, 123)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(80, 30)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Location = New System.Drawing.Point(103, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnManual
        '
        Me.btnManual.BackColor = System.Drawing.Color.Black
        Me.btnManual.Font = New System.Drawing.Font("Trajan Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.Color.Gold
        Me.btnManual.Location = New System.Drawing.Point(103, 159)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(80, 30)
        Me.btnManual.TabIndex = 4
        Me.btnManual.Text = "Manual"
        Me.btnManual.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Project__I.My.Resources.Resources.steel_block_texture_wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flappy Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnScore As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
End Class
