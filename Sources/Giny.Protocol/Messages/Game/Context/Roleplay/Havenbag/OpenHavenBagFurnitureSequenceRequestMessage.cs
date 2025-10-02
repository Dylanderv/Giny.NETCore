using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class OpenHavenBagFurnitureSequenceRequestMessage : NetworkMessage
{
    public const ushort Id = 9397;
    public override ushort MessageId => Id;


    public OpenHavenBagFurnitureSequenceRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}