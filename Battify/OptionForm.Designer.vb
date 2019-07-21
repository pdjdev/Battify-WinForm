<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionForm))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mode1PN = New System.Windows.Forms.Panel()
        Me.cka_mute = New System.Windows.Forms.CheckBox()
        Me.ckc_0 = New System.Windows.Forms.CheckBox()
        Me.cka_2 = New System.Windows.Forms.CheckBox()
        Me.cka_1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckc_8 = New System.Windows.Forms.CheckBox()
        Me.ckc_6 = New System.Windows.Forms.CheckBox()
        Me.ckc_7 = New System.Windows.Forms.CheckBox()
        Me.ckc_5 = New System.Windows.Forms.CheckBox()
        Me.ckc_4 = New System.Windows.Forms.CheckBox()
        Me.ckc_3 = New System.Windows.Forms.CheckBox()
        Me.ckc_2 = New System.Windows.Forms.CheckBox()
        Me.ckc_1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mode2PN = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rd_gui_4 = New System.Windows.Forms.RadioButton()
        Me.rd_gui_3 = New System.Windows.Forms.RadioButton()
        Me.rd_gui_2 = New System.Windows.Forms.RadioButton()
        Me.rd_gui_1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rd_cl_2 = New System.Windows.Forms.RadioButton()
        Me.rd_cl_1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_startup = New System.Windows.Forms.CheckBox()
        Me.MenuPanel.SuspendLayout()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Mode1PN.SuspendLayout()
        Me.Mode2PN.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.Button2)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.CloseBT)
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(459, 41)
        Me.MenuPanel.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(303, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 35)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "설 정  초 기 화"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(113, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label2.Size = New System.Drawing.Size(152, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "모양 설정/정보"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CloseBT
        '
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBT.Image = Global.Battify.My.Resources.Resources.closeicon
        Me.CloseBT.Location = New System.Drawing.Point(415, 0)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(44, 41)
        Me.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBT.TabIndex = 0
        Me.CloseBT.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label1.Size = New System.Drawing.Size(113, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "기본 설정"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Mode2PN)
        Me.Panel3.Controls.Add(Me.Mode1PN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(459, 218)
        Me.Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕 Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(318, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 39)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "적용/저장"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mode1PN
        '
        Me.Mode1PN.Controls.Add(Me.chk_startup)
        Me.Mode1PN.Controls.Add(Me.Label8)
        Me.Mode1PN.Controls.Add(Me.cka_mute)
        Me.Mode1PN.Controls.Add(Me.ckc_0)
        Me.Mode1PN.Controls.Add(Me.cka_2)
        Me.Mode1PN.Controls.Add(Me.cka_1)
        Me.Mode1PN.Controls.Add(Me.Label5)
        Me.Mode1PN.Controls.Add(Me.ckc_8)
        Me.Mode1PN.Controls.Add(Me.ckc_6)
        Me.Mode1PN.Controls.Add(Me.ckc_7)
        Me.Mode1PN.Controls.Add(Me.ckc_5)
        Me.Mode1PN.Controls.Add(Me.ckc_4)
        Me.Mode1PN.Controls.Add(Me.ckc_3)
        Me.Mode1PN.Controls.Add(Me.ckc_2)
        Me.Mode1PN.Controls.Add(Me.ckc_1)
        Me.Mode1PN.Controls.Add(Me.Label3)
        Me.Mode1PN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mode1PN.Location = New System.Drawing.Point(0, 0)
        Me.Mode1PN.Name = "Mode1PN"
        Me.Mode1PN.Size = New System.Drawing.Size(459, 218)
        Me.Mode1PN.TabIndex = 0
        '
        'cka_mute
        '
        Me.cka_mute.AutoSize = True
        Me.cka_mute.BackColor = System.Drawing.Color.Transparent
        Me.cka_mute.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cka_mute.ForeColor = System.Drawing.Color.White
        Me.cka_mute.Location = New System.Drawing.Point(235, 105)
        Me.cka_mute.Margin = New System.Windows.Forms.Padding(1)
        Me.cka_mute.Name = "cka_mute"
        Me.cka_mute.Size = New System.Drawing.Size(73, 24)
        Me.cka_mute.TabIndex = 31
        Me.cka_mute.Text = "음소거"
        Me.cka_mute.UseVisualStyleBackColor = False
        '
        'ckc_0
        '
        Me.ckc_0.AutoSize = True
        Me.ckc_0.BackColor = System.Drawing.Color.Transparent
        Me.ckc_0.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_0.ForeColor = System.Drawing.Color.White
        Me.ckc_0.Location = New System.Drawing.Point(334, 17)
        Me.ckc_0.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_0.Name = "ckc_0"
        Me.ckc_0.Size = New System.Drawing.Size(103, 23)
        Me.ckc_0.TabIndex = 30
        Me.ckc_0.Text = "배터리 없음"
        Me.ckc_0.UseVisualStyleBackColor = False
        '
        'cka_2
        '
        Me.cka_2.AutoSize = True
        Me.cka_2.BackColor = System.Drawing.Color.Transparent
        Me.cka_2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cka_2.ForeColor = System.Drawing.Color.White
        Me.cka_2.Location = New System.Drawing.Point(175, 105)
        Me.cka_2.Margin = New System.Windows.Forms.Padding(1)
        Me.cka_2.Name = "cka_2"
        Me.cka_2.Size = New System.Drawing.Size(58, 24)
        Me.cka_2.TabIndex = 29
        Me.cka_2.Text = "완충"
        Me.cka_2.UseVisualStyleBackColor = False
        '
        'cka_1
        '
        Me.cka_1.AutoSize = True
        Me.cka_1.BackColor = System.Drawing.Color.Transparent
        Me.cka_1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cka_1.ForeColor = System.Drawing.Color.White
        Me.cka_1.Location = New System.Drawing.Point(100, 105)
        Me.cka_1.Margin = New System.Windows.Forms.Padding(1)
        Me.cka_1.Name = "cka_1"
        Me.cka_1.Size = New System.Drawing.Size(73, 24)
        Me.cka_1.TabIndex = 28
        Me.cka_1.Text = "충전중"
        Me.cka_1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "알 림  소 리"
        '
        'ckc_8
        '
        Me.ckc_8.AutoSize = True
        Me.ckc_8.BackColor = System.Drawing.Color.Transparent
        Me.ckc_8.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_8.ForeColor = System.Drawing.Color.White
        Me.ckc_8.Location = New System.Drawing.Point(218, 69)
        Me.ckc_8.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_8.Name = "ckc_8"
        Me.ckc_8.Size = New System.Drawing.Size(105, 23)
        Me.ckc_8.TabIndex = 23
        Me.ckc_8.Text = "100% (완충)"
        Me.ckc_8.UseVisualStyleBackColor = False
        '
        'ckc_6
        '
        Me.ckc_6.AutoSize = True
        Me.ckc_6.BackColor = System.Drawing.Color.Transparent
        Me.ckc_6.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_6.ForeColor = System.Drawing.Color.White
        Me.ckc_6.Location = New System.Drawing.Point(100, 69)
        Me.ckc_6.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_6.Name = "ckc_6"
        Me.ckc_6.Size = New System.Drawing.Size(56, 23)
        Me.ckc_6.TabIndex = 22
        Me.ckc_6.Text = "30%"
        Me.ckc_6.UseVisualStyleBackColor = False
        '
        'ckc_7
        '
        Me.ckc_7.AutoSize = True
        Me.ckc_7.BackColor = System.Drawing.Color.Transparent
        Me.ckc_7.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_7.ForeColor = System.Drawing.Color.White
        Me.ckc_7.Location = New System.Drawing.Point(159, 69)
        Me.ckc_7.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_7.Name = "ckc_7"
        Me.ckc_7.Size = New System.Drawing.Size(56, 23)
        Me.ckc_7.TabIndex = 21
        Me.ckc_7.Text = "50%"
        Me.ckc_7.UseVisualStyleBackColor = False
        '
        'ckc_5
        '
        Me.ckc_5.AutoSize = True
        Me.ckc_5.BackColor = System.Drawing.Color.Transparent
        Me.ckc_5.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_5.ForeColor = System.Drawing.Color.White
        Me.ckc_5.Location = New System.Drawing.Point(218, 44)
        Me.ckc_5.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_5.Name = "ckc_5"
        Me.ckc_5.Size = New System.Drawing.Size(56, 23)
        Me.ckc_5.TabIndex = 20
        Me.ckc_5.Text = "25%"
        Me.ckc_5.UseVisualStyleBackColor = False
        '
        'ckc_4
        '
        Me.ckc_4.AutoSize = True
        Me.ckc_4.BackColor = System.Drawing.Color.Transparent
        Me.ckc_4.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_4.ForeColor = System.Drawing.Color.White
        Me.ckc_4.Location = New System.Drawing.Point(159, 44)
        Me.ckc_4.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_4.Name = "ckc_4"
        Me.ckc_4.Size = New System.Drawing.Size(56, 23)
        Me.ckc_4.TabIndex = 19
        Me.ckc_4.Text = "15%"
        Me.ckc_4.UseVisualStyleBackColor = False
        '
        'ckc_3
        '
        Me.ckc_3.AutoSize = True
        Me.ckc_3.BackColor = System.Drawing.Color.Transparent
        Me.ckc_3.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_3.ForeColor = System.Drawing.Color.White
        Me.ckc_3.Location = New System.Drawing.Point(100, 44)
        Me.ckc_3.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_3.Name = "ckc_3"
        Me.ckc_3.Size = New System.Drawing.Size(48, 23)
        Me.ckc_3.TabIndex = 18
        Me.ckc_3.Text = "5%"
        Me.ckc_3.UseVisualStyleBackColor = False
        '
        'ckc_2
        '
        Me.ckc_2.AutoSize = True
        Me.ckc_2.BackColor = System.Drawing.Color.Transparent
        Me.ckc_2.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_2.ForeColor = System.Drawing.Color.White
        Me.ckc_2.Location = New System.Drawing.Point(175, 17)
        Me.ckc_2.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_2.Name = "ckc_2"
        Me.ckc_2.Size = New System.Drawing.Size(158, 23)
        Me.ckc_2.TabIndex = 17
        Me.ckc_2.Text = "사용중 (플러그 빠짐)"
        Me.ckc_2.UseVisualStyleBackColor = False
        '
        'ckc_1
        '
        Me.ckc_1.AutoSize = True
        Me.ckc_1.BackColor = System.Drawing.Color.Transparent
        Me.ckc_1.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ckc_1.ForeColor = System.Drawing.Color.White
        Me.ckc_1.Location = New System.Drawing.Point(100, 17)
        Me.ckc_1.Margin = New System.Windows.Forms.Padding(1)
        Me.ckc_1.Name = "ckc_1"
        Me.ckc_1.Size = New System.Drawing.Size(70, 23)
        Me.ckc_1.TabIndex = 16
        Me.ckc_1.Text = "충전중"
        Me.ckc_1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(17, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "알 림  항 목"
        '
        'Mode2PN
        '
        Me.Mode2PN.Controls.Add(Me.LinkLabel1)
        Me.Mode2PN.Controls.Add(Me.RichTextBox1)
        Me.Mode2PN.Controls.Add(Me.Label7)
        Me.Mode2PN.Controls.Add(Me.Label6)
        Me.Mode2PN.Controls.Add(Me.Label4)
        Me.Mode2PN.Controls.Add(Me.Panel4)
        Me.Mode2PN.Controls.Add(Me.Panel1)
        Me.Mode2PN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mode2PN.ForeColor = System.Drawing.Color.White
        Me.Mode2PN.Location = New System.Drawing.Point(0, 0)
        Me.Mode2PN.Name = "Mode2PN"
        Me.Mode2PN.Size = New System.Drawing.Size(459, 218)
        Me.Mode2PN.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(13, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "G U I  배 율"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "트 레 이  아 이 콘  색 상"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rd_gui_4)
        Me.Panel4.Controls.Add(Me.rd_gui_3)
        Me.Panel4.Controls.Add(Me.rd_gui_2)
        Me.Panel4.Controls.Add(Me.rd_gui_1)
        Me.Panel4.Location = New System.Drawing.Point(92, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(317, 36)
        Me.Panel4.TabIndex = 35
        '
        'rd_gui_4
        '
        Me.rd_gui_4.AutoSize = True
        Me.rd_gui_4.BackColor = System.Drawing.Color.Transparent
        Me.rd_gui_4.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_gui_4.ForeColor = System.Drawing.Color.White
        Me.rd_gui_4.Location = New System.Drawing.Point(248, 4)
        Me.rd_gui_4.Name = "rd_gui_4"
        Me.rd_gui_4.Size = New System.Drawing.Size(64, 24)
        Me.rd_gui_4.TabIndex = 28
        Me.rd_gui_4.TabStop = True
        Me.rd_gui_4.Text = "150%"
        Me.rd_gui_4.UseVisualStyleBackColor = False
        '
        'rd_gui_3
        '
        Me.rd_gui_3.AutoSize = True
        Me.rd_gui_3.BackColor = System.Drawing.Color.Transparent
        Me.rd_gui_3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_gui_3.ForeColor = System.Drawing.Color.White
        Me.rd_gui_3.Location = New System.Drawing.Point(178, 4)
        Me.rd_gui_3.Name = "rd_gui_3"
        Me.rd_gui_3.Size = New System.Drawing.Size(64, 24)
        Me.rd_gui_3.TabIndex = 27
        Me.rd_gui_3.TabStop = True
        Me.rd_gui_3.Text = "125%"
        Me.rd_gui_3.UseVisualStyleBackColor = False
        '
        'rd_gui_2
        '
        Me.rd_gui_2.AutoSize = True
        Me.rd_gui_2.BackColor = System.Drawing.Color.Transparent
        Me.rd_gui_2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_gui_2.ForeColor = System.Drawing.Color.White
        Me.rd_gui_2.Location = New System.Drawing.Point(64, 4)
        Me.rd_gui_2.Name = "rd_gui_2"
        Me.rd_gui_2.Size = New System.Drawing.Size(109, 24)
        Me.rd_gui_2.TabIndex = 26
        Me.rd_gui_2.TabStop = True
        Me.rd_gui_2.Text = "100% (기본)"
        Me.rd_gui_2.UseVisualStyleBackColor = False
        '
        'rd_gui_1
        '
        Me.rd_gui_1.AutoSize = True
        Me.rd_gui_1.BackColor = System.Drawing.Color.Transparent
        Me.rd_gui_1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_gui_1.ForeColor = System.Drawing.Color.White
        Me.rd_gui_1.Location = New System.Drawing.Point(4, 4)
        Me.rd_gui_1.Name = "rd_gui_1"
        Me.rd_gui_1.Size = New System.Drawing.Size(56, 24)
        Me.rd_gui_1.TabIndex = 25
        Me.rd_gui_1.TabStop = True
        Me.rd_gui_1.Text = "75%"
        Me.rd_gui_1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rd_cl_2)
        Me.Panel1.Controls.Add(Me.rd_cl_1)
        Me.Panel1.Location = New System.Drawing.Point(152, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 36)
        Me.Panel1.TabIndex = 34
        '
        'rd_cl_2
        '
        Me.rd_cl_2.AutoSize = True
        Me.rd_cl_2.BackColor = System.Drawing.Color.Transparent
        Me.rd_cl_2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_cl_2.ForeColor = System.Drawing.Color.White
        Me.rd_cl_2.Location = New System.Drawing.Point(79, 5)
        Me.rd_cl_2.Name = "rd_cl_2"
        Me.rd_cl_2.Size = New System.Drawing.Size(72, 24)
        Me.rd_cl_2.TabIndex = 26
        Me.rd_cl_2.TabStop = True
        Me.rd_cl_2.Text = "하양색"
        Me.rd_cl_2.UseVisualStyleBackColor = False
        '
        'rd_cl_1
        '
        Me.rd_cl_1.AutoSize = True
        Me.rd_cl_1.BackColor = System.Drawing.Color.Transparent
        Me.rd_cl_1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rd_cl_1.ForeColor = System.Drawing.Color.White
        Me.rd_cl_1.Location = New System.Drawing.Point(4, 4)
        Me.rd_cl_1.Name = "rd_cl_1"
        Me.rd_cl_1.Size = New System.Drawing.Size(72, 24)
        Me.rd_cl_1.TabIndex = 25
        Me.rd_cl_1.TabStop = True
        Me.rd_cl_1.Text = "검은색"
        Me.rd_cl_1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(13, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "정 보"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 133)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(287, 73)
        Me.RichTextBox1.TabIndex = 38
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(207, 116)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(101, 13)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "새 버전 확인하기..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(17, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "자 동  시 작"
        '
        'chk_startup
        '
        Me.chk_startup.AutoSize = True
        Me.chk_startup.BackColor = System.Drawing.Color.Transparent
        Me.chk_startup.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chk_startup.ForeColor = System.Drawing.Color.White
        Me.chk_startup.Location = New System.Drawing.Point(100, 142)
        Me.chk_startup.Margin = New System.Windows.Forms.Padding(1)
        Me.chk_startup.Name = "chk_startup"
        Me.chk_startup.Size = New System.Drawing.Size(210, 24)
        Me.chk_startup.TabIndex = 33
        Me.chk_startup.Text = "Windows 시작시 함께 시작"
        Me.chk_startup.UseVisualStyleBackColor = False
        '
        'OptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 259)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Battify.My.Resources.Resources.icon
        Me.Name = "OptionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MenuPanel.ResumeLayout(False)
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Mode1PN.ResumeLayout(False)
        Me.Mode1PN.PerformLayout()
        Me.Mode2PN.ResumeLayout(False)
        Me.Mode2PN.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CloseBT As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Mode2PN As Panel
    Friend WithEvents Mode1PN As Panel
    Friend WithEvents cka_2 As CheckBox
    Friend WithEvents cka_1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ckc_8 As CheckBox
    Friend WithEvents ckc_6 As CheckBox
    Friend WithEvents ckc_7 As CheckBox
    Friend WithEvents ckc_5 As CheckBox
    Friend WithEvents ckc_4 As CheckBox
    Friend WithEvents ckc_3 As CheckBox
    Friend WithEvents ckc_2 As CheckBox
    Friend WithEvents ckc_1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rd_gui_4 As RadioButton
    Friend WithEvents rd_gui_3 As RadioButton
    Friend WithEvents rd_gui_2 As RadioButton
    Friend WithEvents rd_gui_1 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rd_cl_2 As RadioButton
    Friend WithEvents rd_cl_1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents ckc_0 As CheckBox
    Friend WithEvents cka_mute As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents chk_startup As CheckBox
    Friend WithEvents Label8 As Label
End Class
