using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
{
    public new const ushort Id = 5724;
    public override ushort MessageId => Id;


    public PartyInvitationArenaRequestMessage()
    {
    }
    public PartyInvitationArenaRequestMessage(AbstractPlayerSearchInformation target)
    {
        this.target = target;
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