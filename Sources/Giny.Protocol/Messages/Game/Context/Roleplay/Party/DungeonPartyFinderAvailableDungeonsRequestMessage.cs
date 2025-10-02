using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class DungeonPartyFinderAvailableDungeonsRequestMessage : NetworkMessage
{
    public const ushort Id = 4464;
    public override ushort MessageId => Id;


    public DungeonPartyFinderAvailableDungeonsRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}