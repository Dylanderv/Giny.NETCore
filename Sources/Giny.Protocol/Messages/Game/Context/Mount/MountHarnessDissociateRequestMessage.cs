using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountHarnessDissociateRequestMessage : NetworkMessage
{
    public const ushort Id = 7514;
    public override ushort MessageId => Id;


    public MountHarnessDissociateRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}