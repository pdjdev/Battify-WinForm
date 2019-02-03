Imports System.Runtime.InteropServices

Module GUIEffect

#Region "Aero 그림자 효과 (Vista이상)"
    Structure MARGINS
        Public Left, Right, Top, Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    Public Function CreateDropShadow(form As Form) As Boolean
        Try
            Dim val As Integer = 2
            Dim ret1 As Integer = DwmSetWindowAttribute(form.Handle, 2, val, 4)

            If ret1 = 0 Then
                Dim m As MARGINS = New MARGINS() With {
                        .Left = 0,
                        .Right = 0,
                        .Top = 1,
                        .Bottom = 0
                    }

                Dim ret2 As Integer = DwmExtendFrameIntoClientArea(form.Handle, m)
                Return ret2 = 0
            Else
                Return False
            End If
        Catch ex As Exception
            'dwmapi.dll 없음
            Return False
        End Try
    End Function

#End Region

#Region "DPI 계산 (고해상도 디스플레이용)"
    Public Function dpicalc(targetform As Form, size As Integer)
        Dim g As Graphics = targetform.CreateGraphics
        Dim dpi = g.DpiX.ToString()

        Dim current = dpi / 96
        Dim expand = current * size

        Return expand
    End Function
#End Region

#Region "창 페이드 인/아웃 효과"
    Public Sub FadeIn(Form As Form, goalopacity As Double)
        Form.Opacity = 0

        Do While Form.Opacity < goalopacity - 0.1
            Form.Opacity += 0.1
            Threading.Thread.Sleep(20)
        Loop

        Form.Opacity = goalopacity

    End Sub

    Public Sub FadeOut(Form As Form)

        Do While Not Form.Opacity = 0
            Form.Opacity = Form.Opacity - 0.1
            Threading.Thread.Sleep(20)
        Loop

    End Sub
#End Region

#Region "컨트롤 조정"
    '참조 코드:http://justsomevbcode.blogspot.com/2011/06/how-to-find-all-child-controls-from.html
    'by Adam Zuckerman

    ''' <summary>
    ''' 재귀적으로 폼에 있는 모든 컨트롤을 탐색합니다
    ''' </summary>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllChildren(ByRef StartingContainer As System.Windows.Forms.Form) As List(Of System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        Dim oControl As System.Windows.Forms.Control
        For Each oControl In StartingContainer.Controls
            Children.Add(oControl)
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllChildren())
            End If
        Next

        Return Children
    End Function

    ''' <summary>
    ''' 컨트롤의 모든 컨트롤을 탐색합니다
    ''' </summary>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllChildren(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If

        Return Children
    End Function

    ''' <summary>
    ''' 폼을 확대합니다
    ''' </summary>
    ''' <param name="Form">대상 폼</param>
    ''' <param name="ZoomFactor">확대 배수</param>
    ''' <param name="Refresh">Refresh 여부</param>
    Public Sub ZoomForm(Form As Form, ZoomFactor As Double, Refresh As Boolean)

        Form.Width *= ZoomFactor
        Form.Height *= ZoomFactor

        For Each c As Control In Form.FindAllChildren
            c.Width *= ZoomFactor
            c.Height *= ZoomFactor
            c.Location = New Point(c.Location.X * 2, c.Location.Y * 2)

            Try
                c.Font = New System.Drawing.Font(c.Font.Name, c.Font.Size * ZoomFactor, c.Font.Style, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Catch ex As Exception


            End Try
        Next

        If Refresh Then Form.Refresh()
    End Sub
#End Region

End Module
