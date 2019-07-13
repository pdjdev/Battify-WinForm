Imports System.ComponentModel

Public Class OptionForm

    Dim normal_color As Color = Color.FromArgb(34, 34, 34)
    Dim active_color As Color = Color.FromArgb(50, 50, 50)

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0
        Dim marign As Integer = dpicalc(Me, PopupForm.popupMargin)

        Dim showx = Screen.PrimaryScreen.WorkingArea.Width - Width - marign
        Dim showy = Screen.PrimaryScreen.WorkingArea.Height - Height - marign
        SetDesktopLocation(showx, showy)

        LoadSet()

        UpdateMode(1)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        UpdateMode(1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        UpdateMode(2)
    End Sub

    Sub UpdateMode(mode As Integer)
        Select Case mode
            Case 1
                Label1.BackColor = active_color
                Label2.BackColor = normal_color
                Mode1PN.Visible = True
                Mode2PN.Visible = False
            Case 2
                Label1.BackColor = normal_color
                Label2.BackColor = active_color
                Mode1PN.Visible = False
                Mode2PN.Visible = True
        End Select
    End Sub

    Sub SaveSet()
        Dim alimlist As String = Nothing
        If ckc_0.Checked Then alimlist += "[nobat]"
        If ckc_1.Checked Then alimlist += "[plugged]"
        If ckc_2.Checked Then alimlist += "[unplug][using]"
        If ckc_3.Checked Then alimlist += "[5left][5charge]"
        If ckc_4.Checked Then alimlist += "[15left][15charge]"
        If ckc_5.Checked Then alimlist += "[20left][20charge]"
        If ckc_6.Checked Then alimlist += "[30left][30charge]"
        If ckc_7.Checked Then alimlist += "[50left][50charge]"
        If ckc_8.Checked Then alimlist += "[100charge]"
        My.Computer.Clipboard.SetText(alimlist)
        My.Settings.alimlist = alimlist

        My.Settings.mute = cka_mute.Checked

        Dim snd As String = Nothing
        If cka_1.Checked Then snd += "0"
        If cka_1.Checked Then snd += "1"
        My.Settings.snd = snd

        If rd_cl_1.Checked Then My.Settings.color = "black"
        If rd_cl_2.Checked Then My.Settings.color = "white"

        If rd_gui_1.Checked Then My.Settings.zoomfactor = 0.75
        If rd_gui_2.Checked Then My.Settings.zoomfactor = 1.0
        If rd_gui_3.Checked Then My.Settings.zoomfactor = 1.25
        If rd_gui_4.Checked Then My.Settings.zoomfactor = 1.5

        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Sub LoadSet()
        Dim tmpchk = My.Settings.alimlist

        If tmpchk.Contains("[nobat]") Then ckc_0.Checked = True
        If tmpchk.Contains("[plugged]") Then ckc_1.Checked = True
        If tmpchk.Contains("[unplug]") Or tmpchk.Contains("[using]") Then ckc_2.Checked = True
        If tmpchk.Contains("[5left]") Or tmpchk.Contains("[5charge]") Then ckc_3.Checked = True
        If tmpchk.Contains("[15left]") Or tmpchk.Contains("[15charge]") Then ckc_4.Checked = True
        If tmpchk.Contains("[20left]") Or tmpchk.Contains("[20charge]") Then ckc_5.Checked = True
        If tmpchk.Contains("[30left]") Or tmpchk.Contains("[30charge]") Then ckc_6.Checked = True
        If tmpchk.Contains("[50left]") Or tmpchk.Contains("[50charge]") Then ckc_7.Checked = True
        If tmpchk.Contains("[100charge]") Then ckc_8.Checked = True

        tmpchk = My.Settings.snd

        If My.Settings.mute Then cka_mute.Checked = True
        If tmpchk.Contains("0") Then cka_1.Checked = True
        If tmpchk.Contains("1") Then cka_2.Checked = True

        Select Case My.Settings.color
            Case "black"
                rd_cl_1.Checked = True
            Case "white"
                rd_cl_2.Checked = True
        End Select

        Select Case My.Settings.zoomfactor
            Case 0.75
                rd_gui_1.Checked = True
            Case 1
                rd_gui_2.Checked = True
            Case 1.25
                rd_gui_3.Checked = True
            Case 1.5
                rd_gui_4.Checked = True
        End Select

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FadeOut(Me)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSet()
        TrayForm.redaw_Tray()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cka_mute.CheckedChanged
        cka_1.Enabled = Not cka_mute.Checked
        cka_2.Enabled = Not cka_mute.Checked
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs)
        CloseBT.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs)
        CloseBT.BackColor = Color.Transparent
    End Sub
End Class