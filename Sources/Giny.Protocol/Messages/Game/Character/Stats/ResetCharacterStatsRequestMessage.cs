using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ResetCharacterStatsRequestMessage : NetworkMessage
{
    public const ushort Id = 4287;
    public override ushort MessageId => Id;


    public ResetCharacterStatsRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}