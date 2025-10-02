using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeStartOkCraftMessage : NetworkMessage
{
    public const ushort Id = 1786;
    public override ushort MessageId => Id;


    public ExchangeStartOkCraftMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}