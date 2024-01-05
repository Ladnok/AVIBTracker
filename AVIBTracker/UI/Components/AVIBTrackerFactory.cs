using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    class AVIBTrackerFactory : IComponentFactory
    {
        // The displayed name of the component in the Layout Editor.
        public string ComponentName => "AVIB Tracker";

        public string Description => "Track Vitality Fragments and Ivory Bugs collected.";

        public ComponentCategory Category => ComponentCategory.Information;

        public string UpdateName => ComponentName;

        public string UpdateURL => "";

        public string XMLURL => UpdateURL + "";

        public Version Version => Version.Parse("1.0.0");

        public IComponent Create(LiveSplitState state)
        {
            return new AVIBTracker(state);
        }
    }
}
