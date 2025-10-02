using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyModifiableStatusMessage : AbstractPartyMessage
{
    public new const ushort Id = 9490;
    public override ushort MessageId => Id;

    public bool enabled;

    public PartyModifiableStatusMessage()
    {
    }
    public PartyModifiableStatusMessage(bool enabled, int partyId)
    {
        this.enabled = enabled;
        this.partyId = partyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteBoolean((bool)enabled);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        enabled = (bool)reader.ReadBoolean();
    }

}