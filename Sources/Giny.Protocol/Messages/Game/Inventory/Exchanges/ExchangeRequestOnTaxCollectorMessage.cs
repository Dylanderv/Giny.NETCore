using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
{
    public const ushort Id = 4495;
    public override ushort MessageId => Id;


    public ExchangeRequestOnTaxCollectorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}