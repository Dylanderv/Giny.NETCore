using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuestModeMessage : NetworkMessage
{
    public const ushort Id = 9281;
    public override ushort MessageId => Id;

    public bool active;

    public GuestModeMessage()
    {
    }
    public GuestModeMessage(bool active)
    {
        this.active = active;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)active);
    }
    public override void Deserialize(IDataReader reader)
    {
        active = (bool)reader.ReadBoolean();
    }

}