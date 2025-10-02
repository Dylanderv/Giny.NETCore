using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildBulletinSetErrorMessage : SocialNoticeSetErrorMessage
{
    public new const ushort Id = 4667;
    public override ushort MessageId => Id;


    public GuildBulletinSetErrorMessage()
    {
    }
    public GuildBulletinSetErrorMessage(byte reason)
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