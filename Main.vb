Imports System.ComponentModel
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text

Public Class Main

    Dim WithEvents oddBot As New RobotConnection("0.0.0.0", 0)

    Dim map As New robotMap
    Dim MainController
    Dim timer As New Stopwatch

    Public teleop As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            MainController = New AForge.Controls.Joystick(0)
        Catch ex As AForge.NotConnectedException

        End Try
    End Sub 

    Public Sub BotDataRecieved(e As Object) Handles oddBot.DataRecieved
        Console.Text &= (e.ToString)
        Console.Text &= (Environment.NewLine)
        If e.ToString = "//server-stop" Then
            RobotDisable()
        End If
    End Sub

    Private Sub CheckConnection_DoWork(sender As Object, e As DoWorkEventArgs) Handles CheckConnection.DoWork
        lblTimer.Text = timer.Elapsed.Duration.ToString
    End Sub

    Private Sub CheckConnection_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles CheckConnection.RunWorkerCompleted
        If oddBot.ReturnStatus Then
            CheckConnection.RunWorkerAsync()
        Else
            RobotDisable()
        End If
    End Sub
      
    Private Sub JoystickInput_Tick(sender As Object, e As EventArgs) Handles JoystickInput.Tick
        updateGUI()
        lblTimer.Text = timer.Elapsed.ToString
    End Sub

    Dim controllerDataStream As Stream
    Dim joyStickData As AForge.Controls.Joystick.Status
    Public Sub updateGUI()
        joyStickData = MainController.GetCurrentStatus
        leftJoy.JoyPoint(joyStickData.XAxis, joyStickData.YAxis) 
        rightJoy.JoyPoint(joyStickData.UAxis, joyStickData.RAxis)
        AxisBar.Value = joyStickData.ZAxis
        listButton.Items.Clear()

        For Each joystickButton In System.Enum.GetValues(GetType(AForge.Controls.Joystick.Buttons))
            If joystickButton.ToString.Contains("Button") And joyStickData.IsButtonPressed(joystickButton) Then
                listButton.Items.Add(map.getButton(joystickButton))
            End If
        Next
    End Sub

    Public Function getJoystickJSON()
        Dim status As AForge.Controls.Joystick.Status = MainController.GetCurrentStatus

        Dim newJoystickMap As New JoystickData
        newJoystickMap.buttonA = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button1)
        newJoystickMap.buttonB = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button2)
        newJoystickMap.buttonX = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button3)
        newJoystickMap.buttonY = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button4)
        newJoystickMap.joystick_RIGHT_X = status.RAxis
        newJoystickMap.joystick_RIGHT_Y = status.UAxis
        newJoystickMap.joystick_LEFT_X = status.XAxis
        newJoystickMap.joystick_LEFT_Y = status.YAxis
        newJoystickMap.trigger = status.ZAxis
        newJoystickMap.button_BACK = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button7)
        newJoystickMap.button_START = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button8)
        newJoystickMap.button_LEFT_JOY = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button9)
        newJoystickMap.button_RIGHT_JOY = status.IsButtonPressed(AForge.Controls.Joystick.Buttons.Button10)

        Return JsonConvert.SerializeObject(newJoystickMap)
    End Function

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        oddBot = New RobotConnection(txtIP.Text, txtPort.Text)
        If RobotEnable() Then
            My.Computer.Audio.Play(My.Resources.teleop_start, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        RobotDisable()
    End Sub

    Public Function RobotEnable() As Boolean
        oddBot.Connect()
        If oddBot.ReturnStatus = True Then 
            btnDisable.State = oddToggleButton.Status.ON
            statusServerCommunication.Status = True
            controllerDataStream = oddBot.GetStream
            DataSend.RunWorkerAsync()
            Console.AppendText("Connection Status: Connected" & vbNewLine)
            timer.Start()
            Return True
        End If
        Return False
    End Function

    Public Function RobotDisable() As Boolean
        oddBot.Disconnect()
        If oddBot.ReturnStatus = False Then
            btnEnable.State = oddToggleButton.Status.ON
            statusServerCommunication.Status = False
            Console.AppendText("Connection Status: Disconnected" & vbNewLine)
            timer.Stop()
            Return True
        End If
        Return False
    End Function   

    Private Sub OddToggleButton3_Click(sender As Object, e As EventArgs) Handles OddToggleButton3.Click
        If OddToggleButton3.State = oddToggleButton.Status.OFF Then
            teleop = False
        Else
            teleop = True
            DataSend.RunWorkerAsync()
        End If
    End Sub

    Private Sub Console_TextChanged(sender As Object, e As EventArgs) Handles Console.TextChanged
        Console.SelectionStart = Console.Text.Length
        Console.ScrollToCaret()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        oddBot.SendData(txtCommand.Text)
        txtCommand.Clear()
    End Sub

    Private Sub txtCommand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCommand.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCommand.Clear()
            oddBot.SendData(txtCommand.Text)
        End If
        e.Handled = True
    End Sub

    Private Sub DataSend_DoWork(sender As Object, e As DoWorkEventArgs) Handles DataSend.DoWork
        Try
            Dim ba As Byte() = New ASCIIEncoding().GetBytes(getJoystickJSON)
            controllerDataStream.Write(ba, 0, ba.Length)
            Threading.Thread.Sleep(100)
        Catch ex As Exception
            Console.Text &= ("Error..... " & ex.StackTrace) & vbNewLine
        End Try
    End Sub

    Private Sub DataSend_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles DataSend.RunWorkerCompleted
        If statusServerCommunication.Status And teleop Then
            DataSend.RunWorkerAsync()
        End If
    End Sub

    Private Sub OddButtonRed1_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(getJoystickJSON)
    End Sub
End Class