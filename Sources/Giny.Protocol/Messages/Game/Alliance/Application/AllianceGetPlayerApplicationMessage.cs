using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceGetPlayerApplicationMessage : NetworkMessage
{
    public const ushort Id = 6329;
    public override ushort MessageId => Id;


    public AllianceGetPlayerApplicationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}