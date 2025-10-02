using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildPlayerApplicationAbstractMessage : NetworkMessage
{
    public const ushort Id = 2453;
    public override ushort MessageId => Id;


    public GuildPlayerApplicationAbstractMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}