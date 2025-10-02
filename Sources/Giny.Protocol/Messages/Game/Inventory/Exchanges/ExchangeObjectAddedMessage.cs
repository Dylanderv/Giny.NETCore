using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectAddedMessage : ExchangeObjectMessage
{
    public new const ushort Id = 3343;
    public override ushort MessageId => Id;

    public ObjectItem @object;

    public ExchangeObjectAddedMessage()
    {
    }
    public ExchangeObjectAddedMessage(ObjectItem @object, bool remote)
    {
        this.@object = @object;
        this.remote = remote;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        @object.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        @object = new ObjectItem();
        @object.Deserialize(reader);
    }

}