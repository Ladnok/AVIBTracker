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
            this.FontValue = new System.Windows.Forms.Label();
            this.FontBtn = new System.Windows.Forms.Button();
            this.FontOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.LabelFont = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.InlineText = new System.Windows.Forms.Label();
            this.InlineBtn = new System.Windows.Forms.Button();
            this.ShadowsText = new System.Windows.Forms.Label();
            this.ShadowsBtn = new System.Windows.Forms.Button();
            this.OutlineText = new System.Windows.Forms.Label();
            this.OutlineBtn = new System.Windows.Forms.Button();
            this.TextOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.achievementColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.CompletedColorBtn = new System.Windows.Forms.Button();
            this.CompletedText = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel6.Controls.Add(this.FontValue, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.FontBtn, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.FontOverrideCheckbox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LabelFont, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(440, 57);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // FontValue
            // 
            this.FontValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FontValue.AutoSize = true;
            this.FontValue.Location = new System.Drawing.Point(160, 37);
            this.FontValue.Name = "FontValue";
            this.FontValue.Size = new System.Drawing.Size(191, 13);
            this.FontValue.TabIndex = 4;
            this.FontValue.Text = "Font";
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
            // FontOverrideCheckbox
            // 
            this.FontOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FontOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.FontOverrideCheckbox, 3);
            this.FontOverrideCheckbox.Location = new System.Drawing.Point(7, 6);
            this.FontOverrideCheckbox.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.FontOverrideCheckbox.Name = "FontOverrideCheckbox";
            this.FontOverrideCheckbox.Size = new System.Drawing.Size(430, 17);
            this.FontOverrideCheckbox.TabIndex = 0;
            this.FontOverrideCheckbox.Text = "Override Layout Settings";
            this.FontOverrideCheckbox.UseVisualStyleBackColor = true;
            this.FontOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideTextFont_CheckedChanged);
            // 
            // LabelFont
            // 
            this.LabelFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFont.AutoSize = true;
            this.LabelFont.Location = new System.Drawing.Point(3, 37);
            this.LabelFont.Name = "LabelFont";
            this.LabelFont.Size = new System.Drawing.Size(151, 13);
            this.LabelFont.TabIndex = 5;
            this.LabelFont.Text = "Font:";
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
            this.tableLayoutPanel4.Controls.Add(this.InlineText, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.InlineBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.ShadowsText, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ShadowsBtn, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.OutlineText, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.OutlineBtn, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextOverrideCheckbox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // InlineText
            // 
            this.InlineText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InlineText.AutoSize = true;
            this.InlineText.Location = new System.Drawing.Point(217, 8);
            this.InlineText.Name = "InlineText";
            this.InlineText.Size = new System.Drawing.Size(179, 13);
            this.InlineText.TabIndex = 7;
            this.InlineText.Text = "Inline";
            // 
            // InlineBtn
            // 
            this.InlineBtn.Location = new System.Drawing.Point(402, 3);
            this.InlineBtn.Name = "InlineBtn";
            this.InlineBtn.Size = new System.Drawing.Size(23, 23);
            this.InlineBtn.TabIndex = 3;
            this.InlineBtn.UseVisualStyleBackColor = true;
            this.InlineBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // ShadowsText
            // 
            this.ShadowsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowsText.AutoSize = true;
            this.ShadowsText.Location = new System.Drawing.Point(3, 37);
            this.ShadowsText.Name = "ShadowsText";
            this.ShadowsText.Size = new System.Drawing.Size(179, 13);
            this.ShadowsText.TabIndex = 6;
            this.ShadowsText.Text = "Shadows";
            // 
            // ShadowsBtn
            // 
            this.ShadowsBtn.Location = new System.Drawing.Point(188, 32);
            this.ShadowsBtn.Name = "ShadowsBtn";
            this.ShadowsBtn.Size = new System.Drawing.Size(23, 23);
            this.ShadowsBtn.TabIndex = 4;
            this.ShadowsBtn.UseVisualStyleBackColor = true;
            this.ShadowsBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // OutlineText
            // 
            this.OutlineText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutlineText.AutoSize = true;
            this.OutlineText.Location = new System.Drawing.Point(217, 37);
            this.OutlineText.Name = "OutlineText";
            this.OutlineText.Size = new System.Drawing.Size(179, 13);
            this.OutlineText.TabIndex = 5;
            this.OutlineText.Text = "Outline";
            // 
            // OutlineBtn
            // 
            this.OutlineBtn.Location = new System.Drawing.Point(402, 32);
            this.OutlineBtn.Name = "OutlineBtn";
            this.OutlineBtn.Size = new System.Drawing.Size(23, 23);
            this.OutlineBtn.TabIndex = 2;
            this.OutlineBtn.UseVisualStyleBackColor = true;
            this.OutlineBtn.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // TextOverrideCheckbox
            // 
            this.TextOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.TextOverrideCheckbox, 2);
            this.TextOverrideCheckbox.Location = new System.Drawing.Point(3, 6);
            this.TextOverrideCheckbox.Name = "TextOverrideCheckbox";
            this.TextOverrideCheckbox.Size = new System.Drawing.Size(208, 17);
            this.TextOverrideCheckbox.TabIndex = 0;
            this.TextOverrideCheckbox.Text = "Override Layout Settings";
            this.TextOverrideCheckbox.UseVisualStyleBackColor = true;
            this.TextOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideTextColor_CheckedChanged);
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
            this.tableLayoutPanel2.Controls.Add(this.StatusOverrideCheckbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CompletedColorBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CompletedText, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProgressText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProgressColorBtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatusOverrideCheckbox
            // 
            this.StatusOverrideCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusOverrideCheckbox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.StatusOverrideCheckbox, 4);
            this.StatusOverrideCheckbox.Location = new System.Drawing.Point(3, 6);
            this.StatusOverrideCheckbox.Name = "StatusOverrideCheckbox";
            this.StatusOverrideCheckbox.Size = new System.Drawing.Size(422, 17);
            this.StatusOverrideCheckbox.TabIndex = 1;
            this.StatusOverrideCheckbox.Text = "Override Layout Settings";
            this.StatusOverrideCheckbox.UseVisualStyleBackColor = true;
            this.StatusOverrideCheckbox.CheckedChanged += new System.EventHandler(this.overrideStatusColor_CheckedChanged);
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
            // CompletedText
            // 
            this.CompletedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletedText.AutoSize = true;
            this.CompletedText.Location = new System.Drawing.Point(217, 37);
            this.CompletedText.Name = "CompletedText";
            this.CompletedText.Size = new System.Drawing.Size(179, 13);
            this.CompletedText.TabIndex = 6;
            this.CompletedText.Text = "Completed";
            // 
            // ProgressText
            // 
            this.ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(3, 37);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(179, 13);
            this.ProgressText.TabIndex = 5;
            this.ProgressText.Text = "In Progress";
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
            this.Size = new System.Drawing.Size(456, 295);
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
        private Label FontValue;
        private Button FontBtn;
        private CheckBox FontOverrideCheckbox;
        private Label LabelFont;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox labelColorGroup;
        private TableLayoutPanel tableLayoutPanel4;
        private Label InlineText;
        private Button InlineBtn;
        private CheckBox TextOverrideCheckbox;
        private GroupBox achievementColorGroup;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox StatusOverrideCheckbox;
        private Button CompletedColorBtn;
        private Label CompletedText;
        private Label ProgressText;
        private Button ProgressColorBtn;
        private Label ShadowsText;
        private Button ShadowsBtn;
        private Label OutlineText;
        private Button OutlineBtn;
    }
}
