using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildRanksRequestMessage : NetworkMessage
{
    public const ushort Id = 1149;
    public override ushort MessageId => Id;


    public GuildRanksRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}