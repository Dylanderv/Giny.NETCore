using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachExitResponseMessage : NetworkMessage
{
    public const ushort Id = 8365;
    public override ushort MessageId => Id;

    public bool exited;

    public BreachExitResponseMessage()
    {
    }
    public BreachExitResponseMessage(bool exited)
    {
        this.exited = exited;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)exited);
    }
    public override void Deserialize(IDataReader reader)
    {
        exited = (bool)reader.ReadBoolean();
    }

}