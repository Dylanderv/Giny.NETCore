using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountToggleRidingRequestMessage : NetworkMessage
{
    public const ushort Id = 5154;
    public override ushort MessageId => Id;


    public MountToggleRidingRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}