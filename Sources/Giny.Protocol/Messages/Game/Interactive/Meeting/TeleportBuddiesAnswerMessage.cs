using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class TeleportBuddiesAnswerMessage : NetworkMessage
{
    public const ushort Id = 9243;
    public override ushort MessageId => Id;

    public bool accept;

    public TeleportBuddiesAnswerMessage()
    {
    }
    public TeleportBuddiesAnswerMessage(bool accept)
    {
        this.accept = accept;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)accept);
    }
    public override void Deserialize(IDataReader reader)
    {
        accept = (bool)reader.ReadBoolean();
    }

}