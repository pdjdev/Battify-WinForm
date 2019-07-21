<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrayForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EventCheck = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.팝업표시ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MutesoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextcolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.설정ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventCheck
        '
        Me.EventCheck.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "Battify"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.팝업표시ToolStripMenuItem, Me.MutesoundToolStripMenuItem, Me.TextcolorToolStripMenuItem, Me.ToolStripMenuItem1, Me.설정ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.ShowItemToolTips = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 218)
        '
        '팝업표시ToolStripMenuItem
        '
        Me.팝업표시ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.팝업표시ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.팝업표시ToolStripMenuItem.Name = "팝업표시ToolStripMenuItem"
        Me.팝업표시ToolStripMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.팝업표시ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.팝업표시ToolStripMenuItem.Text = "팝업 표시"
        Me.팝업표시ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MutesoundToolStripMenuItem
        '
        Me.MutesoundToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.MutesoundToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MutesoundToolStripMenuItem.Name = "MutesoundToolStripMenuItem"
        Me.MutesoundToolStripMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.MutesoundToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MutesoundToolStripMenuItem.Text = "음소거"
        Me.MutesoundToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem1.Text = "상태 창"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.Visible = False
        '
        'TextcolorToolStripMenuItem
        '
        Me.TextcolorToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.TextcolorToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.TextcolorToolStripMenuItem.Name = "TextcolorToolStripMenuItem"
        Me.TextcolorToolStripMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.TextcolorToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TextcolorToolStripMenuItem.Text = "텍스트 색: "
        Me.TextcolorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TextcolorToolStripMenuItem.Visible = False
        '
        '설정ToolStripMenuItem
        '
        Me.설정ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.설정ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem"
        Me.설정ToolStripMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.설정ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.설정ToolStripMenuItem.Text = "설정 / 정보"
        Me.설정ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.종료ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.종료ToolStripMenuItem.Text = "종료"
        Me.종료ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TrayForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(120, 50)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Battify.My.Resources.Resources.icon
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TrayForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TrayForm"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EventCheck As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 팝업표시ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MutesoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextcolorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 설정ToolStripMenuItem As ToolStripMenuItem
End Class
