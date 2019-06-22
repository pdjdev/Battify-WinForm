Imports System.ComponentModel

Public Class PopupForm
    Dim col As Integer = 255
    Public curPercent As String = Nothing
    Public nextstr As String = Nothing
    Dim ispercent As Boolean = True

    Dim zoomfactor As Single = 1.0!
    Dim popupMargin As Integer = 20

    Public isPopupMode As Boolean = False
    Dim modeCount As Integer = 0 '0 = 처음 텍스트 전환 / 1 = 화면 끄기

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Private Sub AniTimer_Fadeout_Tick(sender As Object, e As EventArgs) Handles AniTimer_Fadeout.Tick
        If col - 5 <= 0 Then
            col = 0
            AniTimer_Fadeout.Stop()
            ModeSwitcher()

            AniTimer_Fadein.Start()
        Else
            col -= 15
        End If

        MainLabel.ForeColor = Color.FromArgb(col, col, col)
    End Sub

    Private Sub AniTimer_Fadein_Tick(sender As Object, e As EventArgs) Handles AniTimer_Fadein.Tick
        If col + 5 >= 255 Then
            col = 255
            AniTimer_Fadein.Stop()
        Else
            col += 15
        End If

        MainLabel.ForeColor = Color.FromArgb(col, col, col)
    End Sub

    Sub ModeSwitcher()
        If ispercent Then
            ispercent = False
            MainLabel.Font = New Font("맑은 고딕 Semilight", 15.0! * zoomfactor)
            MainLabel.Text = nextstr

        Else
            ispercent = True
            MainLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            MainLabel.Text = curPercent

        End If
    End Sub

    Sub BattDrawer()
        If IsNumeric(curPercent) Then
            Dim tmp_per As Integer = Convert.ToInt32(curPercent)

            Select Case tmp_per
                Case < 11
                    BattImg.Image = My.Resources.fill_10
                Case < 21
                    BattImg.Image = My.Resources.fill_20
                Case < 31
                    BattImg.Image = My.Resources.fill_30
                Case < 41
                    BattImg.Image = My.Resources.fill_40
                Case < 51
                    BattImg.Image = My.Resources.fill_50
                Case < 61
                    BattImg.Image = My.Resources.fill_60
                Case < 71
                    BattImg.Image = My.Resources.fill_70
                Case < 81
                    BattImg.Image = My.Resources.fill_80
                Case < 91
                    BattImg.Image = My.Resources.fill_90
                Case Else
                    BattImg.Image = My.Resources.fill_100
            End Select

        Else
            BattImg.Image = Nothing
        End If
    End Sub

    Private Sub SwitchTimer_Tick(sender As Object, e As EventArgs) Handles SwitchTimer.Tick
        If modeCount = 0 Then
            AniTimer_Fadein.Stop()
            AniTimer_Fadeout.Start()
            SwitchTimer.Interval = 4000
            modeCount = 1
        Else
            Me.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        ZoomForm(Me, zoomfactor, False)

        Dim marign As Integer = dpicalc(Me, popupMargin)

        Dim showx = Screen.PrimaryScreen.WorkingArea.Width - Width - marign
        Dim showy = Screen.PrimaryScreen.WorkingArea.Height - Height - marign
        SetDesktopLocation(showx, showy)

        MainLabel.Text = curPercent + "%"
        BattDrawer()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FadeOut(Me)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If isPopupMode Then SwitchTimer.Start()
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub
End Class
