using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeSellOkMessage : NetworkMessage
{
    public const ushort Id = 8812;
    public override ushort MessageId => Id;


    public ExchangeSellOkMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}