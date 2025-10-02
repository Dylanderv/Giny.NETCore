using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MapRunningFightListRequestMessage : NetworkMessage
{
    public const ushort Id = 2782;
    public override ushort MessageId => Id;


    public MapRunningFightListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}