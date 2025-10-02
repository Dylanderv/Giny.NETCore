using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountUnSetMessage : NetworkMessage
{
    public const ushort Id = 6291;
    public override ushort MessageId => Id;


    public MountUnSetMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}