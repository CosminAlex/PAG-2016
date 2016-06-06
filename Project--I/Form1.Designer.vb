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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbScore = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bestScore = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbScoreMaxim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.score_curent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sCurent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbRecord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.scor_record = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbScoreNew = New System.Windows.Forms.ToolStripStatusLabel()
        Me.actor = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.actor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Score: "
        '
        'stbScore
        '
        Me.stbScore.Name = "stbScore"
        Me.stbScore.Size = New System.Drawing.Size(13, 17)
        Me.stbScore.Text = "0"
        '
        'bestScore
        '
        Me.bestScore.Name = "bestScore"
        Me.bestScore.Size = New System.Drawing.Size(85, 17)
        Me.bestScore.Text = "BEST SCORE->"
        '
        'stbScoreMaxim
        '
        Me.stbScoreMaxim.Name = "stbScoreMaxim"
        Me.stbScoreMaxim.Size = New System.Drawing.Size(0, 17)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.score_curent, Me.sCurent, Me.stbRecord, Me.scor_record, Me.ToolStripStatusLabel2, Me.stbScoreNew})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(364, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "Score:"
        '
        'score_curent
        '
        Me.score_curent.Name = "score_curent"
        Me.score_curent.Size = New System.Drawing.Size(39, 17)
        Me.score_curent.Text = "Score:"
        '
        'sCurent
        '
        Me.sCurent.BackColor = System.Drawing.Color.DarkGray
        Me.sCurent.Name = "sCurent"
        Me.sCurent.Size = New System.Drawing.Size(13, 17)
        Me.sCurent.Text = "0"
        '
        'stbRecord
        '
        Me.stbRecord.Name = "stbRecord"
        Me.stbRecord.Size = New System.Drawing.Size(47, 17)
        Me.stbRecord.Text = "Record:"
        '
        'scor_record
        '
        Me.scor_record.Name = "scor_record"
        Me.scor_record.Size = New System.Drawing.Size(13, 17)
        Me.scor_record.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'stbScoreNew
        '
        Me.stbScoreNew.Name = "stbScoreNew"
        Me.stbScoreNew.Size = New System.Drawing.Size(120, 17)
        Me.stbScoreNew.Text = "ToolStripStatusLabel3"
        Me.stbScoreNew.Visible = False
        '
        'actor
        '
        Me.actor.BackColor = System.Drawing.Color.Transparent
        Me.actor.Location = New System.Drawing.Point(12, 166)
        Me.actor.Name = "actor"
        Me.actor.Size = New System.Drawing.Size(40, 40)
        Me.actor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.actor.TabIndex = 0
        Me.actor.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(364, 391)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.actor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game-Demo"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.actor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents actor As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbScore As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bestScore As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbScoreMaxim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents score_curent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sCurent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbRecord As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents scor_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbScoreNew As System.Windows.Forms.ToolStripStatusLabel

End Class
