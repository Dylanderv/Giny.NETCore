using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildInvitationAnswerMessage : NetworkMessage
{
    public const ushort Id = 3470;
    public override ushort MessageId => Id;

    public bool accept;

    public GuildInvitationAnswerMessage()
    {
    }
    public GuildInvitationAnswerMessage(bool accept)
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