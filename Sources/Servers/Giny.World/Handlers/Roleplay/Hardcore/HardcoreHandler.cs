using Giny.Core.Network.Messages;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.Hardcore;

public class HardcoreHandler
{
    [MessageHandler]
    public static void HandleGameRolePlayFreeSoulRequest(GameRolePlayFreeSoulRequestMessage message, WorldClient client)
    {
        client.Send(new GameRolePlayGameOverMessage());
    }

}