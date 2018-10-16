Public Class Circle
    Private Const ToRad As Single = Math.PI / 180

    Public Property Angle As Single
    Public Property Color As Color
    Public Property PointLocation As PointF
    Public Property Frequency As Single

    Private mPhase As Single
    Private mDiameter As Single
    Private mX As Single
    Private mY As Single
    Private mRadius As Single
    Private mPointSize As Single

    Private ellipsePoints() As PointF
    Private halfPointSize As Single

    Public Sub New(x As Single, y As Single, radius As Single, Optional frequency As Single = 1.0!, Optional phase As Single = 0.0!)
        mX = x
        mY = y
        mRadius = radius
        mDiameter = radius * 2
        mPhase = phase
        Me.Frequency = frequency
        Me.Color = Color.White
        Me.PointSize = 6

        CreateEllipse()
    End Sub

    Public Sub New(location As PointF, radius As Single, Optional frequency As Single = 1.0!, Optional phase As Single = 0.0!)
        Me.New(location.X, location.Y, radius, frequency, phase)
    End Sub

    Public Property X As Single
        Get
            Return mX
        End Get
        Set
            mX = Value
            CreateEllipse()
        End Set
    End Property

    Public Property Y As Single
        Get
            Return mY
        End Get
        Set
            mY = Value
            CreateEllipse()
        End Set
    End Property

    Public Property PointSize As Single
        Get
            Return mPointSize
        End Get
        Set(value As Single)
            mPointSize = value
            halfPointSize = value / 2
        End Set
    End Property

    Public Property Phase As Single
        Get
            Return mPhase
        End Get
        Set
            mPhase = Value
            CreateEllipse()
        End Set
    End Property

    Public Property Diameter As Single
        Get
            Return mDiameter
        End Get
        Set
            mDiameter = Value
            mRadius = mDiameter / 2
            CreateEllipse()
        End Set
    End Property

    Public Property Radius As Single
        Get
            Return mRadius
        End Get
        Set(value As Single)
            mRadius = value
            mDiameter = mRadius * 2
            CreateEllipse()
        End Set
    End Property

    Private Sub CreateEllipse()
        Dim steps As Double = 0.2 / If(Phase <> 0, Math.Abs(Phase * 10), 1)
        Dim pc As Double = Math.Ceiling(2 * Math.PI / steps)
        Dim k As Integer = 0

        ReDim ellipsePoints(pc - (pc Mod 2))

        For a As Double = 0 To 2 * Math.PI Step steps
            ellipsePoints(k) = ToCartesian(a)
            k += 1
        Next
        ReDim Preserve ellipsePoints(k - 1)
    End Sub

    Public Sub Render(g As Graphics)
        PointLocation = ToCartesian(Angle)

        Using p As New Pen(Color)
            If Phase = 0 Then
                g.DrawEllipse(p, X, Y, mDiameter, mDiameter)
            Else
                g.DrawPolygon(p, ellipsePoints)
            End If
            g.FillEllipse(Brushes.White, PointLocation.X - halfPointSize,
                                         PointLocation.Y - halfPointSize,
                                         mPointSize, mPointSize)
        End Using
    End Sub

    Private Function ToCartesian(angle As Single) As PointF
        Return New PointF(X + mRadius + CSng(mRadius * Math.Cos(angle * Frequency)),
                          Y + mRadius - CSng(mRadius * Math.Sin(angle * Frequency + Phase)))
    End Function
End Class