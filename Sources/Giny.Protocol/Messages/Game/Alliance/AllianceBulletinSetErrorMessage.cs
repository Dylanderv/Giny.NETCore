using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceBulletinSetErrorMessage : SocialNoticeSetErrorMessage
{
    public new const ushort Id = 6084;
    public override ushort MessageId => Id;


    public AllianceBulletinSetErrorMessage()
    {
    }
    public AllianceBulletinSetErrorMessage(byte reason)
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