using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterAlignmentWarEffortProgressionRequestMessage : NetworkMessage
{
    public const ushort Id = 1350;
    public override ushort MessageId => Id;


    public CharacterAlignmentWarEffortProgressionRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}