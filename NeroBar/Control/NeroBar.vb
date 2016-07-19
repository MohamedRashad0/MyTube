#Region "References"

Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

#End Region

<Assembly: CLSCompliant(True)> 

<Serializable()> <ToolboxBitmap(GetType(NeroBar), "NeroBar.bmp")> <DefaultProperty("Value")> Public Class NeroBar

    Inherits UserControl

#Region "Enums"

    Public Enum NeroBarSegments

        One = 1
        Two = 2
        Three = 3

    End Enum

    Public Enum NeroBarGlowModes

        None = 0
        ProgressOnly = 1
        WholeBar = 2

    End Enum

    Public Enum NeroBarPercentageCalculationModes

        Segment_1 = 1
        Segments_1_2 = 2
        WholeControl = 3

    End Enum

    Public Enum NeroBarColorChangeModes

        Segments = 0
        WholeBar = 1

    End Enum

#End Region

#Region "Private Variables"

    Private _BorderColor As Color = Color.FromArgb(178, 178, 178)
    Private _BackRemain1 As Color = Color.FromArgb(202, 202, 202)
    Private _BackRemain2 As Color = Color.FromArgb(234, 234, 234)
    Private _BackRemain3 As Color = Color.FromArgb(219, 219, 219)
    Private _BackRemain4 As Color = Color.FromArgb(243, 243, 243)
    Private _Segment1Color As Color = Color.FromArgb(55, 217, 60)
    Private _Segment2Color As Color = Color.FromArgb(252, 252, 0)
    Private _Segment3Color As Color = Color.FromArgb(252, 0, 0)
    Private _GlowColor As Color = Color.FromArgb(150, 255, 255, 255)
    Private _SegmentCount As NeroBarSegments = NeroBarSegments.Three
    Private _Value As Double = 0
    Private _MaxValue As Double = 100
    Private _MinValue As Double = 0
    Private _Segment2StartThreshold As Double = 80
    Private _Segment3StartThreshold As Double = 90
    Private _DrawThresholds As Boolean = True
    Private _ColorThresholds As Boolean = False
    Private _GlowMode As NeroBarGlowModes = NeroBarGlowModes.None
    Private _GlowSpeed As Long = 20
    Private _GlowPause As Long = 5000
    Private _GlowPosition As Integer = -60
    Private _PercentageMode As NeroBarPercentageCalculationModes = NeroBarPercentageCalculationModes.WholeControl
    Private _RightToLeft As Boolean = False
    Private _ChangeMode As NeroBarColorChangeModes = NeroBarColorChangeModes.Segments
    Private WithEvents TmrAnimateGlow As New System.Timers.Timer
    Private WithEvents TmrGlowPause As New System.Timers.Timer
    Private LblPercent As New Label
    Private STooLarge As String

#End Region

