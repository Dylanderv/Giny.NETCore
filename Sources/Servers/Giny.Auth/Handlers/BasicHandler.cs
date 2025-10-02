using Giny.Auth.Network;
using Giny.Protocol.Messages;

namespace Giny.Auth.Handlers;

class BasicHandler
{
    public static void HandleBasicPing(BasicPingMessage message, AuthClient client)
    {
        client.Send(new BasicPongMessage(message.quiet));
    }
}