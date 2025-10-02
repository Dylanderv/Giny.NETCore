using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ObjectAveragePricesErrorMessage : NetworkMessage
{
    public const ushort Id = 3885;
    public override ushort MessageId => Id;


    public ObjectAveragePricesErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}