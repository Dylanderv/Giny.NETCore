using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PartyNameSetRequestMessage : AbstractPartyMessage
{
    public new const ushort Id = 9077;
    public override ushort MessageId => Id;

    public string partyName;

    public PartyNameSetRequestMessage()
    {
    }
    public PartyNameSetRequestMessage(string partyName, int partyId)
    {
        this.partyName = partyName;
        this.partyId = partyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteUTF((string)partyName);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        partyName = (string)reader.ReadUTF();
    }

}