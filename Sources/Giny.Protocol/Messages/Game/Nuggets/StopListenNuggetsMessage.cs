using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StopListenNuggetsMessage : NetworkMessage
{
    public const ushort Id = 1489;
    public override ushort MessageId => Id;


    public StopListenNuggetsMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}