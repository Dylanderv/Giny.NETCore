using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildGetPlayerApplicationMessage : NetworkMessage
{
    public const ushort Id = 6087;
    public override ushort MessageId => Id;


    public GuildGetPlayerApplicationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}