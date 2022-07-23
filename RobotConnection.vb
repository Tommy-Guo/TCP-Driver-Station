Imports System.Net.Sockets
Imports System.ComponentModel
Imports System.IO

Public Class RobotConnection

    Private _ip As String
    Private _port As Integer
    Private _client As TcpClient

    Public Event DataRecieved(e As Object)
    Public WithEvents TCPListener As New BackgroundWorker()

    Sub New()

    End Sub

    Sub New(ip As String, port As Integer)
        _ip = ip
        _port = port
    End Sub

    Public Function Connect(Optional debug As Boolean = False)
        Try
            _client = New TcpClient
            _client.Connect(_ip, _port)
            If _client.Connected Then
                TCPListener.RunWorkerAsync()
            End If
        Catch ex As Exception
            Return IIf(debug, ex.StackTrace, False)
        End Try
        Return ReturnStatus()
    End Function

    Public Sub Disconnect()
        _client.Close()
    End Sub

    Public Function ReturnStatus()
        Return _client.Connected
    End Function

    Public Sub SendData(data As String)
        Dim Writer As New StreamWriter(_client.GetStream())
        Writer.Write(data)
        Writer.Flush()
    End Sub

    Private Sub ReadingData(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles TCPListener.DoWork
        Dim serverStream As NetworkStream = _client.GetStream()
        If serverStream.DataAvailable Then
            Dim inStream(_client.ReceiveBufferSize) As Byte
            serverStream.Read(inStream, 0, _client.ReceiveBufferSize)
            Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
            RaiseEvent DataRecieved(returndata)
        End If
    End Sub

    Private Sub ReadData(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TCPListener.RunWorkerCompleted
        If _client.Connected Then
            TCPListener.RunWorkerAsync()
        End If
    End Sub

    Public Function GetStream() As NetworkStream
        Return _client.GetStream
    End Function
End Class