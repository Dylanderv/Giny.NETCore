using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildMemberStopWarnOnConnectionMessage : NetworkMessage
{
    public const ushort Id = 2325;
    public override ushort MessageId => Id;


    public GuildMemberStopWarnOnConnectionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}