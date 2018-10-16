Public Class FormMain
    Private Structure Settings
        Public Radius As Single

        Public AngleStep As Single
        Public HPhase As Single
        Public VPhase As Single

        Public LineColor As Pen
        Public FigureForeColor As Pen
        Public FigurePointForeColor As SolidBrush
        Public FigureBackColor As SolidBrush
    End Structure
    Private ps As Settings

    Private hCircles As New List(Of Circle)
    Private vCircles As New List(Of Circle)
    Private figures As List(Of List(Of PointF))

    Private syncObj As New Object()

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        LoadDefaults()
        CreateCircles()

        AddHandler Me.Resize, Sub() CreateCircles()
        AddHandler Me.DoubleClick, Sub()
                                       Using dlg As New FormSettings()
                                           dlg.TextBoxAngleStep.Text = ps.AngleStep
                                           dlg.TextBoxHPhase.Text = ps.HPhase
                                           dlg.TextBoxVPhase.Text = ps.VPhase

                                           AddHandler dlg.ButtonApply.Click, Sub()
                                                                                 Single.TryParse(dlg.TextBoxAngleStep.Text, ps.AngleStep)
                                                                                 Single.TryParse(dlg.TextBoxHPhase.Text, ps.HPhase)
                                                                                 Single.TryParse(dlg.TextBoxVPhase.Text, ps.VPhase)

                                                                                 CreateCircles()
                                                                             End Sub
                                           dlg.ShowDialog(Me)
                                       End Using
                                   End Sub

        Task.Run(Sub()
                     Do
                         Threading.Thread.Sleep(25)
                         Me.Invalidate()
                     Loop
                 End Sub)
    End Sub

    Private Sub LoadDefaults()
        ps.Radius = 50
        ps.AngleStep = 0.02
        ps.HPhase = 0
        ps.VPhase = 0
        ps.LineColor = New Pen(Color.FromArgb(120, Color.Gray))
        ps.FigureForeColor = Pens.Cyan
        ps.FigurePointForeColor = Brushes.Blue
        ps.FigureBackColor = New SolidBrush(Color.FromArgb(255, 22, 22, 22))
    End Sub

    Private Sub CreateCircles()
        SyncLock syncObj
            Dim s As Integer = Me.DisplayRectangle.Width
            Dim d As Single = ps.Radius * 2
            Dim k As Single = d
            Dim m As Integer = 20
            Dim m2 As Integer = m * 2

            hCircles.Clear()
            vCircles.Clear()

            For i As Integer = 1 To (s - ps.Radius) \ (ps.Radius + m)
                hCircles.Add(New Circle(k + m2, m, ps.Radius, i, ps.HPhase))
                vCircles.Add(New Circle(m, k + m2, ps.Radius, i, ps.VPhase))
                k += d + m
            Next

            figures = New List(Of List(Of PointF))
        End SyncLock
    End Sub

    Private Sub FormMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Black)

        SyncLock syncObj
            Dim index As Integer

            ' Draw Circles and figures' backgrounds
            For j As Integer = 0 To vCircles.Count - 1
                For i As Integer = 0 To hCircles.Count - 1
                    index = i + j * hCircles.Count

                    g.FillRectangle(ps.FigureBackColor, hCircles(i).X,
                                                        vCircles(j).Y,
                                                        hCircles(i).Diameter, hCircles(i).Diameter)

                    hCircles(i).Render(g)
                    vCircles(j).Render(g)

                    If figures.Count <= index Then figures.Add(New List(Of PointF))
                    figures(index).Add(New PointF(hCircles(i).PointLocation.X, vCircles(j).PointLocation.Y))
                Next
            Next

            ' Draw lines
            For i As Integer = 0 To hCircles.Count - 1
                g.DrawLine(ps.LineColor,
                            hCircles(i).PointLocation.X, hCircles(i).PointLocation.Y,
                            hCircles(i).PointLocation.X, Me.DisplayRectangle.Height)
                hCircles(i).Angle += ps.AngleStep

                g.DrawLine(ps.LineColor,
                            vCircles(i).PointLocation.X, vCircles(i).PointLocation.Y,
                            Me.DisplayRectangle.Width, vCircles(i).PointLocation.Y)
                vCircles(i).Angle += ps.AngleStep
            Next

            ' Draw figures and remove duplicate points
            For i As Integer = 0 To figures.Count - 1
                If figures(i).Count > 1 Then
                    Dim points() As PointF = figures(i).ToArray()
                    If (points.Length Mod 2) = 0 Then ReDim Preserve points(points.Count - 1)

                    g.DrawLines(ps.FigureForeColor, points)
                    Dim lp As PointF = points(points.Length - 1)
                    g.FillEllipse(ps.FigurePointForeColor, lp.X - 3, lp.Y - 3, 6, 6)

                    If hCircles(0).Angle >= Circle.TwoPI Then figures(i).RemoveAt(0)
                End If
            Next
        End SyncLock
    End Sub
End Class
