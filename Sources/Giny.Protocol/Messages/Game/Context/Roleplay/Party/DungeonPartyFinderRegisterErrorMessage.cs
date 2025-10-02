using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class DungeonPartyFinderRegisterErrorMessage : NetworkMessage
{
    public const ushort Id = 8873;
    public override ushort MessageId => Id;


    public DungeonPartyFinderRegisterErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}