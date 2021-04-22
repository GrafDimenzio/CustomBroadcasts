using Synapse.Api.Plugin;

namespace CustomBroadcasts
{
    [PluginInformation(
        Author = "Dimenzio",
        Description = "Displays Random broadcast",
        LoadPriority = 0,
        Name = "CustomBroadcasts",
        SynapseMajor = 2,
        SynapseMinor = 5,
        SynapsePatch = 3,
        Version = "v.1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Config(section = "CustomBroadcasts")]
        public PluginConfig Config { get; set; }

        public override void Load()
        {
            new EventHandlers(this);
            base.Load();
        }
    }
}
