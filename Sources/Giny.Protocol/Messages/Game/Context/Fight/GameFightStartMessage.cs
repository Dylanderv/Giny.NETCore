using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightStartMessage : NetworkMessage
{
    public const ushort Id = 1844;
    public override ushort MessageId => Id;


    public GameFightStartMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}