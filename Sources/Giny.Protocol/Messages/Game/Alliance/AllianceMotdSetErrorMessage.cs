using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
{
    public new const ushort Id = 2581;
    public override ushort MessageId => Id;


    public AllianceMotdSetErrorMessage()
    {
    }
    public AllianceMotdSetErrorMessage(byte reason)
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