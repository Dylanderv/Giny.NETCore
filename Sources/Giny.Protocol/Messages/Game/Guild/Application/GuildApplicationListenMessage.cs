using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildApplicationListenMessage : NetworkMessage
{
    public const ushort Id = 1821;
    public override ushort MessageId => Id;

    public bool listen;

    public GuildApplicationListenMessage()
    {
    }
    public GuildApplicationListenMessage(bool listen)
    {
        this.listen = listen;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)listen);
    }
    public override void Deserialize(IDataReader reader)
    {
        listen = (bool)reader.ReadBoolean();
    }

}