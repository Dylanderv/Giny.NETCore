using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PrismExchangeRequestMessage : NetworkMessage
{
    public const ushort Id = 4630;
    public override ushort MessageId => Id;


    public PrismExchangeRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}