using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachTeleportResponseMessage : NetworkMessage
{
    public const ushort Id = 4007;
    public override ushort MessageId => Id;

    public bool teleported;

    public BreachTeleportResponseMessage()
    {
    }
    public BreachTeleportResponseMessage(bool teleported)
    {
        this.teleported = teleported;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)teleported);
    }
    public override void Deserialize(IDataReader reader)
    {
        teleported = (bool)reader.ReadBoolean();
    }

}