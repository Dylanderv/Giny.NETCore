using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildDeleteApplicationRequestMessage : NetworkMessage
{
    public const ushort Id = 9302;
    public override ushort MessageId => Id;


    public GuildDeleteApplicationRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}