using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StartListenGuildChestStructureMessage : NetworkMessage
{
    public const ushort Id = 3185;
    public override ushort MessageId => Id;


    public StartListenGuildChestStructureMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}