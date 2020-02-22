Imports Microsoft.Win32
Imports System.Net.NetworkInformation
Public Class Form1
    Dim say As Integer = 0
    Private Sub CarbonFiberButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarbonFiberButton1.Click
        CarbonFiberTextBox1.Text = ""
        say = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (say < 100) Then
            say += 1
            CarbonFiberProgressBar1.Progress = say
        Else
            Timer1.Enabled = False
            Dim rkey As RegistryKey = Registry.LocalMachine
            CarbonFiberTextBox1.Text = MacAddress()
            Clipboard.SetText(CarbonFiberTextBox1.Text)
        End If
    End Sub
    Function MacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(0).GetPhysicalAddress.ToString()
    End Function
    Private Sub CarbonFiberButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarbonFiberButton2.Click
        Application.Exit()
    End Sub
End Class
