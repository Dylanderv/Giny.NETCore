using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyRestrictedMessage : AbstractPartyMessage
{
    public new const ushort Id = 1488;
    public override ushort MessageId => Id;

    public bool restricted;

    public PartyRestrictedMessage()
    {
    }
    public PartyRestrictedMessage(bool restricted, int partyId)
    {
        this.restricted = restricted;
        this.partyId = partyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteBoolean((bool)restricted);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        restricted = (bool)reader.ReadBoolean();
    }

}