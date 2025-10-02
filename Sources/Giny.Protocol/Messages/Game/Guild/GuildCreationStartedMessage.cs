using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildCreationStartedMessage : NetworkMessage
{
    public const ushort Id = 3789;
    public override ushort MessageId => Id;


    public GuildCreationStartedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}