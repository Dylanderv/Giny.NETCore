using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeBuyOkMessage : NetworkMessage
{
    public const ushort Id = 1649;
    public override ushort MessageId => Id;


    public ExchangeBuyOkMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}