using SCHOTT.Core.Extensions;
using SCHOTT.Core.Utilities;
using SCHOTT.VisiLED.Communication;
using SCHOTT.VisiLED.Dashboard.Enums;
using SCHOTT.VisiLED.Enums;
using SCHOTT.VisiLED.Serial;
using SCHOTT.WinForms.Controls.Combo_Controls;
using SCHOTT.WinForms.Controls.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Charting = System.Windows.Forms.DataVisualization.Charting;
using Docking = SCHOTT.WinForms.Docking.Docking;

namespace SCHOTT.VisiLED.Dashboard.Forms
{
    public partial class ChannelControls : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private readonly Channel _channel;
        private readonly Timer _rotationTimer = new Timer();
        private readonly VisiLEDThreadedComPort _visiLedThreadedComPort;

        public ChannelControls(string title, Channel channel, VisiLEDThreadedComPort visiLedThreadedComPort)
        {
            InitializeComponent();

            #region Setup Buttons

            segmentsFull.BackgroundImage = CreateSegmentImage(0xFF);
            segmentsHalf.BackgroundImage = CreateSegmentImage(0x0F);
            segmentsQuarter.BackgroundImage = CreateSegmentImage(0x03);
            segmentsQuarterSpaced.BackgroundImage = CreateSegmentImage(0x33);
            segmentsEigthSpaced.BackgroundImage = CreateSegmentImage(0x55);
            segmentsNone.BackgroundImage = CreateSegmentImage(0x00);

            outputPower.SliderControl.ElapsedInnerColor = Globals.OnColor;
            outputPower.SliderControl.ElapsedOuterColor = ControlPaint.Light(Globals.OnColor, 0.65f);
            outputPower.SliderControl.BarInnerColor = Globals.OffColor;
            outputPower.SliderControl.BarOuterColor = ControlPaint.Light(Globals.OffColor, 0.65f);
            outputPower.OnValueChanged += OutputPower_OnValueChanged;

            outputPowerToggle.ToggleEnabledColor = Globals.OnColor;
            outputPowerToggle.ToggleEnabledText = "On";
            outputPowerToggle.ToggleDisabledColor = Globals.OffColor;
            outputPowerToggle.ToggleDisabledText = "Off";

            strobe.ToggleEnabledColor = Globals.OnColor;
            strobe.ToggleEnabledText = "";
            strobe.ToggleDisabledColor = Globals.OffColor;
            strobe.ToggleDisabledText = "";

            contRotationCCW.ToggleEnabledColor = Globals.OnColor;
            contRotationCCW.ToggleEnabledText = "";
            contRotationCCW.ToggleDisabledColor = Globals.OffColor;
            contRotationCCW.ToggleDisabledText = "";

            contRotationCW.ToggleEnabledColor = Globals.OnColor;
            contRotationCW.ToggleEnabledText = "";
            contRotationCW.ToggleDisabledColor = Globals.OffColor;
            contRotationCW.ToggleDisabledText = "";

            #endregion

            // setup form
            Text = title;
            HideOnClose = true;
            ShowHint = DockState.Document;
            CloseButton = false;
            CloseButtonVisible = false;

            // setup external variables
            _channel = channel;
            _visiLedThreadedComPort = visiLedThreadedComPort;

            // setup initial display state
            DisplayControls(false);

            // register update events
            Load += LoadEvent;
            segments.MouseClick += Segments_MouseClick;
            _visiLedThreadedComPort.RegisterChannelStatusUpdate(channel, MessageBroker.MessageContext.NewThreadToGui,
                UpdateDisplay);
            _visiLedThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui,
                args => DisplayControls(args.IsConnected));
            _visiLedThreadedComPort.RegisterMasterStatusUpdate(MessageBroker.MessageContext.NewThreadToGui,
                args => RotationTimerInterval = args.RotationPeriod);

            _rotationTimer.Interval = 500;
            _rotationTimer.Tick += RotationTimer_Tick;
            _rotationTimer.Enabled = true;

