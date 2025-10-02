using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CloseHavenBagFurnitureSequenceRequestMessage : NetworkMessage
{
    public const ushort Id = 9998;
    public override ushort MessageId => Id;


    public CloseHavenBagFurnitureSequenceRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}