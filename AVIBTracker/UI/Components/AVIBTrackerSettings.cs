using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    partial class AVIBTrackerSettings : UserControl
    {
        public bool OverrideFont { get; set; }
        public string TextFontString => SettingsHelper.FormatFont(TextFont);
        public Font TextFont { get; set; }

        public bool OverrideTextColor { get; set; }
        public Color TextInlineColor { get; set; }
        public Color TextOutlineColor { get; set; }
        public Color TextShadowColor { get; set; }

        public bool OverrideStatusColor { get; set; }
        public Color inProgressColor { get; set; }
        public Color completedColor { get; set; }


        public AVIBTrackerSettings()
        {
            InitializeComponent();

            OverrideFont = false;
            TextFont = new Font("Segoe UI", 13, FontStyle.Regular, GraphicsUnit.Pixel);
            OverrideTextColor = false;
            TextInlineColor = Color.FromArgb(255, 255, 255);
            TextOutlineColor = Color.FromArgb(255, 255, 255);
            TextShadowColor = Color.FromArgb(255, 255, 255);
            OverrideStatusColor = false;
            inProgressColor = Color.FromArgb(255, 155, 55);
            completedColor = Color.FromArgb(10, 255, 10);

            TextFontOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideFont", false, DataSourceUpdateMode.OnPropertyChanged);
            TextFontValue.DataBindings.Add("Text", this, "TextFontString", false, DataSourceUpdateMode.OnPropertyChanged);
            TextColorOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            TextInlineBtn.DataBindings.Add("BackColor", this, "TextInlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            TextOutlineBtn.DataBindings.Add("BackColor", this, "TextOutlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            TextShadowsBtn.DataBindings.Add("BackColor", this, "TextShadowColor", false, DataSourceUpdateMode.OnPropertyChanged);
            StatusColorOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideStatusColor", false, DataSourceUpdateMode.OnPropertyChanged);
            ProgressColorBtn.DataBindings.Add("BackColor", this, "inProgressColor", false, DataSourceUpdateMode.OnPropertyChanged);
            CompletedColorBtn.DataBindings.Add("BackColor", this, "completedColor", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AchievementTrackerComponentSettings_Load(object sender, EventArgs e)
        {
            overrideTextFont_CheckedChanged(null, null);
            overrideTextColor_CheckedChanged(null, null);
            overrideStatusColor_CheckedChanged(null, null);
        }

        private void ColorButtonClick(object sender, EventArgs e) => SettingsHelper.ColorButtonClick((Button)sender, this);

        private void btnFont_Click(object sender, EventArgs e)
        {
            var dialog = SettingsHelper.GetFontDialog(TextFont, 7, 20);
            dialog.FontChanged += (s, ev) => TextFont = ((CustomFontDialog.FontChangedEventArgs)ev).NewFont;
            dialog.ShowDialog(this);
            TextFontValue.Text = TextFontString;
        }

        private void overrideTextFont_CheckedChanged(object sender, EventArgs e)
        {
            FontText.Enabled = TextFontValue.Enabled = FontBtn.Enabled = TextFontOverrideCheckbox.Checked;
        }

        private void overrideTextColor_CheckedChanged(object sender, EventArgs e)
        {
            TextInlineText.Enabled = TextOutlineText.Enabled = TextShadowsText.Enabled = TextInlineBtn.Enabled = TextOutlineBtn.Enabled = TextShadowsBtn.Enabled = StatusColorOverrideCheckbox.Enabled = TextColorOverrideCheckbox.Checked;
            overrideStatusColor_CheckedChanged(sender, e);
        }

        private void overrideStatusColor_CheckedChanged(object sender, EventArgs e)
        {

            ProgressColorText.Enabled = CompletedColorText.Enabled = ProgressColorBtn.Enabled = CompletedColorBtn.Enabled = TextColorOverrideCheckbox.Checked == true ? StatusColorOverrideCheckbox.Checked : false;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;
            Version version = SettingsHelper.ParseVersion(element["Version"]);

            if (version >= new Version(1, 2))
            {
                TextFont = SettingsHelper.GetFontFromElement(element["TextFont"]);
                if (version >= new Version(1, 3))
                {
                    OverrideFont = SettingsHelper.ParseBool(element["OverrideFont"]);
                }
                else
                    OverrideFont = !SettingsHelper.ParseBool(element["UseLayoutSettingsFont"]);
            }
            else
            {
                TextFont = new Font("Segoe UI", 13, FontStyle.Regular, GraphicsUnit.Pixel);
                OverrideFont = false;
            }

            OverrideTextColor = SettingsHelper.ParseBool(element["OverrideTextColor"], false);
            TextInlineColor = SettingsHelper.ParseColor(element["TextInlineColor"], Color.FromArgb(255, 255, 255));
            TextOutlineColor = SettingsHelper.ParseColor(element["TextOutlineColor"], Color.FromArgb(255, 255, 255));
            TextShadowColor = SettingsHelper.ParseColor(element["TextShadowColor"], Color.FromArgb(255, 255, 255));
            OverrideStatusColor = SettingsHelper.ParseBool(element["OverrideStatusColor"], false);
            inProgressColor = SettingsHelper.ParseColor(element["inProgressColor"], Color.FromArgb(255, 155, 55));
            completedColor = SettingsHelper.ParseColor(element["completedColor"], Color.FromArgb(10, 255, 10));

        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            SettingsHelper.CreateSetting(document, parent, "OverrideFont", OverrideFont);
            SettingsHelper.CreateSetting(document, parent, "TextFont", TextFont);
            SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor);
            SettingsHelper.CreateSetting(document, parent, "TextInlineColor", TextInlineColor);
            SettingsHelper.CreateSetting(document, parent, "TextOutlineColor", TextOutlineColor);
            SettingsHelper.CreateSetting(document, parent, "TextShadowColor", TextShadowColor);
            SettingsHelper.CreateSetting(document, parent, "OverrideStatusColor", OverrideStatusColor);
            SettingsHelper.CreateSetting(document, parent, "inProgressColor", inProgressColor);
            SettingsHelper.CreateSetting(document, parent, "completedColor", completedColor);
            return parent;
        }
    }
}
