#Region "References"

Imports System.ComponentModel
Imports System.Windows.Forms.Design

#End Region

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)> Public Class NeroBarToolStripItem

    Inherits ToolStripControlHost

#Region "Private Members"

    Private _neroBar As NeroBar = Nothing

#End Region

#Region "Constructor"

    Public Sub New()

        MyBase.New(New NeroBar)
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        _neroBar = CType(Control, NeroBar)

    End Sub

#End Region

#Region "Properties"

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(0))> <Category("NeroBar")> <Description("The NeroBar's value.")> Public Property Value() As Double

        Get
            Return _neroBar.Value
        End Get
        Set(ByVal value As Double)
            _neroBar.Value = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(100))> <Category("NeroBar")> <Description("The NeroBar's maximum value.")> Public Property MaxValue() As Double

        Get
            Return _neroBar.MaxValue
        End Get
        Set(ByVal value As Double)
            _neroBar.MaxValue = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(0))> <Category("NeroBar")> <Description("The NeroBar's minimum value.")> Public Property MinValue() As Double

        Get
            Return _neroBar.MinValue
        End Get
        Set(ByVal value As Double)
            _neroBar.MinValue = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(True)> <Category("NeroBar")> <Description("Determines if the thresholds should be shown or not.")> Public Property DrawThresholds() As Boolean

        Get
            Return _neroBar.DrawThresholds
        End Get
        Set(ByVal value As Boolean)
            _neroBar.DrawThresholds = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("NeroBar")> <Description("Determines if the thresholds should be colored according to the selected segment color or not.")> Public Property ColorThresholds() As Boolean

        Get
            Return _neroBar.ColorThresholds
        End Get
        Set(ByVal value As Boolean)
            _neroBar.ColorThresholds = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBar.NeroBarSegments), "Three")> <Category("NeroBar")> <Description("The number of segments - between one and three.")> Public Property SegmentCount() As NeroBar.NeroBarSegments

        Get
            Return _neroBar.SegmentCount
        End Get
        Set(ByVal value As NeroBar.NeroBarSegments)
            _neroBar.SegmentCount = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "55, 217, 60")> <Description("The color of the first segment.")> Public Property Segment1Color() As Color

        Get
            Return _neroBar.Segment1Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment1Color = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "252, 252, 0")> <Description("The color of the second segment.")> Public Property Segment2Color() As Color

        Get
            Return _neroBar.Segment2Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment2Color = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "252, 0, 0")> <Description("The color of the third segment.")> Public Property Segment3Color() As Color

        Get
            Return _neroBar.Segment3Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment3Color = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(NeroBar.NeroBarColorChangeModes), "Segments")> <Description("Determines if the whole bar should change color when threshold is passed or only the next segment.")> Public Property ColorChangeMode() As NeroBar.NeroBarColorChangeModes

        Get
            Return _neroBar.ColorChangeMode
        End Get
        Set(ByVal value As NeroBar.NeroBarColorChangeModes)
            _neroBar.ColorChangeMode = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(80))> <Category("NeroBar")> <Description("The lower threshold (starting position) of the second segment.")> Public Property Segment2StartThreshold() As Double

        Get
            Return _neroBar.Segment2StartThreshold
        End Get
        Set(ByVal value As Double)
            _neroBar.Segment2StartThreshold = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(CDbl(90))> <Category("NeroBar")> <Description("The lower threshold (starting position) of the third segment.")> Public Property Segment3StartThreshold() As Double

        Get
            Return _neroBar.Segment3StartThreshold
        End Get
        Set(ByVal value As Double)
            _neroBar.Segment3StartThreshold = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBar.NeroBarGlowModes), "None")> <Category("NeroBar")> <Description("Determines if the NeroBar should have an animated glow or not.")> Public Property GlowMode() As NeroBar.NeroBarGlowModes

        Get
            Return _neroBar.GlowMode
        End Get
        Set(ByVal value As NeroBar.NeroBarGlowModes)
            _neroBar.GlowMode = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(20)> <Category("NeroBar")> <Description("The time between the glow advances in milliseconds. Lower value -> Higher Speed etc.")> Public Property GlowSpeed() As Integer

        Get
            Return _neroBar.GlowSpeed
        End Get
        Set(ByVal value As Integer)
            _neroBar.GlowSpeed = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(5000)> <Category("NeroBar")> <Description("The pause between the glow animations in milliseconds.")> Public Property GlowPause() As Integer

        Get
            Return _neroBar.GlowPause
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("The GlowPause value cannot be zero or negative")
            End If
            _neroBar.GlowPause = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("NeroBar")> <DefaultValue(GetType(Color), "150, 255, 255, 255")> <Description("The color of the animated glow.")> Public Property GlowColor() As Color

        Get
            Return _neroBar.GlowColor
        End Get
        Set(ByVal value As Color)
            _neroBar.GlowColor = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("NeroBar")> <Description("Determines if progress percentage should be shown or not.")> Public Property PercentageShow() As Boolean

        Get
            Return _neroBar.PercentageShow
        End Get
        Set(ByVal value As Boolean)
            _neroBar.PercentageShow = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(NeroBar.NeroBarPercentageCalculationModes), "Segments_1_2_3")> <Category("NeroBar")> <Description("Determines if progress percentage should be calculated based on the segment first segment(s) or the whole control width.")> Public Property PercentageBasedOn() As NeroBar.NeroBarPercentageCalculationModes

        Get
            Return _neroBar.PercentageBasedOn
        End Get
        Set(ByVal value As NeroBar.NeroBarPercentageCalculationModes)
            _neroBar.PercentageBasedOn = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(GetType(Color), "ControlText")> <Category("Appearance")> <Description("The forecolor of the Percentage text.")> Public Overrides Property ForeColor() As System.Drawing.Color

        Get
            Return _neroBar.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _neroBar.ForeColor = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("Appearance")> <Description("The Percentage text font.")> Public Overrides Property Font() As System.Drawing.Font

        Get
            Return _neroBar.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            _neroBar.Font = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <Category("Appearance")> <Description("The alignment of the Percentage text.")> Public Shadows Property TextAlign() As System.Drawing.ContentAlignment

        Get
            Return _neroBar.TextAlign
        End Get
        Set(ByVal value As System.Drawing.ContentAlignment)
            _neroBar.TextAlign = value
        End Set

    End Property

    <Localizable(False)> <Bindable(False)> <Browsable(True)> <DefaultValue(False)> <Category("Nerobar")> <Description("If true, the bar will be filled from right to left instead of left to right.")> Public Shadows Property RightToLeft() As Boolean

        Get
            Return _neroBar.RightToLeft
        End Get
        Set(ByVal value As Boolean)
            _neroBar.RightToLeft = value
        End Set

    End Property

#End Region

#Region "Overridden Methods"

    Public Overrides Function GetPreferredSize(ByVal constrainingSize As System.Drawing.Size) As System.Drawing.Size
        Return Control.GetPreferredSize(constrainingSize)
    End Function

    Protected Overrides Sub OnSubscribeControlEvents(ByVal c As Control)
        MyBase.OnSubscribeControlEvents(Control)
    End Sub

    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal c As Control)
        MyBase.OnUnsubscribeControlEvents(Control)
    End Sub

#End Region

End Class