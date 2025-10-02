using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeBidSearchOkMessage : NetworkMessage
{
    public const ushort Id = 5585;
    public override ushort MessageId => Id;


    public ExchangeBidSearchOkMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}