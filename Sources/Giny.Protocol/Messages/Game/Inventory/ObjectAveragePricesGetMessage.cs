using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ObjectAveragePricesGetMessage : NetworkMessage
{
    public const ushort Id = 8285;
    public override ushort MessageId => Id;


    public ObjectAveragePricesGetMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}