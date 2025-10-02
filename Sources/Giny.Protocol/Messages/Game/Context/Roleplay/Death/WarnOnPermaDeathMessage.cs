using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class WarnOnPermaDeathMessage : NetworkMessage
{
    public const ushort Id = 7659;
    public override ushort MessageId => Id;

    public bool enable;

    public WarnOnPermaDeathMessage()
    {
    }
    public WarnOnPermaDeathMessage(bool enable)
    {
        this.enable = enable;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)enable);
    }
    public override void Deserialize(IDataReader reader)
    {
        enable = (bool)reader.ReadBoolean();
    }

}