<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopupForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BattImg = New System.Windows.Forms.PictureBox()
        Me.AniTimer_Fadeout = New System.Windows.Forms.Timer(Me.components)
        Me.AniTimer_Fadein = New System.Windows.Forms.Timer(Me.components)
        Me.SwitchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BattImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLabel
        '
        Me.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLabel.Location = New System.Drawing.Point(56, 0)
        Me.MainLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainLabel.Name = "MainLabel"
        Me.MainLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MainLabel.Size = New System.Drawing.Size(158, 66)
        Me.MainLabel.TabIndex = 1
        Me.MainLabel.Text = "100%"
        Me.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BattImg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.Panel1.Size = New System.Drawing.Size(56, 66)
        Me.Panel1.TabIndex = 2
        '
        'BattImg
        '
        Me.BattImg.BackgroundImage = Global.Battify.My.Resources.Resources.batt_bg
        Me.BattImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BattImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattImg.Image = Global.Battify.My.Resources.Resources.fill_100
        Me.BattImg.Location = New System.Drawing.Point(10, 10)
        Me.BattImg.Name = "BattImg"
        Me.BattImg.Size = New System.Drawing.Size(46, 46)
        Me.BattImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BattImg.TabIndex = 0
        Me.BattImg.TabStop = False
        '
        'AniTimer_Fadeout
        '
        Me.AniTimer_Fadeout.Interval = 10
        '
        'AniTimer_Fadein
        '
        Me.AniTimer_Fadein.Interval = 10
        '
        'SwitchTimer
        '
        Me.SwitchTimer.Interval = 2000
        '
        'PopupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(214, 66)
        Me.Controls.Add(Me.MainLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopupForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Panel1.ResumeLayout(False)
        CType(Me.BattImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BattImg As PictureBox
    Friend WithEvents MainLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AniTimer_Fadeout As Timer
    Friend WithEvents AniTimer_Fadein As Timer
    Friend WithEvents SwitchTimer As Timer
End Class
