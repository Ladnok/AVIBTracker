using LiveSplit.Model;
using System;
using static System.Net.WebRequestMethods;

namespace LiveSplit.UI.Components
{
    class AVIBTrackerFactory : IComponentFactory
    {
        public string ComponentName => "AVIBTracker";

        public string Description => "Track Vitality Fragments and Ivory Bugs collected.";

        public ComponentCategory Category => ComponentCategory.Information;

        public string UpdateName => ComponentName;

        public string UpdateURL => "https://github.com/Ladnok/AVIBTracker/tree/main/";

        public string XMLURL => UpdateURL + "Components/update.AVIBTracker.xml";

        public Version Version => Version.Parse("1.0.1");

        public IComponent Create(LiveSplitState state)
        {
            return new AVIBTracker(state);
        }
    }
}