#Region "Properties"

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(0))> <Category("NeroBar")> <Description("The NeroBar's value.")> Public Property Value() As Double

        Get
            Return _Value
        End Get
        Set(ByVal value As Double)
            _Value = value
            STooLarge = ""
            If _Value > _MaxValue Then
                _Value = _MaxValue
                STooLarge = "> "
            End If
            If _Value < _MinValue Then
                _Value = _MinValue
            End If
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(100))> <Category("NeroBar")> <Description("The NeroBar's maximum value.")> Public Property MaxValue() As Double

        Get
            Return _MaxValue
        End Get
        Set(ByVal value As Double)
            If value <= _MinValue Then
                Throw New Exception("You can't set max value to a value than or equal to min value!")
            Else
                _MaxValue = value
                If _Value > value Then
                    _Value = value
                End If
                If _Segment2StartThreshold > value Then
                    _Segment2StartThreshold = value
                End If
                If _Segment3StartThreshold > value Then
                    _Segment3StartThreshold = value
                End If
                Me.Invalidate()
            End If
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(0))> <Category("NeroBar")> <Description("The NeroBar's minimum value.")> Public Property MinValue() As Double

        Get
            Return _MinValue
        End Get
        Set(ByVal value As Double)
            If value >= _MaxValue Then
                Throw New Exception("You can't set min value to a value higher than or equal to max value!")
            Else
                _MinValue = value
                If _Value < value Then
                    _Value = value
                End If
                If _Segment2StartThreshold < value Then
                    _Segment2StartThreshold = value
                End If
                If _Segment3StartThreshold < value Then
                    _Segment3StartThreshold = value
                End If
                Me.Invalidate()
            End If
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(True)> <Category("NeroBar")> <Description("Determines if the thresholds should be shown or not.")> Public Property DrawThresholds() As Boolean

        Get
            Return _DrawThresholds
        End Get
        Set(ByVal value As Boolean)
            _DrawThresholds = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("NeroBar")> <Description("Determines if the thresholds should be colored according to the selected segment color or not.")> Public Property ColorThresholds() As Boolean

        Get
            Return _ColorThresholds
        End Get
        Set(ByVal value As Boolean)
            _ColorThresholds = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBar.NeroBarSegments), "Three")> <Category("NeroBar")> <Description("The number of segments - between one and three.")> Public Property SegmentCount() As NeroBarSegments

        Get
            Return _SegmentCount
        End Get
        Set(ByVal value As NeroBarSegments)
            _SegmentCount = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "55, 217, 60")> <Description("The color of the first segment.")> Public Property Segment1Color() As Color

        Get
            Return _Segment1Color
        End Get
        Set(ByVal value As Color)
            _Segment1Color = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "252, 252, 0")> <Description("The color of the second segment.")> Public Property Segment2Color() As Color

        Get
            Return _Segment2Color
        End Get
        Set(ByVal value As Color)
            _Segment2Color = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "252, 0, 0")> <Description("The color of the third segment.")> Public Property Segment3Color() As Color

        Get
            Return _Segment3Color
        End Get
        Set(ByVal value As Color)
            _Segment3Color = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(NeroBarColorChangeModes), "Segments")> <Description("Determines if the WHOLE bar should change color when threshold is passed or only the next segment.")> Public Property ColorChangeMode() As NeroBarColorChangeModes

        Get
            Return _ChangeMode
        End Get
        Set(ByVal value As NeroBarColorChangeModes)
            _ChangeMode = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(80))> <Category("NeroBar")> <Description("The lower threshold (starting position) of the second segment.")> Public Property Segment2StartThreshold() As Double

        Get
            Return _Segment2StartThreshold
        End Get
        Set(ByVal value As Double)
            If _SegmentCount <> NeroBarSegments.One Then
                If value > _MaxValue Or value < _MinValue Then
                    Throw New Exception("Segment 2 Start Threshold must be between min and max value")
                Else
                    _Segment2StartThreshold = value
                    Me.Invalidate()
                End If
            End If
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(90))> <Category("NeroBar")> <Description("The lower threshold (starting position) of the third segment.")> Public Property Segment3StartThreshold() As Double

        Get
            Return _Segment3StartThreshold
        End Get
        Set(ByVal value As Double)
            If _SegmentCount = NeroBarSegments.Three Then
                If value > _MaxValue Or value < _MinValue Then
                    Throw New Exception("Segment 3 Start Threshold must be between min and max value")
                Else
                    _Segment3StartThreshold = value
                    Me.Invalidate()
                End If
            End If
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBarGlowModes), "None")> <Category("NeroBar")> <Description("Determines if the NeroBar should have an animated glow or not.")> Public Property GlowMode() As NeroBarGlowModes

        Get
            Return _GlowMode
        End Get
        Set(ByVal value As NeroBarGlowModes)
            _GlowMode = value
            If _GlowMode <> NeroBarGlowModes.None Then
                TmrAnimateGlow.Enabled = True
                TmrGlowPause.Enabled = False
            Else
                If _RightToLeft Then
                    _GlowPosition = Me.Width + 60
                Else
                    _GlowPosition = -60
                End If
                TmrAnimateGlow.Enabled = False
                TmrGlowPause.Enabled = False
            End If
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(20)> <Category("NeroBar")> <Description("The time between the glow advances in milliseconds. Lower value -> Higher Speed etc.")> Public Property GlowSpeed() As Integer

        Get
            Return CInt(_GlowSpeed)
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("The GlowSpeed value cannot be zero or negative")
            End If
            _GlowSpeed = value
            If TmrAnimateGlow.Enabled Then
                TmrAnimateGlow.Enabled = False
                TmrAnimateGlow.Interval = _GlowSpeed
                TmrAnimateGlow.Enabled = True
            Else
                TmrAnimateGlow.Interval = _GlowSpeed
            End If
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(5000)> <Category("NeroBar")> <Description("The pause between the glow animations in milliseconds.")> Public Property GlowPause() As Integer

        Get
            Return CInt(_GlowPause)
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("The GlowPause value cannot be zero or negative")
            End If
            _GlowPause = value
            If TmrGlowPause.Enabled Then
                TmrGlowPause.Enabled = False
                TmrGlowPause.Interval = _GlowPause
                TmrGlowPause.Enabled = True
            Else
                TmrGlowPause.Interval = _GlowPause
            End If
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "150, 255, 255, 255")> <Description("The color of the animated glow.")> Public Property GlowColor() As Color

        Get
            Return _GlowColor
        End Get
        Set(ByVal value As Color)
            _GlowColor = Color.FromArgb(150, value.R, value.G, value.B)
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("NeroBar")> <Description("Determines if progress percentage should be shown or not.")> Public Property PercentageShow() As Boolean

        Get
            Return LblPercent.Visible
        End Get
        Set(ByVal value As Boolean)
            LblPercent.Visible = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBarPercentageCalculationModes), "Segments_1_2_3")> <Category("NeroBar")> <Description("Determines if progress percentage should be calculated based on the segment first segment(s) or the whole control width.")> Public Property PercentageBasedOn() As NeroBarPercentageCalculationModes

        Get
            Return _PercentageMode
        End Get
        Set(ByVal value As NeroBarPercentageCalculationModes)
            _PercentageMode = value
            Me.Invalidate()
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(Color), "ControlText")> <Category("Appearance")> <Description("The forecolor of the Percentage text.")> Public Overrides Property ForeColor() As Color

        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            LblPercent.ForeColor = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("Appearance")> <Description("The Percentage text font.")> Public Overrides Property Font() As Font

        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            LblPercent.Font = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("Appearance")> <Description("The alignment of the Percentage text.")> Public Property TextAlign() As System.Drawing.ContentAlignment

        Get
            Return LblPercent.TextAlign
        End Get
        Set(ByVal value As System.Drawing.ContentAlignment)
            LblPercent.TextAlign = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("Nerobar")> <Description("If true, the bar will be filled from right to left instead of left to right.")> Public Shadows Property RightToLeft() As Boolean

        Get
            Return _RightToLeft
        End Get
        Set(ByVal value As Boolean)
            _RightToLeft = value
            If _GlowPosition = -60 Then _GlowPosition = Me.Width + 60
            Me.Invalidate()
        End Set

    End Property

