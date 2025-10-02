using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildMemberStartWarnOnConnectionMessage : NetworkMessage
{
    public const ushort Id = 239;
    public override ushort MessageId => Id;


    public GuildMemberStartWarnOnConnectionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}