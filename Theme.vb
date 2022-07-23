Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

''' <summary>
''' This file contains all the controls and themed controls for the Driver station.
''' </summary>

Public Class VerticalSplitter
    Inherits Control

    Sub New()
        DoubleBuffered = True
        Size = New Size(1, Height)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.Clear(Color.Black)
    End Sub

    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e) 
        Size = New Size(1, Height)
    End Sub
End Class

Public Class HorizontalSplitter
    Inherits Control

    Sub New()
        DoubleBuffered = True
        Size = New Size(Width, 1)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.Clear(Color.Black)
    End Sub

    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e) 
        Size = New Size(Width, 1)
    End Sub
End Class

Public Class oddPanel
    Inherits Panel

    Private _title As String = "Driver Station Panel"
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
        ForeColor = Color.White
        BackColor = Color.FromArgb(51, 51, 51)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        g.Clear(BackColor)
        Dim titleSize As New Size(g.MeasureString(Title, Font).Width, g.MeasureString(Title, Font).Height) 
        If String.IsNullOrEmpty(Title) Then
            g.DrawRectangle(New Pen(Color.FromArgb(41, 41, 41)), New Rectangle(0, 0, Width - 1, Height - 1))
        Else
            g.DrawRectangle(New Pen(Color.FromArgb(41, 41, 41)), New Rectangle(0, 1 + titleSize.Height / 2, Width - 1, Height - 2 - titleSize.Height / 2))
        End If
        g.FillRectangle(New SolidBrush(BackColor), 7, 3, titleSize.Width + 3, titleSize.Height + 3)
        g.DrawString(Title, Font, New SolidBrush(ForeColor), 9, 1)
    End Sub
End Class

Public Class oddTabControl
    Inherits TabControl

    Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(100, 40)
        Alignment = TabAlignment.Top
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim b As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(b)
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        g.Clear(FromHex("#424242"))
        For i = 0 To TabCount - 1
            Dim tabRect As Rectangle = GetTabRect(i)
            If i = SelectedIndex Then
                g.FillRectangle(New SolidBrush(FromHex("#F0544C")), New Rectangle(tabRect.X, tabRect.Height - 3, tabRect.Width, 2))
                g.DrawString(TabPages(i).Text, Font, New SolidBrush(FromHex("#F0544C")), New Rectangle(tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            Else
                g.DrawString(TabPages(i).Text, Font, New SolidBrush(FromHex("#CFCFCF")), New Rectangle(tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End If
        Next
        e.Graphics.DrawImage(b.Clone, 0, 0) : g.Dispose() : b.Dispose()
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        Invalidate()
    End Sub

    Public Sub FillRoundedRectangle(ByVal g As Drawing.Graphics, ByVal r As Rectangle, ByVal d As Integer, ByVal b As Brush)
        Dim mode As Drawing2D.SmoothingMode = g.SmoothingMode
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        g.FillPie(b, r.X, r.Y, d, d, 180, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y, d, d, 270, 90)
        g.FillPie(b, r.X, r.Y + r.Height - d, d, d, 90, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        g.FillRectangle(b, CInt(r.X + d / 2), r.Y, r.Width - d, CInt(d / 2))
        g.FillRectangle(b, r.X, CInt(r.Y + d / 2), r.Width, CInt(r.Height - d))
        g.FillRectangle(b, CInt(r.X + d / 2), CInt(r.Y + r.Height - d / 2), CInt(r.Width - d), CInt(d / 2))
        g.SmoothingMode = mode
    End Sub

    Public Function FromHex(hex As String) As Color
        Return ColorTranslator.FromHtml(hex.Replace("#", "").Insert(0, "#"))
    End Function
End Class

Public Class oddButton '207, 82
    Inherits ButtonClass

    Private _buttonColor As Color = FromHex("#444444")
    Private _textColour As Color = Color.White

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

        If Enabled Then
            If MouseState = mouseStates.Down Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, FromHex("#3A3A3A"), FromHex("#3A3A3A")), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(_textColour), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            ElseIf MouseState = mouseStates.Hover Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, FromHex("#3F3F3F"), FromHex("#3F3F3F")), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(_textColour), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            Else
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, FromHex("#444444"), FromHex("#444444")), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(_textColour), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            End If
        Else
            g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, FromHex("#303030"), Color.Black), 0, 0, Width + 1, Height + 1)
            g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(82, 82, 82)), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
        End If

    End Sub
End Class

Public Class oddButtonRed
    Inherits ButtonClass

    Dim redColour As Color = FromHex("F0544C")

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

        If MouseState = mouseStates.Down Then
            g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, redColour, redColour), 0, 0, Width + 1, Height + 1)
            g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
        ElseIf MouseState = mouseStates.Hover Then
            g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(redColour, 7), ShiftColour(redColour, 7)), 0, 0, Width + 1, Height + 1)
            g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
        Else
            g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(redColour, 12), ShiftColour(redColour, 12)), 0, 0, Width + 1, Height + 1)
            g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
        End If

        g.DrawString(Text, Font, New SolidBrush(IIf(Enabled, ForeColor, Color.FromArgb(82, 82, 82))), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
    End Sub
End Class

Public Class oddToggleButton
    Inherits ButtonClass

    Dim redColour As Color = FromHex("F0544C")

    Private _state As Status = Status.OFF
    Public Property State As Status
        Get
            Return _state
        End Get
        Set(value As Status)
            _state = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        If New Rectangle(0, 0, Width, Height).Contains(e.X, e.Y) Then
            If State = Status.OFF Then
                State = Status.ON
            Else
                State = Status.OFF
            End If
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

        If _state = Status.OFF Then
            If MouseState = mouseStates.Down Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(BackColor, 5), ShiftColour(BackColor, 5)), 0, 0, Width + 1, Height + 1)
            ElseIf MouseState = mouseStates.Hover Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(BackColor, 9), ShiftColour(BackColor, 9)), 0, 0, Width + 1, Height + 1)
            Else
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(BackColor, 16), ShiftColour(BackColor, 16)), 0, 0, Width + 1, Height + 1)
            End If
        ElseIf _state = Status.ON Then
            If MouseState = mouseStates.Down Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, redColour, redColour), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            ElseIf MouseState = mouseStates.Hover Then
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(redColour, 7), ShiftColour(redColour, 7)), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            Else
                g.DrawImage(RoundedRectangle.DrawRoundRectangle(New Rectangle(0, 0, Width, Height), 10, 4, ShiftColour(redColour, 12), ShiftColour(redColour, 12)), 0, 0, Width + 1, Height + 1)
                g.DrawString(Text, Font, New SolidBrush(ForeColor), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
            End If
        End If

        g.DrawString(Text, Font, New SolidBrush(IIf(Enabled, ForeColor, Color.FromArgb(82, 82, 82))), Width / 2 - g.MeasureString(Text, Font).Width / 2, Height / 2 - g.MeasureString(Text, Font).Height / 2)
    End Sub

    Public Enum Status
        [ON] = 1
        OFF = 2
    End Enum
End Class

Public Class joyArea
    Inherits Control

    Public JoyX As Decimal
    Public JoyY As Decimal


    Public Sub JoyPoint(x As Decimal, y As Decimal)
        JoyX = x
        JoyY = y
        Invalidate()
    End Sub 

    Sub New()
        DoubleBuffered = True
        Size = New Size(200, 200)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        g.Clear(Color.FromArgb(57, 57, 62))
        g.DrawRectangle(New Pen(Color.FromArgb(255, 33, 33, 33)), 0, 0, Width - 1, Height - 1)

        Dim gridPen As New Pen(Color.FromArgb(75, 75, 1))

        For x As Integer = 1 To 10
            g.DrawLine(gridPen, New PointF((Width / 10) * x, 0), New PointF((Width / 10) * x, Height))
        Next
        For y As Integer = 1 To 10
            g.DrawLine(gridPen, New PointF(0, (Height / 10) * y), New PointF(Height, (Width / 10) * y))
        Next

        g.DrawEllipse(New Pen(Color.FromArgb(90, 90, 1)), -10, -10, Width + 20, Height + 20)

        g.DrawLine(New Pen(Color.FromArgb(240, 84, 76)), New PointF(Width / 2, 0), New PointF(Width / 2, Height))
        g.DrawLine(New Pen(Color.FromArgb(240, 84, 76)), New PointF(0, Height / 2), New PointF(Width, Height / 2))

        ' g.FillEllipse(New SolidBrush(Color.FromArgb(54, 252, 41)), New Rectangle(map(JoyX, -1.1, 1.1, 0, Width) - 2.7, map(JoyY, -1.1, 1.1, 0, Height) - 2.7, 5, 5))
        g.FillEllipse(Brushes.White, New Rectangle(map(JoyX, -1.1, 1.1, 0, Width) - 2.7, map(JoyY, -1.1, 1.1, 0, Height) - 2.7, 5, 5))
    End Sub

    Public Function map(x As Decimal, in_min As Decimal, in_max As Decimal, out_min As Decimal, out_max As Decimal) 
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function
End Class

Public Class VerticalAxisBar
    Inherits Control

    Public _value As Double = 0
    Public Property Value As Double
        Get
            Return _value
        End Get
        Set(value As Double)
            _value = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.Clear(Color.FromArgb(59, 59, 59))

        g.FillRectangle(New SolidBrush(Color.FromArgb(176, 176, 176)), New RectangleF(1, 1, Width - 2, map(Value, -1, 1, Height - 2, 0)))

        g.DrawLine(New Pen(Color.FromArgb(107, 107, 107)), New PointF(1, Height / 2), New PointF(Width, Height / 2))

        g.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1)
    End Sub

    Public Function map(x As Double, in_min As Double, in_max As Double, out_min As Double, out_max As Double)
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function
End Class

Public Class HorizontalAxisBar
    Inherits Control

    Public _value As Double = 0
    Public Property Value As Double
        Get
            Return _value
        End Get
        Set(value As Double)
            _value = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.Clear(Color.FromArgb(59, 59, 59))

        g.FillRectangle(New SolidBrush(Color.FromArgb(176, 176, 176)), New RectangleF(1, 1, map(Value, -1, 1, Width - 2, 0), Height - 2))
        'g.FillRectangle(New SolidBrush(Color.FromArgb(176, 176, 176)), New RectangleF(1, 1, Width - 2, map(Value, -1, 1, Height, 0)))

        g.DrawLine(New Pen(Color.FromArgb(107, 107, 107)), New PointF(Width / 2, 1), New PointF(Width / 2, Height - 2))
        'g.DrawLine(New Pen(Color.FromArgb(107, 107, 107)), New PointF(1, Height / 2), New PointF(Width, Height / 2))
    End Sub

    Public Function map(x As Double, in_min As Double, in_max As Double, out_min As Double, out_max As Double)
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function
End Class

Public Class ToggleLight
    Inherits Control

    Private _status As Boolean = True
    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
            Invalidate()
        End Set
    End Property

    Sub New()
        Size = New Size(30, 20)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        If Status Then
            g.FillRectangle(New SolidBrush(Color.FromArgb(99, 255, 1)), 0, 0, Width, Height)
        Else
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 21, 0)), 0, 0, Width, Height)
        End If
        g.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1)
    End Sub
End Class

Class RoundedRectangle
    <DllImport("gdi32.dll")>
    Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function
    Shared Function DrawRoundRectangle(rct As Rectangle, r As Integer, MSAA As Integer, FillColor As Color, BorderColor As Color)
        Dim b As New Bitmap(rct.Width * MSAA + MSAA, rct.Height * MSAA + MSAA)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim RegH As IntPtr = CreateRoundRectRgn(rct.Left, rct.Top, (rct.Width) * MSAA, (rct.Height) * MSAA, r * MSAA, r * MSAA)
        Dim RegH1 As IntPtr = CreateRoundRectRgn(rct.Left + MSAA / 1, rct.Top + MSAA / 1, (rct.Width - 1) * MSAA, (rct.Height - 1) * MSAA, (r - 2) * MSAA, (r - 2) * MSAA)
        Dim Reg As Region = Region.FromHrgn(RegH)
        Dim Reg1 As Region = Region.FromHrgn(RegH1)

        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        g.FillRegion(New SolidBrush(BorderColor), Reg)
        g.SetClip(Reg1, CombineMode.Replace)
        g.Clear(FillColor)
        Return b
    End Function
End Class

Public Class ButtonClass
    Inherits Control

    Public MouseState As mouseStates = mouseStates.None

    Sub New()
        Font = New Font("Clear Sans", 11.0F)
        Size = New Size(160, 35)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        MouseState = mouseStates.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        MouseState = mouseStates.Hover
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
        MouseState = mouseStates.Hover
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        MouseState = mouseStates.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        Invalidate()
    End Sub

    Public Function FromHex(hex As String) As Color
        Return ColorTranslator.FromHtml(hex.Replace("#", "").Insert(0, "#"))
    End Function

    Public Function ShiftColour(input As Color, val As Integer) As Color
        Return Color.FromArgb(input.R + val, input.G + val, input.B + val)
    End Function

    Public Enum mouseStates
        None = 1
        Hover = 2
        Down = 3
    End Enum
End Class