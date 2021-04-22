using Synapse;
using MEC;
using Synapse.Api;
using System.Linq;
using System.Collections.Generic;

namespace CustomBroadcasts
{
    public class EventHandlers
    {
        private PluginClass plugin;

        public EventHandlers(PluginClass _plugin)
        {
            plugin = _plugin;

            Server.Get.Events.Round.RoundStartEvent += StartRound;
            Server.Get.Events.Round.RoundRestartEvent += RestartRound;
        }

        private CoroutineHandle coroutine;

        private void StartRound() => coroutine = Timing.RunCoroutine(Broadcast());

        private void RestartRound()
        {
            if (coroutine != null)
                Timing.KillCoroutines(coroutine);
        }

        public IEnumerator<float> Broadcast()
        {
            for(; ; )
            {
                Map.Get.SendBroadcast(plugin.Config.BroadcastTime, plugin.Config.Broadcasts.ElementAt(UnityEngine.Random.Range(0, plugin.Config.Broadcasts.Count)));
                yield return Timing.WaitForSeconds(plugin.Config.Delay);
            }
        }
    }
}
