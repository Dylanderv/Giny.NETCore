using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlignmentWarEffortProgressionRequestMessage : NetworkMessage
{
    public const ushort Id = 9210;
    public override ushort MessageId => Id;


    public AlignmentWarEffortProgressionRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}