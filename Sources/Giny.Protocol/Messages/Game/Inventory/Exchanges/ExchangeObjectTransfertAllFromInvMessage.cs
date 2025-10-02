using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectTransfertAllFromInvMessage : NetworkMessage
{
    public const ushort Id = 5560;
    public override ushort MessageId => Id;


    public ExchangeObjectTransfertAllFromInvMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}