            scrollPanel.Dock = DockStyle.Fill;
        }

        #region External Functions

        public void DisplayControls(bool enable)
        {
            if (!enable)
            {
                outputPowerToggle.ToggleSet(false);
                strobe.ToggleSet(false);
                contRotationCCW.ToggleSet(false);
                contRotationCW.ToggleSet(false);
                GraphSegmentCode = 0;
                outputPower.Value = 0;
                transparentLabel.BringToFront();
            }
            else
            {
                transparentLabel.SendToBack();
            }
        }

        public void PowerOutputToggle()
        {
            outputPowerToggle.Toggle();
            SendPower();
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public void ConfigureLayout(UserModes mode)
        {
            foreach (ColumnStyle style in tableLayoutPanel2.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 100;
            }

            switch (mode)
            {
                case UserModes.Simple:
                    tableLayoutPanel2.ColumnStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.ColumnStyles[0].Width = 0;
                    tableLayoutPanel2.ColumnStyles[3].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.ColumnStyles[3].Width = 0;
                    tableLayoutPanel2.ColumnStyles[4].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.ColumnStyles[4].Width = 0;
                    break;

                default:
                    break;
            }
        }

        public int RotationTimerInterval
        {
            get { return _rotationTimer.Interval; }
            set { _rotationTimer.Interval = Math.Max(value, 2); }
        }

        #endregion

        #region Internal Functions

        #region Events

        private void LoadEvent(object sender, EventArgs e)
        {
            _pnlMonitor = new DetectEnterExit(scrollPanel);
            _pnlMonitor.ControlEnter += _pnlMonitor_ControlEnter;
            Application.AddMessageFilter(_pnlMonitor);
        }

        private void _pnlMonitor_ControlEnter(Control control)
        {
            scrollPanel.Focus();
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            if (contRotationCCW.ToggleGet())
            {
                GraphSegmentCode = GraphSegmentCode.RotateRight();
            }
            else if (contRotationCW.ToggleGet())
            {
                GraphSegmentCode = GraphSegmentCode.RotateLeft();
            }
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }

        private void Segments_MouseClick(object sender, MouseEventArgs e)
        {
            var result = segments.HitTest(e.X, e.Y);
            if (result?.Series == null || result.PointIndex == 8)
                return;

            var currentColor = result.Series.Points[result.PointIndex].Color;
            result.Series.Points[result.PointIndex].Color = currentColor == Globals.OffColor
                ? Globals.OnColor
                : Globals.OffColor;

            _visiLedThreadedComPort.SetSegmentCode(_channel, GraphSegmentCode);
        }

        #endregion

        private void UpdateDisplay(ChannelObject args)
        {
            GraphSegmentCode = args.SegmentCode;
            SetMode(args.Mode, false);
            SetPower(((uint) args.Mode & (uint) Mode.Strobe) == 0 ? args.Power : args.StrobePower);
        }

        private void OutputPower_OnValueChanged(SliderNumericCombo control, int value)
        {
            outputPowerToggle.ToggleSet(true);
            SendPower();
        }

        #endregion

        public void SetPower(int power)
        {
            outputPowerToggle.ToggleSet(power > 0);
            outputPower.Value = power;
        }

        private void outputPowerToggle_Click(object sender, EventArgs e)
        {
            PowerOutputToggle();
        }

        private void SendPower()
        {
            var command = outputPowerToggle.ToggleGet() ? outputPower.Value : 0;
            _visiLedThreadedComPort.SetPower(_channel, strobe.ToggleGet() ? PowerMode.Strobe : PowerMode.Normal, command);
        }

        #region Mode Changes

        private void rotateCW_Click(object sender, EventArgs e)
        {
            switch (_previousMode)
            {
                case Mode.StrobeClockwise:
                    SetMode(Mode.Strobe);
                    break;

                case Mode.StrobeCounterClockwise:
                    SetMode(Mode.Strobe);
                    break;

                default:
                    SetMode(Mode.Normal);
                    break;
            }
            _visiLedThreadedComPort.Rotate(_channel, RotationDirection.Clockwise);
        }

        private void rotateCCW_Click(object sender, EventArgs e)
        {
            switch (_previousMode)
            {
                case Mode.StrobeClockwise:
                    SetMode(Mode.Strobe);
                    break;

                case Mode.StrobeCounterClockwise:
                    SetMode(Mode.Strobe);
                    break;

                default:
                    SetMode(Mode.Normal);
                    break;
            }
            _visiLedThreadedComPort.Rotate(_channel, RotationDirection.CounterClockwise);
        }

        private void contRotationCCW_Click(object sender, EventArgs e)
        {
            switch (_previousMode)
            {
                case Mode.CounterClockwise:
                    SetMode(Mode.Normal);
                    break;

                case Mode.Strobe:
                    SetMode(Mode.StrobeCounterClockwise);
                    break;

                case Mode.StrobeCounterClockwise:
                    SetMode(Mode.Strobe);
                    break;

                default:
                    SetMode(Mode.CounterClockwise);
                    break;
            }
        }

        private void contRotationCW_Click(object sender, EventArgs e)
        {
            switch (_previousMode)
            {
                case Mode.Clockwise:
                    SetMode(Mode.Normal);
                    break;

                case Mode.Strobe:
                    SetMode(Mode.StrobeClockwise);
                    break;

                case Mode.StrobeClockwise:
                    SetMode(Mode.Strobe);
                    break;

                default:
                    SetMode(Mode.Clockwise);
                    break;
            }
        }

        private void strobe_Click(object sender, EventArgs e)
        {
            switch (_previousMode)
            {
                case Mode.Clockwise:
                    SetMode(Mode.StrobeClockwise);
                    break;

                case Mode.CounterClockwise:
                    SetMode(Mode.StrobeCounterClockwise);
                    break;

                case Mode.Strobe:
                    SetMode(Mode.Normal);
                    break;

                case Mode.StrobeClockwise:
                    SetMode(Mode.Clockwise);
                    break;

                case Mode.StrobeCounterClockwise:
                    SetMode(Mode.CounterClockwise);
                    break;

                default:
                    SetMode(Mode.Strobe);
                    break;
            }
        }

        private Mode _previousMode = Mode.Off;

        private void SetMode(Mode mode, bool sendCommand = true)
        {
            if (mode == _previousMode)
                return;

            _previousMode = mode;
            switch (mode)
            {
                case Mode.Clockwise:
                    contRotationCCW.ToggleSet(false);
                    contRotationCW.ToggleSet(true);
                    strobe.ToggleSet(false);
                    break;

                case Mode.StrobeClockwise:
                    contRotationCCW.ToggleSet(false);
                    contRotationCW.ToggleSet(true);
                    strobe.ToggleSet(true);
                    break;

                case Mode.CounterClockwise:
                    contRotationCCW.ToggleSet(true);
                    contRotationCW.ToggleSet(false);
                    strobe.ToggleSet(false);
                    break;

                case Mode.StrobeCounterClockwise:
                    contRotationCCW.ToggleSet(true);
                    contRotationCW.ToggleSet(false);
                    strobe.ToggleSet(true);
                    break;

                case Mode.Normal:
                    contRotationCCW.ToggleSet(false);
                    contRotationCW.ToggleSet(false);
                    strobe.ToggleSet(false);
                    break;

                case Mode.Strobe:
                    contRotationCCW.ToggleSet(false);
                    contRotationCW.ToggleSet(false);
                    strobe.ToggleSet(true);
                    break;

                default:
                    SetMode(Mode.Normal);
                    break;
            }

            if (!sendCommand)
                return;

            _visiLedThreadedComPort.SetMode(_channel, mode);
            _visiLedThreadedComPort.GetStatus();
        }

        #endregion

        #region Segment Functions

        private static Bitmap CreateSegmentImage(uint code)
        {
            var chart = new Charting.Chart();
            chart.Series.Clear();
            chart.BackColor = Color.Transparent;
            chart.ChartAreas.Add("Chart Area");
            chart.ChartAreas[0].BackColor = Color.Transparent;
            chart.Series.Add("segments");
            chart.Series[0].ChartType = Charting.SeriesChartType.Doughnut;
            chart.Series[0].BorderWidth = 10;
            chart.Series[0].BorderColor = Color.Black;
            for (var i = 0; i < 8; i++)
            {
                chart.Series[0].Points.Add(1, i);
                chart.Series[0].Points[i].Color = code.CheckBit(i) ? Globals.OnColor : Globals.OffColor;
            }

            using (var ms = new MemoryStream())
            {
                chart.SaveImage(ms, Charting.ChartImageFormat.Png);
                return new Bitmap(ms);
            }
        }

        private void segmentsFull_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.Full);
        }

        private void segmentsHalf_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.Half);
        }

        private void segmentsQuarter_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.Quarter);
        }

        private void segmentsQuarterSpaced_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.QuarterSpaced);
        }

        private void segmentsEigthSpaced_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.EigthSpaced);
        }

        private void segmentsNone_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SetSegmentCode(_channel, (byte) SegmentCodes.None);
        }

        private byte GraphSegmentCode
        {
            get
            {
                byte code = 0;

                for (var i = 0; i < 8; i++)
                {
                    if (segments.Series[0].Points[i].Color == Globals.OnColor)
                        code = code.SetBit(i);
                }

                return code;
            }
            set
            {
                for (var i = 0; i < 8; i++)
                {
                    if (segments.IsDisposed)
                        return;

                    segments.Series[0].Points[i].Color = value.CheckBit(i) ? Globals.OnColor : Globals.OffColor;
                }
            }
        }

        #endregion
    }
}
