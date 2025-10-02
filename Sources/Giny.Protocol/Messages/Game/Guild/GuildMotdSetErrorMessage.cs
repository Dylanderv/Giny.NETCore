using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildMotdSetErrorMessage : SocialNoticeSetErrorMessage
{
    public new const ushort Id = 3887;
    public override ushort MessageId => Id;


    public GuildMotdSetErrorMessage()
    {
    }
    public GuildMotdSetErrorMessage(byte reason)
    {
        this.reason = reason;
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