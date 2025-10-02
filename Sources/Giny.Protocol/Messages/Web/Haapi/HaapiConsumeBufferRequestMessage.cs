using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiConsumeBufferRequestMessage : NetworkMessage
{
    public const ushort Id = 4843;
    public override ushort MessageId => Id;


    public HaapiConsumeBufferRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}