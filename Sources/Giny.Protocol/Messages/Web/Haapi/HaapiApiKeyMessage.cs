using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiApiKeyMessage : NetworkMessage
{
    public const ushort Id = 4529;
    public override ushort MessageId => Id;

    public string token;

    public HaapiApiKeyMessage()
    {
    }
    public HaapiApiKeyMessage(string token)
    {
        this.token = token;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteUTF((string)token);
    }
    public override void Deserialize(IDataReader reader)
    {
        token = (string)reader.ReadUTF();
    }

}