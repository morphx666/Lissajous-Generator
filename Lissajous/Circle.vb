Public Class Circle
    Private Const ToRad As Single = Math.PI / 180

    Public Property Angle As Single
    Public Property Color As Color
    Public Property PointLocation As PointF

    Private mPhase As Single
    Private mDiameter As Single
    Private mX As Single
    Private mY As Single

    Private ellipsePoints() As PointF

    Public Sub New(x As Single, y As Single, radius As Single, Optional phase As Single = 0)
        mX = x
        mY = y
        mDiameter = radius
        mPhase = phase
        Me.Color = Color.White

        CreateEllipse()
    End Sub

    Public Sub New(location As PointF, radius As Single, Optional phase As Single = 0)
        Me.New(location.X, location.Y, radius, phase)
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
            CreateEllipse()
        End Set
    End Property

    Private Sub CreateEllipse()
        Dim r As Single = Diameter / 2
        Dim r2 As Single = r / 2
        Dim steps As Double = 0.1
        Dim pc As Double = Math.Ceiling(2 * Math.PI / steps)
        ReDim ellipsePoints(pc - (pc Mod 2))
        Dim k As Integer = 0
        For a As Double = 0 To 2 * Math.PI Step steps
            ellipsePoints(k) = New PointF(X + r2 + CSng(r2 * Math.Cos(a)),
                                          Y + r2 - CSng(r2 * Math.Sin(a + Phase)))
            k += 1
        Next
    End Sub

    Public Sub Render(g As Graphics)
        Dim r As Single = Diameter / 2
        Dim r2 As Single = r / 2

        PointLocation = New PointF(X + r2 + CSng(r2 * Math.Cos(Angle)),
                                   Y + r2 - CSng(r2 * Math.Sin(Angle + Phase)))

        Using p As New Pen(Color)
            'g.DrawEllipse(p, Location.X, Location.Y, r, r)
            g.DrawPolygon(p, ellipsePoints)
            g.FillEllipse(Brushes.White, PointLocation.X - 3, PointLocation.Y - 3, 6, 6)
        End Using
    End Sub
End Class
