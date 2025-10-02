using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyRefuseInvitationMessage : AbstractPartyMessage
{
    public new const ushort Id = 3324;
    public override ushort MessageId => Id;


    public PartyRefuseInvitationMessage()
    {
    }
    public PartyRefuseInvitationMessage(int partyId)
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