#Region "Hide irrelevant base properties"

    <Browsable(False)> Public Overrides Property AllowDrop() As Boolean

        Get
            Return MyBase.AllowDrop
        End Get
        Set(ByVal value As Boolean)
            MyBase.AllowDrop = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property AutoScroll() As Boolean

        Get
            Return MyBase.AutoScroll
        End Get
        Set(ByVal value As Boolean)
            MyBase.AutoScroll = value
        End Set

    End Property

    <Browsable(False)> Public Shadows Property AutoScrollMargin() As Size

        Get
            Return MyBase.AutoScrollMargin
        End Get
        Set(ByVal value As Size)
            MyBase.AutoScrollMargin = value
        End Set

    End Property

    <Browsable(False)> Public Shadows Property AutoScrollMinSize() As Size

        Get
            Return MyBase.AutoScrollMinSize
        End Get
        Set(ByVal value As Size)
            MyBase.AutoScrollMinSize = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property AutoScrollOffset() As System.Drawing.Point

        Get
            Return MyBase.AutoScrollOffset
        End Get
        Set(ByVal value As System.Drawing.Point)
            MyBase.AutoScrollOffset = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property AutoSize() As Boolean

        Get
            Return MyBase.AutoSize
        End Get
        Set(ByVal value As Boolean)
            MyBase.AutoSize = value
        End Set

    End Property

    <Browsable(False)> Public Shadows Property AutoSizeMode() As Windows.Forms.AutoSizeMode

        Get
            Return MyBase.AutoSizeMode
        End Get
        Set(ByVal value As Windows.Forms.AutoSizeMode)
            MyBase.AutoSizeMode = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property AutoValidate() As System.Windows.Forms.AutoValidate

        Get
            Return MyBase.AutoValidate
        End Get
        Set(ByVal value As System.Windows.Forms.AutoValidate)
            MyBase.AutoValidate = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property BackColor() As System.Drawing.Color

        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.BackColor = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property BackgroundImage() As System.Drawing.Image

        Get
            Return MyBase.BackgroundImage
        End Get
        Set(ByVal value As System.Drawing.Image)
            MyBase.BackgroundImage = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property BackgroundImageLayout() As System.Windows.Forms.ImageLayout

        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(ByVal value As System.Windows.Forms.ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set

    End Property

    <Browsable(False)> Public Shadows Property BorderStyle() As System.Windows.Forms.BorderStyle

        Get
            Return MyBase.BorderStyle
        End Get
        Set(ByVal value As System.Windows.Forms.BorderStyle)
            MyBase.BorderStyle = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property ContextMenuStrip() As System.Windows.Forms.ContextMenuStrip

        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(ByVal value As System.Windows.Forms.ContextMenuStrip)
            MyBase.ContextMenuStrip = value
        End Set

    End Property

    <Browsable(False)> Public Shadows Property CausesValidation() As Boolean

        Get
            Return MyBase.CausesValidation
        End Get
        Set(ByVal value As Boolean)
            MyBase.CausesValidation = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property MaximumSize() As System.Drawing.Size

        Get
            Return MyBase.MaximumSize
        End Get
        Set(ByVal value As System.Drawing.Size)
            MyBase.MaximumSize = value
        End Set

    End Property

    <Browsable(False)> Public Overrides Property MinimumSize() As System.Drawing.Size

        Get
            Return MyBase.MinimumSize
        End Get
        Set(ByVal value As System.Drawing.Size)
            MyBase.MinimumSize = value
        End Set

    End Property

#End Region

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Name = "NeroBar"
        Me.Size = New System.Drawing.Size(307, 15)
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me.TmrAnimateGlow.Interval = _GlowSpeed
        Me.TmrAnimateGlow.Enabled = False
        Me.TmrGlowPause.Interval = _GlowPause
        Me.TmrGlowPause.Enabled = False
        Me.SuspendLayout()

        With LblPercent
            .Dock = System.Windows.Forms.DockStyle.Fill
            .ForeColor = System.Drawing.SystemColors.ControlText
            .Location = New System.Drawing.Point(0, 0)
            .Name = "PercentLabel"
            .Size = New System.Drawing.Size(307, 15)
            .TabIndex = 0
            .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            .Visible = False
        End With

        Me.Controls.Add(LblPercent)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Overridden Methods"

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)

        MyBase.OnPaintBackground(e)

        Dim rectUpper As Rectangle = New Rectangle(0, 0, Me.Width, CInt(Me.Height / 2 + 2))
        Dim rectLower As Rectangle = New Rectangle(0, CInt(Me.Height / 2), Me.Width, CInt(Me.Height - (Me.Height / 2)))
        Dim pathLower As GraphicsPath = GetRoundPath(rectLower, 2)
        Dim pathUpper As GraphicsPath = GetRoundPath(rectUpper, 2)

        Using brushUpper As Brush = New LinearGradientBrush(rectUpper, _BackRemain4, _BackRemain3, LinearGradientMode.Vertical)
            e.Graphics.FillPath(brushUpper, pathUpper)
        End Using

        Using brushLower As Brush = New LinearGradientBrush(rectLower, _BackRemain1, _BackRemain2, LinearGradientMode.Vertical)
            e.Graphics.FillPath(brushLower, pathLower)
        End Using

        If _DrawThresholds Then

            Dim linePen As Pen = Nothing
            Dim pos As Integer

            If _SegmentCount = NeroBarSegments.Two Or SegmentCount = NeroBarSegments.Three Then

                If _ColorThresholds Then
                    linePen = New Pen(_Segment2Color, 1)
                Else
                    linePen = New Pen(_BorderColor, 1)
                End If

                If _RightToLeft Then
                    pos = Me.Width - CInt(((CDbl(Me.Width) - 2) * (_Segment2StartThreshold - _MinValue)) / (_MaxValue - _MinValue))
                Else
                    pos = CInt(((CDbl(Me.Width) - 2) * (_Segment2StartThreshold - _MinValue)) / (_MaxValue - _MinValue))
                End If

                e.Graphics.DrawLine(linePen, pos, 0, pos, Me.Height)

            End If

            If _SegmentCount = NeroBarSegments.Three Then

                If _ColorThresholds Then
                    linePen = New Pen(_Segment3Color, 1)
                Else
                    linePen = New Pen(_BorderColor, 1)
                End If

                If _RightToLeft Then
                    pos = Me.Width - CInt(((CDbl(Me.Width) - 2) * (_Segment3StartThreshold - _MinValue)) / (_MaxValue - _MinValue))
                Else
                    pos = CInt(((CDbl(Me.Width) - 2) * (_Segment3StartThreshold - _MinValue)) / (_MaxValue - _MinValue))
                End If

                e.Graphics.DrawLine(linePen, pos, 0, pos, Me.Height)

            End If

        End If

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim backActive1 As Color
        Dim backActive2 As Color
        Dim backActive3 As Color
        Dim backActive4 As Color
        Dim width As Double
        Dim prevWidth As Double
        Dim offset As Double
        Dim rectUpper As Rectangle
        Dim pathUpper As GraphicsPath
        Dim rectLower As Rectangle
        Dim pathLower As GraphicsPath
        Dim Percent As Integer = 0

        Dim corrFactor2To1 As Single = -0.225
        Dim corrFactor2To3 As Single = 0.5
        Dim corrFactor2To4 As Single = 0.8

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

        width = ((CDbl(Me.Width) - 2) * (_Value - _MinValue)) / (_MaxValue - _MinValue)

        If _ChangeMode = NeroBarColorChangeModes.Segments Then
            If _SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three Then
                If _Value > _Segment2StartThreshold Then
                    width = ((CDbl(Me.Width) - 2) * (_Segment2StartThreshold - _MinValue)) / (_MaxValue - _MinValue)
                End If
            End If
        End If

        prevWidth = width

        If CInt(width) > 0 Then
            If _RightToLeft Then
                rectUpper = New Rectangle(Me.Width - CInt(width), 1, CInt(width), CInt(Me.Height / 2 + 1))
                If _SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three Then
                    If _Value < _Segment2StartThreshold Then
                        pathUpper = GetRoundPath(rectUpper, 1)
                    Else
                        pathUpper = GetRightRoundPath(rectUpper, 1)
                    End If
                Else
                    pathUpper = GetRoundPath(rectUpper, 1)
                End If

                rectLower = New Rectangle(Me.Width - CInt(width), CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))
                If _SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three Then
                    If _Value < _Segment2StartThreshold Then
                        pathLower = GetRoundPath(rectLower, 1)
                    Else
                        pathLower = GetRightRoundPath(rectLower, 1)
                    End If
                Else
                    pathLower = GetRoundPath(rectLower, 1)
                End If
            Else
                rectUpper = New Rectangle(1, 1, CInt(width), CInt(Me.Height / 2 + 1))
                If _SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three Then
                    If _Value < _Segment2StartThreshold Then
                        pathUpper = GetRoundPath(rectUpper, 1)
                    Else
                        pathUpper = GetLeftRoundPath(rectUpper, 1)
                    End If
                Else
                    pathUpper = GetRoundPath(rectUpper, 1)
                End If

                rectLower = New Rectangle(1, CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))
                If _SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three Then
                    If _Value < _Segment2StartThreshold Then
                        pathLower = GetRoundPath(rectLower, 1)
                    Else
                        pathLower = GetLeftRoundPath(rectLower, 1)
                    End If
                Else
                    pathLower = GetRoundPath(rectLower, 1)
                End If
            End If

            backActive1 = CreateColorWithCorrectedLightness(_Segment1Color, corrFactor2To1)
            backActive2 = _Segment1Color
            backActive3 = CreateColorWithCorrectedLightness(_Segment1Color, corrFactor2To3)
            backActive4 = CreateColorWithCorrectedLightness(_Segment1Color, corrFactor2To4)

            If _ChangeMode = NeroBarColorChangeModes.WholeBar And _SegmentCount <> NeroBarSegments.One Then
                If _SegmentCount = NeroBarSegments.Two Then
                    If _Value > _Segment2StartThreshold Then
                        backActive1 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To1)
                        backActive2 = _Segment2Color
                        backActive3 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To3)
                        backActive4 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To4)
                    End If
                ElseIf _SegmentCount = NeroBarSegments.Three Then
                    If _Value > _Segment2StartThreshold Then
                        backActive1 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To1)
                        backActive2 = _Segment2Color
                        backActive3 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To3)
                        backActive4 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To4)
                    End If
                    If _Value > _Segment3StartThreshold Then
                        backActive1 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To1)
                        backActive2 = _Segment3Color
                        backActive3 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To3)
                        backActive4 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To4)
                    End If
                End If
            End If

            Using brushUpper As Brush = New LinearGradientBrush(rectUpper, backActive4, backActive3, LinearGradientMode.Vertical)
                e.Graphics.FillPath(brushUpper, pathUpper)
            End Using

            Using brushLower As Brush = New LinearGradientBrush(rectLower, backActive1, backActive2, LinearGradientMode.Vertical)
                e.Graphics.FillPath(brushLower, pathLower)
            End Using
        End If

        If (_SegmentCount = NeroBarSegments.Two Or _SegmentCount = NeroBarSegments.Three) And _ChangeMode = NeroBarColorChangeModes.Segments Then

            width = ((CDbl(Me.Width) - 2) * (_Value - _MinValue)) / (_MaxValue - _MinValue)

            If _SegmentCount = NeroBarSegments.Three Then
                If _Value > _Segment3StartThreshold Then
                    width = ((CDbl(Me.Width) - 2) * (_Segment3StartThreshold - _MinValue)) / (_MaxValue - _MinValue)
                End If
            End If

            width = width - prevWidth
            offset = prevWidth + 1
            prevWidth = width + prevWidth

            If CInt(width) > 0 Then
                If _RightToLeft Then
                    rectUpper = New Rectangle(CInt(Me.Width - CInt(width) - offset), 1, CInt(width), CInt(Me.Height / 2 + 1))
                    If _SegmentCount = NeroBarSegments.Three Then
                        If _Value < _Segment3StartThreshold Then
                            pathUpper = GetLeftRoundPath(rectUpper, 1)
                        Else
                            pathUpper = GetNoRoundPath(rectUpper, 1)
                        End If
                    Else
                        pathUpper = GetLeftRoundPath(rectUpper, 1)
                    End If

                    rectLower = New Rectangle(CInt(Me.Width - CInt(width) - offset), CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))

                    If _SegmentCount = NeroBarSegments.Three Then

                        If _Value < _Segment3StartThreshold Then
                            pathLower = GetLeftRoundPath(rectLower, 1)
                        Else
                            pathLower = GetNoRoundPath(rectLower, 1)
                        End If

                    Else
                        pathLower = GetLeftRoundPath(rectLower, 1)
                    End If

                Else

                    rectUpper = New Rectangle(CInt(offset), 1, CInt(width), CInt(Me.Height / 2 + 1))

                    If _SegmentCount = NeroBarSegments.Three Then

                        If _Value < _Segment3StartThreshold Then
                            pathUpper = GetRightRoundPath(rectUpper, 1)
                        Else
                            pathUpper = GetNoRoundPath(rectUpper, 1)
                        End If

                    Else

                        pathUpper = GetRightRoundPath(rectUpper, 1)

                    End If

                    rectLower = New Rectangle(CInt(offset), CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))

                    If _SegmentCount = NeroBarSegments.Three Then

                        If _Value < _Segment3StartThreshold Then
                            pathLower = GetRightRoundPath(rectLower, 1)
                        Else
                            pathLower = GetNoRoundPath(rectLower, 1)
                        End If

                    Else

                        pathLower = GetRightRoundPath(rectLower, 1)

                    End If

                End If

                backActive1 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To1)
                backActive2 = _Segment2Color
                backActive3 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To3)
                backActive4 = CreateColorWithCorrectedLightness(_Segment2Color, corrFactor2To4)

                Using brushUpper As Brush = New LinearGradientBrush(rectUpper, backActive4, backActive3, LinearGradientMode.Vertical)
                    e.Graphics.FillPath(brushUpper, pathUpper)
                End Using

                Using brushLower As Brush = New LinearGradientBrush(rectLower, backActive1, backActive2, LinearGradientMode.Vertical)
                    e.Graphics.FillPath(brushLower, pathLower)
                End Using

            End If

        End If

        If _SegmentCount = NeroBarSegments.Three And _ChangeMode = NeroBarColorChangeModes.Segments Then

            width = ((CDbl(Me.Width) - 2) * (_Value - _MinValue)) / (_MaxValue - _MinValue)
            width = width - prevWidth

            offset = prevWidth + 1

            If CInt(width) > 0 Then

                If _RightToLeft Then

                    rectUpper = New Rectangle(CInt(Me.Width - CInt(width) - offset), 1, CInt(width), CInt(Me.Height / 2 + 1))
                    pathUpper = GetLeftRoundPath(rectUpper, 1)

                    rectLower = New Rectangle(CInt(Me.Width - CInt(width) - offset), CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))
                    pathLower = GetLeftRoundPath(rectLower, 1)
                Else

                    rectUpper = New Rectangle(CInt(offset), 1, CInt(width), CInt(Me.Height / 2 + 1))
                    pathUpper = GetRightRoundPath(rectUpper, 1)

                    rectLower = New Rectangle(CInt(offset), CInt(Me.Height / 2), CInt(width), CInt(Me.Height - (Me.Height / 2) - 1))
                    pathLower = GetRightRoundPath(rectLower, 1)
                End If

                backActive1 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To1)
                backActive2 = _Segment3Color
                backActive3 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To3)
                backActive4 = CreateColorWithCorrectedLightness(_Segment3Color, corrFactor2To4)

                Using brushUpper As Brush = New LinearGradientBrush(rectUpper, backActive4, backActive3, LinearGradientMode.Vertical)
                    e.Graphics.FillPath(brushUpper, pathUpper)
                End Using

                Using brushLower As Brush = New LinearGradientBrush(rectLower, backActive1, backActive2, LinearGradientMode.Vertical)
                    e.Graphics.FillPath(brushLower, pathLower)
                End Using

            End If

        End If

        Dim rectFull As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim pathFull As GraphicsPath = GetRoundPath(rectFull, 2)

        Using pen As New Pen(_BorderColor)
            e.Graphics.DrawPath(pen, pathFull)
        End Using

        If _GlowMode <> NeroBarGlowModes.None And Not Me.DesignMode Then

            Dim r As New Rectangle(_GlowPosition, 0, 60, Me.Height)
            Dim lgb As New LinearGradientBrush(r, Color.White, Color.White, LinearGradientMode.Horizontal)

            Dim cb As New ColorBlend(4)
            cb.Colors = New Color() {Color.Transparent, _GlowColor, _GlowColor, Color.Transparent}
            cb.Positions = New Single() {0.0F, 0.5F, 0.6F, 1.0F}
            lgb.InterpolationColors = cb

            Dim clip As New Rectangle(1, 2, Me.Width - 3, Me.Height - 3)

            clip.Width = CInt(_Value * 1.0F / (_MaxValue - _MinValue) * Me.Width)

            If _RightToLeft Then
                clip.X = Me.Width - clip.Width
            End If

            If clip.Width > 0 And clip.Height > 0 And r.Width > 0 And r.Height > 0 Then

                If GlowMode = NeroBarGlowModes.ProgressOnly Then
                    e.Graphics.SetClip(clip)
                End If
                e.Graphics.FillRectangle(lgb, r)
                e.Graphics.ResetClip()

            End If

        End If

        If LblPercent.Visible Then

            Try
                Select Case _PercentageMode
                    Case NeroBarPercentageCalculationModes.Segment_1
                        If _SegmentCount = NeroBarSegments.One Then
                            Percent = CInt((_Value * 100) / (_MaxValue - _MinValue))
                        Else
                            Percent = CInt((_Value * 100) / (_Segment2StartThreshold - _MinValue))
                        End If
                    Case NeroBarPercentageCalculationModes.Segments_1_2
                        If _SegmentCount <> NeroBarSegments.Three Then
                            Percent = CInt((_Value * 100) / (_MaxValue - _MinValue))
                        Else
                            Percent = CInt((_Value * 100) / (_Segment3StartThreshold - _MinValue))
                        End If
                    Case NeroBarPercentageCalculationModes.WholeControl
                        Percent = CInt((_Value * 100) / (_MaxValue - _MinValue))
                End Select
            Catch
            End Try

            LblPercent.Text = STooLarge & String.Format("{0}%", Percent)
            LblPercent.Width = Me.Width

        End If

    End Sub

    Public Overrides Function GetPreferredSize(ByVal proposedSize As System.Drawing.Size) As System.Drawing.Size

        If proposedSize.Width < 100 Then proposedSize.Width = 100
        proposedSize.Height = 16
        Return proposedSize

    End Function

