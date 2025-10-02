using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AbstractPartyEventMessage : AbstractPartyMessage
{
    public new const ushort Id = 9359;
    public override ushort MessageId => Id;


    public AbstractPartyEventMessage()
    {
    }
    public AbstractPartyEventMessage(int partyId)
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