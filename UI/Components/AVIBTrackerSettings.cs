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

        public bool OverrideText { get; set; }
        public Color TextInlineColor { get; set; }
        public Color TextOutlineColor { get; set; }
        public Color TextShadowColor { get; set; }

        public bool OverrideStatus { get; set; }
        public Color inProgressColor { get; set; }
        public Color completedColor { get; set; }


        public AVIBTrackerSettings()
        {
            InitializeComponent();

            OverrideFont = false;
            TextFont = new Font("Segoe UI", 13, FontStyle.Regular, GraphicsUnit.Pixel);
            OverrideText = false;
            TextInlineColor = Color.FromArgb(255, 255, 255);
            TextOutlineColor = Color.FromArgb(255, 255, 255);
            TextShadowColor = Color.FromArgb(255, 255, 255);
            OverrideStatus = false;
            inProgressColor = Color.FromArgb(255, 155, 55);
            completedColor = Color.FromArgb(10, 255, 10);

            FontOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideFont", false, DataSourceUpdateMode.OnPropertyChanged);
            FontValue.DataBindings.Add("Text", this, "TextFontString", false, DataSourceUpdateMode.OnPropertyChanged);
            TextOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideText", false, DataSourceUpdateMode.OnPropertyChanged);
            InlineBtn.DataBindings.Add("BackColor", this, "TextInlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            OutlineBtn.DataBindings.Add("BackColor", this, "TextOutlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            ShadowsBtn.DataBindings.Add("BackColor", this, "TextShadowColor", false, DataSourceUpdateMode.OnPropertyChanged);
            StatusOverrideCheckbox.DataBindings.Add("Checked", this, "OverrideStatus", false, DataSourceUpdateMode.OnPropertyChanged);
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
            FontValue.Text = TextFontString;
        }

        private void overrideTextFont_CheckedChanged(object sender, EventArgs e)
        {
            LabelFont.Enabled = FontValue.Enabled = FontBtn.Enabled = FontOverrideCheckbox.Checked;
        }

        private void overrideTextColor_CheckedChanged(object sender, EventArgs e)
        {
            InlineText.Enabled = OutlineText.Enabled = ShadowsText.Enabled = InlineBtn.Enabled = OutlineBtn.Enabled = ShadowsBtn.Enabled = StatusOverrideCheckbox.Enabled = TextOverrideCheckbox.Checked;
            overrideStatusColor_CheckedChanged(sender, e);
        }

        private void overrideStatusColor_CheckedChanged(object sender, EventArgs e)
        {

            ProgressText.Enabled = CompletedText.Enabled = ProgressColorBtn.Enabled = CompletedColorBtn.Enabled = TextOverrideCheckbox.Checked == true ? StatusOverrideCheckbox.Checked : false;
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

            OverrideText = SettingsHelper.ParseBool(element["OverrideText"], false);
            TextInlineColor = SettingsHelper.ParseColor(element["TextInlineColor"], Color.FromArgb(255, 255, 255));
            TextOutlineColor = SettingsHelper.ParseColor(element["TextOutlineColor"], Color.FromArgb(255, 255, 255));
            TextShadowColor = SettingsHelper.ParseColor(element["TextShadowColor"], Color.FromArgb(255, 255, 255));
            OverrideStatus = SettingsHelper.ParseBool(element["OverrideStatus"], false);
            inProgressColor = SettingsHelper.ParseColor(element["inProgressColor"], Color.FromArgb(255, 155, 55));
            completedColor = SettingsHelper.ParseColor(element["completedColor"], Color.FromArgb(10, 255, 10));

        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            SettingsHelper.CreateSetting(document, parent, "OverrideFont", OverrideFont);
            SettingsHelper.CreateSetting(document, parent, "TextFont", TextFont);
            SettingsHelper.CreateSetting(document, parent, "OverrideText", OverrideText);
            SettingsHelper.CreateSetting(document, parent, "TextInlineColor", TextInlineColor);
            SettingsHelper.CreateSetting(document, parent, "TextOutlineColor", TextOutlineColor);
            SettingsHelper.CreateSetting(document, parent, "TextShadowColor", TextShadowColor);
            SettingsHelper.CreateSetting(document, parent, "OverrideStatus", OverrideStatus);
            SettingsHelper.CreateSetting(document, parent, "inProgressColor", inProgressColor);
            SettingsHelper.CreateSetting(document, parent, "completedColor", completedColor);
            return parent;
        }
    }
}
