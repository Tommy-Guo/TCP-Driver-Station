Imports AForge
Imports Newtonsoft.Json

Public Class robotMap

    Public Function getButton(input As AForge.Controls.Joystick.Buttons) As JoystickButtons
        Select Case input
            Case Controls.Joystick.Buttons.Button1
                Return JoystickButtons.A
            Case Controls.Joystick.Buttons.Button2
                Return JoystickButtons.B
            Case Controls.Joystick.Buttons.Button3
                Return JoystickButtons.X
            Case Controls.Joystick.Buttons.Button4
                Return JoystickButtons.Y
            Case Controls.Joystick.Buttons.Button5
                Return JoystickButtons.LEFT_TRIGGER
            Case Controls.Joystick.Buttons.Button6
                Return JoystickButtons.RIGHT_TRIGGER
            Case Controls.Joystick.Buttons.Button7
                Return JoystickButtons.BACK
            Case Controls.Joystick.Buttons.Button8
                Return JoystickButtons.START
            Case Controls.Joystick.Buttons.Button9
                Return JoystickButtons.LEFT_JOY_BUTTON
            Case Controls.Joystick.Buttons.Button10
                Return JoystickButtons.RIGHT_JOY_BUTTON
            Case Else
                Return JoystickButtons.NOTHING
        End Select
    End Function

    Public Function getButtonID(input As AForge.Controls.Joystick.Buttons) As Integer
        Select Case input
            Case AForge.Controls.Joystick.Buttons.Button1
                Return 1
            Case AForge.Controls.Joystick.Buttons.Button2
                Return 2
            Case AForge.Controls.Joystick.Buttons.Button3
                Return 3
            Case AForge.Controls.Joystick.Buttons.Button4
                Return 4
            Case AForge.Controls.Joystick.Buttons.Button5
                Return 5
            Case AForge.Controls.Joystick.Buttons.Button6
                Return 6
            Case AForge.Controls.Joystick.Buttons.Button7
                Return 7
            Case AForge.Controls.Joystick.Buttons.Button8
                Return 8
            Case AForge.Controls.Joystick.Buttons.Button9
                Return 9
            Case AForge.Controls.Joystick.Buttons.Button10
                Return 10
            Case Else
                Return 0
        End Select
    End Function

    Public Function getButtonID(input As JoystickButtons) As Integer
        Select Case input
            Case JoystickButtons.A
                Return 1
            Case JoystickButtons.B
                Return 2
            Case JoystickButtons.X
                Return 3
            Case JoystickButtons.Y
                Return 4
            Case JoystickButtons.LEFT_TRIGGER
                Return 5
            Case JoystickButtons.RIGHT_TRIGGER
                Return 6
            Case JoystickButtons.BACK
                Return 7
            Case JoystickButtons.START
                Return 8
            Case JoystickButtons.LEFT_JOY_BUTTON
                Return 9
            Case JoystickButtons.RIGHT_JOY_BUTTON
                Return 10
            Case Else
                Return 0
        End Select
    End Function
End Class

Public Enum JoystickButtons
    A = 1
    B = 2
    X = 3
    Y = 4
    LEFT_TRIGGER = 5
    RIGHT_TRIGGER = 6
    BACK = 7
    START = 8
    LEFT_JOY_BUTTON = 9
    RIGHT_JOY_BUTTON = 10
    [NOTHING] = 11
End Enum

Public Class JoystickData

    <JsonProperty("joystick_RIGHT_X")>
    Public Property joystick_RIGHT_X As Double

    <JsonProperty("joystick_RIGHT_Y")>
    Public Property joystick_RIGHT_Y As Double

    <JsonProperty("joystick_LEFT_X")>
    Public Property joystick_LEFT_X As Double

    <JsonProperty("joystick_LEFT_Y")>
    Public Property joystick_LEFT_Y As Double

    <JsonProperty("trigger")>
    Public Property trigger As Double

    <JsonProperty("buttonA")>
    Public Property buttonA As Boolean

    <JsonProperty("buttonB")>
    Public Property buttonB As Boolean

    <JsonProperty("buttonX")>
    Public Property buttonX As Boolean

    <JsonProperty("buttonY")>
    Public Property buttonY As Boolean

    <JsonProperty("button_BACK")>
    Public Property button_BACK As Boolean

    <JsonProperty("button_START")>
    Public Property button_START As Boolean

    <JsonProperty("button_LEFT_JOY")>
    Public Property button_LEFT_JOY As Boolean

    <JsonProperty("button_RIGHT_JOY")>
    Public Property button_RIGHT_JOY As Boolean
End Class