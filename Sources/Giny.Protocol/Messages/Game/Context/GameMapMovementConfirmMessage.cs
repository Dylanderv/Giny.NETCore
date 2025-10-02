using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameMapMovementConfirmMessage : NetworkMessage
{
    public const ushort Id = 302;
    public override ushort MessageId => Id;


    public GameMapMovementConfirmMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}