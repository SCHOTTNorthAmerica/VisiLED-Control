using System.Windows.Forms;
using SCHOTT.VisiLED.Dashboard.Enums;
using SCHOTT.WinForms;

namespace SCHOTT.VisiLED.Dashboard
{
    public class Settings
    {
        public int FontSize { get; set; } = 12;
        public UserModes UserMode { get; set; } = UserModes.Simple;
        public bool RememberUserMode { get; set; }
        public WindowInformation FormSettings { get; set; } = new WindowInformation(
            FormWindowState.Normal, 460, 1050, new System.Drawing.Point(0, 0));
    }
}
