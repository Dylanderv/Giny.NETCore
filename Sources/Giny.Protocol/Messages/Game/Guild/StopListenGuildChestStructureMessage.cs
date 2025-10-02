using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StopListenGuildChestStructureMessage : NetworkMessage
{
    public const ushort Id = 4831;
    public override ushort MessageId => Id;


    public StopListenGuildChestStructureMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}