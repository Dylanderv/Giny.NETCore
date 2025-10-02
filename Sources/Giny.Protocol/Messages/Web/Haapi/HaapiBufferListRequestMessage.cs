using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiBufferListRequestMessage : NetworkMessage
{
    public const ushort Id = 4050;
    public override ushort MessageId => Id;


    public HaapiBufferListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}