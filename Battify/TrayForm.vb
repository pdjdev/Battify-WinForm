Public Class TrayForm
    Public ChargePlugged As Boolean = False

    Dim nowPowerType As Integer
    Dim nowPercent As Integer
    Dim nowPlugged As Boolean

    Dim prePowerType As Integer
    Dim prePercent As Integer
    Dim prePlugged As Boolean

    Dim nowNotifyType As String = ""
    Dim preNotifyType As String = ""

    Private Sub TrayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        EventCheck.Start()
    End Sub

    Private Sub EventCheck_Tick(sender As Object, e As EventArgs) Handles EventCheck.Tick

        nowPowerType = CheckType()
        nowPercent = Checkbatt()

        If nowPowerType = BatteryChargeStatus.NoSystemBattery Then
            '배터리 없음
            nowNotifyType = "nobat"
            nowPlugged = True
        ElseIf nowPowerType = BatteryChargeStatus.Unknown Then
            '알수 없음
            nowNotifyType = "unknow"
            nowPlugged = False
        ElseIf nowPowerType = 8 Or nowPowerType = 9 Then
            '충전 중
            nowNotifyType = "charg"
            nowPlugged = True
        Else
            '충전 중이 아님(사용중)
            nowNotifyType = "using"
            nowPlugged = False
        End If



        If nowNotifyType = "using" Then

            '충전 중이었다가 빡 뺐을때
            If preNotifyType = "charg" Then
                nowNotifyType = "unplug"

            Else
                '걍 사용중
                Select Case nowPercent
                    Case < 5 '5퍼 이하
                        nowNotifyType = "5left"

                    Case < 15 '15퍼 이하
                        nowNotifyType = "15left"

                    Case < 20 '20퍼 이하
                        nowNotifyType = "20lest"

                    Case < 30 '30퍼 이하
                        nowNotifyType = "30left"

                    Case < 50 '50퍼 이하
                        nowNotifyType = "50left"

                End Select


            End If

        ElseIf nowNotifyType = "charg" Then

            '안꽂았다가 빡 꽂았을때-가 아닐때
            If Not preNotifyType = "using" Then

                Select Case nowPercent
                    Case 50
                        nowNotifyType = "50charge"

                    Case 100
                        nowNotifyType = "100charge"

                End Select
            Else '빡 꽂은거 맞음 근데

                If nowPercent = 100 Then nowNotifyType = "100charge"

            End If

        End If



        If Not preNotifyType = nowNotifyType Then

            ShowPopup()
            preNotifyType = nowNotifyType

        End If

        If Not prePercent = nowPercent Then

            If nowNotifyType = "nobat" Or nowNotifyType = "unknow" Then
                DrawTray(-1)
            Else
                DrawTray(nowPercent)
            End If


        End If

        prePowerType = nowPowerType
        prePercent = nowPercent

    End Sub

    Sub ShowPopup()
        Dim first_str As String = ""
        Dim second_str As String = ""

        Select Case nowNotifyType
            Case "nobat"
                first_str = "-"
                second_str = "배터리 없음"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_no

            Case "unknow"
                first_str = "-"
                second_str = "알 수 없는 상태"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg

            Case "charg"
                first_str = nowPercent
                second_str = "충전 중"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_charge
                My.Computer.Audio.Play(My.Resources.plug, AudioPlayMode.Background)

            Case "unplug"
                first_str = nowPercent
                second_str = "연결 해제됨"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

            Case "5left"
                first_str = nowPercent
                second_str = "배터리 부족"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_warn

            Case "15left"
                first_str = nowPercent
                second_str = "배터리 부족"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_warn

            Case "20left"
                first_str = nowPercent
                second_str = "배터리 부족"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_warn

            Case "30left"
                first_str = nowPercent
                second_str = "충전기 준비"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_warn

            Case "50left"
                first_str = nowPercent
                second_str = "반이 남아있음"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

            Case "50charge"
                first_str = nowPercent
                second_str = "반이 충전됨"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_charge

            Case "100charge"
                first_str = nowPercent
                second_str = "충전 완료"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_full
                My.Computer.Audio.Play(My.Resources.full, AudioPlayMode.Background)

            Case "using"
                first_str = nowPercent
                second_str = "배터리 사용중"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

        End Select

        With PopupForm
            .curPercent = first_str
            .nextstr = second_str
            .isPopupMode = True
        End With

        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.PrimaryScreen.WorkingArea.Width - PopupForm.Width - marign
        Dim showy = Screen.PrimaryScreen.WorkingArea.Height - PopupForm.Height - marign
        PopupForm.SetDesktopLocation(showx, showy)
        PopupForm.Show()
    End Sub

    Sub DrawTray(percent As Integer)
        If percent >= 0 And percent <= 100 Then
            NotifyIcon1.Icon = My.Resources.ResourceManager.GetObject("_" + percent.ToString)
            NotifyIcon1.Visible = True
        Else
            NotifyIcon1.Icon = My.Resources.ResourceManager.GetObject("_0")
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub 팝업표시ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 팝업표시ToolStripMenuItem.Click
        ShowPopup()
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub TrayForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub
End Class