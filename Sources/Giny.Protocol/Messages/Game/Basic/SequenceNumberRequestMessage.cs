using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SequenceNumberRequestMessage : NetworkMessage
{
    public const ushort Id = 5241;
    public override ushort MessageId => Id;


    public SequenceNumberRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}