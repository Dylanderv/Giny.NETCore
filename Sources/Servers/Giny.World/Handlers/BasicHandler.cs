using Giny.Core.Network.Messages;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers;

public class BasicHandler
{
    [MessageHandler]
    public static void HandlePopupWarningCloseRequest(PopupWarningCloseRequestMessage message,WorldClient client)
    {
        client.Send(new PopupWarningClosedMessage());
    }
    [MessageHandler]
    public static void HandleBasicPing(BasicPingMessage message,WorldClient client)
    {
        client.Send(new BasicPongMessage(message.quiet));
    }
}