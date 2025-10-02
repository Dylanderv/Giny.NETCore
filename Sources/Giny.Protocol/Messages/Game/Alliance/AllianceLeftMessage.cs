using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceLeftMessage : NetworkMessage
{
    public const ushort Id = 8384;
    public override ushort MessageId => Id;


    public AllianceLeftMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}