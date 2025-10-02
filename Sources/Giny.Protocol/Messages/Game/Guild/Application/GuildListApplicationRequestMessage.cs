using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildListApplicationRequestMessage : PaginationRequestAbstractMessage
{
    public new const ushort Id = 2510;
    public override ushort MessageId => Id;


    public GuildListApplicationRequestMessage()
    {
    }
    public GuildListApplicationRequestMessage(double offset, uint count)
    {
        this.offset = offset;
        this.count = count;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }

}