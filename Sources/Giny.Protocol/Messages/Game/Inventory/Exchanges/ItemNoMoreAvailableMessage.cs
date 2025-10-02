using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ItemNoMoreAvailableMessage : NetworkMessage
{
    public const ushort Id = 2274;
    public override ushort MessageId => Id;


    public ItemNoMoreAvailableMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}