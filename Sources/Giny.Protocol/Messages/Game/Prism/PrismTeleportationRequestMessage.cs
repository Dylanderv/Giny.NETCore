using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PrismTeleportationRequestMessage : NetworkMessage
{
    public const ushort Id = 4692;
    public override ushort MessageId => Id;


    public PrismTeleportationRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}