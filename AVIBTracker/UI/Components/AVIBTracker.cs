using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using LiveSplit.Model;
using System.Diagnostics;
using LiveSplit.ComponentUtil;
using System.Reflection;
using static System.Windows.Forms.AxHost;

namespace LiveSplit.UI.Components
{
    internal class AVIBTracker : IComponent
    {
        #region Component variables
        private const string V1 = "1.05b", V2 = "1.07";
        private const string PROCESS_NAME = "MomodoraRUtM";
        private Process GameProcess = null;
        private string GameVersion = "";
        private Dictionary<string, int[]> Offsets = new Dictionary<string, int[]>();
        private Boolean refreshLabel = false;
        #endregion

        #region Basic component variables
        private List<SimpleLabel> LabelList;
        protected InfoTextComponent InternalComponent { get; set; }
        private LiveSplitState CurrentState { get; set; }
        private AVIBTrackerSettings Settings { get; set; }

        public string ComponentName => "Momodora AVIB Tracker";

        public float HorizontalWidth { get; set; }
        public float MinimumHeight => 10;
        public float VerticalHeight { get; set; }
        public float MinimumWidth => 200;

        public float PaddingTop => 1;
        public float PaddingBottom => 1;
        public float PaddingLeft => 2;
        public float PaddingRight => 2;

        public IDictionary<string, Action> ContextMenuControls => null;
        #endregion

        #region Basic component logic
        public AVIBTracker(LiveSplitState state)
        {
            LabelList = new List<SimpleLabel>();
            for (int i = 0; i < 4; i++)
            {
                LabelList.Add(new SimpleLabel(i % 2 == 1 ? "Tracker" : "Value"));
            }
            LabelList[1].Text = "Ivory Bugs";
            LabelList[3].Text = "Vitality Fragments";

            Settings = new AVIBTrackerSettings();

            state.OnStart += OnStart;
            state.OnReset += OnReset;

            CurrentState = state;
        }

        public void PrepareDraw(LiveSplitState state, int i)
        {
            LabelList[i + 1].Font = state.LayoutSettings.TextFont;
            LabelList[i].Font = state.LayoutSettings.TextFont;

            LabelList[i].VerticalAlignment = StringAlignment.Center;
            LabelList[i].HorizontalAlignment = StringAlignment.Far;
            LabelList[i + 1].VerticalAlignment = StringAlignment.Center;
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion) => throw new NotImplementedException();

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            var textHeight = g.MeasureString("A", state.LayoutSettings.TextFont).Height;
            VerticalHeight = textHeight * 9;

            for (int i = 0; i < 18; i += 2)
            {
                LabelList[i].ShadowColor = Settings.OverrideTextColor ? Settings.TextShadowColor : state.LayoutSettings.ShadowsColor;
                LabelList[i].OutlineColor = Settings.OverrideStatusColor ? Settings.TextOutlineColor : state.LayoutSettings.TextOutlineColor;
                LabelList[i + 1].ShadowColor = Settings.OverrideStatusColor ? Settings.TextShadowColor : state.LayoutSettings.ShadowsColor;
                LabelList[i + 1].OutlineColor = Settings.OverrideStatusColor ? Settings.TextOutlineColor : state.LayoutSettings.TextOutlineColor;

                LabelList[i + 1].SetActualWidth(g);
                LabelList[i].SetActualWidth(g);

                LabelList[i].Width = LabelList[i].ActualWidth;
                LabelList[i].Height = VerticalHeight;
                LabelList[i].X = width - LabelList[i].ActualWidth;
                LabelList[i].Y = i*textHeight*0.42f - (3.5f * textHeight);

                LabelList[i + 1].Width = width;
                LabelList[i + 1].Height = VerticalHeight;
                LabelList[i + 1].Y = i*textHeight * 0.42f - (3.5f * textHeight);
                LabelList[i + 1].X = 0;

                PrepareDraw(state, i);

                LabelList[i].Draw(g);
                LabelList[i + 1].Draw(g);
            }
        }

