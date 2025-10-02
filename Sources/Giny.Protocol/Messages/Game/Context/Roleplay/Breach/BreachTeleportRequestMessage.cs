using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachTeleportRequestMessage : NetworkMessage
{
    public const ushort Id = 7242;
    public override ushort MessageId => Id;


    public BreachTeleportRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}