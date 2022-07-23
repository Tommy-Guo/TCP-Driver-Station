<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckConnection = New System.ComponentModel.BackgroundWorker()
        Me.JoystickInput = New System.Windows.Forms.Timer(Me.components)
        Me.DataSend = New System.ComponentModel.BackgroundWorker()
        Me.OddPanel2 = New TheOddOnes_Driver_Station.oddPanel()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VerticalSplitter2 = New TheOddOnes_Driver_Station.VerticalSplitter()
        Me.OddToggleButton3 = New TheOddOnes_Driver_Station.oddToggleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OddPanel1 = New TheOddOnes_Driver_Station.oddPanel()
        Me.HorizontalSplitter1 = New TheOddOnes_Driver_Station.HorizontalSplitter()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Labelx = New System.Windows.Forms.Label()
        Me.VerticalSplitter1 = New TheOddOnes_Driver_Station.VerticalSplitter()
        Me.btnDisable = New TheOddOnes_Driver_Station.oddToggleButton()
        Me.btnEnable = New TheOddOnes_Driver_Station.oddToggleButton()
        Me.lblConnectionStats = New System.Windows.Forms.Label()
        Me.statusServerCommunication = New TheOddOnes_Driver_Station.ToggleLight()
        Me.OddTabControl1 = New TheOddOnes_Driver_Station.oddTabControl()
        Me.tabDrive = New System.Windows.Forms.TabPage()
        Me.listButton = New System.Windows.Forms.ListBox()
        Me.labelButtons = New System.Windows.Forms.Label()
        Me.AxisBar = New TheOddOnes_Driver_Station.VerticalAxisBar()
        Me.rightJoy = New TheOddOnes_Driver_Station.joyArea()
        Me.leftJoy = New TheOddOnes_Driver_Station.joyArea()
        Me.tabConsole = New System.Windows.Forms.TabPage()
        Me.btnSend = New TheOddOnes_Driver_Station.oddButtonRed()
        Me.Console = New System.Windows.Forms.RichTextBox()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.OddPanel2.SuspendLayout()
        Me.OddPanel1.SuspendLayout()
        Me.OddTabControl1.SuspendLayout()
        Me.tabDrive.SuspendLayout()
        Me.tabConsole.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Clear Sans", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = ""
        Me.Label2.Text = "The Odd Ones - Team 7136"
        '
        'CheckConnection
        '
        '
        'JoystickInput
        '
        Me.JoystickInput.Enabled = True
        Me.JoystickInput.Interval = 10
        '
        'DataSend
        '
        '
        'OddPanel2
        '
        Me.OddPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.OddPanel2.Controls.Add(Me.txtPort)
        Me.OddPanel2.Controls.Add(Me.txtIP)
        Me.OddPanel2.Controls.Add(Me.Label6)
        Me.OddPanel2.Controls.Add(Me.Label5)
        Me.OddPanel2.Controls.Add(Me.VerticalSplitter2)
        Me.OddPanel2.Controls.Add(Me.OddToggleButton3)
        Me.OddPanel2.Controls.Add(Me.Label4)
        Me.OddPanel2.ForeColor = System.Drawing.Color.White
        Me.OddPanel2.Location = New System.Drawing.Point(12, 47)
        Me.OddPanel2.Name = "OddPanel2"
        Me.OddPanel2.Size = New System.Drawing.Size(364, 80)
        Me.OddPanel2.TabIndex = 8
        Me.OddPanel2.Title = ""
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.txtPort.Location = New System.Drawing.Point(206, 45)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(147, 20)
        Me.txtPort.TabIndex = 20
        Me.txtPort.Text = "7136"
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.txtIP.Location = New System.Drawing.Point(206, 17)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(147, 20)
        Me.txtIP.TabIndex = 19
        Me.txtIP.Text = "192.168.0.27"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Clear Sans", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(162, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Clear Sans", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(160, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Host:"
        '
        'VerticalSplitter2
        '
        Me.VerticalSplitter2.Location = New System.Drawing.Point(154, 5)
        Me.VerticalSplitter2.Name = "VerticalSplitter2"
        Me.VerticalSplitter2.Size = New System.Drawing.Size(1, 73)
        Me.VerticalSplitter2.TabIndex = 15
        Me.VerticalSplitter2.Text = "VerticalSplitter2"
        '
        'OddToggleButton3
        '
        Me.OddToggleButton3.Font = New System.Drawing.Font("Clear Sans", 11.0!)
        Me.OddToggleButton3.Location = New System.Drawing.Point(17, 35)
        Me.OddToggleButton3.Name = "OddToggleButton3"
        Me.OddToggleButton3.Size = New System.Drawing.Size(125, 35)
        Me.OddToggleButton3.State = TheOddOnes_Driver_Station.oddToggleButton.Status.OFF
        Me.OddToggleButton3.TabIndex = 16
        Me.OddToggleButton3.Text = "Disabled"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Clear Sans", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(51, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "TeleOP:"
        '
        'OddPanel1
        '
        Me.OddPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.OddPanel1.Controls.Add(Me.HorizontalSplitter1)
        Me.OddPanel1.Controls.Add(Me.lblTimer)
        Me.OddPanel1.Controls.Add(Me.Labelx)
        Me.OddPanel1.Controls.Add(Me.VerticalSplitter1)
        Me.OddPanel1.Controls.Add(Me.btnDisable)
        Me.OddPanel1.Controls.Add(Me.btnEnable)
        Me.OddPanel1.Controls.Add(Me.lblConnectionStats)
        Me.OddPanel1.Controls.Add(Me.statusServerCommunication)
        Me.OddPanel1.Font = New System.Drawing.Font("Clear Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OddPanel1.ForeColor = System.Drawing.Color.White
        Me.OddPanel1.Location = New System.Drawing.Point(12, 134)
        Me.OddPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OddPanel1.Name = "OddPanel1"
        Me.OddPanel1.Size = New System.Drawing.Size(364, 98)
        Me.OddPanel1.TabIndex = 7
        Me.OddPanel1.Title = ""
        '
        'HorizontalSplitter1
        '
        Me.HorizontalSplitter1.Location = New System.Drawing.Point(15, 43)
        Me.HorizontalSplitter1.Name = "HorizontalSplitter1"
        Me.HorizontalSplitter1.Size = New System.Drawing.Size(183, 1)
        Me.HorizontalSplitter1.TabIndex = 17
        Me.HorizontalSplitter1.Text = "HorizontalSplitter1"
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Clear Sans", 12.0!)
        Me.lblTimer.Location = New System.Drawing.Point(15, 71)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(187, 21)
        Me.lblTimer.TabIndex = 16
        Me.lblTimer.Text = "00:00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelx
        '
        Me.Labelx.AutoSize = True
        Me.Labelx.Font = New System.Drawing.Font("Clear Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Labelx.Location = New System.Drawing.Point(51, 49)
        Me.Labelx.Name = "Labelx"
        Me.Labelx.Size = New System.Drawing.Size(114, 21)
        Me.Labelx.TabIndex = 15
        Me.Labelx.Text = "Elapsed Time:"
        '
        'VerticalSplitter1
        '
        Me.VerticalSplitter1.Location = New System.Drawing.Point(214, 13)
        Me.VerticalSplitter1.Name = "VerticalSplitter1"
        Me.VerticalSplitter1.Size = New System.Drawing.Size(1, 73)
        Me.VerticalSplitter1.TabIndex = 14
        Me.VerticalSplitter1.Text = "VerticalSplitter1"
        '
        'btnDisable
        '
        Me.btnDisable.Font = New System.Drawing.Font("Clear Sans", 11.0!)
        Me.btnDisable.ForeColor = System.Drawing.Color.White
        Me.btnDisable.Location = New System.Drawing.Point(227, 52)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(125, 35)
        Me.btnDisable.State = TheOddOnes_Driver_Station.oddToggleButton.Status.OFF
        Me.btnDisable.TabIndex = 13
        Me.btnDisable.Text = "Disconnect"
        '
        'btnEnable
        '
        Me.btnEnable.Font = New System.Drawing.Font("Clear Sans", 11.0!)
        Me.btnEnable.ForeColor = System.Drawing.Color.White
        Me.btnEnable.Location = New System.Drawing.Point(227, 11)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(125, 35)
        Me.btnEnable.State = TheOddOnes_Driver_Station.oddToggleButton.Status.[ON]
        Me.btnEnable.TabIndex = 12
        Me.btnEnable.Text = "Connect"
        '
        'lblConnectionStats
        '
        Me.lblConnectionStats.AutoSize = True
        Me.lblConnectionStats.Font = New System.Drawing.Font("Clear Sans", 10.0!)
        Me.lblConnectionStats.Location = New System.Drawing.Point(11, 13)
        Me.lblConnectionStats.Name = "lblConnectionStats"
        Me.lblConnectionStats.Size = New System.Drawing.Size(155, 20)
        Me.lblConnectionStats.TabIndex = 7
        Me.lblConnectionStats.Text = "Server Communication"
        Me.lblConnectionStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'statusServerCommunication
        '
        Me.statusServerCommunication.Location = New System.Drawing.Point(172, 13)
        Me.statusServerCommunication.Name = "statusServerCommunication"
        Me.statusServerCommunication.Size = New System.Drawing.Size(30, 20)
        Me.statusServerCommunication.Status = False
        Me.statusServerCommunication.TabIndex = 6
        Me.statusServerCommunication.Text = "ToggleLight1"
        '
        'OddTabControl1
        '
        Me.OddTabControl1.Controls.Add(Me.tabDrive)
        Me.OddTabControl1.Controls.Add(Me.tabConsole)
        Me.OddTabControl1.Font = New System.Drawing.Font("Clear Sans", 10.0!)
        Me.OddTabControl1.ItemSize = New System.Drawing.Size(100, 40)
        Me.OddTabControl1.Location = New System.Drawing.Point(382, 13)
        Me.OddTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OddTabControl1.Name = "OddTabControl1"
        Me.OddTabControl1.SelectedIndex = 0
        Me.OddTabControl1.Size = New System.Drawing.Size(503, 219)
        Me.OddTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.OddTabControl1.TabIndex = 6
        '
        'tabDrive
        '
        Me.tabDrive.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tabDrive.Controls.Add(Me.listButton)
        Me.tabDrive.Controls.Add(Me.labelButtons)
        Me.tabDrive.Controls.Add(Me.AxisBar)
        Me.tabDrive.Controls.Add(Me.rightJoy)
        Me.tabDrive.Controls.Add(Me.leftJoy)
        Me.tabDrive.ForeColor = System.Drawing.Color.White
        Me.tabDrive.Location = New System.Drawing.Point(4, 44)
        Me.tabDrive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabDrive.Name = "tabDrive"
        Me.tabDrive.Size = New System.Drawing.Size(495, 171)
        Me.tabDrive.TabIndex = 0
        Me.tabDrive.Text = "Drive"
        '
        'listButton
        '
        Me.listButton.Font = New System.Drawing.Font("Clear Sans", 9.5!)
        Me.listButton.FormattingEnabled = True
        Me.listButton.IntegralHeight = False
        Me.listButton.ItemHeight = 18
        Me.listButton.Location = New System.Drawing.Point(351, 32)
        Me.listButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listButton.Name = "listButton"
        Me.listButton.Size = New System.Drawing.Size(134, 130)
        Me.listButton.TabIndex = 4
        '
        'labelButtons
        '
        Me.labelButtons.AutoSize = True
        Me.labelButtons.Font = New System.Drawing.Font("Clear Sans", 9.5!)
        Me.labelButtons.Location = New System.Drawing.Point(348, 12)
        Me.labelButtons.Name = "labelButtons"
        Me.labelButtons.Size = New System.Drawing.Size(57, 18)
        Me.labelButtons.TabIndex = 3
        Me.labelButtons.Text = "Buttons:"
        '
        'AxisBar
        '
        Me.AxisBar.Font = New System.Drawing.Font("Clear Sans", 9.5!)
        Me.AxisBar.Location = New System.Drawing.Point(322, 12)
        Me.AxisBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AxisBar.Name = "AxisBar"
        Me.AxisBar.Size = New System.Drawing.Size(20, 150)
        Me.AxisBar.TabIndex = 2
        Me.AxisBar.Text = "VerticalAxisBar1"
        Me.AxisBar.Value = 0.0R
        '
        'rightJoy
        '
        Me.rightJoy.Font = New System.Drawing.Font("Clear Sans", 9.5!)
        Me.rightJoy.Location = New System.Drawing.Point(166, 12)
        Me.rightJoy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rightJoy.Name = "rightJoy"
        Me.rightJoy.Size = New System.Drawing.Size(150, 150)
        Me.rightJoy.TabIndex = 1
        Me.rightJoy.Text = "JoyArea2"
        '
        'leftJoy
        '
        Me.leftJoy.Font = New System.Drawing.Font("Clear Sans", 9.5!)
        Me.leftJoy.Location = New System.Drawing.Point(10, 12)
        Me.leftJoy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.leftJoy.Name = "leftJoy"
        Me.leftJoy.Size = New System.Drawing.Size(150, 150)
        Me.leftJoy.TabIndex = 0
        Me.leftJoy.Text = "JoyArea1"
        '
        'tabConsole
        '
        Me.tabConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tabConsole.Controls.Add(Me.btnSend)
        Me.tabConsole.Controls.Add(Me.Console)
        Me.tabConsole.Controls.Add(Me.txtCommand)
        Me.tabConsole.ForeColor = System.Drawing.Color.White
        Me.tabConsole.Location = New System.Drawing.Point(4, 44)
        Me.tabConsole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.Size = New System.Drawing.Size(495, 171)
        Me.tabConsole.TabIndex = 1
        Me.tabConsole.Text = "Console"
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Clear Sans", 11.0!)
        Me.btnSend.Location = New System.Drawing.Point(378, 137)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(104, 25)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        '
        'Console
        '
        Me.Console.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Console.Location = New System.Drawing.Point(10, 12)
        Me.Console.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(474, 117)
        Me.Console.TabIndex = 4
        Me.Console.Text = ""
        '
        'txtCommand
        '
        Me.txtCommand.AcceptsReturn = True
        Me.txtCommand.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(10, 138)
        Me.txtCommand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(362, 22)
        Me.txtCommand.TabIndex = 5
        Me.txtCommand.Text = "The Odd Ones - 7136 //Test Message"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(892, 245)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OddPanel2)
        Me.Controls.Add(Me.OddPanel1)
        Me.Controls.Add(Me.OddTabControl1)
        Me.Font = New System.Drawing.Font("Clear Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.Text = "The Odd Ones Driver Station"
        Me.OddPanel2.ResumeLayout(False)
        Me.OddPanel2.PerformLayout()
        Me.OddPanel1.ResumeLayout(False)
        Me.OddPanel1.PerformLayout()
        Me.OddTabControl1.ResumeLayout(False)
        Me.tabDrive.ResumeLayout(False)
        Me.tabDrive.PerformLayout()
        Me.tabConsole.ResumeLayout(False)
        Me.tabConsole.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Console As RichTextBox
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents OddTabControl1 As oddTabControl
    Friend WithEvents tabDrive As TabPage
    Friend WithEvents rightJoy As joyArea
    Friend WithEvents leftJoy As joyArea
    Friend WithEvents tabConsole As TabPage
    Friend WithEvents listButton As ListBox
    Friend WithEvents labelButtons As Label
    Friend WithEvents AxisBar As VerticalAxisBar
    Friend WithEvents btnSend As oddButtonRed
    Friend WithEvents statusServerCommunication As TheOddOnes_Driver_Station.ToggleLight
    Friend WithEvents lblConnectionStats As System.Windows.Forms.Label
    Friend WithEvents OddPanel1 As TheOddOnes_Driver_Station.oddPanel
    Friend WithEvents btnDisable As TheOddOnes_Driver_Station.oddToggleButton
    Friend WithEvents btnEnable As TheOddOnes_Driver_Station.oddToggleButton
    Friend WithEvents VerticalSplitter1 As TheOddOnes_Driver_Station.VerticalSplitter
    Friend WithEvents OddPanel2 As TheOddOnes_Driver_Station.oddPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OddToggleButton3 As TheOddOnes_Driver_Station.oddToggleButton
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VerticalSplitter2 As TheOddOnes_Driver_Station.VerticalSplitter
    Friend WithEvents CheckConnection As System.ComponentModel.BackgroundWorker
    Friend WithEvents JoystickInput As System.Windows.Forms.Timer
    Friend WithEvents HorizontalSplitter1 As TheOddOnes_Driver_Station.HorizontalSplitter
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Labelx As System.Windows.Forms.Label
    Friend WithEvents DataSend As System.ComponentModel.BackgroundWorker
End Class
