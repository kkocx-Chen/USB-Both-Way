Imports LED_Arduino.EasyTool


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim command(1) As Byte
        command = EasyTool.ReadCommand(SerialPort1)
        Dim ledID As Byte = command(0)
        Select Case ledID
            Case 0
                OvalShape1.FillColor = Color.DarkRed
            Case 1
                OvalShape2.FillColor = Color.DarkRed
            Case 2
                OvalShape3.FillColor = Color.DarkRed
            Case 3
                OvalShape4.FillColor = Color.DarkRed
            Case 4
                OvalShape5.FillColor = Color.DarkRed
            Case 5
                OvalShape6.FillColor = Color.DarkRed
            Case 6
                OvalShape7.FillColor = Color.DarkRed
            Case 7
                OvalShape8.FillColor = Color.DarkRed
            Case 8
                OvalShape1.FillColor = Color.Black
            Case 9
                OvalShape2.FillColor = Color.Black
            Case 10
                OvalShape3.FillColor = Color.Black
            Case 11
                OvalShape4.FillColor = Color.Black
            Case 12
                OvalShape5.FillColor = Color.Black
            Case 13
                OvalShape6.FillColor = Color.Black
            Case 14
                OvalShape7.FillColor = Color.Black
            Case 15
                OvalShape8.FillColor = Color.Black
        End Select
    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OvalShape1_Click_1(sender As Object, e As EventArgs) Handles OvalShape1.Click, OvalShape8.Click, OvalShape7.Click, OvalShape6.Click, OvalShape5.Click, OvalShape4.Click, OvalShape3.Click, OvalShape2.Click

    End Sub

    Private Sub AllLEDON_Click(sender As Object, e As EventArgs) Handles AllLEDON.Click
        If AllLEDON_Click() Then
            SendCommand(SerialPort1.1)
        End If

    End Sub
End Class
