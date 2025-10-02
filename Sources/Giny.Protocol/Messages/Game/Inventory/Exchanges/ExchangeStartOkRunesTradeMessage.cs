using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeStartOkRunesTradeMessage : NetworkMessage
{
    public const ushort Id = 9289;
    public override ushort MessageId => Id;


    public ExchangeStartOkRunesTradeMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}