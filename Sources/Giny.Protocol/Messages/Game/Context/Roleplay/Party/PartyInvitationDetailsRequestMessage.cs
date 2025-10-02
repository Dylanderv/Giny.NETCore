using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyInvitationDetailsRequestMessage : AbstractPartyMessage
{
    public new const ushort Id = 4130;
    public override ushort MessageId => Id;


    public PartyInvitationDetailsRequestMessage()
    {
    }
    public PartyInvitationDetailsRequestMessage(int partyId)
    {
        this.partyId = partyId;
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