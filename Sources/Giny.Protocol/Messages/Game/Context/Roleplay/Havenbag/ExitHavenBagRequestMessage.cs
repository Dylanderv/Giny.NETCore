using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExitHavenBagRequestMessage : NetworkMessage
{
    public const ushort Id = 4256;
    public override ushort MessageId => Id;


    public ExitHavenBagRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}