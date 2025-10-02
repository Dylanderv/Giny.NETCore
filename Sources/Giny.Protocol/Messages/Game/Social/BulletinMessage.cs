using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BulletinMessage : SocialNoticeMessage
{
    public new const ushort Id = 881;
    public override ushort MessageId => Id;


    public BulletinMessage()
    {
    }
    public BulletinMessage(string content, int timestamp, long memberId, string memberName)
    {
        this.content = content;
        this.timestamp = timestamp;
        this.memberId = memberId;
        this.memberName = memberName;
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