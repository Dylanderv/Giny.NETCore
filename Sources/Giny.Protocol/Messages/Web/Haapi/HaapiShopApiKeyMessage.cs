using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiShopApiKeyMessage : NetworkMessage
{
    public const ushort Id = 7531;
    public override ushort MessageId => Id;

    public string token;

    public HaapiShopApiKeyMessage()
    {
    }
    public HaapiShopApiKeyMessage(string token)
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