using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameRolePlayArenaUnregisterMessage : NetworkMessage
{
    public const ushort Id = 2239;
    public override ushort MessageId => Id;


    public GameRolePlayArenaUnregisterMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}