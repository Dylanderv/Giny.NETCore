using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiApiKeyRequestMessage : NetworkMessage
{
    public const ushort Id = 1598;
    public override ushort MessageId => Id;


    public HaapiApiKeyRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}