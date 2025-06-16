using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Commands;

namespace Map;

public partial class Map : BasePlugin
{
    [ConsoleCommand("css_map", "host_workshop_map")]
    [CommandHelper(minArgs: 1, usage: "[workshopId]", whoCanExecute: CommandUsage.CLIENT_AND_SERVER)]
    public void OnCommand(CCSPlayerController? player, CommandInfo command)
    {
        if (!AdminManager.PlayerHasPermissions(player, "@css/generic"))
            return;

        var arg = command.ArgByIndex(1);
        Server.ExecuteCommand($"host_workshop_map {arg}");
    }
}