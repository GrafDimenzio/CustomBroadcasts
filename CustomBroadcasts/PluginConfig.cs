using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomBroadcasts
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("A List of all Broadcasts that can appear")]
        public List<string> Broadcasts { get; set; } = new List<string>
        {
            "Welcome on my Server",
            "Please Read the Rules",
        };

        [Description("The amount of time the broadcast is displayed")]
        public ushort BroadcastTime { get; set; } = 5;

        [Description("The amount of time between each broadcast")]
        public float Delay { get; set; } = 60;
    }
}
