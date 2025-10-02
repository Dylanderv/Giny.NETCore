using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BasicNoOperationMessage : NetworkMessage
{
    public const ushort Id = 2629;
    public override ushort MessageId => Id;


    public BasicNoOperationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}