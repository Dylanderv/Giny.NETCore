using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ObjectModifiedMessage : NetworkMessage
{
    public const ushort Id = 2227;
    public override ushort MessageId => Id;

    public ObjectItem @object;

    public ObjectModifiedMessage()
    {
    }
    public ObjectModifiedMessage(ObjectItem @object)
    {
        this.@object = @object;
    }
    public override void Serialize(IDataWriter writer)
    {
        @object.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        @object = new ObjectItem();
        @object.Deserialize(reader);
    }

}