using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameRolePlayFreeSoulRequestMessage : NetworkMessage
{
    public const ushort Id = 8141;
    public override ushort MessageId => Id;


    public GameRolePlayFreeSoulRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}