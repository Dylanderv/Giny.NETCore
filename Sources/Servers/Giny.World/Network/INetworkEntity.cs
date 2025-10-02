using Giny.Core.Network.Messages;

namespace Giny.World.Network;

public interface INetworkEntity
{
    void Send(NetworkMessage message);
}