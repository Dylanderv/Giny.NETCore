using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameActionNoopMessage : NetworkMessage
{
    public const ushort Id = 5512;
    public override ushort MessageId => Id;


    public GameActionNoopMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}