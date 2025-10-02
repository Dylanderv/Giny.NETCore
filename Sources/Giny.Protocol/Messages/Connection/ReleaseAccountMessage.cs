using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ReleaseAccountMessage : NetworkMessage
{
    public const ushort Id = 9736;
    public override ushort MessageId => Id;


    public ReleaseAccountMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}