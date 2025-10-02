using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachInvitationAnswerMessage : NetworkMessage
{
    public const ushort Id = 40;
    public override ushort MessageId => Id;

    public bool accept;

    public BreachInvitationAnswerMessage()
    {
    }
    public BreachInvitationAnswerMessage(bool accept)
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