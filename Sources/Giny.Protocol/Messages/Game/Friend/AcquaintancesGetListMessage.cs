using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AcquaintancesGetListMessage : NetworkMessage
{
    public const ushort Id = 8067;
    public override ushort MessageId => Id;


    public AcquaintancesGetListMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}