using System;
using System.Linq;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.VisiLED.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.VisiLED.Dashboard.Forms
{
    public partial class CommDialog : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private readonly VisiLEDThreadedComPort _visiLedThreadedComPort;

        public CommDialog(VisiLEDThreadedComPort visiLedThreadedComPort)
        {
            InitializeComponent();

            _visiLedThreadedComPort = visiLedThreadedComPort;
            _visiLedThreadedComPort.RegisterMessageOutput(MessageBroker.MessageContext.NewThreadToGui, args => MessageBox.WriteLine(args) );

            HideOnClose = true;
            ShowHint = DockState.Document;
            Load += LoadEvent;
        }

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

        private string _lastCommand = "";
        private void send_Click(object sender, EventArgs e)
        {
            if (command.Text.Length > 0)
            {
                _lastCommand = command.Text.Replace("\\r", "\r");
                command.Text = "";
            }
            var commands = _lastCommand.Split(new[] {';', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            commands.ForEach(com =>
            {
                _visiLedThreadedComPort.SendCommandSingle(com, echoComTraffic: true);
            });
        }

        private void msgClear_Click(object sender, EventArgs e)
        {
            MessageBox.ClearMessages();
        }

    }
}
