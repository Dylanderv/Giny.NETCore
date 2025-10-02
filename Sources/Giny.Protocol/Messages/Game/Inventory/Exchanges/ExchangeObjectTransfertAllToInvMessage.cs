using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectTransfertAllToInvMessage : NetworkMessage
{
    public const ushort Id = 4489;
    public override ushort MessageId => Id;


    public ExchangeObjectTransfertAllToInvMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}