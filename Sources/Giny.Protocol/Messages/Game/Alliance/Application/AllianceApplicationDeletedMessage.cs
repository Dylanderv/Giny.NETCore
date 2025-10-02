using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceApplicationDeletedMessage : NetworkMessage
{
    public const ushort Id = 5178;
    public override ushort MessageId => Id;

    public bool deleted;

    public AllianceApplicationDeletedMessage()
    {
    }
    public AllianceApplicationDeletedMessage(bool deleted)
    {
        this.deleted = deleted;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)deleted);
    }
    public override void Deserialize(IDataReader reader)
    {
        deleted = (bool)reader.ReadBoolean();
    }

}