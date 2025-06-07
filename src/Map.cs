using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace Map;

public partial class Map : BasePlugin
{
    public override void Load(bool hotReload)
    {
        AddCommand("css_map", "Map", (player, info) =>
        {
            var args = info.ArgString;
            Server.ExecuteCommand($"host_workshop_map {args}");
        });
    }
}