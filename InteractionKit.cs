using Life;
using ModKit.Interfaces;

namespace InteractionKit
{
    public class InteractionKit : ModKit.ModKit
    {
        public InteractionKit(IGameAPI api) : base(api)
        {
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();          
            ModKit.Internal.Logger.LogSuccess($"{PluginInformations.SourceName} v{PluginInformations.Version}", "initialisé");
        }
    }
}
