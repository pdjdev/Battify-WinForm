Imports System.ComponentModel

Public Class TrayForm
    Dim nowPlugged As Integer = -2
    Dim nowPowerType As Integer
    Dim nowPercent As Integer

    Dim prePlugged As Integer = -2
    Dim prePowerType As Integer = -1
    Dim prePercent As Integer


    Dim nowNotifyType As String = ""
    Dim preNotifyType As String = ""



    Private Sub TrayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        EventCheck.Start()
    End Sub

    Private Sub EventCheck_Tick(sender As Object, e As EventArgs) Handles EventCheck.Tick
        BattChkEvent()
    End Sub

    Sub BattChkEvent()
        '상황표시 폼이 있으면 디버그 모드 진입
        Dim debugmode As Boolean = Application.OpenForms().OfType(Of statusform).Any

        nowPlugged = Checkplug() '전원연결여부
        nowPowerType = CheckType() '배터리충전여부
        nowPercent = Checkbatt() '배터리퍼센트

        If debugmode Then statusform.Label1.Text = "nowPowerType: " + nowPowerType.ToString _
            + vbCr + "prePowerType: " + prePowerType.ToString _
            + vbCr + "nowPlugged: " + nowPlugged.ToString _
            + vbCr + "prePlugged: " + prePlugged.ToString

        nowPlugged = 0
        nowPowerType = 0
        nowPercent = 27

        '플러그드 종류:
        '0 - 연결 안됨 (사용중)
        '1 - 연결됨 (연결, 연결하면서 충전)
        '-1 - 알 수 없음

        '파워타이프 종류:
        '배터리 없음 - 128
        '알 수 없음 - 255
        '충전중 - 8, 9, 10
        '충전 중이 아님(사용중) - 0, 1, 2, 4

        Dim trayText As String = Nothing


        '[배터리의] 상태 알기
        If nowPowerType = BatteryChargeStatus.NoSystemBattery Then
            '배터리 없음
            nowNotifyType = "nobat"
            trayText = "배터리 없음"
        ElseIf nowPowerType = BatteryChargeStatus.Unknown Then
            '알수 없음
            nowNotifyType = "unknow"
            trayText = "알 수 없음"
        Else
            '이제 취급 가능한 정상적인 배터리 사용 상태

            If nowPlugged = 0 Then

                nowNotifyType = "using"
                trayText = "사용 중"

                '충전 중이었다가 빡 뺐을때
                If prePlugged = 1 Then

                    nowNotifyType = "unplug"

                ElseIf prePlugged = 0 Then
                    '걍 사용중


                    Select Case nowPercent
                        Case < 5 '5퍼 이하
                            nowNotifyType = "5left"
                            trayText = "사용 중 - 배터리 매우 부족"

                        Case < 15 '15퍼 이하
                            nowNotifyType = "15left"
                            trayText = "사용 중 - 배터리 부족"

                        Case < 20 '20퍼 이하
                            nowNotifyType = "20left"
                            trayText = "사용 중 - 배터리 부족"

                        Case < 30 '30퍼 이하
                            nowNotifyType = "30left"
                            trayText = "사용 중 - 충전기 준비"

                        Case < 50 '50퍼 이하
                            nowNotifyType = "50left"

                    End Select

                    If Application.OpenForms().OfType(Of PopupForm).Any Then
                        '팝업 켜져있을시 이거는 걍 싸그리 무시 (이전알림을 업데이트함으로써)
                        preNotifyType = nowNotifyType
                    End If


                End If

            ElseIf nowPlugged = 1 Then

                If nowPowerType >= 8 And nowPowerType <= 10 Then
                    nowNotifyType = "plugged" '-charge"
                    trayText = "충전 중"
                Else
                    nowNotifyType = "plugged"
                    trayText = "케이블 연결됨 (충전 중 아님)"
                End If

                '안꽂았다가 빡 꽂았을때-가 아닐때 (이전-충전, 현재-충전 일시)
                If prePlugged = 1 Then

                    Select Case nowPercent
                        Case 50
                            nowNotifyType = "50charge"

                        Case 100
                            nowNotifyType = "100charge"
                            trayText = "충전 완료"

                    End Select

                ElseIf prePlugged = 0 Then '빡 꽂은거 맞음 근데

                    If nowPercent = 100 Then
                        nowNotifyType = "100charge"
                        trayText = "충전 완료"
                    End If

                End If

            End If

        End If

        If debugmode Then statusform.Label2.Text = nowNotifyType + "/" + preNotifyType

        '팝업 판별
        If Not preNotifyType = nowNotifyType Then

            If My.Settings.alimlist.Contains("[" + nowNotifyType + "]") Then
                ShowPopup()
                preNotifyType = nowNotifyType

            End If
        End If

        '트레이 아이콘 숫자 표시 판별
        If Not prePercent = nowPercent Then

            If nowNotifyType = "nobat" Or nowNotifyType = "unknow" Then
                DrawTray(-1)
            Else
                DrawTray(nowPercent)
            End If

        End If

        If nowPowerType = 128 Or nowPowerType = 255 Then
            trayText = "?% - " + trayText
        Else
            trayText = nowPercent.ToString + "% - " + trayText
        End If

        If Not NotifyIcon1.Text = trayText Then NotifyIcon1.Text = trayText


        prePlugged = nowPlugged
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

            Case "plugged"

                If nowPowerType >= 8 And nowPowerType <= 10 Then
                    first_str = nowPercent
                    second_str = "충전 중"
                Else
                    first_str = nowPercent
                    second_str = "플러그 연결됨" + vbCr + "(충전 중이 아님)"
                End If
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_charge
                If Not My.Settings.mute And My.Settings.snd.Contains("0") Then My.Computer.Audio.Play(My.Resources.plug, AudioPlayMode.Background)

            Case "unplug"
                first_str = nowPercent
                second_str = "연결 해제됨"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

            Case "5left"
                first_str = nowPercent
                second_str = "배터리 매우 부족"
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
                second_str = "반 이하 남음"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

            Case "50charge"
                first_str = nowPercent
                second_str = "반이 충전됨"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_charge

            Case "100charge"
                first_str = nowPercent
                second_str = "충전 완료"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_full
                If Not My.Settings.mute And My.Settings.snd.Contains("1") Then My.Computer.Audio.Play(My.Resources.full, AudioPlayMode.Background)

            Case "using"
                first_str = nowPercent
                second_str = "배터리 사용중"
                PopupForm.BattImg.BackgroundImage = My.Resources.batt_bg_usinge

        End Select

        With PopupForm
            .curPercent = first_str
            .nextstr = second_str
            .isPopupMode = True
            .TopMost = True
        End With

        PopupForm.Show()
    End Sub

    Sub DrawTray(percent As Integer)

        Dim args As String = Nothing

        If My.Settings.color = "black" Then
            args = "__2_"
        End If

        If percent >= 0 And percent <= 100 Then
            NotifyIcon1.Icon = My.Resources.ResourceManager.GetObject("_" + percent.ToString + args)
            NotifyIcon1.Visible = True
        Else
            NotifyIcon1.Icon = My.Resources.ResourceManager.GetObject("_0" + args)
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
        If Not My.Settings.mute Then
            MutesoundToolStripMenuItem.Text = "음소거"
        Else
            MutesoundToolStripMenuItem.Text = "알림 소리 활성화"
        End If

        TextcolorToolStripMenuItem.Text = "텍스트 색: "

        If My.Settings.color = "black" Then
            TextcolorToolStripMenuItem.Text += "검정"
        Else
            TextcolorToolStripMenuItem.Text += "하양"
        End If
    End Sub

    Private Sub TrayForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        statusform.Show()
    End Sub

    Private Sub TrayForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon1.Icon = Nothing
        NotifyIcon1.Visible = False
    End Sub

    Private Sub MutesoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MutesoundToolStripMenuItem.Click
        My.Settings.mute = Not My.Settings.mute
        My.Settings.Save()
        My.Settings.Reload()

        If Not My.Settings.mute Then
            MutesoundToolStripMenuItem.Text = "음소거"
        Else
            MutesoundToolStripMenuItem.Text = "알림 소리 활성화"
        End If
    End Sub

    Public Sub redaw_Tray()
        If nowNotifyType = "nobat" Or nowNotifyType = "unknow" Then
            DrawTray(-1)
        Else
            DrawTray(nowPercent)
        End If
    End Sub


    Private Sub TextcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextcolorToolStripMenuItem.Click
        If My.Settings.color = "white" Then
            My.Settings.color = "black"
        Else
            My.Settings.color = "white"
        End If

        My.Settings.Save()
        My.Settings.Reload()
        redaw_Tray()

    End Sub

    Private Sub 설정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 설정ToolStripMenuItem.Click
        OptionForm.Show()
    End Sub
End Class