        public XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);

        public Control GetSettingsControl(LayoutMode mode) => Settings;

        public void SetSettings(XmlNode settings) => this.Settings.SetSettings(settings);
        #endregion

        #region Component Events
        private void OnStart(object sender, EventArgs e)
        {
            if (IsProcessRunning())
            {
                GetGameVersion();
                if (GameVersion != "")
                {
                    string WhatcherName = "";

                    PrepareOffsets();

                    WhatcherName = "VFCounter";
                    ContainerWatcher<int>.List.Add(new ContainerWatcher<int>(WhatcherName, GameProcess, Offsets[WhatcherName], (old, current) =>
                    {
                        if(current != old)
                        {
                            if (current == 17)
                            {
                                SetTextColor(1, Settings.completedColor);
                            }
                            else
                            {
                                SetTextColor(1, Settings.inProgressColor);
                            }
                            LabelList[1].Text = String.Format("{0}/17", current);
                            refreshLabel = true;
                        }
                    }));

                    WhatcherName = "IBCounter";
                    ContainerWatcher<int>.List.Add(new ContainerWatcher<int>(WhatcherName, GameProcess, Offsets[WhatcherName], (old, current) =>
                    {
                        if (current != old)
                        {
                            if (current == 20)
                            {
                                SetTextColor(1, Settings.completedColor);
                            }
                            else
                            {
                                SetTextColor(1, Settings.inProgressColor);
                            }
                            LabelList[3].Text = String.Format("{0}/20", current);
                            refreshLabel = true;
                        }
                    }));
                }
            }
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (IsProcessRunning())
            {
                GetGameVersion();
                if (GameVersion != "" && CurrentState.CurrentPhase == TimerPhase.Running)
                {
                    ContainerWatcher<double>.UpdateWatchers(GameProcess);
                    if(refreshLabel && invalidator != null)
                    {
                        invalidator?.Invalidate(0, 0, width, height);
                    }
                }
            }
            else
            {
                GetProcess();
            }
        }

        private void OnReset(object sender, TimerPhase value)
        {
            ContainerWatcher<double>.Clear();
            Offsets.Clear();
        }

        public void Dispose()
        {
            CurrentState.OnStart -= OnStart;
            CurrentState.OnReset -= OnReset;
        }
        #endregion

        #region Component logic
        private void SetTextColor(int index, Color achievementColor)
        {
            LabelList[index].ForeColor = Settings.OverrideTextColor ? (Settings.OverrideStatusColor ? achievementColor : Settings.TextInlineColor) : CurrentState.LayoutSettings.TextColor;
            LabelList[index + 1].ForeColor = Settings.OverrideTextColor ? (Settings.OverrideStatusColor ? achievementColor : Settings.TextInlineColor) : CurrentState.LayoutSettings.TextColor;
        }

        /// <summary>
        /// Add Offsets to a Dictionary
        /// </summary>
        private void PrepareOffsets()
        {
            switch (GameVersion)
            {
                case V1:
                    Offsets.Add("VFCounter",  new int[] { 0x230C440, 0x0, 0x4, 0x60, 0x4, 0x4, 0xAE0 });
                    Offsets.Add("IBCounter",  new int[] { 0x230C440, 0x0, 0x4, 0x60, 0x4, 0x4, 0x3C0 });
                    break;
                case V2:
                    Offsets.Add("VFCounter",  new int[] { 0x2379600, 0x0, 0x4, 0x60, 0x4, 0x4, 0xAE0 });
                    Offsets.Add("IBCounter",  new int[] { 0x2379600, 0x0, 0x4, 0x60, 0x4, 0x4, 0x3C0 });
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Check if the process with name is currently running and set reference
        /// </summary>
        private void GetProcess()
        {
            Process[] game = Process.GetProcessesByName(PROCESS_NAME);

            if (game.Length > 0)
            {
                GameProcess = game[0];
            }
        }

        /// <summary>
        /// Check if the process is currently running
        /// </summary>
        /// <returns>
        ///     <c>True</c> if the process is running<br/>
        ///     <c>False</c> otherwise
        /// </returns>
        private bool IsProcessRunning()
        {
            return GameProcess != null && !GameProcess.HasExited;
        }

        /// <summary>
        ///     Get version of the process based on module memory size
        /// </summary>
        private void GetGameVersion()
        {
            if(IsProcessRunning())
            {
                switch (GameProcess.MainModule.ModuleMemorySize)
                {
                    case 39690240:
                        GameVersion = V1;
                        break;
                    case 40222720:
                        GameVersion = V2;
                        break;
                    default:
                        GameVersion = "";
                        break;
                }
            }
            else
                GameVersion = "";
        }
        #endregion
    }
}
