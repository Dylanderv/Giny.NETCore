using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceRanksRequestMessage : NetworkMessage
{
    public const ushort Id = 8832;
    public override ushort MessageId => Id;


    public AllianceRanksRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}