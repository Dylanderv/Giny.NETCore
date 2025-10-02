using Giny.Core.Network.Messages;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.Tinsel;

class TinselHandler
{
    [MessageHandler]
    public static void HandleTitlesAndOrnamentsListRequestMessage(TitlesAndOrnamentsListRequestMessage message, WorldClient client)
    {
        client.Character.SendTitlesAndOrnamentsList();
    }
    [MessageHandler]
    public static void HandleOrnamentSelectRequestMessage(OrnamentSelectRequestMessage message, WorldClient client)
    {
        if (client.Character.ActiveOrnament(message.ornamentId))
            client.Send(new OrnamentSelectedMessage(message.ornamentId));

    }
    [MessageHandler]
    public static void HandleTitleSelectRequestMessage(TitleSelectRequestMessage message, WorldClient client)
    {
        if (client.Character.ActiveTitle(message.titleId))
            client.Send(new TitleSelectedMessage(message.titleId));
    }
}