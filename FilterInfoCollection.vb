Friend Class FilterInfoCollection
    Private videoInputDevice As Object

    Public Sub New(videoInputDevice As Object)
        Me.videoInputDevice = videoInputDevice
    End Sub

    Public Property Count As Integer
End Class
