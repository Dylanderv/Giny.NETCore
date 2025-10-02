using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeStartOkEvolutiveObjectRecycleTradeMessage : NetworkMessage
{
    public const ushort Id = 5801;
    public override ushort MessageId => Id;


    public ExchangeStartOkEvolutiveObjectRecycleTradeMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}