using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyNewMemberMessage : PartyUpdateMessage
{
    public new const ushort Id = 9480;
    public override ushort MessageId => Id;


    public PartyNewMemberMessage()
    {
    }
    public PartyNewMemberMessage(int partyId, PartyMemberInformations memberInformations)
    {
        this.partyId = partyId;
        this.memberInformations = memberInformations;
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