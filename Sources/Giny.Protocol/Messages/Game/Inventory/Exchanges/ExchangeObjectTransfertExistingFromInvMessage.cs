using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectTransfertExistingFromInvMessage : NetworkMessage
{
    public const ushort Id = 4358;
    public override ushort MessageId => Id;


    public ExchangeObjectTransfertExistingFromInvMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}