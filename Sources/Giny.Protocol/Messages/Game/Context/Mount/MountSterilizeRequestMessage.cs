using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountSterilizeRequestMessage : NetworkMessage
{
    public const ushort Id = 3111;
    public override ushort MessageId => Id;


    public MountSterilizeRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}