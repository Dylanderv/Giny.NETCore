using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyAcceptInvitationMessage : AbstractPartyMessage
{
    public new const ushort Id = 38;
    public override ushort MessageId => Id;


    public PartyAcceptInvitationMessage()
    {
    }
    public PartyAcceptInvitationMessage(int partyId)
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