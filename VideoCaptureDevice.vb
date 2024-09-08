Friend Class VideoCaptureDevice
    Public Sub New(monikerString As Object)
    End Sub

    Public Event NewFrame(sender As Object, eventArgs As NewFrameEventArgs)

    Friend Sub Start()
        Throw New NotImplementedException()
    End Sub

    Friend Sub SignalToStop()
        Throw New NotImplementedException()
    End Sub
End Class
