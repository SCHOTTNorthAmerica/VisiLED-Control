using System;
using System.Drawing;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.VisiLED.Communication;
using SCHOTT.VisiLED.Dashboard.Enums;
using SCHOTT.VisiLED.Enums;
using SCHOTT.VisiLED.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.VisiLED.Dashboard.Forms
{
    public partial class CommonControls : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private string _helpMessage = $"Click save, then the memory location you{Environment.NewLine}would like to store the current settings to.";
        private readonly VisiLEDThreadedComPort _visiLedThreadedComPort;
        private readonly Docking _docking;

        public CommonControls(Docking docking, VisiLEDThreadedComPort visiLedThreadedComPort)
        {
            InitializeComponent();
            
            saveLoad.ToggleDisabledColor = Globals.OffColor;
            saveLoad.ToggleDisabledText = "Save";
            saveLoad.ToggleEnabledColor = Globals.OnColor;
            saveLoad.ToggleEnabledText = "Save";
            saveLoad.ToggleSet(false);

            DisplayControls(false);

            _visiLedThreadedComPort = visiLedThreadedComPort;
            _docking = docking;
            _visiLedThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls(args.IsConnected));
            _visiLedThreadedComPort.RegisterMasterStatusUpdate(MessageBroker.MessageContext.NewThreadToGui, UpdateForm);

            HideOnClose = true;
            ShowHint = DockState.Document;
            CloseButton = false;
            CloseButtonVisible = false;

            var saveTip = new ToolTip();
            saveTip.SetToolTip(saveLoad, _helpMessage);
            saveTip.OwnerDraw = true;
            saveTip.Draw += saveTip_Draw;
            saveTip.Popup += saveTip_Popup;

            Load += LoadEvent;
        }

        public void DisplayControls(bool enable)
        {
            if (!enable)
            {
                saveLoad.ToggleSet(false);
                rotationPeriod.Value = rotationPeriod.Minimum;
                strobePeriod.Value = strobePeriod.Minimum;
                strobeOnTime.Value = strobeOnTime.Minimum;
                transparentLabel.BringToFront();
            }
            else
            {
                transparentLabel.SendToBack();
            }
        }

        private void UpdateForm(CommonObject args)
        {
            rotationPeriod.Value = args.RotationPeriod;
            strobePeriod.Value = args.StrobePeriod;
            strobeOnTime.Value = args.StrobeOnTime;
        }
        
        internal void ConfigureLayout(UserModes mode)
        {
            var j = 0;
            switch (mode)
            {
                case UserModes.Simple:
                    for (var i = 9; i < tableLayoutPanel1.RowCount; i++)
                    {
                        tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel1.RowStyles[i].Height = 0;
                    }
                    break;

                default:
                    for (var i = 9; i < tableLayoutPanel1.RowCount; i++)
                    {
                        if (j % 3 == 0)
                        {
                            tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                            tableLayoutPanel1.RowStyles[i].Height = 20;
                        }
                        else
                        {
                            tableLayoutPanel1.RowStyles[i].SizeType = SizeType.AutoSize;
                        }
                        j++;
                    }
                    break;
            }
        }

        private void saveTip_Popup(object sender, PopupEventArgs e)
        {
            // on popip set the size of tool tip
            e.ToolTipSize = TextRenderer.MeasureText(_helpMessage, saveLoad.Font);
        }

        private void saveTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            _helpMessage = e.ToolTipText;
            e.Graphics.DrawString(e.ToolTipText, saveLoad.Font, Brushes.Black, new PointF(2, 2));
        }

        #region window functions
       
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
        
        public string FormTitle
        {
            get { return Text; }
            set { Text = value; }
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }

        #endregion
        
        private void saveLoad_Click(object sender, EventArgs e)
        {
            saveLoad.Toggle();
        }

        private void MemoryClick(object sender, EventArgs e)
        {
            var location = (MemoryLocation) int.Parse(((Button) sender).Name.Substring(1, 1));
            if (saveLoad.ToggleGet())
            {
                _visiLedThreadedComPort.SaveToMemory(location);
                saveLoad.ToggleSet(false);
            }
            else
            {
                _visiLedThreadedComPort.RestoreFromMemory(location);
            }
        }

        private void ToggleOutput_Click(object sender, EventArgs e)
        {
            ((ChannelControls)_docking.GetForm("Channel A")).PowerOutputToggle();
            ((ChannelControls)_docking.GetForm("Channel B")).PowerOutputToggle();
        }

        private void loadSettings_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.GetStatus();
        }

        private void rotationPeriod_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender)
                return;

            _visiLedThreadedComPort.SetRotationPeriod((int)rotationPeriod.Value);
            ((ChannelControls)_docking.GetForm("Channel A")).RotationTimerInterval = (int)rotationPeriod.Value;
            ((ChannelControls)_docking.GetForm("Channel B")).RotationTimerInterval = (int)rotationPeriod.Value;
        }

        private void strobePeriod_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender)
                return;

            _visiLedThreadedComPort.SetStrobePeriod((int)strobePeriod.Value);
        }

        private void strobeOnTime_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender)
                return;

            _visiLedThreadedComPort.SetStrobeOnTime((int)strobeOnTime.Value);
        }

        private void saveStartup_Click(object sender, EventArgs e)
        {
            _visiLedThreadedComPort.SaveStartupConfiguration();
        }
    }
}
