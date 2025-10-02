using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightTurnStartPlayingMessage : NetworkMessage
{
    public const ushort Id = 2368;
    public override ushort MessageId => Id;


    public GameFightTurnStartPlayingMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}