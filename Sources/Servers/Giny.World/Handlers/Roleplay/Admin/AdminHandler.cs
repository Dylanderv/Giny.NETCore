using Giny.Core.Network.Messages;
using Giny.Protocol.Custom.Enums;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Admin;

class AdminHandler
{
    [MessageHandler]
    public static void HandleAdminCommandMessage(AdminCommandMessage message, WorldClient client)
    {
        client.Character.ReplyWarning("Unhandled.");

    }
    [MessageHandler]
    public static void HandleAdminQuietCommandMessage(AdminQuietCommandMessage message, WorldClient client)
    {
        if (client.Account.Role < ServerRoleEnum.Administrator)
            return;

        try
        {
            var c = message.content.Split(null)[1];
            client.Character.Teleport(int.Parse(c));
        }
        catch
        {
            client.Character.Reply("No");
        }
    }
}