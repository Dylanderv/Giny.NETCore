using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FinishMoveListRequestMessage : NetworkMessage
{
    public const ushort Id = 935;
    public override ushort MessageId => Id;


    public FinishMoveListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}