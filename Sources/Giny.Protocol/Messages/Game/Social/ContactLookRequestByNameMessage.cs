using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ContactLookRequestByNameMessage : ContactLookRequestMessage
{
    public new const ushort Id = 7171;
    public override ushort MessageId => Id;

    public string playerName;

    public ContactLookRequestByNameMessage()
    {
    }
    public ContactLookRequestByNameMessage(string playerName, byte requestId, byte contactType)
    {
        this.playerName = playerName;
        this.requestId = requestId;
        this.contactType = contactType;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteUTF((string)playerName);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        playerName = (string)reader.ReadUTF();
    }

}