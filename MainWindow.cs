using SCHOTT.Core.Communication.Serial;
using SCHOTT.Core.Settings;
using SCHOTT.Core.Threading;
using SCHOTT.Core.Utilities;
using SCHOTT.VisiLED.Dashboard.Dialogs;
using SCHOTT.VisiLED.Dashboard.Enums;
using SCHOTT.VisiLED.Dashboard.Forms;
using SCHOTT.VisiLED.Enums;
using SCHOTT.VisiLED.Serial;
using SCHOTT.WinForms.Controls.Group_Boxes;
using SCHOTT.WinForms.Controls.Labels;
using SCHOTT.WinForms.Dialogs;
using SCHOTT.WinForms.Docking;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOTT.VisiLED.Dashboard
{
    public partial class MainWindow : Form
    {
        private readonly ClosingWorker _closingWorker = new ClosingWorker();
        private readonly Settings _applicationSettings = new Settings();
        private readonly Docking _docking;
        private readonly VisiLEDThreadedComPort _visiLedThreadedComPort;

        public MainWindow()
        {
            InitializeComponent();

            // initialize popup forms
            CrossThreadDialogs.InitializeDialogs(this);

            // add version to form title
            Text += $@" V{Version.String}";

            // initialize settings
            _applicationSettings.ReadSettings();
            _applicationSettings.FormSettings.LoadLocation(this);
            UserModeRemember.Checked = _applicationSettings.RememberUserMode;

            // initialize the VisiLEDComPort
            _visiLedThreadedComPort = new VisiLEDThreadedComPort("VisiLEDComPort", _closingWorker);
            _visiLedThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, UpdateConnectionButton);
            UpdateConnectionButton(new ThreadedComPortBase.ConnectionUpdateArgs());

            // initialize docking
            _docking = new Docking(this, dockPanel, menuStrip1);
            _docking.AddForm(new CommonControls(_docking, _visiLedThreadedComPort));
            _docking.AddForm(new CommDialog(_visiLedThreadedComPort));
            _docking.AddForm(new ChannelControls("Channel A", Channel.A, _visiLedThreadedComPort));
            _docking.AddForm(new ChannelControls("Channel B", Channel.B, _visiLedThreadedComPort));
            _docking.LoadLayout();

            // initialize forms from settings
            SetUserMode(_applicationSettings.RememberUserMode ? _applicationSettings.UserMode : UserModes.Simple);
            ChangeFontAll(_applicationSettings.FontSize);

            // Handlers         
            FormClosing += MainWindow_FormClosing;
        }
        
        public void UpdateConnectionButton(ThreadedComPortBase.ConnectionUpdateArgs args)
        {
            connectionMessage.BackColor = args.IsConnected ? Color.LimeGreen : Color.Red;
            connectionMessage.Text = args.IsConnected ? $@"VisiLED Connected on {args.Port}" : @"No VisiLED found!";
        }

        private void SetUserMode(UserModes mode)
        {
            UserModeSimple.Checked = mode == UserModes.Simple;
            UserModeAdvanced.Checked = mode == UserModes.Advanced;

            ((CommonControls)_docking.GetForm("CommonControls")).ConfigureLayout(mode);
            ((ChannelControls)_docking.GetForm("Channel A")).ConfigureLayout(mode);
            ((ChannelControls)_docking.GetForm("Channel B")).ConfigureLayout(mode);
        }

        #region Event Handlers

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _applicationSettings.FormSettings.SaveLocation(this);
            _applicationSettings.WriteSettings();
            _docking.SaveLayout();

            _closingWorker.ShutdownThreads();
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            ChangeFontAll(int.Parse(((ToolStripMenuItem)sender).Text));
        }

        private void resetLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _docking.LoadLayout(Layouts.Layouts.GetStream("ApplicationLayout.xml"));
        }

        private void commDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _docking.ShowDockedForm("Comm Dialog");
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _applicationSettings.UserMode = UserModes.Simple;
            SetUserMode(UserModes.Simple);
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _applicationSettings.UserMode = UserModes.Advanced;
            SetUserMode(UserModes.Advanced);
        }

        #endregion

        #region Font Functions

        private void ChangeFont(Control control, int fontSize)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    c.Font = new Font(c.Font.FontFamily, fontSize + 2, FontStyle.Bold);
                }
                else if (c is TransparentLabel)
                {
                    c.Font = new Font(c.Font.FontFamily, fontSize, FontStyle.Bold);
                }
                else if (!(c is TableLayoutPanel))
                {
                    c.Font = new Font(c.Font.FontFamily, fontSize);
                }

                ChangeFont(c, fontSize);

                if (c is GrowGroupbox)
                {
                    ((GrowGroupbox)c).ResizeGroupBox();
                }
                else if (c is GrowLabel)
                {
                    ((GrowLabel)c).ResizeLabel();
                }
                else if (c is ComboBox && c.Parent is TableLayoutPanel && c.Parent.Parent is GrowGroupbox)
                {
                    var comboBox = (ComboBox)c;
                    var table = (TableLayoutPanel)c.Parent;
                    var position = table.GetPositionFromControl(c);
                    var s = TextRenderer.MeasureText("A", comboBox.Font);
                    table.RowStyles[position.Row].SizeType = SizeType.Absolute;
                    table.RowStyles[position.Row].Height = s.Height + 15;
                    table.Refresh();
                }
                else if (c is TextBox && ((TextBox)c).Multiline)
                {
                    var s = TextRenderer.MeasureText("A", ((TextBox)c).Font);
                    s.Height += 8;
                    if (s.Height < 20) s.Height = 20;
                    ((TextBox)c).Size = s;
                }
                else if (c is GroupBox && c.Location == new Point(6, -6))
                {
                    var s = TextRenderer.MeasureText("A", new Font(Font.FontFamily, fontSize));
                    s.Width = 0;
                    foreach (Control cont in c.Controls[0].Controls)
                    {
                        s.Width += cont.Width;
                    }

                    c.Height = (int)(s.Height * 1.2) + 36;
                    c.Width = s.Width + 26;
                }
                else if (c is PictureBox)
                {
                    var s = TextRenderer.MeasureText("A", Font);
                    s.Height += 12;
                    s.Width = s.Height;
                    ((PictureBox)c).MinimumSize = s;
                }
                else if (c is TableLayoutPanel)
                {
                    ((TableLayoutPanel)c).Margin = new Padding(0);
                }
            }
        }

        private void ChangeFontAll(int fontSize)
        {
            _applicationSettings.FontSize = fontSize;

            foreach (ToolStripMenuItem item in FontSizeMenu.DropDownItems)
            {
                item.Checked = int.Parse(item.Text) == fontSize;
            }

            _docking.GetAllForms().ForEach(form =>
            {
                ChangeFont(form, fontSize);
            });
        }

        #endregion

        private void portSelect_DropDownOpening(object sender, EventArgs e)
        {
            portSelect.DropDownItems.Clear();

            var item = new ToolStripMenuItem();
            item.Click += PortSelect_Click;
            item.Text = @"Any VisiLEDComPort";
            item.Checked = item.Text == portSelect.Text;
            portSelect.DropDownItems.Add(item);

            ComPortInfo.GetDescriptions().ForEach(port =>
            {
                item = new ToolStripMenuItem();
                item.Click += PortSelect_Click;
                item.Text = port.Port;
                item.Checked = item.Text == portSelect.Text;
                portSelect.DropDownItems.Add(item);
            });

        }

        private string _lastPort = @"Any VisiLEDComPort";
        private void PortSelect_Click(object sender, EventArgs e)
        {
            portSelect.Text = ((ToolStripMenuItem) sender).Text;

            if (portSelect.Text == _lastPort)
                return;

            _lastPort = portSelect.Text;

            if (portSelect.Text == @"Any VisiLEDComPort")
            {
                _visiLedThreadedComPort.ChangeMode();
            }
            else
            {
                _visiLedThreadedComPort.ChangeMode(((ToolStripMenuItem) sender).Text);
            }
        }

        private void UserModeRemember_Click(object sender, EventArgs e)
        {
            _applicationSettings.RememberUserMode = !_applicationSettings.RememberUserMode;
            UserModeRemember.Checked = _applicationSettings.RememberUserMode;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var licenseInfo = new LicenseInfo(this);
            licenseInfo.ShowDialog();
        }
    }
}