#End Region

#Region "Private Methods"

    Private Function GetLeftRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath

        Dim GraphPath As New GraphicsPath

        GraphPath.AddArc(r.X, r.Y, depth, depth, 180, 90)
        GraphPath.AddLine(r.X + r.Width - depth, r.Y, r.X + r.Width, r.Y)
        GraphPath.AddLine(r.X + r.Width, r.Y, r.X + r.Width, r.Y + depth)
        GraphPath.AddLine(r.X + r.Width, r.Y + r.Height - depth, r.X + r.Width, r.Y + r.Height)
        GraphPath.AddLine(r.X + r.Width, r.Y + r.Height, r.X + r.Width - depth, r.Y + r.Height)
        GraphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90)

        Return GraphPath

    End Function

    Private Function GetRightRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath

        Dim GraphPath As New GraphicsPath

        GraphPath.AddLine(r.X, r.Y + depth, r.X, r.Y)
        GraphPath.AddLine(r.X, r.Y, r.X + depth, r.Y)
        GraphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90)
        GraphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90)
        GraphPath.AddLine(r.X + depth, r.Y + r.Height, r.X, r.Y + r.Height)
        GraphPath.AddLine(r.X, r.Y + r.Height, r.X, r.Y + r.Height - depth)

        Return GraphPath

    End Function

    Private Function GetNoRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath

        Dim GraphPath As New GraphicsPath

        GraphPath.AddLine(r.X, r.Y + depth, r.X, r.Y)
        GraphPath.AddLine(r.X, r.Y, r.X + depth, r.Y)
        GraphPath.AddLine(r.X + r.Width - depth, r.Y, r.X + r.Width, r.Y)
        GraphPath.AddLine(r.X + r.Width, r.Y, r.X + r.Width, r.Y + depth)
        GraphPath.AddLine(r.X + r.Width, r.Y + r.Height - depth, r.X + r.Width, r.Y + r.Height)
        GraphPath.AddLine(r.X + r.Width, r.Y + r.Height, r.X + r.Width - depth, r.Y + r.Height)
        GraphPath.AddLine(r.X + depth, r.Y + r.Height, r.X, r.Y + r.Height)
        GraphPath.AddLine(r.X, r.Y + r.Height, r.X, r.Y + r.Height - depth)

        Return GraphPath

    End Function

    Private Function GetRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath

        Dim GraphPath As New GraphicsPath

        GraphPath.AddArc(r.X, r.Y, depth, depth, 180, 90)
        GraphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90)
        GraphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90)
        GraphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90)
        GraphPath.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth \ 2)

        Return GraphPath

    End Function

    Private Function CreateColorWithCorrectedLightness(ByVal originalColor As Color, ByVal correctionFactor As Single) As Color

        If correctionFactor = 0 Then Return originalColor

        Dim red As Single = CSng(originalColor.R)
        Dim green As Single = CSng(originalColor.G)
        Dim blue As Single = CSng(originalColor.B)

        If correctionFactor < 0 Then
            red = red * (1 + correctionFactor)
            green = green * (1 + correctionFactor)
            blue = blue * (1 + correctionFactor)
        Else
            red = (255 - red) * correctionFactor + red
            green = (255 - green) * correctionFactor + green
            blue = (255 - blue) * correctionFactor + blue
        End If

        If red > 255 Then red = 255
        If green > 255 Then green = 255
        If blue > 255 Then blue = 255

        Return Color.FromArgb(originalColor.A, CInt(red), CInt(green), CInt(blue))

    End Function

