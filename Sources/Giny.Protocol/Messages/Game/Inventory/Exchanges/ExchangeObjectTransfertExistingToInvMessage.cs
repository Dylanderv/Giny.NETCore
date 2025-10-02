using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectTransfertExistingToInvMessage : NetworkMessage
{
    public const ushort Id = 2383;
    public override ushort MessageId => Id;


    public ExchangeObjectTransfertExistingToInvMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}