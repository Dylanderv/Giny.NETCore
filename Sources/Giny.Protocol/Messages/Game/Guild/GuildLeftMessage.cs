using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildLeftMessage : NetworkMessage
{
    public const ushort Id = 5908;
    public override ushort MessageId => Id;


    public GuildLeftMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}