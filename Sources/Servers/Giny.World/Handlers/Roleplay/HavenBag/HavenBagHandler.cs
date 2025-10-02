using Giny.Core.Network.Messages;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.HeavenBag;

class HeavenBagHandler
{
    [MessageHandler]
    public static void HandleEnterHavenBagRequest(EnterHavenBagRequestMessage message, WorldClient client)
    {
        client.Character.Teleport(162791424);
    }
}