#End Region

#Region "Timer Event Handlers"

    Private Sub TmrGlowPause_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles TmrGlowPause.Elapsed

        TmrGlowPause.Enabled = False

        If _GlowMode <> NeroBarGlowModes.None Then
            TmrAnimateGlow.Enabled = True

        Else

            TmrAnimateGlow.Enabled = False
            TmrGlowPause.Enabled = False

            If _RightToLeft Then
                _GlowPosition = Me.Width + 60
            Else
                _GlowPosition = -60
            End If

        End If

    End Sub

    Private Sub TmrAnimateGlow_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles TmrAnimateGlow.Elapsed

        TmrAnimateGlow.Enabled = False

        If _GlowMode <> NeroBarGlowModes.None Then

            If _RightToLeft Then

                _GlowPosition -= 2

                If _GlowPosition < -60 Then
                    _GlowPosition = Me.Width + 60
                    TmrGlowPause.Enabled = True
                Else
                    TmrAnimateGlow.Enabled = True
                End If

            Else

                _GlowPosition += 2

                If _GlowPosition > Me.Width Then
                    _GlowPosition = -60
                    TmrGlowPause.Enabled = True
                Else
                    TmrAnimateGlow.Enabled = True
                End If

            End If

            Me.Invalidate()

        Else

            TmrAnimateGlow.Enabled = False
            TmrGlowPause.Enabled = False

            If _RightToLeft Then
                _GlowPosition = Me.Width + 60
            Else
                _GlowPosition = -60
            End If

        End If

    End Sub

#End Region

End Class