using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameRolePlayGameOverMessage : NetworkMessage
{
    public const ushort Id = 6207;
    public override ushort MessageId => Id;


    public GameRolePlayGameOverMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}