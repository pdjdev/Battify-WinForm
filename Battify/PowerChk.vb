Module PowerChk
    Dim psBattery As PowerStatus = SystemInformation.PowerStatus

    Public Function Checkbatt() As Integer
        Dim perFull As Single = psBattery.BatteryLifePercent
        Return (perFull * 100)
    End Function

    Public Function Checkplug() As Integer
        If psBattery.PowerLineStatus = PowerLineStatus.Online Then
            Return 1
        ElseIf psBattery.PowerLineStatus = PowerLineStatus.Offline Then
            Return 0
        Else
            Return -1
        End If
    End Function

    Public Function CheckType() As BatteryChargeStatus '128 = 전원 연결
        Dim type = psBattery.BatteryChargeStatus
        Return type
    End Function
End Module
