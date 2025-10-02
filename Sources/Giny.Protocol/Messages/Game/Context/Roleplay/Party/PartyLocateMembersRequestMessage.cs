using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyLocateMembersRequestMessage : AbstractPartyMessage
{
    public new const ushort Id = 1037;
    public override ushort MessageId => Id;


    public PartyLocateMembersRequestMessage()
    {
    }
    public PartyLocateMembersRequestMessage(int partyId)
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