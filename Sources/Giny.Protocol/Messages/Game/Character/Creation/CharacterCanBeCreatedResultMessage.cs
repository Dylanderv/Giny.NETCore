using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterCanBeCreatedResultMessage : NetworkMessage
{
    public const ushort Id = 6725;
    public override ushort MessageId => Id;

    public bool yesYouCan;

    public CharacterCanBeCreatedResultMessage()
    {
    }
    public CharacterCanBeCreatedResultMessage(bool yesYouCan)
    {
        this.yesYouCan = yesYouCan;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)yesYouCan);
    }
    public override void Deserialize(IDataReader reader)
    {
        yesYouCan = (bool)reader.ReadBoolean();
    }

}