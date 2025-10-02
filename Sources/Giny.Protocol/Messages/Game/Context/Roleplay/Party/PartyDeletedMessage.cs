using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyDeletedMessage : AbstractPartyMessage
{
    public new const ushort Id = 8798;
    public override ushort MessageId => Id;


    public PartyDeletedMessage()
    {
    }
    public PartyDeletedMessage(int partyId)
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