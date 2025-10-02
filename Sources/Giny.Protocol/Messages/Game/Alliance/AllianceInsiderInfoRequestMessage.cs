using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceInsiderInfoRequestMessage : NetworkMessage
{
    public const ushort Id = 3738;
    public override ushort MessageId => Id;


    public AllianceInsiderInfoRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}