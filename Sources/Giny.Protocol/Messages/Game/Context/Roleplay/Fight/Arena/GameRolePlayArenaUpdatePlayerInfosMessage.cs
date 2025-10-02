using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{
    public const ushort Id = 5977;
    public override ushort MessageId => Id;

    public ArenaRankInfos solo;

    public GameRolePlayArenaUpdatePlayerInfosMessage()
    {
    }
    public GameRolePlayArenaUpdatePlayerInfosMessage(ArenaRankInfos solo)
    {
        this.solo = solo;
    }
    public override void Serialize(IDataWriter writer)
    {
        solo.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        solo = new ArenaRankInfos();
        solo.Deserialize(reader);
    }

}