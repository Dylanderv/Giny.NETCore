using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PrismRecycleTradeRequestMessage : NetworkMessage
{
    public const ushort Id = 8103;
    public override ushort MessageId => Id;


    public PrismRecycleTradeRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}