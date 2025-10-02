using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StartListenNuggetsMessage : NetworkMessage
{
    public const ushort Id = 2836;
    public override ushort MessageId => Id;


    public StartListenNuggetsMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}