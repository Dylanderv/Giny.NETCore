using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ClientKeyMessage : NetworkMessage
{
    public const ushort Id = 3370;
    public override ushort MessageId => Id;

    public string key;

    public ClientKeyMessage()
    {
    }
    public ClientKeyMessage(string key)
    {
        this.key = key;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteUTF((string)key);
    }
    public override void Deserialize(IDataReader reader)
    {
        key = (string)reader.ReadUTF();
    }

}