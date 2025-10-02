using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SetEnablePVPRequestMessage : NetworkMessage
{
    public const ushort Id = 9540;
    public override ushort MessageId => Id;

    public bool enable;

    public SetEnablePVPRequestMessage()
    {
    }
    public SetEnablePVPRequestMessage(bool enable)
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