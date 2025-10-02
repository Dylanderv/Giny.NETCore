using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
{
    public new const ushort Id = 550;
    public override ushort MessageId => Id;

    public bool loyal;

    public PartyPledgeLoyaltyRequestMessage()
    {
    }
    public PartyPledgeLoyaltyRequestMessage(bool loyal, int partyId)
    {
        this.loyal = loyal;
        this.partyId = partyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteBoolean((bool)loyal);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        loyal = (bool)reader.ReadBoolean();
    }

}