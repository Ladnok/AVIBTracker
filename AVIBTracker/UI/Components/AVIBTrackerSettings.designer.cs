
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    partial class AVIBTrackerSettings
    {


        private void InitializeComponent()
        {
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.TextFontValue = new System.Windows.Forms.Label();
            this.FontBtn = new System.Windows.Forms.Button();
            this.TextFontOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.FontText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TextInlineText = new System.Windows.Forms.Label();
            this.TextInlineBtn = new System.Windows.Forms.Button();
            this.TextShadowsText = new System.Windows.Forms.Label();
            this.TextShadowsBtn = new System.Windows.Forms.Button();
            this.TextOutlineText = new System.Windows.Forms.Label();
            this.TextOutlineBtn = new System.Windows.Forms.Button();
            this.TextColorOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.achievementColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusColorOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.CompletedColorBtn = new System.Windows.Forms.Button();
            this.CompletedColorText = new System.Windows.Forms.Label();
            this.ProgressColorText = new System.Windows.Forms.Label();
            this.ProgressColorBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.labelColorGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.achievementColorGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxFont, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(453, 292);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.AutoSize = true;
            this.groupBoxFont.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxFont.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(447, 80);
            this.groupBoxFont.TabIndex = 49;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Font";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel6.Controls.Add(this.TextFontValue, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.FontBtn, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.TextFontOverrideCheckbox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.FontText, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(440, 57);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // TextFontValue
            // 
            this.TextFontValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFontValue.AutoSize = true;
            this.TextFontValue.Location = new System.Drawing.Point(160, 37);
            this.TextFontValue.Name = "TextFontValue";
            this.TextFontValue.Size = new System.Drawing.Size(191, 13);
            this.TextFontValue.TabIndex = 4;
            this.TextFontValue.Text = "Font";
            // 
            // FontBtn
            // 
            this.FontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FontBtn.Location = new System.Drawing.Point(357, 32);
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(80, 23);
            this.FontBtn.TabIndex = 1;
            this.FontBtn.Text = "Choose...";
            this.FontBtn.UseVisualStyleBackColor = true;
            this.FontBtn.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // TextFontOverrideCheckbox
            // 
            this.TextFontOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFontOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.TextFontOverrideCheckbox, 3);
            this.TextFontOverrideCheckbox.Location = new System.Drawing.Point(7, 6);
            this.TextFontOverrideCheckbox.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.TextFontOverrideCheckbox.Name = "TextFontOverrideCheckbox";
            this.TextFontOverrideCheckbox.Size = new System.Drawing.Size(430, 17);
            this.TextFontOverrideCheckbox.TabIndex = 0;
            this.TextFontOverrideCheckbox.Text = "Override Layout Settings";
            this.TextFontOverrideCheckbox.UseVisualStyleBackColor = true;
            this.TextFontOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideTextFont_CheckedChanged);
            // 
            // FontText
            // 
            this.FontText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FontText.AutoSize = true;
            this.FontText.Location = new System.Drawing.Point(3, 37);
            this.FontText.Name = "FontText";
            this.FontText.Size = new System.Drawing.Size(151, 13);
            this.FontText.TabIndex = 5;
            this.FontText.Text = "Font:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelColorGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.achievementColorGroup, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelColorGroup
            // 
            this.labelColorGroup.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelColorGroup, 2);
            this.labelColorGroup.Controls.Add(this.tableLayoutPanel4);
            this.labelColorGroup.Location = new System.Drawing.Point(3, 3);
            this.labelColorGroup.Name = "labelColorGroup";
            this.labelColorGroup.Size = new System.Drawing.Size(440, 82);
            this.labelColorGroup.TabIndex = 3;
            this.labelColorGroup.TabStop = false;
            this.labelColorGroup.Text = "Text";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Controls.Add(this.TextInlineText, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextInlineBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextShadowsText, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextShadowsBtn, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextOutlineText, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextOutlineBtn, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextColorOverrideCheckbox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // TextInlineText
            // 
            this.TextInlineText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextInlineText.AutoSize = true;
            this.TextInlineText.Location = new System.Drawing.Point(217, 8);
            this.TextInlineText.Name = "TextInlineText";
            this.TextInlineText.Size = new System.Drawing.Size(179, 13);
            this.TextInlineText.TabIndex = 7;
            this.TextInlineText.Text = "Inline";
            // 
            // TextInlineBtn
            // 
            this.TextInlineBtn.Location = new System.Drawing.Point(402, 3);
            this.TextInlineBtn.Name = "TextInlineBtn";
            this.TextInlineBtn.Size = new System.Drawing.Size(23, 23);
            this.TextInlineBtn.TabIndex = 3;
            this.TextInlineBtn.UseVisualStyleBackColor = true;
            this.TextInlineBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // TextShadowsText
            // 
            this.TextShadowsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextShadowsText.AutoSize = true;
            this.TextShadowsText.Location = new System.Drawing.Point(3, 37);
            this.TextShadowsText.Name = "TextShadowsText";
            this.TextShadowsText.Size = new System.Drawing.Size(179, 13);
            this.TextShadowsText.TabIndex = 6;
            this.TextShadowsText.Text = "Shadows";
            // 
            // TextShadowsBtn
            // 
            this.TextShadowsBtn.Location = new System.Drawing.Point(188, 32);
            this.TextShadowsBtn.Name = "TextShadowsBtn";
            this.TextShadowsBtn.Size = new System.Drawing.Size(23, 23);
            this.TextShadowsBtn.TabIndex = 4;
            this.TextShadowsBtn.UseVisualStyleBackColor = true;
            this.TextShadowsBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // TextOutlineText
            // 
            this.TextOutlineText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutlineText.AutoSize = true;
            this.TextOutlineText.Location = new System.Drawing.Point(217, 37);
            this.TextOutlineText.Name = "TextOutlineText";
            this.TextOutlineText.Size = new System.Drawing.Size(179, 13);
            this.TextOutlineText.TabIndex = 5;
            this.TextOutlineText.Text = "Outline";
            // 
            // TextOutlineBtn
            // 
            this.TextOutlineBtn.Location = new System.Drawing.Point(402, 32);
            this.TextOutlineBtn.Name = "TextOutlineBtn";
            this.TextOutlineBtn.Size = new System.Drawing.Size(23, 23);
            this.TextOutlineBtn.TabIndex = 2;
            this.TextOutlineBtn.UseVisualStyleBackColor = true;
            this.TextOutlineBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // TextColorOverrideCheckbox
            // 
            this.TextColorOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextColorOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.TextColorOverrideCheckbox, 2);
            this.TextColorOverrideCheckbox.Location = new System.Drawing.Point(3, 6);
            this.TextColorOverrideCheckbox.Name = "TextColorOverrideCheckbox";
            this.TextColorOverrideCheckbox.Size = new System.Drawing.Size(208, 17);
            this.TextColorOverrideCheckbox.TabIndex = 0;
            this.TextColorOverrideCheckbox.Text = "Override Layout Settings";
            this.TextColorOverrideCheckbox.UseVisualStyleBackColor = true;
            this.TextColorOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideTextColor_CheckedChanged);
            // 
            // achievementColorGroup
            // 
            this.achievementColorGroup.AutoSize = true;
            this.achievementColorGroup.Controls.Add(this.tableLayoutPanel2);
            this.achievementColorGroup.Location = new System.Drawing.Point(3, 91);
            this.achievementColorGroup.Name = "achievementColorGroup";
            this.achievementColorGroup.Size = new System.Drawing.Size(440, 81);
            this.achievementColorGroup.TabIndex = 5;
            this.achievementColorGroup.TabStop = false;
            this.achievementColorGroup.Text = "Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.StatusColorOverrideCheckbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CompletedColorBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CompletedColorText, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProgressColorText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProgressColorBtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatusColorOverrideCheckbox
            // 
            this.StatusColorOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusColorOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.StatusColorOverrideCheckbox, 4);
            this.StatusColorOverrideCheckbox.Location = new System.Drawing.Point(3, 6);
            this.StatusColorOverrideCheckbox.Name = "StatusColorOverrideCheckbox";
            this.StatusColorOverrideCheckbox.Size = new System.Drawing.Size(422, 17);
            this.StatusColorOverrideCheckbox.TabIndex = 1;
            this.StatusColorOverrideCheckbox.Text = "Override Layout Settings";
            this.StatusColorOverrideCheckbox.UseVisualStyleBackColor = true;
            this.StatusColorOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideStatusColor_CheckedChanged);
            // 
            // CompletedColorBtn
            // 
            this.CompletedColorBtn.Location = new System.Drawing.Point(402, 32);
            this.CompletedColorBtn.Name = "CompletedColorBtn";
            this.CompletedColorBtn.Size = new System.Drawing.Size(23, 23);
            this.CompletedColorBtn.TabIndex = 4;
            this.CompletedColorBtn.UseVisualStyleBackColor = true;
            this.CompletedColorBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // CompletedColorText
            // 
            this.CompletedColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletedColorText.AutoSize = true;
            this.CompletedColorText.Location = new System.Drawing.Point(217, 37);
            this.CompletedColorText.Name = "CompletedColorText";
            this.CompletedColorText.Size = new System.Drawing.Size(179, 13);
            this.CompletedColorText.TabIndex = 6;
            this.CompletedColorText.Text = "Completed Color";
            // 
            // ProgressColorText
            // 
            this.ProgressColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressColorText.AutoSize = true;
            this.ProgressColorText.Location = new System.Drawing.Point(3, 37);
            this.ProgressColorText.Name = "ProgressColorText";
            this.ProgressColorText.Size = new System.Drawing.Size(179, 13);
            this.ProgressColorText.TabIndex = 5;
            this.ProgressColorText.Text = "In Progress Color";
            // 
            // ProgressColorBtn
            // 
            this.ProgressColorBtn.Location = new System.Drawing.Point(188, 32);
            this.ProgressColorBtn.Name = "ProgressColorBtn";
            this.ProgressColorBtn.Size = new System.Drawing.Size(23, 23);
            this.ProgressColorBtn.TabIndex = 2;
            this.ProgressColorBtn.UseVisualStyleBackColor = true;
            this.ProgressColorBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // AVIBTrackerSettings
            // 
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "AVIBTrackerSettings";
            this.Size = new System.Drawing.Size(459, 298);
            this.Load += new System.EventHandler(this.AchievementTrackerComponentSettings_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBoxFont.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.labelColorGroup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.achievementColorGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBoxFont;
        private TableLayoutPanel tableLayoutPanel6;
        private Label TextFontValue;
        private Button FontBtn;
        private CheckBox TextFontOverrideCheckbox;
        private Label FontText;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox labelColorGroup;
        private TableLayoutPanel tableLayoutPanel4;
        private Label TextInlineText;
        private Button TextInlineBtn;
        private CheckBox TextColorOverrideCheckbox;
        private GroupBox achievementColorGroup;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox StatusColorOverrideCheckbox;
        private Button CompletedColorBtn;
        private Label CompletedColorText;
        private Label ProgressColorText;
        private Button ProgressColorBtn;
        private Label TextShadowsText;
        private Button TextShadowsBtn;
        private Label TextOutlineText;
        private Button TextOutlineBtn;
    }
}
