using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SpouseStatusMessage : NetworkMessage
{
    public const ushort Id = 6714;
    public override ushort MessageId => Id;

    public bool hasSpouse;

    public SpouseStatusMessage()
    {
    }
    public SpouseStatusMessage(bool hasSpouse)
    {
        this.hasSpouse = hasSpouse;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)hasSpouse);
    }
    public override void Deserialize(IDataReader reader)
    {
        hasSpouse = (bool)reader.ReadBoolean();
    }

}